namespace MyApp {
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Canon;

    operation entangle () : Unit {

      mutable numOnes = [0,0,0];

      for (i in 1..1000) {

        using (q = Qubit[3]) {

          H(q[0]);
          CNOT(q[0], q[1]);
          CNOT(q[1], q[2]);
          
          let res = [M(q[0]), M(q[1]), M(q[2])];

          for (j in 0..2) {

            if (res[j] == One) {
              set numOnes w/= j <- numOnes[j] + 1;
            }

          }

          ResetAll(q);
        }
      }

      Message($"{numOnes}");
    }

}
