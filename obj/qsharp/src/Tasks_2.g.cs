#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Week2\",\"Name\":\"Task11\"},\"SourceFile\":\"/home/torishabhmehta/MyApp/Tasks_2.qs\",\"Position\":{\"Item1\":45,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":19},\"Item2\":{\"Line\":1,\"Column\":20}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":31}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"F\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":42}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Week2\",\"Name\":\"Task11\"},\"SourceFile\":\"/home/torishabhmehta/MyApp/Tasks_2.qs\",\"Position\":{\"Item1\":45,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Week2\",\"Name\":\"Task12\"},\"SourceFile\":\"/home/torishabhmehta/MyApp/Tasks_2.qs\",\"Position\":{\"Item1\":71,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":19},\"Item2\":{\"Line\":1,\"Column\":25}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Week2\",\"Name\":\"Task12\"},\"SourceFile\":\"/home/torishabhmehta/MyApp/Tasks_2.qs\",\"Position\":{\"Item1\":71,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Week2
{
    public partial class Task11 : Operation<(Qubit,Qubit,Int64), QVoid>, ICallable
    {
        public Task11(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Qubit,Int64)>, IApplyData
        {
            public In((Qubit,Qubit,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "Task11";
        String ICallable.FullName => "Quantum.Week2.Task11";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Qubit,Qubit,Int64), QVoid> Body => (__in__) =>
        {
            var (x,y,F) = __in__;
#line 48 "/home/torishabhmehta/MyApp/Tasks_2.qs"
            if ((F == 1L))
            {
#line 50 "/home/torishabhmehta/MyApp/Tasks_2.qs"
                MicrosoftQuantumPrimitiveX.Apply(y);
            }
            else if ((F == 2L))
            {
#line 54 "/home/torishabhmehta/MyApp/Tasks_2.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((x, y));
            }
            else if ((F == 3L))
            {
#line 58 "/home/torishabhmehta/MyApp/Tasks_2.qs"
                MicrosoftQuantumPrimitiveX.Apply(x);
#line 59 "/home/torishabhmehta/MyApp/Tasks_2.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((x, y));
#line 60 "/home/torishabhmehta/MyApp/Tasks_2.qs"
                MicrosoftQuantumPrimitiveX.Apply(x);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Qubit,Qubit,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit x, Qubit y, Int64 F)
        {
            return __m__.Run<Task11, (Qubit,Qubit,Int64), QVoid>((x, y, F));
        }
    }

    public partial class Task12 : Operation<ICallable, Int64>, ICallable
    {
        public Task12(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Task12";
        String ICallable.FullName => "Quantum.Week2.Task12";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumPrimitiveM
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<ICallable, Int64> Body => (__in__) =>
        {
            var oracle = __in__;
#line 74 "/home/torishabhmehta/MyApp/Tasks_2.qs"
            var output = 0L;
#line hidden
            {
#line 76 "/home/torishabhmehta/MyApp/Tasks_2.qs"
                var (x,y) = (Allocate.Apply(), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 79 "/home/torishabhmehta/MyApp/Tasks_2.qs"
                    MicrosoftQuantumPrimitiveH.Apply(x);
#line 81 "/home/torishabhmehta/MyApp/Tasks_2.qs"
                    MicrosoftQuantumPrimitiveX.Apply(y);
#line 82 "/home/torishabhmehta/MyApp/Tasks_2.qs"
                    MicrosoftQuantumPrimitiveH.Apply(y);
#line 85 "/home/torishabhmehta/MyApp/Tasks_2.qs"
                    oracle.Apply((x, y));
#line 87 "/home/torishabhmehta/MyApp/Tasks_2.qs"
                    MicrosoftQuantumPrimitiveH.Apply(x);
#line 89 "/home/torishabhmehta/MyApp/Tasks_2.qs"
                    if ((MicrosoftQuantumPrimitiveM.Apply(x) == Result.One))
                    {
#line 90 "/home/torishabhmehta/MyApp/Tasks_2.qs"
                        output = 1L;
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
                    Release.Apply(x);
#line hidden
                    Release.Apply(y);
                }
            }

#line 95 "/home/torishabhmehta/MyApp/Tasks_2.qs"
            return output;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.MicrosoftQuantumPrimitiveM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(ICallable data) => new QTuple<ICallable>(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, ICallable oracle)
        {
            return __m__.Run<Task12, ICallable, Int64>(oracle);
        }
    }
}