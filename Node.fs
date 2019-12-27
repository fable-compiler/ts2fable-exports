// ts2fable 0.0.0
module rec Node
open System
open Fable.Core
open Fable.Core.JS

let [<Global>] Symbol: SymbolConstructor = jsNative

type [<AllowNullLiteral>] MapConstructor =
    interface end

type [<AllowNullLiteral>] WeakMapConstructor =
    interface end

type [<AllowNullLiteral>] SetConstructor =
    interface end

type [<AllowNullLiteral>] WeakSetConstructor =
    interface end

type [<AllowNullLiteral>] IteratorResult<'T> =
    interface end

type [<AllowNullLiteral>] Iterable<'T> =
    interface end

type [<AllowNullLiteral>] Iterator<'T> =
    abstract next: ?value: obj -> IteratorResult<'T>

type [<AllowNullLiteral>] IterableIterator<'T> =
    interface end

type [<AllowNullLiteral>] SymbolConstructor =
    abstract iterator: Symbol

module Util =
    let [<Import("inspect","util")>] inspect: Inspect.IExports = jsNative
    let [<Import("promisify","util")>] promisify: Promisify.IExports = jsNative

    module Inspect =

        type [<AllowNullLiteral>] IExports =
            abstract custom: Symbol

    module Promisify =

        type [<AllowNullLiteral>] IExports =
            abstract custom: Symbol
