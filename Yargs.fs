// ts2fable 0.0.0
module rec Yargs

#nowarn "3390" // disable warnings for invalid XML comments
#nowarn "0044" // disable warnings for `Obsolete` usage

open System
open Fable.Core
open Fable.Core.JS

[<Erase>] type KeyOf<'T> = Key of string
type Array<'T> = System.Collections.Generic.IList<'T>
type Error = System.Exception
type ReadonlyArray<'T> = System.Collections.Generic.IReadOnlyList<'T>
type RegExp = System.Text.RegularExpressions.Regex

type DetailedArguments = Yargs_parser.DetailedArguments
type Configuration = Yargs_parser.Configuration
let [<Import("*","yargs")>] yargs: Yargs.Argv = jsNative

module Yargs =

    type BuilderCallback<'T, 'R> =
        U2<(Argv<'T> -> Argv<'R>), (Argv<'T> -> unit)>

    type [<AllowNullLiteral>] ParserConfigurationOptions =
        interface end

    /// <summary>
    /// The type parameter <c>T</c> is the expected shape of the parsed options.
    /// <c>Arguments&lt;T&gt;</c> is those options plus <c>_</c> and <c>$0</c>, and an indexer falling
    /// back to <c>unknown</c> for unknown options.
    /// 
    /// For the return type / <c>argv</c> property, we create a mapped type over
    /// <c>Arguments&lt;T&gt;</c> to simplify the inferred type signature in client code.
    /// </summary>
    type Argv =
        Argv<obj>

    /// <summary>
    /// The type parameter <c>T</c> is the expected shape of the parsed options.
    /// <c>Arguments&lt;T&gt;</c> is those options plus <c>_</c> and <c>$0</c>, and an indexer falling
    /// back to <c>unknown</c> for unknown options.
    /// 
    /// For the return type / <c>argv</c> property, we create a mapped type over
    /// <c>Arguments&lt;T&gt;</c> to simplify the inferred type signature in client code.
    /// </summary>
    type [<AllowNullLiteral>] Argv<'T> =
        [<Emit "$0($1...)">] abstract Invoke: unit -> obj
        [<Emit "$0($1...)">] abstract Invoke: args: ResizeArray<string> * ?cwd: string -> Argv<'T>
        /// <summary>
        /// Set key names as equivalent such that updates to a key will propagate to aliases and vice-versa.
        /// 
        /// Optionally <c>.alias()</c> can take an object that maps keys to aliases.
        /// Each key of this object should be the canonical version of the option, and each value should be a string or an array of strings.
        /// </summary>
        abstract alias: shortName: KeyOf<'T> * longName: U2<'K2, ResizeArray<'K2>> -> Argv<obj>
        abstract alias: shortName: 'K2 * longName: U2<KeyOf<'T>, ResizeArray<KeyOf<'T>>> -> Argv<obj>
        abstract alias: shortName: U2<string, ResizeArray<string>> * longName: U2<string, ResizeArray<string>> -> Argv<'T>
        abstract alias: aliases: ArgvAliasAliases -> Argv<'T>
        /// <summary>
        /// Get the arguments as a plain old object.
        /// 
        /// Arguments without a corresponding flag show up in the <c>argv._</c> array.
        /// 
        /// The script name or node command is available at <c>argv.$0</c> similarly to how <c>$0</c> works in bash or perl.
        /// 
        /// If <c>yargs</c> is executed in an environment that embeds node and there's no script name (e.g. Electron or nw.js),
        /// it will ignore the first parameter since it expects it to be the script name. In order to override
        /// this behavior, use <c>.parse(process.argv.slice(1))</c> instead of .argv and the first parameter won't be ignored.
        /// </summary>
        abstract argv: obj with get, set
        /// <summary>
        /// Tell the parser to interpret <c>key</c> as an array.
        /// If <c>.array('foo')</c> is set, <c>--foo foo bar</c> will be parsed as <c>['foo', 'bar']</c> rather than as <c>'foo'</c>.
        /// Also, if you use the option multiple times all the values will be flattened in one array so <c>--foo foo --foo bar</c> will be parsed as <c>['foo', 'bar']</c>
        /// 
        /// When the option is used with a positional, use <c>--</c> to tell <c>yargs</c> to stop adding values to the array.
        /// </summary>
        abstract array: key: U2<KeyOf<'T>, ResizeArray<KeyOf<'T>>> -> Argv<obj>
        abstract array: key: U2<'K, ResizeArray<'K>> -> Argv<obj>
        /// <summary>
        /// Interpret <c>key</c> as a boolean. If a non-flag option follows <c>key</c> in <c>process.argv</c>, that string won't get set as the value of <c>key</c>.
        /// 
        /// <c>key</c> will default to <c>false</c>, unless a <c>default(key, undefined)</c> is explicitly set.
        /// 
        /// If <c>key</c> is an array, interpret all the elements as booleans.
        /// </summary>
        abstract boolean: key: U2<KeyOf<'T>, ResizeArray<KeyOf<'T>>> -> Argv<obj>
        abstract boolean: key: U2<'K, ResizeArray<'K>> -> Argv<obj>
        /// <summary>Check that certain conditions are met in the provided arguments.</summary>
        /// <param name="func">
        /// Called with two arguments, the parsed <c>argv</c> hash and an array of options and their aliases.
        /// If <c>func</c> throws or returns a non-truthy value, show the thrown error, usage information, and exit.
        /// </param>
        /// <param name="global">Indicates whether <c>check()</c> should be enabled both at the top-level and for each sub-command.</param>
        abstract check: func: (Arguments<'T> -> ArgvCheck -> obj option) * ?``global``: bool -> Argv<'T>
        /// <summary>
        /// Limit valid values for key to a predefined set of choices, given as an array or as an individual value.
        /// If this method is called multiple times, all enumerated values will be merged together.
        /// Choices are generally strings or numbers, and value matching is case-sensitive.
        /// 
        /// Optionally <c>.choices()</c> can take an object that maps multiple keys to their choices.
        /// 
        /// Choices can also be specified as choices in the object given to <c>option()</c>.
        /// </summary>
        abstract choices: key: KeyOf<'T> * values: 'C -> Argv<obj>
        abstract choices: key: 'K * values: 'C -> Argv<obj>
        abstract choices: choices: 'C -> Argv<obj>
        /// <summary>
        /// Provide a synchronous function to coerce or transform the value(s) given on the command line for <c>key</c>.
        /// 
        /// The coercion function should accept one argument, representing the parsed value from the command line, and should return a new value or throw an error.
        /// The returned value will be used as the value for <c>key</c> (or one of its aliases) in <c>argv</c>.
        /// 
        /// If the function throws, the error will be treated as a validation failure, delegating to either a custom <c>.fail()</c> handler or printing the error message in the console.
        /// 
        /// Coercion will be applied to a value after all other modifications, such as <c>.normalize()</c>.
        /// 
        /// Optionally <c>.coerce()</c> can take an object that maps several keys to their respective coercion function.
        /// 
        /// You can also map the same function to several keys at one time. Just pass an array of keys as the first argument to <c>.coerce()</c>.
        /// 
        /// If you are using dot-notion or arrays, .e.g., <c>user.email</c> and <c>user.password</c>, coercion will be applied to the final object that has been parsed
        /// </summary>
        abstract coerce: key: U2<KeyOf<'T>, ResizeArray<KeyOf<'T>>> * func: (obj option -> 'V) -> Argv<obj>
        abstract coerce: key: U2<'K, ResizeArray<'K>> * func: (obj option -> 'V) -> Argv<obj>
        abstract coerce: opts: 'O -> Argv<obj>
        /// <summary>Define the commands exposed by your application.</summary>
        /// <param name="command">Should be a string representing the command or an array of strings representing the command and its aliases.</param>
        /// <param name="description">
        /// Use to provide a description for each command your application accepts (the values stored in <c>argv._</c>).
        /// Set <c>description</c> to false to create a hidden command. Hidden commands don't show up in the help output and aren't available for completion.
        /// </param>
        /// <param name="builder">
        /// Object to give hints about the options that your command accepts.
        /// Can also be a function. This function is executed with a yargs instance, and can be used to provide advanced command specific help.
        /// 
        /// Note that when <c>void</c> is returned, the handler <c>argv</c> object type will not include command-specific arguments.
        /// </param>
        /// <param name="handler">Function, which will be executed with the parsed <c>argv</c> object.</param>
        abstract command: command: U2<string, ResizeArray<string>> * description: string * ?builder: BuilderCallback<'T, 'U> * ?handler: (Arguments<'U> -> unit) -> Argv<'T>
        abstract command: command: U2<string, ResizeArray<string>> * description: string * ?builder: 'O * ?handler: (Arguments<InferredOptionTypes<'O>> -> unit) -> Argv<'T>
        abstract command: command: U2<string, ResizeArray<string>> * description: string * ``module``: CommandModule<'T, 'U> -> Argv<'U>
        abstract command: command: U2<string, ResizeArray<string>> * showInHelp: obj * ?builder: BuilderCallback<'T, 'U> * ?handler: (Arguments<'U> -> unit) -> Argv<'T>
        abstract command: command: U2<string, ResizeArray<string>> * showInHelp: obj * ?builder: 'O * ?handler: (Arguments<InferredOptionTypes<'O>> -> unit) -> Argv<'T>
        abstract command: command: U2<string, ResizeArray<string>> * showInHelp: obj * ``module``: CommandModule<'T, 'U> -> Argv<'U>
        abstract command: ``module``: CommandModule<'T, 'U> -> Argv<'U>
        /// Apply command modules from a directory relative to the module calling this method.
        abstract commandDir: dir: string * ?opts: RequireDirectoryOptions -> Argv<'T>
        /// <summary>
        /// Enable bash/zsh-completion shortcuts for commands and options.
        /// 
        /// If invoked without parameters, <c>.completion()</c> will make completion the command to output the completion script.
        /// </summary>
        /// <param name="cmd">
        /// When present in <c>argv._</c>, will result in the <c>.bashrc</c> or <c>.zshrc</c> completion script being outputted.
        /// To enable bash/zsh completions, concat the generated script to your <c>.bashrc</c> or <c>.bash_profile</c> (or <c>.zshrc</c> for zsh).
        /// </param>
        /// <param name="description">Provide a description in your usage instructions for the command that generates the completion scripts.</param>
        /// <param name="func">Rather than relying on yargs' default completion functionality, which shiver me timbers is pretty awesome, you can provide your own completion method.</param>
        abstract completion: unit -> Argv<'T>
        abstract completion: cmd: string * ?func: AsyncCompletionFunction -> Argv<'T>
        abstract completion: cmd: string * ?func: SyncCompletionFunction -> Argv<'T>
        abstract completion: cmd: string * ?func: PromiseCompletionFunction -> Argv<'T>
        abstract completion: cmd: string * ?description: string * ?func: AsyncCompletionFunction -> Argv<'T>
        abstract completion: cmd: string * ?description: string * ?func: SyncCompletionFunction -> Argv<'T>
        abstract completion: cmd: string * ?description: string * ?func: PromiseCompletionFunction -> Argv<'T>
        /// <summary>
        /// Tells the parser that if the option specified by <c>key</c> is passed in, it should be interpreted as a path to a JSON config file.
        /// The file is loaded and parsed, and its properties are set as arguments.
        /// Because the file is loaded using Node's require(), the filename MUST end in <c>.json</c> to be interpreted correctly.
        /// 
        /// If invoked without parameters, <c>.config()</c> will make --config the option to pass the JSON config file.
        /// </summary>
        /// <param name="description">Provided to customize the config (<c>key</c>) option in the usage string.</param>
        /// <param name="explicitConfigurationObject">An explicit configuration <c>object</c></param>
        abstract config: unit -> Argv<'T>
        abstract config: key: U2<string, ResizeArray<string>> * ?description: string * ?parseFn: (string -> obj) -> Argv<'T>
        abstract config: key: U2<string, ResizeArray<string>> * parseFn: (string -> obj) -> Argv<'T>
        abstract config: explicitConfigurationObject: obj -> Argv<'T>
        /// <summary>
        /// Given the key <c>x</c> is set, the key <c>y</c> must not be set. <c>y</c> can either be a single string or an array of argument names that <c>x</c> conflicts with.
        /// 
        /// Optionally <c>.conflicts()</c> can accept an object specifying multiple conflicting keys.
        /// </summary>
        abstract conflicts: key: string * value: U2<string, ResizeArray<string>> -> Argv<'T>
        abstract conflicts: conflicts: ArgvConflicts -> Argv<'T>
        /// <summary>Interpret <c>key</c> as a boolean flag, but set its parsed value to the number of flag occurrences rather than <c>true</c> or <c>false</c>. Default value is thus <c>0</c>.</summary>
        abstract count: key: U2<KeyOf<'T>, ResizeArray<KeyOf<'T>>> -> Argv<obj>
        abstract count: key: U2<'K, ResizeArray<'K>> -> Argv<obj>
        /// <summary>
        /// Set <c>argv[key]</c> to <c>value</c> if no option was specified in <c>process.argv</c>.
        /// 
        /// Optionally <c>.default()</c> can take an object that maps keys to default values.
        /// 
        /// The default value can be a <c>function</c> which returns a value. The name of the function will be used in the usage string.
        /// 
        /// Optionally, <c>description</c> can also be provided and will take precedence over displaying the value in the usage instructions.
        /// </summary>
        abstract ``default``: key: KeyOf<'T> * value: 'V * ?description: string -> Argv<obj>
        abstract ``default``: key: 'K * value: 'V * ?description: string -> Argv<obj>
        abstract ``default``: defaults: 'D * ?description: string -> Argv<obj>
        [<Obsolete("since version 6.6.0
Use '.demandCommand()' or '.demandOption()' instead")>]
        abstract demand: key: U2<KeyOf<'T>, ResizeArray<KeyOf<'T>>> * ?msg: string -> Argv<Defined<'T, KeyOf<'T>>>
        abstract demand: key: U2<'K, ResizeArray<'K>> * ?msg: string -> Argv<obj>
        abstract demand: key: U2<string, ResizeArray<string>> * ?required: bool -> Argv<'T>
        abstract demand: positionals: float * msg: string -> Argv<'T>
        abstract demand: positionals: float * ?required: bool -> Argv<'T>
        abstract demand: positionals: float * max: float * ?msg: string -> Argv<'T>
        /// <param name="key">
        /// If is a string, show the usage information and exit if key wasn't specified in <c>process.argv</c>.
        /// If is an array, demand each element.
        /// </param>
        /// <param name="msg">If string is given, it will be printed when the argument is missing, instead of the standard error message.</param>
        /// <param name="demand">Controls whether the option is demanded; this is useful when using .options() to specify command line parameters.</param>
        abstract demandOption: key: U2<KeyOf<'T>, ResizeArray<KeyOf<'T>>> * ?msg: string -> Argv<Defined<'T, KeyOf<'T>>>
        abstract demandOption: key: U2<'K, ResizeArray<'K>> * ?msg: string -> Argv<obj>
        abstract demandOption: key: U2<string, ResizeArray<string>> * ?demand: bool -> Argv<'T>
        /// Demand in context of commands.
        /// You can demand a minimum and a maximum number a user can have within your program, as well as provide corresponding error messages if either of the demands is not met.
        abstract demandCommand: unit -> Argv<'T>
        abstract demandCommand: min: float * ?minMsg: string -> Argv<'T>
        abstract demandCommand: min: float * ?max: float * ?minMsg: string * ?maxMsg: string -> Argv<'T>
        /// <summary>
        /// Describe a <c>key</c> for the generated usage information.
        /// 
        /// Optionally <c>.describe()</c> can take an object that maps keys to descriptions.
        /// </summary>
        abstract describe: key: U2<string, ResizeArray<string>> * description: string -> Argv<'T>
        abstract describe: descriptions: ArgvDescribeDescriptions -> Argv<'T>
        /// <summary>Should yargs attempt to detect the os' locale? Defaults to <c>true</c>.</summary>
        abstract detectLocale: detect: bool -> Argv<'T>
        /// <summary>
        /// Tell yargs to parse environment variables matching the given prefix and apply them to argv as though they were command line arguments.
        /// 
        /// Use the "__" separator in the environment variable to indicate nested options. (e.g. prefix_nested__foo =&gt; nested.foo)
        /// 
        /// If this method is called with no argument or with an empty string or with true, then all env vars will be applied to argv.
        /// 
        /// Program arguments are defined in this order of precedence:
        /// 1. Command line args
        /// 2. Env vars
        /// 3. Config file/objects
        /// 4. Configured defaults
        /// 
        /// Env var parsing is disabled by default, but you can also explicitly disable it by calling <c>.env(false)</c>, e.g. if you need to undo previous configuration.
        /// </summary>
        abstract env: unit -> Argv<'T>
        abstract env: prefix: string -> Argv<'T>
        abstract env: enable: bool -> Argv<'T>
        /// A message to print at the end of the usage instructions
        abstract epilog: msg: string -> Argv<'T>
        /// A message to print at the end of the usage instructions
        abstract epilogue: msg: string -> Argv<'T>
        /// <summary>
        /// Give some example invocations of your program.
        /// Inside <c>cmd</c>, the string <c>$0</c> will get interpolated to the current script name or node command for the present script similar to how <c>$0</c> works in bash or perl.
        /// Examples will be printed out as part of the help message.
        /// </summary>
        abstract example: command: string * description: string -> Argv<'T>
        /// <summary>Manually indicate that the program should exit, and provide context about why we wanted to exit. Follows the behavior set by <c>.exitProcess().</c></summary>
        abstract exit: code: float * err: Error -> unit
        /// <summary>
        /// By default, yargs exits the process when the user passes a help flag, the user uses the <c>.version</c> functionality, validation fails, or the command handler fails.
        /// Calling <c>.exitProcess(false)</c> disables this behavior, enabling further actions after yargs have been validated.
        /// </summary>
        abstract exitProcess: enabled: bool -> Argv<'T>
        /// <summary>Method to execute when a failure occurs, rather than printing the failure message.</summary>
        /// <param name="func">Is called with the failure message that would have been printed, the Error instance originally thrown and yargs state when the failure occurred.</param>
        abstract fail: func: (string -> Error -> Argv<'T> -> obj option) -> Argv<'T>
        /// <summary>Allows to programmatically get completion choices for any line.</summary>
        /// <param name="args">An array of the words in the command line to complete.</param>
        /// <param name="done">The callback to be called with the resulting completions.</param>
        abstract getCompletion: args: ResizeArray<string> * ``done``: (ResizeArray<string> -> unit) -> Argv<'T>
        /// Indicate that an option (or group of options) should not be reset when a command is executed
        /// 
        /// Options default to being global.
        abstract ``global``: key: U2<string, ResizeArray<string>> -> Argv<'T>
        /// Given a key, or an array of keys, places options under an alternative heading when displaying usage instructions
        abstract group: key: U2<string, ResizeArray<string>> * groupName: string -> Argv<'T>
        /// <summary>Hides a key from the generated usage information. Unless a <c>--show-hidden</c> option is also passed with <c>--help</c> (see <c>showHidden()</c>).</summary>
        abstract hide: key: string -> Argv<'T>
        /// <summary>
        /// Configure an (e.g. <c>--help</c>) and implicit command that displays the usage string and exits the process.
        /// By default yargs enables help on the <c>--help</c> option.
        /// 
        /// Note that any multi-char aliases (e.g. <c>help</c>) used for the help option will also be used for the implicit command.
        /// If there are no multi-char aliases (e.g. <c>h</c>), then all single-char aliases will be used for the command.
        /// 
        /// If invoked without parameters, <c>.help()</c> will use <c>--help</c> as the option and help as the implicit command to trigger help output.
        /// </summary>
        /// <param name="description">Customizes the description of the help option in the usage string.</param>
        /// <param name="enableExplicit">If <c>false</c> is provided, it will disable --help.</param>
        abstract help: unit -> Argv<'T>
        abstract help: enableExplicit: bool -> Argv<'T>
        abstract help: option: string * enableExplicit: bool -> Argv<'T>
        abstract help: option: string * ?description: string * ?enableExplicit: bool -> Argv<'T>
        /// <summary>
        /// Given the key <c>x</c> is set, it is required that the key <c>y</c> is set.
        /// y<c> can either be the name of an argument to imply, a number indicating the position of an argument or an array of multiple implications to associate with </c>x`.
        /// 
        /// Optionally <c>.implies()</c> can accept an object specifying multiple implications.
        /// </summary>
        abstract implies: key: string * value: U2<string, ResizeArray<string>> -> Argv<'T>
        abstract implies: implies: ArgvImplies -> Argv<'T>
        /// Return the locale that yargs is currently using.
        /// 
        /// By default, yargs will auto-detect the operating system's locale so that yargs-generated help content will display in the user's language.
        abstract locale: unit -> string
        /// <summary>
        /// Override the auto-detected locale from the user's operating system with a static locale.
        /// Note that the OS locale can be modified by setting/exporting the <c>LC_ALL</c> environment variable.
        /// </summary>
        abstract locale: loc: string -> Argv<'T>
        /// <summary>Define global middleware functions to be called first, in list order, for all cli command.</summary>
        /// <param name="callbacks">Can be a function or a list of functions. Each callback gets passed a reference to argv.</param>
        /// <param name="applyBeforeValidation">Set to <c>true</c> to apply middleware before validation. This will execute the middleware prior to validation checks, but after parsing.</param>
        abstract middleware: callbacks: U2<MiddlewareFunction<'T>, ResizeArray<MiddlewareFunction<'T>>> * ?applyBeforeValidation: bool -> Argv<'T>
        /// <summary>
        /// The number of arguments that should be consumed after a key. This can be a useful hint to prevent parsing ambiguity.
        /// 
        /// Optionally <c>.nargs()</c> can take an object of <c>key</c>/<c>narg</c> pairs.
        /// </summary>
        abstract nargs: key: string * count: float -> Argv<'T>
        abstract nargs: nargs: ArgvNargs -> Argv<'T>
        /// <summary>The key provided represents a path and should have <c>path.normalize()</c> applied.</summary>
        abstract normalize: key: U2<KeyOf<'T>, ResizeArray<KeyOf<'T>>> -> Argv<obj>
        abstract normalize: key: U2<'K, ResizeArray<'K>> -> Argv<obj>
        /// <summary>
        /// Tell the parser to always interpret key as a number.
        /// 
        /// If <c>key</c> is an array, all elements will be parsed as numbers.
        /// 
        /// If the option is given on the command line without a value, <c>argv</c> will be populated with <c>undefined</c>.
        /// 
        /// If the value given on the command line cannot be parsed as a number, <c>argv</c> will be populated with <c>NaN</c>.
        /// 
        /// Note that decimals, hexadecimals, and scientific notation are all accepted.
        /// </summary>
        abstract number: key: U2<KeyOf<'T>, ResizeArray<KeyOf<'T>>> -> Argv<obj>
        abstract number: key: U2<'K, ResizeArray<'K>> -> Argv<obj>
        /// <summary>
        /// This method can be used to make yargs aware of options that could exist.
        /// You can also pass an opt object which can hold further customization, like <c>.alias()</c>, <c>.demandOption()</c> etc. for that option.
        /// </summary>
        abstract option: key: KeyOf<'T> * options: 'O -> Argv<obj> when 'O :> Options
        abstract option: key: 'K * options: 'O -> Argv<obj> when 'O :> Options
        abstract option: options: 'O -> Argv<obj>
        /// <summary>
        /// This method can be used to make yargs aware of options that could exist.
        /// You can also pass an opt object which can hold further customization, like <c>.alias()</c>, <c>.demandOption()</c> etc. for that option.
        /// </summary>
        abstract options: key: KeyOf<'T> * options: 'O -> Argv<obj> when 'O :> Options
        abstract options: key: 'K * options: 'O -> Argv<obj> when 'O :> Options
        abstract options: options: 'O -> Argv<obj>
        /// <summary>
        /// Parse <c>args</c> instead of <c>process.argv</c>. Returns the <c>argv</c> object. <c>args</c> may either be a pre-processed argv array, or a raw argument string.
        /// 
        /// Note: Providing a callback to parse() disables the <c>exitProcess</c> setting until after the callback is invoked.
        /// </summary>
        /// <param name="context">Provides a useful mechanism for passing state information to commands</param>
        abstract parse: ?arg: U2<string, ResizeArray<string>> -> obj
        abstract parse: arg: U2<string, ResizeArray<string>> * parseCallback: ParseCallback<'T> -> obj
        abstract parse: arg: U2<string, ResizeArray<string>> * context: obj * ?parseCallback: ParseCallback<'T> -> obj
        /// <summary>
        /// If the arguments have not been parsed, this property is <c>false</c>.
        /// 
        /// If the arguments have been parsed, this contain detailed parsed arguments.
        /// </summary>
        abstract parsed: DetailedArguments with get, set
        /// Allows to configure advanced yargs features.
        abstract parserConfiguration: configuration: obj -> Argv<'T>
        /// <summary>Similar to <c>config()</c>, indicates that yargs should interpret the object from the specified key in package.json as a configuration object.</summary>
        /// <param name="cwd">If provided, the package.json will be read from this location</param>
        abstract pkgConf: key: U2<string, ResizeArray<string>> * ?cwd: string -> Argv<'T>
        /// <summary>
        /// Allows you to configure a command's positional arguments with an API similar to <c>.option()</c>.
        /// <c>.positional()</c> should be called in a command's builder function, and is not available on the top-level yargs instance. If so, it will throw an error.
        /// </summary>
        abstract positional: key: KeyOf<'T> * opt: 'O -> Argv<obj> when 'O :> PositionalOptions
        abstract positional: key: 'K * opt: 'O -> Argv<obj> when 'O :> PositionalOptions
        /// Should yargs provide suggestions regarding similar commands if no matching command is found?
        abstract recommendCommands: unit -> Argv<'T>
        [<Obsolete("since version 6.6.0
Use '.demandCommand()' or '.demandOption()' instead")>]
        abstract require: key: U2<KeyOf<'T>, ResizeArray<KeyOf<'T>>> * ?msg: string -> Argv<Defined<'T, KeyOf<'T>>>
        abstract require: key: string * msg: string -> Argv<'T>
        abstract require: key: string * required: bool -> Argv<'T>
        abstract require: keys: ResizeArray<float> * msg: string -> Argv<'T>
        abstract require: keys: ResizeArray<float> * required: bool -> Argv<'T>
        abstract require: positionals: float * required: bool -> Argv<'T>
        abstract require: positionals: float * msg: string -> Argv<'T>
        [<Obsolete("since version 6.6.0
Use '.demandCommand()' or '.demandOption()' instead")>]
        abstract required: key: U2<KeyOf<'T>, ResizeArray<KeyOf<'T>>> * ?msg: string -> Argv<Defined<'T, KeyOf<'T>>>
        abstract required: key: string * msg: string -> Argv<'T>
        abstract required: key: string * required: bool -> Argv<'T>
        abstract required: keys: ResizeArray<float> * msg: string -> Argv<'T>
        abstract required: keys: ResizeArray<float> * required: bool -> Argv<'T>
        abstract required: positionals: float * required: bool -> Argv<'T>
        abstract required: positionals: float * msg: string -> Argv<'T>
        abstract requiresArg: key: U2<string, ResizeArray<string>> -> Argv<'T>
        [<Obsolete("since version 6.6.0
Use '.global()' instead")>]
        abstract reset: unit -> Argv<'T>
        /// <summary>Set the name of your script ($0). Default is the base filename executed by node (<c>process.argv[1]</c>)</summary>
        abstract scriptName: ``$0``: string -> Argv<'T>
        /// <summary>
        /// Generate a bash completion script.
        /// Users of your application can install this script in their <c>.bashrc</c>, and yargs will provide completion shortcuts for commands and options.
        /// </summary>
        abstract showCompletionScript: unit -> Argv<'T>
        /// <summary>Configure the <c>--show-hidden</c> option that displays the hidden keys (see <c>hide()</c>).</summary>
        /// <param name="option">
        /// If <c>boolean</c>, it enables/disables this option altogether. i.e. hidden keys will be permanently hidden if first argument is <c>false</c>.
        /// If <c>string</c> it changes the key name ("--show-hidden").
        /// </param>
        /// <param name="description">Changes the default description ("Show hidden options")</param>
        abstract showHidden: ?option: U2<string, bool> -> Argv<'T>
        abstract showHidden: option: string * ?description: string -> Argv<'T>
        /// <summary>Print the usage data using the console function consoleLevel for printing.</summary>
        /// <param name="consoleLevel" />
        abstract showHelp: ?consoleLevel: string -> Argv<'T>
        /// <summary>
        /// By default, yargs outputs a usage string if any error is detected.
        /// Use the <c>.showHelpOnFail()</c> method to customize this behavior.
        /// </summary>
        /// <param name="enable">If <c>false</c>, the usage string is not output.</param>
        /// <param name="message">Message that is output after the error message.</param>
        abstract showHelpOnFail: enable: bool * ?message: string -> Argv<'T>
        /// Specifies either a single option key (string), or an array of options. If any of the options is present, yargs validation is skipped.
        abstract skipValidation: key: U2<string, ResizeArray<string>> -> Argv<'T>
        /// Any command-line argument given that is not demanded, or does not have a corresponding description, will be reported as an error.
        /// 
        /// Unrecognized commands will also be reported as errors.
        abstract strict: unit -> Argv<'T>
        abstract strict: enabled: bool -> Argv<'T>
        /// <summary>
        /// Tell the parser logic not to interpret <c>key</c> as a number or boolean. This can be useful if you need to preserve leading zeros in an input.
        /// 
        /// If <c>key</c> is an array, interpret all the elements as strings.
        /// 
        /// <c>.string('_')</c> will result in non-hyphenated arguments being interpreted as strings, regardless of whether they resemble numbers.
        /// </summary>
        abstract string: key: U2<KeyOf<'T>, ResizeArray<KeyOf<'T>>> -> Argv<obj>
        abstract string: key: U2<'K, ResizeArray<'K>> -> Argv<obj>
        abstract terminalWidth: unit -> float
        abstract updateLocale: obj: ArgvUpdateLocaleObj -> Argv<'T>
        /// <summary>
        /// Override the default strings used by yargs with the key/value pairs provided in obj
        /// 
        /// If you explicitly specify a locale(), you should do so before calling <c>updateStrings()</c>.
        /// </summary>
        abstract updateStrings: obj: ArgvUpdateStringsObj -> Argv<'T>
        /// <summary>
        /// Set a usage message to show which commands to use.
        /// Inside <c>message</c>, the string <c>$0</c> will get interpolated to the current script name or node command for the present script similar to how <c>$0</c> works in bash or perl.
        /// 
        /// If the optional <c>description</c>/<c>builder</c>/<c>handler</c> are provided, <c>.usage()</c> acts an an alias for <c>.command()</c>.
        /// This allows you to use <c>.usage()</c> to configure the default command that will be run as an entry-point to your application
        /// and allows you to provide configuration for the positional arguments accepted by your program:
        /// </summary>
        abstract usage: message: string -> Argv<'T>
        abstract usage: command: U2<string, ResizeArray<string>> * description: string * ?builder: (Argv<'T> -> Argv<'U>) * ?handler: (Arguments<'U> -> unit) -> Argv<'T>
        abstract usage: command: U2<string, ResizeArray<string>> * showInHelp: bool * ?builder: (Argv<'T> -> Argv<'U>) * ?handler: (Arguments<'U> -> unit) -> Argv<'T>
        abstract usage: command: U2<string, ResizeArray<string>> * description: string * ?builder: 'O * ?handler: (Arguments<InferredOptionTypes<'O>> -> unit) -> Argv<'T>
        abstract usage: command: U2<string, ResizeArray<string>> * showInHelp: bool * ?builder: 'O * ?handler: (Arguments<InferredOptionTypes<'O>> -> unit) -> Argv<'T>
        /// <summary>
        /// Add an option (e.g. <c>--version</c>) that displays the version number (given by the version parameter) and exits the process.
        /// By default yargs enables version for the <c>--version</c> option.
        /// 
        /// If no arguments are passed to version (<c>.version()</c>), yargs will parse the package.json of your module and use its version value.
        /// 
        /// If the boolean argument <c>false</c> is provided, it will disable <c>--version</c>.
        /// </summary>
        abstract version: unit -> Argv<'T>
        abstract version: version: string -> Argv<'T>
        abstract version: enable: bool -> Argv<'T>
        abstract version: optionKey: string * version: string -> Argv<'T>
        abstract version: optionKey: string * description: string * version: string -> Argv<'T>
        /// <summary>
        /// Format usage output to wrap at columns many columns.
        /// 
        /// By default wrap will be set to <c>Math.min(80, windowWidth)</c>. Use <c>.wrap(null)</c> to specify no column limit (no right-align).
        /// Use <c>.wrap(yargs.terminalWidth())</c> to maximize the width of yargs' usage instructions.
        /// </summary>
        abstract wrap: columns: float option -> Argv<'T>

    type [<AllowNullLiteral>] ArgvAliasAliases =
        [<EmitIndexer>] abstract Item: shortName: string -> U2<string, ResizeArray<string>> with get, set

    type [<AllowNullLiteral>] ArgvConflicts =
        [<EmitIndexer>] abstract Item: key: string -> U2<string, ResizeArray<string>> with get, set

    type [<AllowNullLiteral>] ArgvDescribeDescriptions =
        [<EmitIndexer>] abstract Item: key: string -> string with get, set

    type [<AllowNullLiteral>] ArgvImplies =
        [<EmitIndexer>] abstract Item: key: string -> U2<string, ResizeArray<string>> with get, set

    type [<AllowNullLiteral>] ArgvNargs =
        [<EmitIndexer>] abstract Item: key: string -> float with get, set

    type [<AllowNullLiteral>] ArgvUpdateLocaleObj =
        [<EmitIndexer>] abstract Item: key: string -> string with get, set

    type [<AllowNullLiteral>] ArgvUpdateStringsObj =
        [<EmitIndexer>] abstract Item: key: string -> string with get, set

    type Arguments =
        Arguments<obj>

    type [<AllowNullLiteral>] Arguments<'T> =
        interface end

    type [<AllowNullLiteral>] RequireDirectoryOptions =
        /// Look for command modules in all subdirectories and apply them as a flattened (non-hierarchical) list.
        abstract recurse: bool option with get, set
        /// The types of files to look for when requiring command modules.
        abstract extensions: ReadonlyArray<string> option with get, set
        /// <summary>
        /// A synchronous function called for each command module encountered.
        /// Accepts <c>commandObject</c>, <c>pathToFile</c>, and <c>filename</c> as arguments.
        /// Returns <c>commandObject</c> to include the command; any falsy value to exclude/skip it.
        /// </summary>
        abstract visit: (obj option -> (string) option -> (string) option -> obj option) option with get, set
        /// Whitelist certain modules
        abstract ``include``: U2<RegExp, (string -> bool)> option with get, set
        /// Blacklist certain modules.
        abstract exclude: U2<RegExp, (string -> bool)> option with get, set

    type [<AllowNullLiteral>] Options =
        /// <summary>string or array of strings, alias(es) for the canonical option key, see <c>alias()</c></summary>
        abstract alias: U2<string, ReadonlyArray<string>> option with get, set
        /// <summary>boolean, interpret option as an array, see <c>array()</c></summary>
        abstract array: bool option with get, set
        /// <summary>boolean, interpret option as a boolean flag, see <c>boolean()</c></summary>
        abstract boolean: bool option with get, set
        /// <summary>value or array of values, limit valid option arguments to a predefined set, see <c>choices()</c></summary>
        abstract choices: Choices option with get, set
        /// <summary>function, coerce or transform parsed command line values into another value, see <c>coerce()</c></summary>
        abstract coerce: (obj option -> obj option) option with get, set
        /// <summary>boolean, interpret option as a path to a JSON config file, see <c>config()</c></summary>
        abstract config: bool option with get, set
        /// <summary>function, provide a custom config parsing function, see <c>config()</c></summary>
        abstract configParser: (string -> obj) option with get, set
        /// <summary>string or object, require certain keys not to be set, see <c>conflicts()</c></summary>
        abstract conflicts: U3<string, ReadonlyArray<string>, OptionsConflicts> option with get, set
        /// <summary>boolean, interpret option as a count of boolean flags, see <c>count()</c></summary>
        abstract count: bool option with get, set
        /// <summary>value, set a default value for the option, see <c>default()</c></summary>
        abstract ``default``: obj option with get, set
        /// <summary>string, use this description for the default value in help content, see <c>default()</c></summary>
        abstract defaultDescription: string option with get, set
        [<Obsolete("since version 6.6.0
Use 'demandOption' instead")>]
        abstract demand: U2<bool, string> option with get, set
        /// <summary>boolean or string, demand the option be given, with optional error message, see <c>demandOption()</c></summary>
        abstract demandOption: U2<bool, string> option with get, set
        /// <summary>string, the option description for help content, see <c>describe()</c></summary>
        abstract desc: string option with get, set
        /// <summary>string, the option description for help content, see <c>describe()</c></summary>
        abstract describe: string option with get, set
        /// <summary>string, the option description for help content, see <c>describe()</c></summary>
        abstract description: string option with get, set
        /// <summary>boolean, indicate that this key should not be reset when a command is invoked, see <c>global()</c></summary>
        abstract ``global``: bool option with get, set
        /// <summary>string, when displaying usage instructions place the option under an alternative group heading, see <c>group()</c></summary>
        abstract group: string option with get, set
        /// don't display option in help output.
        abstract hidden: bool option with get, set
        /// <summary>string or object, require certain keys to be set, see <c>implies()</c></summary>
        abstract implies: U3<string, ReadonlyArray<string>, OptionsConflicts> option with get, set
        /// <summary>number, specify how many arguments should be consumed for the option, see <c>nargs()</c></summary>
        abstract nargs: float option with get, set
        /// <summary>boolean, apply path.normalize() to the option, see <c>normalize()</c></summary>
        abstract normalize: bool option with get, set
        /// <summary>boolean, interpret option as a number, <c>number()</c></summary>
        abstract number: bool option with get, set
        [<Obsolete("since version 6.6.0
Use 'demandOption' instead")>]
        abstract require: U2<bool, string> option with get, set
        [<Obsolete("since version 6.6.0
Use 'demandOption' instead")>]
        abstract required: U2<bool, string> option with get, set
        /// <summary>boolean, require the option be specified with a value, see <c>requiresArg()</c></summary>
        abstract requiresArg: bool option with get, set
        /// <summary>boolean, skips validation if the option is present, see <c>skipValidation()</c></summary>
        abstract skipValidation: bool option with get, set
        /// <summary>boolean, interpret option as a string, see <c>string()</c></summary>
        abstract string: bool option with get, set
        abstract ``type``: U2<PositionalOptionsType, string> option with get, set

    type [<AllowNullLiteral>] PositionalOptions =
        /// <summary>string or array of strings, see <c>alias()</c></summary>
        abstract alias: U2<string, ReadonlyArray<string>> option with get, set
        /// <summary>boolean, interpret option as an array, see <c>array()</c></summary>
        abstract array: bool option with get, set
        /// <summary>value or array of values, limit valid option arguments to a predefined set, see <c>choices()</c></summary>
        abstract choices: Choices option with get, set
        /// <summary>function, coerce or transform parsed command line values into another value, see <c>coerce()</c></summary>
        abstract coerce: (obj option -> obj option) option with get, set
        /// <summary>string or object, require certain keys not to be set, see <c>conflicts()</c></summary>
        abstract conflicts: U3<string, ReadonlyArray<string>, OptionsConflicts> option with get, set
        /// <summary>value, set a default value for the option, see <c>default()</c></summary>
        abstract ``default``: obj option with get, set
        /// <summary>boolean or string, demand the option be given, with optional error message, see <c>demandOption()</c></summary>
        abstract demandOption: U2<bool, string> option with get, set
        /// <summary>string, the option description for help content, see <c>describe()</c></summary>
        abstract desc: string option with get, set
        /// <summary>string, the option description for help content, see <c>describe()</c></summary>
        abstract describe: string option with get, set
        /// <summary>string, the option description for help content, see <c>describe()</c></summary>
        abstract description: string option with get, set
        /// <summary>string or object, require certain keys to be set, see <c>implies()</c></summary>
        abstract implies: U3<string, ReadonlyArray<string>, OptionsConflicts> option with get, set
        /// boolean, apply path.normalize() to the option, see normalize()
        abstract normalize: bool option with get, set
        abstract ``type``: PositionalOptionsType option with get, set

    /// Remove keys K in T
    type [<AllowNullLiteral>] Omit<'T, 'K> =
        interface end

    /// Remove undefined as a possible value for keys K in T
    type [<AllowNullLiteral>] Defined<'T> =
        interface end

    /// Convert T to T[] and T | undefined to T[] | undefined
    type ToArray<'T> =
        U2<Array<Exclude<'T, obj>>, Extract<'T, obj>>

    /// Gives string[] if T is an array type, otherwise string. Preserves | undefined.
    type ToString<'T> =
        U2<obj, Extract<'T, obj>>

    /// Gives number[] if T is an array type, otherwise number. Preserves | undefined.
    type ToNumber<'T> =
        U2<obj, Extract<'T, obj>>

    type InferredOptionType<'O> =
        obj

    type RequiredOptionType<'O> =
        obj

    type [<AllowNullLiteral>] InferredOptionTypes<'O> =
        interface end

    type CommandModule =
        CommandModule<obj, obj>

    type CommandModule<'T> =
        CommandModule<'T, obj>

    type [<AllowNullLiteral>] CommandModule<'T, 'U> =
        /// <summary>array of strings (or a single string) representing aliases of <c>exports.command</c>, positional args defined in an alias are ignored</summary>
        abstract aliases: U2<ReadonlyArray<string>, string> option with get, set
        /// object declaring the options the command accepts, or a function accepting and returning a yargs instance
        abstract builder: CommandBuilder<'T, 'U> option with get, set
        /// string (or array of strings) that executes this command when given on the command line, first string may contain positional args
        abstract command: U2<ReadonlyArray<string>, string> option with get, set
        /// <summary>string used as the description for the command in help text, use <c>false</c> for a hidden command</summary>
        abstract describe: string option with get, set
        /// a function which will be passed the parsed argv.
        abstract handler: (Arguments<'U> -> unit) with get, set

    type ParseCallback =
        ParseCallback<obj>

    type [<AllowNullLiteral>] ParseCallback<'T> =
        [<Emit "$0($1...)">] abstract Invoke: err: Error option * argv: Arguments<'T> * output: string -> unit

    type CommandBuilder =
        CommandBuilder<obj, obj>

    type CommandBuilder<'T> =
        CommandBuilder<'T, obj>

    type CommandBuilder<'T, 'U> =
        U2<Options, (Argv<'T> -> Argv<'U>)>

    type [<AllowNullLiteral>] SyncCompletionFunction =
        [<Emit "$0($1...)">] abstract Invoke: current: string * argv: obj option -> ResizeArray<string>

    type [<AllowNullLiteral>] AsyncCompletionFunction =
        [<Emit "$0($1...)">] abstract Invoke: current: string * argv: obj option * ``done``: (ResizeArray<string> -> unit) -> unit

    type [<AllowNullLiteral>] PromiseCompletionFunction =
        [<Emit "$0($1...)">] abstract Invoke: current: string * argv: obj option -> Promise<ResizeArray<string>>

    type MiddlewareFunction =
        MiddlewareFunction<obj>

    type [<AllowNullLiteral>] MiddlewareFunction<'T> =
        [<Emit "$0($1...)">] abstract Invoke: args: Arguments<'T> -> unit

    type Choices =
        ReadonlyArray<U2<string, float> option>

    type [<StringEnum>] [<RequireQualifiedAccess>] PositionalOptionsType =
        | Boolean
        | Number
        | String

    type [<AllowNullLiteral>] ArgvCheck =
        [<EmitIndexer>] abstract Item: alias: string -> string with get, set

    type [<AllowNullLiteral>] OptionsConflicts =
        [<EmitIndexer>] abstract Item: key: string -> U2<string, ReadonlyArray<string>> with get, set
