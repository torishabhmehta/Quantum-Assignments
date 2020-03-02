#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"MyApp\",\"Name\":\"Hgate\"},\"SourceFile\":\"/home/torishabhmehta/MyApp/Hgate.qs\",\"Position\":{\"Item1\":5,\"Item2\":2},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MyApp\",\"Name\":\"Hgate\"},\"SourceFile\":\"/home/torishabhmehta/MyApp/Hgate.qs\",\"Position\":{\"Item1\":5,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"Documentation\":[]}")]
#line hidden
namespace MyApp
{
    public partial class Hgate : Operation<QVoid, QVoid>, ICallable
    {
        public Hgate(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Hgate";
        String ICallable.FullName => "MyApp.Hgate";
        protected Allocate Allocate
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
#line 8 "/home/torishabhmehta/MyApp/Hgate.qs"
            var numOnes = 0L;
#line 10 "/home/torishabhmehta/MyApp/Hgate.qs"
            foreach (var i in new Range(1L, 1000L))
#line hidden
            {
#line hidden
                {
#line 12 "/home/torishabhmehta/MyApp/Hgate.qs"
                    var q = Allocate.Apply(1L);
#line hidden
                    Exception __arg1__ = null;
                    try
                    {
#line 14 "/home/torishabhmehta/MyApp/Hgate.qs"
                        MicrosoftQuantumIntrinsicH.Apply(q[0L]);
#line 15 "/home/torishabhmehta/MyApp/Hgate.qs"
                        var res = MicrosoftQuantumIntrinsicM.Apply(q[0L]);
#line 17 "/home/torishabhmehta/MyApp/Hgate.qs"
                        if ((MicrosoftQuantumIntrinsicM.Apply(q[0L]) == Result.One))
                        {
#line 18 "/home/torishabhmehta/MyApp/Hgate.qs"
                            numOnes = (numOnes + 1L);
                        }

#line 20 "/home/torishabhmehta/MyApp/Hgate.qs"
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

#line 24 "/home/torishabhmehta/MyApp/Hgate.qs"
            MicrosoftQuantumIntrinsicMessage.Apply(String.Format("{0}", numOnes));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
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
            return __m__.Run<Hgate, QVoid, QVoid>(QVoid.Instance);
        }
    }
}