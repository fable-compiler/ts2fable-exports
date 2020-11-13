// ts2fable 0.0.0
module rec Mocha
open System
open Fable.Core
open Fable.Core.JS
open Browser.Types

type Error = System.Exception
type Function = System.Action
type RegExp = System.Text.RegularExpressions.Regex

let [<Import("*","mocha")>] mocha: Mocha = jsNative
let [<Import("describe","mocha")>] describe: Mocha.IContextDefinition = jsNative
let [<Import("xdescribe","mocha")>] xdescribe: Mocha.IContextDefinition = jsNative
let [<Import("context","mocha")>] context: Mocha.IContextDefinition = jsNative
let [<Import("suite","mocha")>] suite: Mocha.IContextDefinition = jsNative
let [<Import("it","mocha")>] it: Mocha.ITestDefinition = jsNative
let [<Import("xit","mocha")>] xit: Mocha.ITestDefinition = jsNative
let [<Import("test","mocha")>] test: Mocha.ITestDefinition = jsNative
let [<Import("specify","mocha")>] specify: Mocha.ITestDefinition = jsNative

type [<AllowNullLiteral>] IExports =
    abstract run: unit -> unit
    abstract setup: callback: (Mocha.IBeforeAndAfterContext -> MochaDone -> obj option) -> unit
    abstract teardown: callback: (Mocha.IBeforeAndAfterContext -> MochaDone -> obj option) -> unit
    abstract suiteSetup: callback: (Mocha.IHookCallbackContext -> MochaDone -> obj option) -> unit
    abstract suiteTeardown: callback: (Mocha.IHookCallbackContext -> MochaDone -> obj option) -> unit
    abstract before: callback: (Mocha.IHookCallbackContext -> MochaDone -> obj option) -> unit
    abstract before: description: string * callback: (Mocha.IHookCallbackContext -> MochaDone -> obj option) -> unit
    abstract after: callback: (Mocha.IHookCallbackContext -> MochaDone -> obj option) -> unit
    abstract after: description: string * callback: (Mocha.IHookCallbackContext -> MochaDone -> obj option) -> unit
    abstract beforeEach: callback: (Mocha.IBeforeAndAfterContext -> MochaDone -> obj option) -> unit
    abstract beforeEach: description: string * callback: (Mocha.IBeforeAndAfterContext -> MochaDone -> obj option) -> unit
    abstract afterEach: callback: (Mocha.IBeforeAndAfterContext -> MochaDone -> obj option) -> unit
    abstract afterEach: description: string * callback: (Mocha.IBeforeAndAfterContext -> MochaDone -> obj option) -> unit
    abstract ReporterConstructor: ReporterConstructorStatic
    abstract Mocha: MochaStatic

type [<AllowNullLiteral>] MochaSetupOptions =
    abstract slow: float option with get, set
    abstract timeout: float option with get, set
    abstract ui: string option with get, set
    abstract globals: ResizeArray<obj option> option with get, set
    abstract reporter: U2<string, ReporterConstructor> option with get, set
    abstract bail: bool option with get, set
    abstract ignoreLeaks: bool option with get, set
    abstract grep: obj option with get, set
    abstract require: ResizeArray<string> option with get, set

type [<AllowNullLiteral>] MochaDone =
    [<Emit "$0($1...)">] abstract Invoke: ?error: obj -> obj option

type [<AllowNullLiteral>] ReporterConstructor =
    interface end

type [<AllowNullLiteral>] ReporterConstructorStatic =
    [<EmitConstructor>] abstract Create: runner: Mocha.IRunner * options: obj option -> ReporterConstructor

type [<AllowNullLiteral>] Mocha =
    abstract currentTest: Mocha.ITestDefinition with get, set
    /// Setup mocha with the given options.
    abstract setup: options: MochaSetupOptions -> Mocha
    abstract bail: ?value: bool -> Mocha
    abstract addFile: file: string -> Mocha
    /// Sets reporter by name, defaults to "spec".
    abstract reporter: name: string * ?reporterOptions: obj -> Mocha
    /// Sets reporter constructor, defaults to mocha.reporters.Spec.
    abstract reporter: reporter: ReporterConstructor * ?reporterOptions: obj -> Mocha
    abstract ui: value: string -> Mocha
    abstract grep: value: string -> Mocha
    abstract grep: value: RegExp -> Mocha
    abstract invert: unit -> Mocha
    abstract ignoreLeaks: value: bool -> Mocha
    abstract checkLeaks: unit -> Mocha
    /// Function to allow assertion libraries to throw errors directly into mocha.
    /// This is useful when running tests in a browser because window.onerror will
    /// only receive the 'message' attribute of the Error.
    abstract throwError: error: Error -> unit
    /// Enables growl support.
    abstract growl: unit -> Mocha
    abstract globals: value: string -> Mocha
    abstract globals: values: ResizeArray<string> -> Mocha
    abstract useColors: value: bool -> Mocha
    abstract useInlineDiffs: value: bool -> Mocha
    abstract timeout: value: float -> Mocha
    abstract slow: value: float -> Mocha
    abstract enableTimeouts: value: bool -> Mocha
    abstract asyncOnly: value: bool -> Mocha
    abstract noHighlighting: value: bool -> Mocha
    /// Runs tests and invokes `onComplete()` when finished.
    abstract run: ?onComplete: (float -> unit) -> Mocha.IRunner

