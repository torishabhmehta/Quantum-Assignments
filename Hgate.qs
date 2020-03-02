namespace MyApp {

  open Microsoft.Quantum.Canon;
  open Microsoft.Quantum.Intrinsic;

  operation Hgate () : Unit {

    mutable numOnes = 0;

    for (i in 1..1000) {

      using (q = Qubit[1]) {

        H(q[0]);
        let res = M(q[0]);

        if (M(q[0]) == One) {
          set numOnes += 1;
        }
        ResetAll(q);
      }
    }

    Message($"{numOnes}");
  }
}
