#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Week2\",\"Name\":\"Task13\"},\"SourceFile\":\"/home/torishabhmehta/MyApp/New_Tasks_2.qs\",\"Position\":{\"Item1\":94,\"Item2\":2},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":19},\"Item2\":{\"Line\":1,\"Column\":20}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":33}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Week2\",\"Name\":\"Task13\"},\"SourceFile\":\"/home/torishabhmehta/MyApp/New_Tasks_2.qs\",\"Position\":{\"Item1\":94,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Week2\",\"Name\":\"Task21\"},\"SourceFile\":\"/home/torishabhmehta/MyApp/New_Tasks_2.qs\",\"Position\":{\"Item1\":141,\"Item2\":2},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qBob\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":19},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qAlice\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":39}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Week2\",\"Name\":\"Task21\"},\"SourceFile\":\"/home/torishabhmehta/MyApp/New_Tasks_2.qs\",\"Position\":{\"Item1\":141,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Week2\",\"Name\":\"Task22\"},\"SourceFile\":\"/home/torishabhmehta/MyApp/New_Tasks_2.qs\",\"Position\":{\"Item1\":176,\"Item2\":2},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qBob\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":19},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b1\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b2\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":45},\"Item2\":{\"Line\":1,\"Column\":47}}}]}]]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Week2\",\"Name\":\"Task22\"},\"SourceFile\":\"/home/torishabhmehta/MyApp/New_Tasks_2.qs\",\"Position\":{\"Item1\":176,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Week2\",\"Name\":\"Task23\"},\"SourceFile\":\"/home/torishabhmehta/MyApp/New_Tasks_2.qs\",\"Position\":{\"Item1\":199,\"Item2\":2},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qBob\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":19},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b1\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b2\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":45},\"Item2\":{\"Line\":1,\"Column\":47}}}]}]]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Week2\",\"Name\":\"Task23\"},\"SourceFile\":\"/home/torishabhmehta/MyApp/New_Tasks_2.qs\",\"Position\":{\"Item1\":199,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Week2
{
    public partial class Task13 : Operation<(IQArray<Qubit>,Qubit), QVoid>, ICallable
    {
        public Task13(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Qubit)>, IApplyData
        {
            public In((IQArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Task13";
        String ICallable.FullName => "Quantum.Week2.Task13";
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

        protected IUnitary<(Qubit,Qubit,Qubit)> MicrosoftQuantumPrimitiveCCNOT
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> MicrosoftQuantumPrimitiveResetAll
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Qubit), QVoid> Body => (__in__) =>
        {
            var (x,y) = __in__;
#line hidden
            {
#line 97 "/home/torishabhmehta/MyApp/New_Tasks_2.qs"
                var c = Allocate.Apply(3L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 99 "/home/torishabhmehta/MyApp/New_Tasks_2.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((x[0L], x[1L], c[1L]));
#line 100 "/home/torishabhmehta/MyApp/New_Tasks_2.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((x[0L], c[0L]));
#line 101 "/home/torishabhmehta/MyApp/New_Tasks_2.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((x[1L], c[0L]));
#line 103 "/home/torishabhmehta/MyApp/New_Tasks_2.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((x[2L], c[0L], c[1L]));
#line 104 "/home/torishabhmehta/MyApp/New_Tasks_2.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((x[2L], c[0L]));
#line 106 "/home/torishabhmehta/MyApp/New_Tasks_2.qs"
                    MicrosoftQuantumPrimitiveX.Controlled.Apply((new QArray<Qubit>(x[3L], c[0L], c[1L]), c[2L]));
#line 107 "/home/torishabhmehta/MyApp/New_Tasks_2.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((x[3L], c[0L], c[1L]));
#line 108 "/home/torishabhmehta/MyApp/New_Tasks_2.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((x[3L], c[0L]));
#line 110 "/home/torishabhmehta/MyApp/New_Tasks_2.qs"
                    MicrosoftQuantumPrimitiveX.Controlled.Apply((new QArray<Qubit>(x[4L], c[0L], c[1L]), c[2L]));
#line 111 "/home/torishabhmehta/MyApp/New_Tasks_2.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((x[4L], c[0L], c[1L]));
#line 112 "/home/torishabhmehta/MyApp/New_Tasks_2.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((x[4L], c[0L]));
#line 114 "/home/torishabhmehta/MyApp/New_Tasks_2.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((c[0L], c[1L], y));
#line 115 "/home/torishabhmehta/MyApp/New_Tasks_2.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((c[2L], y));
#line 117 "/home/torishabhmehta/MyApp/New_Tasks_2.qs"
                    MicrosoftQuantumPrimitiveResetAll.Apply(c);
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
                    Release.Apply(c);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumPrimitiveCCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CCNOT));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, Qubit y)
        {
            return __m__.Run<Task13, (IQArray<Qubit>,Qubit), QVoid>((x, y));
        }
    }

    public partial class Task21 : Operation<(Qubit,Qubit), IQArray<Boolean>>, ICallable
    {
        public Task21(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Qubit)>, IApplyData
        {
            public In((Qubit,Qubit) data) : base(data)
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

        String ICallable.Name => "Task21";
        String ICallable.FullName => "Quantum.Week2.Task21";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
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

        public override Func<(Qubit,Qubit), IQArray<Boolean>> Body => (__in__) =>
        {
            var (qBob,qAlice) = __in__;
#line 144 "/home/torishabhmehta/MyApp/New_Tasks_2.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((qAlice, qBob));
#line 145 "/home/torishabhmehta/MyApp/New_Tasks_2.qs"
            MicrosoftQuantumPrimitiveH.Apply(qAlice);
#line 147 "/home/torishabhmehta/MyApp/New_Tasks_2.qs"
            var output = new QArray<Boolean>(false, false);
#line 149 "/home/torishabhmehta/MyApp/New_Tasks_2.qs"
            if ((MicrosoftQuantumPrimitiveM.Apply(qAlice) == Result.Zero))
            {
#line 150 "/home/torishabhmehta/MyApp/New_Tasks_2.qs"
                output.Modify(0L, true);
            }

#line 153 "/home/torishabhmehta/MyApp/New_Tasks_2.qs"
            if ((MicrosoftQuantumPrimitiveM.Apply(qBob) == Result.Zero))
            {
#line 154 "/home/torishabhmehta/MyApp/New_Tasks_2.qs"
                output.Modify(1L, true);
            }

#line 157 "/home/torishabhmehta/MyApp/New_Tasks_2.qs"
            return output;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.MicrosoftQuantumPrimitiveM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
        }

        public override IApplyData __dataIn((Qubit,Qubit) data) => new In(data);
        public override IApplyData __dataOut(IQArray<Boolean> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Boolean>> Run(IOperationFactory __m__, Qubit qBob, Qubit qAlice)
        {
            return __m__.Run<Task21, (Qubit,Qubit), IQArray<Boolean>>((qBob, qAlice));
        }
    }

    public partial class Task22 : Operation<(Qubit,(Boolean,Boolean)), QVoid>, ICallable
    {
        public Task22(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,(Boolean,Boolean))>, IApplyData
        {
            public In((Qubit,(Boolean,Boolean)) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                }
            }
        }

        String ICallable.Name => "Task22";
        String ICallable.FullName => "Quantum.Week2.Task22";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveY
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveZ
        {
            get;
            set;
        }

        public override Func<(Qubit,(Boolean,Boolean)), QVoid> Body => (__in__) =>
        {
            var (qBob,(b1,b2)) = __in__;
#line 179 "/home/torishabhmehta/MyApp/New_Tasks_2.qs"
            if ((b2 == true))
            {
#line 180 "/home/torishabhmehta/MyApp/New_Tasks_2.qs"
                MicrosoftQuantumPrimitiveY.Apply(qBob);
            }

#line 183 "/home/torishabhmehta/MyApp/New_Tasks_2.qs"
            if ((b1 == true))
            {
#line 184 "/home/torishabhmehta/MyApp/New_Tasks_2.qs"
                MicrosoftQuantumPrimitiveZ.Apply(qBob);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveY = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.Y));
            this.MicrosoftQuantumPrimitiveZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.Z));
        }

        public override IApplyData __dataIn((Qubit,(Boolean,Boolean)) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit qBob, Boolean b1, Boolean b2)
        {
            return __m__.Run<Task22, (Qubit,(Boolean,Boolean)), QVoid>((qBob, (b1, b2)));
        }
    }

    public partial class Task23 : Operation<(Qubit,(Boolean,Boolean)), QVoid>, ICallable
    {
        public Task23(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,(Boolean,Boolean))>, IApplyData
        {
            public In((Qubit,(Boolean,Boolean)) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                }
            }
        }

        String ICallable.Name => "Task23";
        String ICallable.FullName => "Quantum.Week2.Task23";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveS
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveY
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveZ
        {
            get;
            set;
        }

        public override Func<(Qubit,(Boolean,Boolean)), QVoid> Body => (__in__) =>
        {
            var (qBob,(b1,b2)) = __in__;
#line 202 "/home/torishabhmehta/MyApp/New_Tasks_2.qs"
            if ((b2 == true))
            {
#line 203 "/home/torishabhmehta/MyApp/New_Tasks_2.qs"
                MicrosoftQuantumPrimitiveY.Apply(qBob);
#line 204 "/home/torishabhmehta/MyApp/New_Tasks_2.qs"
                MicrosoftQuantumPrimitiveZ.Apply(qBob);
#line 205 "/home/torishabhmehta/MyApp/New_Tasks_2.qs"
                MicrosoftQuantumPrimitiveS.Apply(qBob);
            }

#line 208 "/home/torishabhmehta/MyApp/New_Tasks_2.qs"
            if ((b1 == true))
            {
#line 209 "/home/torishabhmehta/MyApp/New_Tasks_2.qs"
                MicrosoftQuantumPrimitiveZ.Apply(qBob);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveS = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.S));
            this.MicrosoftQuantumPrimitiveY = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.Y));
            this.MicrosoftQuantumPrimitiveZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.Z));
        }

        public override IApplyData __dataIn((Qubit,(Boolean,Boolean)) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit qBob, Boolean b1, Boolean b2)
        {
            return __m__.Run<Task23, (Qubit,(Boolean,Boolean)), QVoid>((qBob, (b1, b2)));
        }
    }
}