type [<AllowNullLiteral>] MochaStatic =
    [<EmitConstructor>] abstract Create: ?options: MochaStaticOptions -> Mocha

type [<AllowNullLiteral>] MochaStaticOptions =
    abstract grep: RegExp option with get, set
    abstract ui: string option with get, set
    abstract reporter: U2<string, ReporterConstructor> option with get, set
    abstract timeout: float option with get, set
    abstract reporterOptions: obj option with get, set
    abstract slow: float option with get, set
    abstract bail: bool option with get, set

module Mocha =
    let [<Import("reporters","mocha/Mocha")>] reporters: Reporters.IExports = jsNative

    type [<AllowNullLiteral>] ISuiteCallbackContext =
        abstract timeout: ms: U2<float, string> -> ISuiteCallbackContext
        abstract retries: n: float -> ISuiteCallbackContext
        abstract slow: ms: float -> ISuiteCallbackContext

    type [<AllowNullLiteral>] IHookCallbackContext =
        abstract skip: unit -> IHookCallbackContext
        abstract timeout: ms: U2<float, string> -> IHookCallbackContext
        [<EmitIndexer>] abstract Item: index: string -> obj option with get, set

    type [<AllowNullLiteral>] ITestCallbackContext =
        abstract skip: unit -> ITestCallbackContext
        abstract timeout: ms: U2<float, string> -> ITestCallbackContext
        abstract retries: n: float -> ITestCallbackContext
        abstract slow: ms: float -> ITestCallbackContext
        [<EmitIndexer>] abstract Item: index: string -> obj option with get, set

    /// Partial interface for Mocha's `Runnable` class.
    type [<AllowNullLiteral>] IRunnable =
        abstract title: string with get, set
        abstract fn: Function with get, set
        abstract async: bool with get, set
        abstract sync: bool with get, set
        abstract timedOut: bool with get, set
        abstract timeout: n: U2<float, string> -> IRunnable
        abstract duration: float option with get, set

    /// Partial interface for Mocha's `Suite` class.
    type [<AllowNullLiteral>] ISuite =
        abstract parent: ISuite with get, set
        abstract title: string with get, set
        abstract fullTitle: unit -> string

    /// Partial interface for Mocha's `Test` class.
    type [<AllowNullLiteral>] ITest =
        inherit IRunnable
        abstract parent: ISuite with get, set
        abstract pending: bool with get, set
        abstract state: ITestState with get, set
        abstract fullTitle: unit -> string

    type [<AllowNullLiteral>] IBeforeAndAfterContext =
        inherit IHookCallbackContext
        abstract currentTest: ITest with get, set

    type [<AllowNullLiteral>] IStats =
        abstract suites: float with get, set
        abstract tests: float with get, set
        abstract passes: float with get, set
        abstract pending: float with get, set
        abstract failures: float with get, set
        abstract start: DateTime option with get, set
        abstract ``end``: DateTime option with get, set
        abstract duration: DateTime option with get, set

    /// Partial interface for Mocha's `Runner` class.
    type [<AllowNullLiteral>] IRunner =
        abstract stats: IStats option with get, set
        abstract started: bool with get, set
        abstract suite: ISuite with get, set
        abstract total: float with get, set
        abstract failures: float with get, set
        abstract grep: (string -> bool -> IRunner) with get, set
        abstract grepTotal: (ISuite -> float) with get, set
        abstract globals: (ResizeArray<string> -> U2<IRunner, ResizeArray<string>>) with get, set
        abstract abort: (unit -> IRunner) with get, set
        abstract run: ((float -> unit) -> IRunner) with get, set

    type [<AllowNullLiteral>] IContextDefinition =
        [<Emit "$0($1...)">] abstract Invoke: description: string * callback: (ISuiteCallbackContext -> unit) -> ISuite
        abstract only: description: string * callback: (ISuiteCallbackContext -> unit) -> ISuite
        abstract skip: description: string * callback: (ISuiteCallbackContext -> unit) -> unit
        abstract timeout: ms: U2<float, string> -> unit

    type [<AllowNullLiteral>] ITestDefinition =
        [<Emit "$0($1...)">] abstract Invoke: expectation: string * ?callback: (ITestCallbackContext -> MochaDone -> obj option) -> ITest
        abstract only: expectation: string * ?callback: (ITestCallbackContext -> MochaDone -> obj option) -> ITest
        abstract skip: expectation: string * ?callback: (ITestCallbackContext -> MochaDone -> obj option) -> unit
        abstract timeout: ms: U2<float, string> -> unit
        abstract state: ITestState with get, set

    module Reporters =

        type [<AllowNullLiteral>] IExports =
            abstract Base: BaseStatic
            abstract Doc: DocStatic
            abstract Dot: DotStatic
            abstract HTML: HTMLStatic
            abstract HTMLCov: HTMLCovStatic
            abstract JSON: JSONStatic
            abstract JSONCov: JSONCovStatic
            abstract JSONStream: JSONStreamStatic
            abstract Landing: LandingStatic
            abstract List: ListStatic
            abstract Markdown: MarkdownStatic
            abstract Min: MinStatic
            abstract Nyan: NyanStatic
            abstract Progress: ProgressStatic
            abstract Spec: SpecStatic
            abstract TAP: TAPStatic
            abstract XUnit: XUnitStatic

        type [<AllowNullLiteral>] Base =
            abstract stats: IStats with get, set

        type [<AllowNullLiteral>] BaseStatic =
            [<EmitConstructor>] abstract Create: runner: IRunner -> Base

        type [<AllowNullLiteral>] Doc =
            inherit Base

        type [<AllowNullLiteral>] DocStatic =
            [<EmitConstructor>] abstract Create: unit -> Doc

        type [<AllowNullLiteral>] Dot =
            inherit Base

        type [<AllowNullLiteral>] DotStatic =
            [<EmitConstructor>] abstract Create: unit -> Dot

        type [<AllowNullLiteral>] HTML =
            inherit Base

        type [<AllowNullLiteral>] HTMLStatic =
            [<EmitConstructor>] abstract Create: unit -> HTML

        type [<AllowNullLiteral>] HTMLCov =
            inherit Base

        type [<AllowNullLiteral>] HTMLCovStatic =
            [<EmitConstructor>] abstract Create: unit -> HTMLCov

        type [<AllowNullLiteral>] JSON =
            inherit Base

        type [<AllowNullLiteral>] JSONStatic =
            [<EmitConstructor>] abstract Create: unit -> JSON

        type [<AllowNullLiteral>] JSONCov =
            inherit Base

        type [<AllowNullLiteral>] JSONCovStatic =
            [<EmitConstructor>] abstract Create: unit -> JSONCov

        type [<AllowNullLiteral>] JSONStream =
            inherit Base

        type [<AllowNullLiteral>] JSONStreamStatic =
            [<EmitConstructor>] abstract Create: unit -> JSONStream

        type [<AllowNullLiteral>] Landing =
            inherit Base

        type [<AllowNullLiteral>] LandingStatic =
            [<EmitConstructor>] abstract Create: unit -> Landing

        type [<AllowNullLiteral>] List =
            inherit Base

        type [<AllowNullLiteral>] ListStatic =
            [<EmitConstructor>] abstract Create: unit -> List

        type [<AllowNullLiteral>] Markdown =
            inherit Base

        type [<AllowNullLiteral>] MarkdownStatic =
            [<EmitConstructor>] abstract Create: unit -> Markdown

        type [<AllowNullLiteral>] Min =
            inherit Base

        type [<AllowNullLiteral>] MinStatic =
            [<EmitConstructor>] abstract Create: unit -> Min

        type [<AllowNullLiteral>] Nyan =
            inherit Base

        type [<AllowNullLiteral>] NyanStatic =
            [<EmitConstructor>] abstract Create: unit -> Nyan

        type [<AllowNullLiteral>] Progress =
            inherit Base

        type [<AllowNullLiteral>] ProgressStatic =
            [<EmitConstructor>] abstract Create: runner: IRunner * ?options: ProgressStaticOptions -> Progress

        type [<AllowNullLiteral>] ProgressStaticOptions =
            abstract ``open``: string option with get, set
            abstract complete: string option with get, set
            abstract incomplete: string option with get, set
            abstract close: string option with get, set

        type [<AllowNullLiteral>] Spec =
            inherit Base

        type [<AllowNullLiteral>] SpecStatic =
            [<EmitConstructor>] abstract Create: unit -> Spec

        type [<AllowNullLiteral>] TAP =
            inherit Base

        type [<AllowNullLiteral>] TAPStatic =
            [<EmitConstructor>] abstract Create: unit -> TAP

        type [<AllowNullLiteral>] XUnit =
            inherit Base

        type [<AllowNullLiteral>] XUnitStatic =
            [<EmitConstructor>] abstract Create: runner: IRunner * ?options: obj -> XUnit

    type [<StringEnum>] [<RequireQualifiedAccess>] ITestState =
        | Failed
        | Passed
