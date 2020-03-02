// Copyright (c) Microsoft Corporation. All rights reserved.

// Author: Rishabh Mehta (17122018) B.Tech EPh IIIrd yr.

namespace Quantum.Week4 {
    
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Arrays;
    open Microsoft.Quantum.Arithmetic;
    
    
    //////////////////////////////////////////////////////////////////
    // This is the set of programming assignments for week 4.
    //////////////////////////////////////////////////////////////////

    // The tasks cover the following topics:
    //  - Grover's algorithm
    //  - quantum Fourier transform
    //
    // We recommend to solve the GroversAlgorithm kata from 
    // https://github.com/Microsoft/QuantumKatas before doing these assignments

    //////////////////////////////////////////////////////////////////
    // Part I. Building marking oracles for classical functions
    //////////////////////////////////////////////////////////////////

    // In this section the oracles are defined on computational basis states,
    // as described at https://docs.microsoft.com/en-us/quantum/concepts/oracles.
    
    // Task 1.1. "Exactly one |1⟩" oracle
    // Inputs:
    //      1) N qubits in an arbitrary state |x⟩ (input/query register)
    //      2) a qubit in an arbitrary state |y⟩ (target qubit)
    //
    // Goal: Transform state |x, y⟩ into state |x, y ⊕ f(x)⟩ (⊕ is addition modulo 2),
    //       where f(x) = 1 if exactly one bit of x is in the |1⟩ state, and 0 otherwise.
    //       Leave the query register in the same state it started in.
    operation Task11 (queryRegister : Qubit[], target : Qubit) : Unit {

        body (...) {

            ApplyToEachA(X, queryRegister);

            for (i in 0..Length(queryRegister) - 1) {
                X(queryRegister[i]);
                Controlled X(queryRegister, target);
                X(queryRegister[i]);
            }

            ApplyToEachA(X, queryRegister);
        }

        adjoint auto;
    }


    // Task 1.2. Pattern matching oracle
    // Inputs:
    //      1) N qubits in an arbitrary state |x⟩ (input/query register)
    //      2) a qubit in an arbitrary state |y⟩ (target qubit)
    //      3) a bit pattern of length N represented as an Int[].
    // k-th element of the pattern encodes the allowed states of the qubit x[k]:
    // 0 and 1 values represent states |0⟩ and |1⟩, respectively, 
    // value -1 represents any state.
    // 
    // Goal: Transform state |x, y⟩ into state |x, y ⊕ f(x)⟩ (⊕ is addition modulo 2),
    //       where f(x) = 1 if the bit string x matches the given pattern, and 0 if it does not.
    //       Leave the query register in the same state it started in.
    //
    // For example, pattern [0, -1, 1] would match two states: |001⟩ and |011⟩.
    operation Task12 (queryRegister : Qubit[], target : Qubit, pattern : Int[]) : Unit {

        body (...) {
            using (c = Qubit[Length(queryRegister)]) {
                
                within {

                    ApplyToEachA(X, c);

                    for (i in 0..Length(queryRegister) - 1) {

                        if (pattern[i] == 0) {
                            CNOT(queryRegister[i], c[i]);
                        } elif (pattern[i] == 1)  {
                            X(c[i]);
                            CNOT(queryRegister[i], c[i]);
                        }
                    }
                }

                apply {

                    Controlled X(c, target);
                }
            }
        }
        
        adjoint auto;
    }


    // Task 1.3*. Substring matching oracle
    // Inputs:
    //      1) N qubits in an arbitrary state |x⟩ (input/query register)
    //      2) a qubit in an arbitrary state |y⟩ (target qubit)
    //      3) a bit string of length K represented as Bool[] (K <= N)
    // 
    // Goal: Transform state |x, y⟩ into state |x, y ⊕ f(x)⟩ (⊕ is addition modulo 2),
    //       where f(x) = 1 if the bit string x contains the given bit string as a continuous substring, and 0 if it does not.
    //       Leave the query register in the same state it started in.
    //
    // For example, bit string [0, 1] would be found in states |011⟩ and |001⟩, but not in state |100⟩;
    // bit string [0] would be found in any state other than |1...1⟩ (the string can occur in multiple places).


