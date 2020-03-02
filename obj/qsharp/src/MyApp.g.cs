#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"MyApp\",\"Name\":\"Template\"},\"SourceFile\":\"/home/torishabhmehta/MyApp/MyApp.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MyApp\",\"Name\":\"Template\"},\"SourceFile\":\"/home/torishabhmehta/MyApp/MyApp.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
#line hidden
namespace MyApp
{
    public partial class Template : Operation<QVoid, (Int64,Int64)>, ICallable
    {
        public Template(IOperationFactory m) : base(m)
        {
        }

        public class Out : QTuple<(Int64,Int64)>, IApplyData
        {
            public Out((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "Template";
        String ICallable.FullName => "MyApp.Template";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<QVoid, (Int64,Int64)> Body => (__in__) =>
        {
#line 8 "/home/torishabhmehta/MyApp/MyApp.qs"
            var numOnes = 0L;
#line hidden
            {
#line 10 "/home/torishabhmehta/MyApp/MyApp.qs"
                var q0 = Allocate.Apply();
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 12 "/home/torishabhmehta/MyApp/MyApp.qs"
                    foreach (var test in new Range(1L, 1000L))
#line hidden
                    {
#line 13 "/home/torishabhmehta/MyApp/MyApp.qs"
                        MicrosoftQuantumIntrinsicX.Apply(q0);
#line 14 "/home/torishabhmehta/MyApp/MyApp.qs"
                        var res = MicrosoftQuantumIntrinsicM.Apply(q0);
#line 17 "/home/torishabhmehta/MyApp/MyApp.qs"
                        if ((res == Result.One))
                        {
#line 18 "/home/torishabhmehta/MyApp/MyApp.qs"
                            numOnes = (numOnes + 1L);
                        }
                    }
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
                    Release.Apply(q0);
                }
            }

#line 24 "/home/torishabhmehta/MyApp/MyApp.qs"
            return ((1000L - numOnes), numOnes);
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut((Int64,Int64) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Int64,Int64)> Run(IOperationFactory __m__)
        {
            return __m__.Run<Template, QVoid, (Int64,Int64)>(QVoid.Instance);
        }
    }
}