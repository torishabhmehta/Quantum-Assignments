// Copyright (c) Microsoft Corporation. All rights reserved.

// Author: Rishabh Mehta (17122018) B.Tech EPh IIIrd yr.

namespace Quantum.Week1 {
    
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Intrinsic;
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
    // operation Task11 (q : Qubit) : Unit {

    //     mutable alpha = ArcCos(0.8);

    //     Ry(2.0 * alpha, q);
    // }

    
    // Task 1.2.
    // Input: a qubit in |0⟩ state.
    // Goal: create one of the following states based on the value of index:
    //    0: (|0⟩ + i|1⟩) / sqrt(2)
    //    1: (|0⟩ - i|1⟩) / sqrt(2)
    // operation Task12 (q : Qubit, index : Int) : Unit {
      
    //     if (index == 0) {
    //       H(q);
    //       S(q);
    //     } elif (index == 1) {
    //       X(q);
    //       H(q);
    //       S(q);
    //     }
    // }

    
    // Task 1.3.
    // Input: a qubit in |0⟩ state.
    // Goal: create the following state on this qubit: ((1+i)|0⟩ + (1-i)|1⟩)) / 2.
    // operation Task13 (q : Qubit) : Unit {

    //     H(q);
    //     S(q);
    //     H(q);
    // }


    // // Task 1.4.
    // // Input: two qubits in |00⟩ state (stored in an array of length 2).
    // // Goal: create the following state on these qubits: (|00⟩ + i|01⟩ - i|10⟩ + |11⟩) / 2.
    // //       The states of the qubits are given in order |qs[0], qs[1]⟩.
    // operation Task14 (qs : Qubit[]) : Unit {
        
    //     X(qs[0]);
    //     H(qs[0]);
    //     S(qs[0]);

    //     H(qs[1]);
    //     S(qs[1]);
    // }


   
    // // Task 1.6.
    // // Input: three qubits in |000⟩ state (stored in an array of length 3).
    // // Goal: create the following state on these qubits: (|000⟩ + |001⟩ + |010⟩ + |100⟩) / 2.
    // operation Task16 (qs : Qubit[]) : Unit {

    //     H(qs[0]);
    //     H(qs[1]);

    //     CCNOT(qs[0], qs[1], qs[2]);
    //     CCNOT(qs[0], qs[2], qs[1]);

    //     CNOT(qs[2], qs[0]);
    // }


   


    //////////////////////////////////////////////////////////////////
    // Part II. Measurements
    //////////////////////////////////////////////////////////////////
    
    // Task 2.1.
    // Input: a qubit which is guaranteed to be in |0⟩ or |1⟩ state.
    // Output: true if the qubit was in |0⟩ state, or false if it was in |1⟩ state.
    // The state of the qubit at the end of the operation does not matter.
    // operation Task21 (q : Qubit) : Bool {

    //     let res = M(q);

    //     if (res == Zero) {
    //       return true;
    //     }

    //     return false;
    // }
    

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
//     operation Task22 (qs : Qubit[]) : Int {

//         mutable numOnes = 0;

//         let res = [M(qs[0]), M(qs[1]), M(qs[2])];

//         for (i in 0..2) {

//           if (res[i] == One) {
//             set numOnes += 1;
//           }
//         }

//         if (numOnes <= 1) {
//           return 0;
//         }

//         return 1;
//     }
   
  }
