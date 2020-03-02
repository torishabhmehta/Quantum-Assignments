#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"MyApp\",\"Name\":\"entangle\"},\"SourceFile\":\"/home/torishabhmehta/MyApp/entangle.qs\",\"Position\":{\"Item1\":4,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MyApp\",\"Name\":\"entangle\"},\"SourceFile\":\"/home/torishabhmehta/MyApp/entangle.qs\",\"Position\":{\"Item1\":4,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
#line hidden
namespace MyApp
{
    public partial class entangle : Operation<QVoid, QVoid>, ICallable
    {
        public entangle(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "entangle";
        String ICallable.FullName => "MyApp.entangle";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> MicrosoftQuantumIntrinsicMessage
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> MicrosoftQuantumIntrinsicResetAll
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 7 "/home/torishabhmehta/MyApp/entangle.qs"
            var numOnes = new QArray<Int64>(0L, 0L, 0L);
#line 9 "/home/torishabhmehta/MyApp/entangle.qs"
            foreach (var i in new Range(1L, 1000L))
#line hidden
            {
#line hidden
                {
#line 11 "/home/torishabhmehta/MyApp/entangle.qs"
                    var q = Allocate.Apply(3L);
#line hidden
                    Exception __arg1__ = null;
                    try
                    {
#line 13 "/home/torishabhmehta/MyApp/entangle.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q[0L]);
#line 14 "/home/torishabhmehta/MyApp/entangle.qs"
                        MicrosoftQuantumIntrinsicCNOT.Apply((q[0L], q[1L]));
#line 15 "/home/torishabhmehta/MyApp/entangle.qs"
                        MicrosoftQuantumIntrinsicCNOT.Apply((q[1L], q[2L]));
#line 17 "/home/torishabhmehta/MyApp/entangle.qs"
                        var res = (IQArray<Result>)new QArray<Result>(MicrosoftQuantumIntrinsicM.Apply(q[0L]), MicrosoftQuantumIntrinsicM.Apply(q[1L]), MicrosoftQuantumIntrinsicM.Apply(q[2L]));
#line 19 "/home/torishabhmehta/MyApp/entangle.qs"
                        foreach (var j in new Range(0L, 2L))
#line hidden
                        {
#line 21 "/home/torishabhmehta/MyApp/entangle.qs"
                            if ((res[j] == Result.One))
                            {
#line 22 "/home/torishabhmehta/MyApp/entangle.qs"
                                numOnes.Modify(j, (numOnes[j] + 1L));
                            }
                        }

#line 27 "/home/torishabhmehta/MyApp/entangle.qs"
                        MicrosoftQuantumIntrinsicResetAll.Apply(q);
                    }
#line hidden
                    catch (Exception __arg2__)
                    {
                        __arg1__ = __arg2__;
                        throw __arg1__;
                    }
#line hidden
                    finally
                    {
                        if (__arg1__ != null)
                        {
                            throw __arg1__;
                        }

#line hidden
                        Release.Apply(q);
                    }
                }
            }

#line 31 "/home/torishabhmehta/MyApp/entangle.qs"
            MicrosoftQuantumIntrinsicMessage.Apply(String.Format("{0}", numOnes));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.MicrosoftQuantumIntrinsicMessage = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.ResetAll));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<entangle, QVoid, QVoid>(QVoid.Instance);
        }
    }
}