// ts2fable 0.0.0
module rec SyncTasks
open System
open Fable.Core
open Fable.Import.JS

let [<Import("*","synctasks")>] config: obj = jsNative

type [<AllowNullLiteral>] IExports =
    abstract fromThenable: thenable: Es6Thenable<'T> -> Promise<'T>
    /// This function will defer callback of the specified callback lambda until the next JS tick, simulating standard A+ promise behavior
    abstract asyncCallback: callback: (unit -> unit) -> unit
    abstract all: values: Raceable<'T1> * Raceable<'T2> * Raceable<'T3> * Raceable<'T4> * Raceable<'T5> * Raceable<'T6> * Raceable<'T7> * Raceable<'T8> * Raceable<'T9> * Raceable<'T10> -> Promise<'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10>
    abstract all: values: Raceable<'T1> * Raceable<'T2> * Raceable<'T3> * Raceable<'T4> * Raceable<'T5> * Raceable<'T6> * Raceable<'T7> * Raceable<'T8> * Raceable<'T9> -> Promise<'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9>
    abstract all: values: Raceable<'T1> * Raceable<'T2> * Raceable<'T3> * Raceable<'T4> * Raceable<'T5> * Raceable<'T6> * Raceable<'T7> * Raceable<'T8> -> Promise<'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8>
    abstract all: values: Raceable<'T1> * Raceable<'T2> * Raceable<'T3> * Raceable<'T4> * Raceable<'T5> * Raceable<'T6> * Raceable<'T7> -> Promise<'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7>
    abstract all: values: Raceable<'T1> * Raceable<'T2> * Raceable<'T3> * Raceable<'T4> * Raceable<'T5> * Raceable<'T6> -> Promise<'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6>
    abstract all: values: Raceable<'T1> * Raceable<'T2> * Raceable<'T3> * Raceable<'T4> * Raceable<'T5> -> Promise<'T1 * 'T2 * 'T3 * 'T4 * 'T5>
    abstract all: values: Raceable<'T1> * Raceable<'T2> * Raceable<'T3> * Raceable<'T4> -> Promise<'T1 * 'T2 * 'T3 * 'T4>
    abstract all: values: Raceable<'T1> * Raceable<'T2> * Raceable<'T3> -> Promise<'T1 * 'T2 * 'T3>
    abstract all: values: Raceable<'T1> * Raceable<'T2> -> Promise<'T1 * 'T2>
    abstract all: values: ResizeArray<U2<'T, Thenable<'T>>> -> Promise<ResizeArray<'T>>
    abstract Defer: unit -> Deferred<'T>
    abstract Resolved: unit -> Promise<'T>
    abstract Resolved: ``val``: 'T -> Promise<'T>
    abstract Rejected: ?``val``: obj option -> Promise<'T>
    abstract race: values: Raceable<'T1> * Raceable<'T2> * Raceable<'T3> * Raceable<'T4> * Raceable<'T5> * Raceable<'T6> * Raceable<'T7> * Raceable<'T8> * Raceable<'T9> * Raceable<'T10> -> Promise<obj>
    abstract race: values: Raceable<'T1> * Raceable<'T2> * Raceable<'T3> * Raceable<'T4> * Raceable<'T5> * Raceable<'T6> * Raceable<'T7> * Raceable<'T8> * Raceable<'T9> -> Promise<obj>
    abstract race: values: Raceable<'T1> * Raceable<'T2> * Raceable<'T3> * Raceable<'T4> * Raceable<'T5> * Raceable<'T6> * Raceable<'T7> * Raceable<'T8> -> Promise<U8<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8>>
    abstract race: values: Raceable<'T1> * Raceable<'T2> * Raceable<'T3> * Raceable<'T4> * Raceable<'T5> * Raceable<'T6> * Raceable<'T7> -> Promise<U7<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7>>
    abstract race: values: Raceable<'T1> * Raceable<'T2> * Raceable<'T3> * Raceable<'T4> * Raceable<'T5> * Raceable<'T6> -> Promise<U6<'T1, 'T2, 'T3, 'T4, 'T5, 'T6>>
    abstract race: values: Raceable<'T1> * Raceable<'T2> * Raceable<'T3> * Raceable<'T4> * Raceable<'T5> -> Promise<U5<'T1, 'T2, 'T3, 'T4, 'T5>>
    abstract race: values: Raceable<'T1> * Raceable<'T2> * Raceable<'T3> * Raceable<'T4> -> Promise<U4<'T1, 'T2, 'T3, 'T4>>
    abstract race: values: Raceable<'T1> * Raceable<'T2> * Raceable<'T3> -> Promise<U3<'T1, 'T2, 'T3>>
    abstract race: values: Raceable<'T1> * Raceable<'T2> -> Promise<U2<'T1, 'T2>>
    abstract race: values: ResizeArray<U2<'T, Thenable<'T>>> -> Promise<ResizeArray<'T>>
    abstract raceTimer: promise: Promise<'T> * timeMs: float -> Promise<RaceTimerResponse<'T>>

