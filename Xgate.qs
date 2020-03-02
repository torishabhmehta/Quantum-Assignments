namespace MyApp
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;

    operation Xgate () : Unit {

        using (q0 = Qubit[1]) {
          X(q0[0]);
          let res = M(q0[0]);
          Message($"{res}");
          ResetAll(q0);
        }
    }
}
