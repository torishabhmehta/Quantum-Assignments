#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Week3\",\"Name\":\"Task11\"},\"SourceFile\":\"/home/torishabhmehta/MyApp/New_Tasks_3.qs\",\"Position\":{\"Item1\":35,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":19},\"Item2\":{\"Line\":1,\"Column\":20}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":33}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Week3\",\"Name\":\"Task11\"},\"SourceFile\":\"/home/torishabhmehta/MyApp/New_Tasks_3.qs\",\"Position\":{\"Item1\":36,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Week3\",\"Name\":\"Task11\"},\"SourceFile\":\"/home/torishabhmehta/MyApp/New_Tasks_3.qs\",\"Position\":{\"Item1\":45,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Week3\",\"Name\":\"Task12\"},\"SourceFile\":\"/home/torishabhmehta/MyApp/New_Tasks_3.qs\",\"Position\":{\"Item1\":69,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"N\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":19},\"Item2\":{\"Line\":1,\"Column\":20}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Uf\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":30}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Week3\",\"Name\":\"Task12\"},\"SourceFile\":\"/home/torishabhmehta/MyApp/New_Tasks_3.qs\",\"Position\":{\"Item1\":69,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Week3
{
    public partial class Task11 : Adjointable<(IQArray<Qubit>,IQArray<Qubit>)>, ICallable
    {
        public Task11(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Task11";
        String ICallable.FullName => "Quantum.Week3.Task11";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (x,y) = __in__;
#line 39 "/home/torishabhmehta/MyApp/New_Tasks_3.qs"
            var N = x.Length;
#line 41 "/home/torishabhmehta/MyApp/New_Tasks_3.qs"
            foreach (var i in new Range(0L, (N - 2L)))
#line hidden
            {
#line 42 "/home/torishabhmehta/MyApp/New_Tasks_3.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((x[(i + 1L)], y[i]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (x,y) = __in__;
#line hidden
            var N = x.Length;
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (N - 2L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((x[(i + 1L)], y[i]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, IQArray<Qubit> y)
        {
            return __m__.Run<Task11, (IQArray<Qubit>,IQArray<Qubit>), QVoid>((x, y));
        }
    }

    public partial class Task12 : Operation<(Int64,ICallable), IQArray<IQArray<Int64>>>, ICallable
    {
        public Task12(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,ICallable)>, IApplyData
        {
            public In((Int64,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "Task12";
        String ICallable.FullName => "Quantum.Week3.Task12";
        protected ICallable MicrosoftQuantumCanonApplyToEach
        {
            get;
            set;
        }

        protected IAdjointable MicrosoftQuantumCanonApplyToEachA
        {
            get;
            set;
        }

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

        protected ICallable<IQArray<Qubit>, QVoid> MicrosoftQuantumPrimitiveResetAll
        {
            get;
            set;
        }

        public override Func<(Int64,ICallable), IQArray<IQArray<Int64>>> Body => (__in__) =>
        {
            var (N,Uf) = __in__;
#line 72 "/home/torishabhmehta/MyApp/New_Tasks_3.qs"
            var b = QArray<IQArray<Int64>>.Create(2L);
#line hidden
            {
#line 74 "/home/torishabhmehta/MyApp/New_Tasks_3.qs"
                var (x,y) = (Allocate.Apply(N), Allocate.Apply(N));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 76 "/home/torishabhmehta/MyApp/New_Tasks_3.qs"
                    foreach (var ii in new Range(1L, 5L))
#line hidden
                    {
#line 79 "/home/torishabhmehta/MyApp/New_Tasks_3.qs"
                        MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumPrimitiveH, x));
#line 82 "/home/torishabhmehta/MyApp/New_Tasks_3.qs"
                        Uf.Apply((x, y));
#line 85 "/home/torishabhmehta/MyApp/New_Tasks_3.qs"
                        MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumPrimitiveH, x));
#line 87 "/home/torishabhmehta/MyApp/New_Tasks_3.qs"
                        var j = QArray<Int64>.Create(N);
#line 89 "/home/torishabhmehta/MyApp/New_Tasks_3.qs"
                        foreach (var i in new Range(0L, (N - 1L)))
#line hidden
                        {
#line 90 "/home/torishabhmehta/MyApp/New_Tasks_3.qs"
                            if ((MicrosoftQuantumPrimitiveM.Apply(x[i]) == Result.One))
                            {
#line 91 "/home/torishabhmehta/MyApp/New_Tasks_3.qs"
                                j.Modify(i, 1L);
                            }
                        }

#line 95 "/home/torishabhmehta/MyApp/New_Tasks_3.qs"
                        MicrosoftQuantumPrimitiveResetAll.Apply(x);
#line 96 "/home/torishabhmehta/MyApp/New_Tasks_3.qs"
                        MicrosoftQuantumPrimitiveResetAll.Apply(y);
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

#line 100 "/home/torishabhmehta/MyApp/New_Tasks_3.qs"
            return b;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            this.MicrosoftQuantumCanonApplyToEachA = this.Factory.Get<IAdjointable>(typeof(Microsoft.Quantum.Canon.ApplyToEachA<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.MicrosoftQuantumPrimitiveM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.MicrosoftQuantumPrimitiveResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
        }

        public override IApplyData __dataIn((Int64,ICallable) data) => new In(data);
        public override IApplyData __dataOut(IQArray<IQArray<Int64>> data) => data;
        public static System.Threading.Tasks.Task<IQArray<IQArray<Int64>>> Run(IOperationFactory __m__, Int64 N, ICallable Uf)
        {
            return __m__.Run<Task12, (Int64,ICallable), IQArray<IQArray<Int64>>>((N, Uf));
        }
    }
}