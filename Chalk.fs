// ts2fable 0.0.0
module rec Chalk
open System
open Fable.Core
open Fable.Core.JS

type TemplateStringsArray = System.Collections.Generic.IReadOnlyList<string>

let [<Import("*","chalk")>] chalk: obj = jsNative

type [<AllowNullLiteral>] IExports =
    abstract ChalkConstructor: ChalkConstructorStatic

type [<RequireQualifiedAccess>] Level =
    | None = 0
    | Basic = 1
    | Ansi256 = 2
    | TrueColor = 3

type [<AllowNullLiteral>] ChalkOptions =
    abstract enabled: bool option with get, set
    abstract level: Level option with get, set

type [<AllowNullLiteral>] ChalkConstructor =
    [<Emit "$0($1...)">] abstract Invoke: ?options: ChalkOptions -> Chalk

type [<AllowNullLiteral>] ChalkConstructorStatic =
    [<EmitConstructor>] abstract Create: ?options: ChalkOptions -> ChalkConstructor

type [<AllowNullLiteral>] ColorSupport =
    abstract level: Level with get, set
    abstract hasBasic: bool with get, set
    abstract has256: bool with get, set
    abstract has16m: bool with get, set

type [<AllowNullLiteral>] Chalk =
    [<Emit "$0($1...)">] abstract Invoke: [<ParamArray>] text: string[] -> string
    [<Emit "$0($1...)">] abstract Invoke: text: TemplateStringsArray * [<ParamArray>] placeholders: string[] -> string
    abstract ``constructor``: ChalkConstructor with get, set
    abstract enabled: bool with get, set
    abstract level: Level with get, set
    abstract rgb: r: float * g: float * b: float -> Chalk
    abstract hsl: h: float * s: float * l: float -> Chalk
    abstract hsv: h: float * s: float * v: float -> Chalk
    abstract hwb: h: float * w: float * b: float -> Chalk
    abstract bgHex: color: string -> Chalk
    abstract bgKeyword: color: string -> Chalk
    abstract bgRgb: r: float * g: float * b: float -> Chalk
    abstract bgHsl: h: float * s: float * l: float -> Chalk
    abstract bgHsv: h: float * s: float * v: float -> Chalk
    abstract bgHwb: h: float * w: float * b: float -> Chalk
    abstract hex: color: string -> Chalk
    abstract keyword: color: string -> Chalk
    abstract reset: Chalk
    abstract bold: Chalk
    abstract dim: Chalk
    abstract italic: Chalk
    abstract underline: Chalk
    abstract inverse: Chalk
    abstract hidden: Chalk
    abstract strikethrough: Chalk
    abstract visible: Chalk
    abstract black: Chalk
    abstract red: Chalk
    abstract green: Chalk
    abstract yellow: Chalk
    abstract blue: Chalk
    abstract magenta: Chalk
    abstract cyan: Chalk
    abstract white: Chalk
    abstract gray: Chalk
    abstract grey: Chalk
    abstract blackBright: Chalk
    abstract redBright: Chalk
    abstract greenBright: Chalk
    abstract yellowBright: Chalk
    abstract blueBright: Chalk
    abstract magentaBright: Chalk
    abstract cyanBright: Chalk
    abstract whiteBright: Chalk
    abstract bgBlack: Chalk
    abstract bgRed: Chalk
    abstract bgGreen: Chalk
    abstract bgYellow: Chalk
    abstract bgBlue: Chalk
    abstract bgMagenta: Chalk
    abstract bgCyan: Chalk
    abstract bgWhite: Chalk
    abstract bgBlackBright: Chalk
    abstract bgRedBright: Chalk
    abstract bgGreenBright: Chalk
    abstract bgYellowBright: Chalk
    abstract bgBlueBright: Chalk
    abstract bgMagentaBright: Chalk
    abstract bgCyanBright: Chalk
    abstract bgWhiteBright: Chalk