    operation Task13 (queryRegister : Qubit[], target : Qubit, substring : Bool[]) : Unit {

        body (...) {
            let N = Length(queryRegister);
            let K  = Length(substring);

            X(target);

            using (c = Qubit[N-K+1]) {

                ApplyToEachA(X, c);

                within {

                    for (i in 0..N-K) {

                        let subregisters = Partitioned([i, i+K], queryRegister);
                        (ControlledOnBitString(substring, X))(subregisters[1], c[i]);
                    }
                } 
                
                apply {

                    Controlled X(c, target);
                }
            }
        }
        
        adjoint auto;
    }


    //////////////////////////////////////////////////////////////////
    // Part II. Oracle transformations and phase-flipping oracles
    //////////////////////////////////////////////////////////////////

    // Task 2.1. Arbitrary bit pattern phase-flipping oracle
    // Inputs:
    //      1) N qubits in an arbitrary state |x⟩ (input/query register)
    //      2) a bit pattern of length N represented as Bool[]
    // Goal: Flip the phase of the register if it is in the state described by the given bit pattern, 
    //       (true represents qubit state One, and false represents Zero).
    // In this task you are not allowed to allocate extra qubits.
    operation Task21 (x : Qubit[], pattern : Bool[]) : Unit {

        body (...) {
            
            for(i in 0..Length(x)-1){
                if (pattern[i] == false) {
                    X(x[i]);
                }
            }

            let subregister = Exclude([Length(x)-1], x);
            Controlled Z(subregister, x[Length(x)-1]);

            for(i in 0..Length(x)-1){
                if (pattern[i] == false) {
                    X(x[i]);
                }
            }
        }
        
        adjoint self;
    }


    // Note: Tasks 2.2-2.4 require you to return an operation (oracle) constructed using another operation.
    // See task 1.4 from the GroversAlgorithm kata for an example of defining an oracle based on another oracle.
    // Note that the operation you return has to be adjointable (same as in task 1.4 from the kata);
    // this means that the operation you return has to have a definition of adjoint (typically "adjoint auto").


    // Task 2.2*. Conversion between different phase-flipping oracles
    // Input: A phase-flipping oracle of the form |x⟩ → (-1)^(f(x)) |x⟩.
    // Output: A phase-flipping oracle of the form |x⟩|b⟩ → (-1)^(b · f(x)) |x⟩|b⟩,
    //         where b is a one-qubit register, and · is dot product of scalar values
    //         (this oracle only flips the phase of the register x if b is in 1 state).

    operation OracleConverter22 (phaseOracle : (Qubit[] => Unit is Adj + Ctl), x : Qubit[], b: Qubit) : Unit

    is Adj {
        Controlled phaseOracle([b], x);
    }

    function Task22 (phaseOracle : (Qubit[] => Unit is Adj + Ctl)) : ((Qubit[], Qubit) => Unit is Adj) {
        // ...
        
        // Currently this function returns an existing oracle for the sake of being able to compile the code.
        // You will need to return your own oracle instead of Task11.
        return OracleConverter22(phaseOracle, _, _);
    }




    // Task 2.3*. Conversion from phase-flipping oracle to marking oracle
    // Input: A phase-flipping oracle of the form |x⟩|b⟩ → (-1)^(b · f(x)) |x⟩|b⟩.
    // Output: A marking oracle of the form |x⟩|b⟩ → |x⟩|b ⊕ f(x)⟩.

    operation OracleConverter23 (phaseOracle : ((Qubit[], Qubit) => Unit is Adj), x : Qubit[], b: Qubit) : Unit

    is Adj {
        H(b);
        phaseOracle(x,b);
        H(b);
    }

    function Task23 (phaseOracle : ((Qubit[], Qubit) => Unit is Adj)) : ((Qubit[], Qubit) => Unit is Adj) {
        // ...

        // Currently this function returns an existing oracle for the sake of being able to compile the code.
        // You will need to return your own oracle instead of Task11.
        return OracleConverter23(phaseOracle, _, _);
    }


