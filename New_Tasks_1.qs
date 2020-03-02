// Copyright (c) Microsoft Corporation. All rights reserved.

// Author: Rishabh Mehta (17122018) B.Tech EPh IIIrd yr.

namespace Quantum.Week1 {
    
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Math;
    
    
    //////////////////////////////////////////////////////////////////
    // This is the set of programming assignments for week 1.
    //////////////////////////////////////////////////////////////////

    // The tasks cover the following topics:
    //  - basic quantum gates
    //  - superposition
    //  - measurements
    //  - implementing unitary transformations
    //
    // We recommend to solve the following katas before doing these assignments:
    //  - BasicGates
    //  - Superposition
    //  - Measurements
    // from https://github.com/Microsoft/QuantumKatas

    //////////////////////////////////////////////////////////////////
    // Part I. Basic Gates and Superposition
    //////////////////////////////////////////////////////////////////
    
    // Task 1.1.
    // Input: a qubit in |0⟩ state.
    // Goal: create the following state on this qubit: 0.8|0⟩ + 0.6|1⟩.
    operation Task11 (q : Qubit) : Unit {

      mutable alpha = ArcCos(0.8);

      Ry(2.0 * alpha, q);
    }

    
    // Task 1.2.
    // Input: a qubit in |0⟩ state.
    // Goal: create one of the following states based on the value of index:
    //    0: (|0⟩ + i|1⟩) / sqrt(2)
    //    1: (|0⟩ - i|1⟩) / sqrt(2)
    operation Task12 (q : Qubit, index : Int) : Unit {

      if (index == 1) {
        X(q);
      }

      H(q);
      S(q);
    }

    
    // Task 1.3.
    // Input: a qubit in |0⟩ state.
    // Goal: create the following state on this qubit: ((1+i)|0⟩ + (1-i)|1⟩)) / 2.
    operation Task13 (q : Qubit) : Unit {

      H(q);
      S(q);
      H(q);
    }


    // Task 1.4.
    // Input: two qubits in |00⟩ state (stored in an array of length 2).
    // Goal: create the following state on these qubits: (|00⟩ + i|01⟩ - i|10⟩ + |11⟩) / 2.
    //       The states of the qubits are given in order |qs[0], qs[1]⟩.
    operation Task14 (qs : Qubit[]) : Unit {

      X(qs[0]);
      ApplyToEachA(H, qs);
      ApplyToEachA(S, qs);
    }


    // Task 1.5*.
    // Input: two qubits in |00⟩ state (stored in an array of length 2).
    // Goal: create the following state on these qubits: (|00⟩ + i|01⟩ + |10⟩ - |11⟩) / 2.
    operation Task15 (qs : Qubit[]) : Unit {

      X(qs[1]);
      ApplyToEachA(H, qs);

      Controlled S([qs[0]],qs[1]);
      CZ(qs[0],qs[1]);
      
      X(qs[0]);
    }


    // Task 1.6.
    // Input: three qubits in |000⟩ state (stored in an array of length 3).
    // Goal: create the following state on these qubits: (|000⟩ + |001⟩ + |010⟩ + |100⟩) / 2.
    operation Task16 (qs : Qubit[]) : Unit {

      H(qs[0]);
      H(qs[1]);

      CCNOT(qs[0], qs[1], qs[2]);
      CCNOT(qs[0], qs[2], qs[1]);

      CNOT(qs[2], qs[0]);
    }


    // Task 1.7.
    // Input: N qubits in |0...0⟩ state (you are guaranteed that N mod 2 = 0).
    // Goal: create the following state on this qubit: (|001100..⟩ + |110011..⟩) / sqrt(2).
    operation Task17 (qs : Qubit[]) : Unit {
        
      H(qs[0]);

      for (i in 0..Length(qs) - 1) {
        CNOT(qs[i],qs[i+1]);
        if(i%2 == 0) {
          X(qs[i+2]);
        }
      }
    }


    // Task 1.8.
    // Input: N qubits in |0...0⟩ state (you are guaranteed that N mod 2 = 0).
    // Goal: create an equal superposition of all the basis states for which
    //       - qubits with indexes 0 and 1 are in the same state,
    //       - qubits with indexes 2 and 3 are in the same state,
    //       - and so on, qubits with indexes 2k and 2k+1 are in the same state.
    // In other words, create an equal superposition of all the basis states
    // of the form |aabbccdd...⟩, where each letter denotes one bit.
    // For example, for N = 4 the required state is (|0000⟩ + |0011⟩ + |1100⟩ + |1111⟩) / 2.
    operation Task18 (qs : Qubit[]) : Unit {
        
      for (i in 0..Length(qs) - 2..2) {
        H(qs[i]);
        CNOT(qs[i],qs[i+1]);
      }
    }


    //////////////////////////////////////////////////////////////////
    // Part II. Measurements
    //////////////////////////////////////////////////////////////////
    
    // Task 2.1.
    // Input: a qubit which is guaranteed to be in |0⟩ or |1⟩ state.
    // Output: true if the qubit was in |0⟩ state, or false if it was in |1⟩ state.
    // The state of the qubit at the end of the operation does not matter.
    operation Task21 (q : Qubit) : Bool {

      if (M(q) == Zero) {
        return true;
      }

      return false;
    }
    

