// Copyright (c) Microsoft Corporation. All rights reserved.

// Author: Rishabh Mehta (17122018) B.Tech EPh IIIrd yr.

namespace Quantum.Week2 {
    
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    
    
    //////////////////////////////////////////////////////////////////
    // This is the set of programming assignments for week 2.
    //////////////////////////////////////////////////////////////////

    // The tasks cover the following topics:
    //  - teleportation
    //  - superdense coding
    //  - quantum oracles
    //  - Deutsch-Jozsa algorithm
    //
    // We recommend to solve the following katas before doing these assignments:
    //  - Teleportation
    //  - SuperdenseCoding
    //  - DeutschJozsaAlgorithm
    // from https://github.com/Microsoft/QuantumKatas

    //////////////////////////////////////////////////////////////////
    // Part I. Quantum oracles and Deutsch-Jozsa algorithm
    //////////////////////////////////////////////////////////////////

    // In this section the oracles are defined on computational basis states,
    // as described at https://docs.microsoft.com/en-us/quantum/concepts/oracles.
    
    // Task 1.1. (The oracles for Deutsch algorithm)
    // Inputs:
    //      1) a qubit in an arbitrary state |x⟩ (function input)
    //      2) a qubit in an arbitrary state |y⟩ (function output)
    //      3) an integer F which defines which function to implement:
    //         F = 0 : f(x) = 0
    //         F = 1 : f(x) = 1
    //         F = 2 : f(x) = x
    //         F = 3 : f(x) = 1 - x
    // Goal: transform state |x⟩|y⟩ into state |x⟩|y ⊕ f(x)⟩ (⊕ is addition modulo 2).
    operation Task11 (x : Qubit, y : Qubit, F : Int) : Unit {
        
        if (F == 1) {

            X(y);

        } elif (F == 2) {

            CNOT(x,y);

        } elif (F == 3) {

            X(x);
            CNOT(x,y);
            X(x);

        }
    }


    // Task 1.2. (Deutsch Algorithm)
    // Input: a quantum operation - the oracle |x⟩|y⟩ -> |x⟩|y ⊕ f(x)⟩,
    //        where f(x) is one of the functions implemented in task 1.1.
    // Output: f(0) ⊕ f(1)
    //        i.e., for f(x) = 0 or f(x) = 1 the output will be 0,
    //        and for f(x) = x or f(x) = 1 - x the output will be 1.
    operation Task12 (oracle : ((Qubit, Qubit) => Unit)) : Int {

        mutable output = 0;

        using ((x, y) = (Qubit(), Qubit())) {

            // Preparing the qubits
            H(x);

            X(y);
            H(y);

            // Applying oracle
            oracle(x,y);

            H(x);

            if (M(x) == One) {
                set output = 1;
            }

        }
        
        return output;
    }
   
}