    // Task 2.4. Oracle with one extra state marked/unmarked
    // Inputs:
    //      1) a marking oracle of the form |x⟩|b⟩ → |x⟩|b ⊕ f(x)⟩
    //      2) a bit pattern of length N represented as Bool[]
    // Output: A marking oracle of the same form, which works as follows:
    //       - for all x != pattern, |x⟩|b⟩ → |x⟩|b ⊕ f(x)⟩
    //       - for x == pattern,     |x⟩|b⟩ → |x⟩|b ⊕ f(x) ⊕ 1⟩
    //         (i.e., if the input oracle marked the pattern as the solution, the output oracle will not mark it, and vice versa)
    operation OracleConverter24 (markingOracle : ((Qubit[], Qubit) => Unit is Adj), x : Qubit[], b: Qubit, pattern : Bool[]) : Unit

    is Adj {
        (ControlledOnBitString(pattern, X))(x, b);
    }

    function Task24 (markingOracle : ((Qubit[], Qubit) => Unit is Adj), pattern : Bool[]) : ((Qubit[], Qubit) => Unit is Adj) {
        // ...
        
        // Currently this function returns the input oracle for the sake of being able to compile the code.
        // You will need to return your own oracle instead of markingOracle.
        return OracleConverter24(markingOracle, _, _, pattern);
    }


    //////////////////////////////////////////////////////////////////
    // Part III. Quantum Fourier Transform
    //////////////////////////////////////////////////////////////////

    // Note: all tasks in this section assume register in little-endian format 
    // (the least significant bit is stored first). This matches the indices used in DumpMachine output.
    // For example, if you have two qubits in state |qs[0], qs[1]⟩ = |01⟩, this register is in state |2⟩.

    // Task 3.1. 
    // Input: n qubits in the |0...0⟩ state (n >= 2).
    // Goal: create the following state on these qubits:
    //       1/sqrt(N) Σₖ exp(2πik/N) |k⟩, where N = 2ⁿ.
    // For example, for n = 2 N = 4, and the goal state is 
    //       1/2 (|0⟩ + i|1⟩ - |2⟩ - i|3⟩).
    
    operation Task31 (qs : Qubit[]) : Unit {
        X(qs[Length(qs)-1]);
        let c = LittleEndian(qs);
        ApplyReversedOpBE(QFT, c);
    }


    // Task 3.2.
    // Input: n qubits in the |0...0⟩ state (n >= 2).
    // Goal: create the following state on these qubits:
    //       sqrt(2)/sqrt(N) Σₖ cos(2πk/N) |k⟩, where N = 2ⁿ.
    // For example, for n = 2 N = 4, and the goal state is 
    //       1/sqrt(2) (cos(0)|0⟩ + cos(π/2)|1⟩ + cos(π)|2⟩ + cos(3π/2)|3⟩) = 1/sqrt(2) (0⟩| - |2⟩).
    operation Task32 (qs : Qubit[]) : Unit {

        X(qs[Length(qs)-1]);
        H(qs[1]);

        for (i in 2..Length(qs)-1) {
            CNOT(qs[i-1], qs[i]);
        }
        let c = LittleEndian(qs);
        ApplyReversedOpBE(QFT, c);
    }


    // Task 3.3. 
    // Input: n qubits in the |0...0⟩ state (n >= 2).
    // Goal: create the following state on these qubits:
    //       sqrt(2)/sqrt(N) Σₖ sin(2πk/N) |k⟩, where N = 2ⁿ.
    // For example, for n = 2 N = 4, and the goal state is 
    //       1/sqrt(2) (sin(0)|0⟩ + sin(π/2)|1⟩ + sin(π)|2⟩ + sin(3π/2)|3⟩) = 1/sqrt(2) (|1⟩ - |3⟩).
    operation Task33 (qs : Qubit[]) : Unit {
        X(qs[Length(qs)-1]);
        X(qs[0]);
        H(qs[0]);

        for (i in 1..Length(qs)-1) {
            CNOT(qs[i-1], qs[i]);
        }
        let c = LittleEndian(qs);
        ApplyReversedOpBE(QFT, c);
    }
}