    // Task 2.2.
    // Input: three qubits which are guaranteed to be in one of the two superposition states:
    //        (|000⟩ + |001⟩ + |010⟩ + |100⟩) / 2 or 
    //        (|111⟩ + |110⟩ + |101⟩ + |011⟩) / 2.
    // Output: 0 if the qubits were in the first state,
    //         1 if they were in the second state.
    // In this task and the subsequent ones the order of qubit states
    // in task description matches the order of qubits in the array
    // (i.e., |10⟩ state corresponds to qs[0] in state |1⟩ and qs[1] in state |0⟩).
    // The state of the qubits at the end of the operation does not matter.
    operation Task22 (qs : Qubit[]) : Int {

      mutable numOnes = 0;

      for (i in 0..2) {
        if (M(qs[i]) == One) {
          set numOnes += 1;
        }
      }

      if (numOnes <= 1) {
        return 0;
      }

      return 1;
    }
    
    
    // Task 2.3.
    // Input: three qubits which are guaranteed to be in one of the four superposition states:
    //         |S0⟩ = (|000⟩ + |111⟩) / sqrt(2)
    //         |S1⟩ = (|001⟩ + |110⟩) / sqrt(2)
    //         |S2⟩ = (|010⟩ + |101⟩) / sqrt(2)
    //         |S3⟩ = (|100⟩ + |011⟩) / sqrt(2)
    // Output: 0 if the qubits were in |S0⟩ state,
    //         1 if they were in |S1⟩ state,
    //         2 if they were in |S2⟩ state,
    //         3 if they were in |S3⟩ state.
    // The state of the qubits at the end of the operation does not matter.
    operation Task23 (qs : Qubit[]) : Int {
        
      mutable output = 0;

      for (i in 0..2) {
        if (M(qs[i]) == One) {
          set output += ExpModI(2,2-i,8);
        }
      }

      set output = MinI(output, 7-output);
      
      return output;
    }
    
    
    // Task 2.4*.
    // Input: two qubits (stored in an array) which are guaranteed to be in one of the four orthogonal states:
    //         |S0⟩ = (|00⟩ + i|01⟩ + i|10⟩ - |11⟩) / 2
    //         |S1⟩ = (|00⟩ - i|01⟩ + i|10⟩ + |11⟩) / 2
    //         |S2⟩ = (|00⟩ + i|01⟩ - i|10⟩ + |11⟩) / 2
    //         |S3⟩ = (|00⟩ - i|01⟩ - i|10⟩ - |11⟩) / 2
    // Output: 0 if the qubits were in |S0⟩ state,
    //         1 if they were in |S1⟩ state,
    //         2 if they were in |S2⟩ state,
    //         3 if they were in |S3⟩ state.
    // The state of the qubits at the end of the operation does not matter.
    operation Task24 (qs : Qubit[]) : Int {
        
      mutable output = 0;

      ApplyToEach(S, qs);
      ApplyToEach(Z, qs);
      ApplyToEach(H, qs);

      for (i in 0..1) {
        if (M(qs[i]) == One) {
          set output += ExpModI(2,1-i,4);
        }
      }

      return output;
    }


    // Task 2.5.
    // Input: 21 copies of an unknown qubit state |ψ⟩ = α |0⟩ + β |1⟩ (amplitudes α and β are non-negative real numbers).
    // Output: a tuple of two numbers (α`, β`) - your estimates of the amplitudes α and β.
    //         The absolute error |α - α`| and |β - β`| should be less than or equal to 0.1.
    // This task will be tested on several different states |ψ⟩; since the task is dependent on measurement results and 
    // can be not deterministic, you will be given 5 attempts for each state |ψ⟩; you need to pass at least one attempt.
    operation Task25 (qs : Qubit[]) : (Double, Double) {

      mutable numOnes = 0.;
      mutable alpha = 0.;

      for (i in 0..20) {

        if(M(qs[i]) == One) {
          set numOnes += 1.;
        }
      }

      set alpha = Sqrt(numOnes);

      return (alpha, 1. - alpha);
    }


    //////////////////////////////////////////////////////////////////
    // Part III. Unitaries
    //////////////////////////////////////////////////////////////////
    
    // Task 3.1*.
    // Goal: Implement a single-qubit gate SQRT(NOT).
    //       The description of the gate can be found at https://aka.ms/sqrtnot.
    operation Task31 (q : Qubit) : Unit {

      H(q);
      S(q);
      H(q);
    }


    // Task 3.2.
    // Goal: Implement a three-qubit gate defined by its effect on the basis states
    //       (the qubits are given in order |qs[0], qs[1], qs[2]⟩):
    //       |0 0 0⟩ → |0 0 0⟩
    //       |0 0 1⟩ → |0 0 1⟩
    //       |0 1 0⟩ → |0 1 0⟩
    //       |0 1 1⟩ → |0 1 1⟩
    //       |1 0 0⟩ → |1 1 0⟩
    //       |1 0 1⟩ → |1 1 1⟩
    //       |1 1 0⟩ → |1 0 1⟩
    //       |1 1 1⟩ → |1 0 0⟩
    operation Task32 (qs : Qubit[]) : Unit {
        
      CCNOT(qs[0], qs[1], qs[2]);
      CNOT(qs[0], qs[1]);
    }


    // Task 3.3*.
    // Goal: Implement a three-qubit Deutsch gate.
    //       The description of the gate can be found at https://aka.ms/deutschgate.
    operation Task33 (qs : Qubit[], theta : Double) : Unit {

      Controlled Rx([qs[0],qs[1]], (2.*theta, qs[2]));
    }
}
