// ts2fable 0.0.0
module rec Node
open System
open Fable.Core
open Fable.Core.JS

type Symbol = obj


module Util =
    let [<Import("inspect","util")>] inspect: Inspect.IExports = jsNative
    let [<Import("promisify","util")>] promisify: Promisify.IExports = jsNative

    module Inspect =

        type [<AllowNullLiteral>] IExports =
            abstract custom: Symbol

    module Promisify =

        type [<AllowNullLiteral>] IExports =
            abstract custom: Symbol
