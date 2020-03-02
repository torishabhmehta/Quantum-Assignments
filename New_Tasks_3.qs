// Copyright (c) Microsoft Corporation. All rights reserved.

// Author: Rishabh Mehta (17122018) B.Tech EPh IIIrd yr.

namespace Quantum.Week3 {
    
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    
    
    //////////////////////////////////////////////////////////////////
    // This is the set of programming assignments for week 3.
    //////////////////////////////////////////////////////////////////

    // The tasks cover the following topics:
    //  - Simon's algorithm
    //
    // We recommend to solve the SimonsAlgorithm kata from 
    // https://github.com/Microsoft/QuantumKatas before doing these assignments

    //////////////////////////////////////////////////////////////////
    // Part I. Quantum oracles and Simon's algorithm
    //////////////////////////////////////////////////////////////////

    // In this section the oracles are defined on computational basis states,
    // as described at https://docs.microsoft.com/en-us/quantum/concepts/oracles.
    
    // Task 1.1. (Bitwise left shift)
    // Inputs:
    //      1) N qubits in an arbitrary state |x⟩ (function input)
    //      2) N qubits in an arbitrary state |y⟩ (function output)
    // Goal: Transform state |x, y⟩ into |x, y ⊕ f(x)⟩, where f is bitwise left shift function, i.e.,
    // |y ⊕ f(x)⟩ = |y[0] ⊕ x[1], y[1] ⊕ x[2], ..., y[N-2] ⊕ x[N-1], y[N-1]⟩ (⊕ is addition modulo 2).
    operation Task11 (x : Qubit[], y : Qubit[]) : Unit {
        body (...) {

          let N = Length(x);

          for (i in 0 .. N - 2) {
            CNOT(x[i+1], y[i]);
          }
        }
        // Note that your implementation has to be adjointable.
        adjoint invert;
    }


    // Task 1.2. (Two bit strings orthogonal to s)
    // Inputs:
    //      1) the number of qubits in the input register N for the function f (4 <= N <= 6)
    //      2) a quantum operation which implements the oracle |x⟩|y⟩ -> |x⟩|y ⊕ f(x)⟩, where
    //         x is N-qubit input register, y is N-qubit answer register, 
    //         and f is a function from N-bit strings into N-bit strings
    // The function f satisfies the settings of the Simon's algorithm, i.e., 
    // it is a two-to-one function: there exists some N-bit string s such that 
    // for all N-bit strings b and c (b != c) we have f(b) = f(c) if and only if b = c ⊕ s.
    //
    // Output:
    //      Any two distinct non-zero bit strings b₀ and b₁ that are both orthogonal to s
    //      (i.e., Σᵢ b₀ᵢ sᵢ = 0 modulo 2 and Σᵢ b₁ᵢ sᵢ = 0 modulo 2).
    //      The return should be an array of 2 arrays, each of which should have length N.
    //      Both arrays should only have 0 and 1 as elements.
    // 
    // This task will be tested on several different oracles, implemented using 
    // Oracle_MultidimensionalOperatorOutput_Reference operation from SimonsAlgorithm oracle.
    // Since the task can be non-deterministic, you get 4 attempts for each oracle.
    // In each attempt you are allowed to make at most 5 oracle calls.
    operation Task12 (N : Int, Uf : ((Qubit[], Qubit[]) => Unit)) : Int[][] {

      mutable b = new Int[][2];

      using ((x, y) = (Qubit[N], Qubit[N])) {

        for (ii in 1..5) {

          // Preparing qubits
          ApplyToEachA(H, x);

          // Applying oracle
          Uf(x, y);

          // Prepping for measurement
          ApplyToEach(H, x);

          mutable j = new Int[N];

          for (i in 0 .. N - 1) {
            if (M(x[i]) == One) {
                set j w/= i <- 1;
            }
          }

          ResetAll(x);
          ResetAll(y);
        }
      }
      
      return b;
    }

}
