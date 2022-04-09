// ts2fable 0.0.0
module rec DeepDiff
open System
open Fable.Core
open Fable.Core.JS

type Array<'T> = System.Collections.Generic.IList<'T>


type [<AllowNullLiteral>] IExports =
    abstract diff: lhs: 'LHS * rhs: 'RHS * ?prefilter: PreFilter<'LHS, 'RHS> -> Array<Diff<'LHS, 'RHS>> option
    abstract diff: lhs: 'LHS * rhs: 'RHS * ?prefilter: PreFilter<'LHS, 'RHS> * ?acc: Accumulator<'LHS, 'RHS> -> Accumulator<'LHS, 'RHS>
    abstract orderIndependentDiff: lhs: 'LHS * rhs: 'RHS * ?prefilter: PreFilter<'LHS, 'RHS> -> Array<Diff<'LHS, 'RHS>> option
    abstract orderIndependentDiff: lhs: 'LHS * rhs: 'RHS * ?prefilter: PreFilter<'LHS, 'RHS> * ?acc: Accumulator<'LHS, 'RHS> -> Accumulator<'LHS, 'RHS>
    abstract observableDiff: lhs: 'LHS * rhs: 'RHS * ?observer: Observer<'LHS, 'RHS> * ?prefilter: PreFilter<'LHS, 'RHS> * ?orderIndependent: bool -> Array<Diff<'LHS, 'RHS>>
    abstract orderIndependentDeepDiff: lhs: 'LHS * rhs: 'RHS * changes: Array<Diff<'LHS, 'RHS>> * prefilter: PreFilter<'LHS, 'RHS> * path: ResizeArray<obj option> * key: obj option * stack: ResizeArray<obj option> -> unit
    abstract orderIndepHash: object: obj option -> float
    abstract applyDiff: target: 'LHS * source: 'RHS * ?filter: Filter<'LHS, 'RHS> -> unit
    abstract applyChange: target: 'LHS * source: obj option * change: Diff<'LHS, obj option> -> unit
    abstract revertChange: target: 'LHS * source: obj option * change: Diff<'LHS, obj option> -> unit

type [<AllowNullLiteral>] DiffNew<'RHS> =
    abstract kind: string with get, set
    abstract path: ResizeArray<obj option> option with get, set
    abstract rhs: 'RHS with get, set

type [<AllowNullLiteral>] DiffDeleted<'LHS> =
    abstract kind: string with get, set
    abstract path: ResizeArray<obj option> option with get, set
    abstract lhs: 'LHS with get, set

type DiffEdit<'LHS> =
    DiffEdit<'LHS, 'LHS>

type [<AllowNullLiteral>] DiffEdit<'LHS, 'RHS> =
    abstract kind: string with get, set
    abstract path: ResizeArray<obj option> option with get, set
    abstract lhs: 'LHS with get, set
    abstract rhs: 'RHS with get, set

type DiffArray<'LHS> =
    DiffArray<'LHS, 'LHS>

type [<AllowNullLiteral>] DiffArray<'LHS, 'RHS> =
    abstract kind: string with get, set
    abstract path: ResizeArray<obj option> option with get, set
    abstract index: float with get, set
    abstract item: Diff<'LHS, 'RHS> with get, set

type Diff<'LHS> =
    Diff<'LHS, 'LHS>

type [<TypeScriptTaggedUnion("kind")>] [<RequireQualifiedAccess>] Diff<'LHS, 'RHS> =
    | [<CompiledName "A">] DiffArray of DiffArray<'LHS, 'RHS>
    | [<CompiledName "D">] DiffDeleted of DiffDeleted<'LHS>
    | [<CompiledName "E">] DiffEdit of DiffEdit<'LHS, 'RHS>
    | [<CompiledName "N">] DiffNew of DiffNew<'RHS>

type [<AllowNullLiteral>] PreFilterFunction =
    [<Emit "$0($1...)">] abstract Invoke: path: ResizeArray<obj option> * key: obj option -> bool

type PreFilterObject<'LHS> =
    PreFilterObject<'LHS, 'LHS>

type [<AllowNullLiteral>] PreFilterObject<'LHS, 'RHS> =
    abstract prefilter: path: ResizeArray<obj option> * key: obj option -> bool
    abstract normalize: currentPath: obj option * key: obj option * lhs: 'LHS * rhs: 'RHS -> 'LHS * 'RHS option

type PreFilter<'LHS> =
    PreFilter<'LHS, 'LHS>

type PreFilter<'LHS, 'RHS> =
    U2<PreFilterFunction, PreFilterObject<'LHS, 'RHS>>

type Accumulator<'LHS> =
    Accumulator<'LHS, 'LHS>

type [<AllowNullLiteral>] Accumulator<'LHS, 'RHS> =
    abstract push: diff: Diff<'LHS, 'RHS> -> unit
    abstract length: float with get, set

type Observer<'LHS> =
    Observer<'LHS, 'LHS>

type [<AllowNullLiteral>] Observer<'LHS, 'RHS> =
    [<Emit "$0($1...)">] abstract Invoke: diff: Diff<'LHS, 'RHS> -> unit

type Filter<'LHS> =
    Filter<'LHS, 'LHS>

type [<AllowNullLiteral>] Filter<'LHS, 'RHS> =
    [<Emit "$0($1...)">] abstract Invoke: target: 'LHS * source: 'RHS * change: Diff<'LHS, 'RHS> -> bool