type [<AllowNullLiteral>] Es6Thenable<'R> =
    abstract ``then``: ?onFulfilled: ('R -> U2<'U, Es6Thenable<'U>>) * ?onRejected: (obj option -> U2<'U, Es6Thenable<'U>>) -> Es6Thenable<'U>
    abstract ``then``: ?onFulfilled: ('R -> U2<'U, Es6Thenable<'U>>) * ?onRejected: (obj option -> unit) -> Es6Thenable<'U>

type [<AllowNullLiteral>] SuccessFunc<'T, 'U> =
    [<Emit "$0($1...)">] abstract Invoke: value: 'T -> U2<'U, Thenable<'U>>

type [<AllowNullLiteral>] ErrorFunc<'U> =
    [<Emit "$0($1...)">] abstract Invoke: error: obj option -> U2<'U, Thenable<'U>>

type [<AllowNullLiteral>] CancelFunc =
    [<Emit "$0($1...)">] abstract Invoke: context: obj option -> unit

type [<AllowNullLiteral>] Deferred<'T> =
    abstract resolve: obj: 'T -> Deferred<'T>
    abstract reject: ?obj: obj option -> Deferred<'T>
    abstract promise: unit -> Promise<'T>
    abstract onCancel: callback: CancelFunc -> Deferred<'T>

type [<AllowNullLiteral>] Thenable<'T> =
    abstract ``then``: successFunc: SuccessFunc<'T, 'U> * ?errorFunc: ErrorFunc<'U> -> Promise<'U>

type [<AllowNullLiteral>] Cancelable =
    abstract cancel: ?context: obj option -> unit

type [<AllowNullLiteral>] Promise<'T> =
    inherit Thenable<'T>
    inherit Cancelable
    abstract catch: errorFunc: ErrorFunc<'T> -> Promise<'T>
    abstract ``finally``: func: (U2<'T, obj option> -> unit) -> Promise<'T>
    abstract always: func: (U2<'T, obj option> -> U2<'U, Thenable<'U>>) -> Promise<'U>
    abstract ``done``: successFunc: ('T -> unit) -> Promise<'T>
    abstract fail: errorFunc: (obj option -> unit) -> Promise<'T>
    abstract thenAsync: successFunc: SuccessFunc<'T, 'U> * ?errorFunc: ErrorFunc<'U> -> Promise<'U>
    abstract setTracingEnabled: enabled: bool -> Promise<'T>

type Raceable<'T> =
    U2<'T, Thenable<'T>> option

[<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module Raceable =
    let ofTOption v: Raceable<'T> = v |> Option.map U2.Case1
    let ofT v: Raceable<'T> = v |> U2.Case1 |> Some
    let isT (v: Raceable<'T>) = match v with None -> false | Some o -> match o with U2.Case1 _ -> true | _ -> false
    let asT (v: Raceable<'T>) = match v with None -> None | Some o -> match o with U2.Case1 o -> Some o | _ -> None
    let ofThenableOption v: Raceable<'T> = v |> Option.map U2.Case2
    let ofThenable v: Raceable<'T> = v |> U2.Case2 |> Some
    let isThenable (v: Raceable<'T>) = match v with None -> false | Some o -> match o with U2.Case2 _ -> true | _ -> false
    let asThenable (v: Raceable<'T>) = match v with None -> None | Some o -> match o with U2.Case2 o -> Some o | _ -> None

type [<AllowNullLiteral>] RaceTimerResponse<'T> =
    abstract timedOut: bool with get, set
    abstract result: 'T option with get, set
