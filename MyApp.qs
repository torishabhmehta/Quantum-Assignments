namespace MyApp
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;

    operation Template () : (Int, Int) {

      mutable numOnes = 0;

      using (q0 = Qubit()) {

        for (test in 1..1000) {
          X(q0);
          let res = M (q0);

          // Count the number of ones we saw:
          if (res == One) {
              set numOnes += 1;
          }
        }
      }

      // Return number of times we saw a |0> and number of times we saw a |1>
      return (1000-numOnes, numOnes);
    }
}
