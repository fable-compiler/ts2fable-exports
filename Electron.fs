// ts2fable 0.0.0
module rec Electron
open System
open Fable.Core
open Fable.Core.JS
open Browser.Types

[<Erase>] type KeyOf<'T> = Key of string
type Array<'T> = System.Collections.Generic.IList<'T>
type Error = System.Exception
type Function = System.Action


type GlobalEvent =
    Event

module Electron =

    type [<AllowNullLiteral>] IExports =
        abstract Accelerator: AcceleratorStatic
        abstract app: App
        abstract autoUpdater: AutoUpdater
        abstract clipboard: Clipboard
        abstract contentTracing: ContentTracing
        abstract contextBridge: ContextBridge
        abstract crashReporter: CrashReporter
        abstract desktopCapturer: DesktopCapturer
        abstract dialog: Dialog
        abstract globalShortcut: GlobalShortcut
        abstract inAppPurchase: InAppPurchase
        abstract ipcMain: IpcMain
        abstract ipcRenderer: IpcRenderer
        abstract nativeImage: obj
        abstract nativeTheme: NativeTheme
        abstract netLog: NetLog
        abstract net: Net
        abstract powerMonitor: PowerMonitor
        abstract powerSaveBlocker: PowerSaveBlocker
        abstract protocol: Protocol
        abstract remote: Remote
        abstract screen: Screen
        abstract session: obj
        abstract shell: Shell
        abstract systemPreferences: SystemPreferences
        abstract webContents: obj
        abstract webFrame: WebFrame
        abstract webviewTag: WebviewTag
        abstract BrowserView: BrowserViewStatic
        abstract BrowserWindow: BrowserWindowStatic
        abstract BrowserWindowProxy: BrowserWindowProxyStatic
        abstract ClientRequest: ClientRequestStatic
        abstract CommandLine: CommandLineStatic
        abstract Cookies: CookiesStatic
        abstract Debugger: DebuggerStatic
        abstract Dock: DockStatic
        abstract DownloadItem: DownloadItemStatic
        abstract IncomingMessage: IncomingMessageStatic
        abstract Menu: MenuStatic
        abstract MenuItem: MenuItemStatic
        abstract MessageChannelMain: MessageChannelMainStatic
        abstract MessagePortMain: MessagePortMainStatic
        abstract NativeImage: NativeImageStatic
        abstract Notification: NotificationStatic
        abstract ServiceWorkers: ServiceWorkersStatic
        abstract Session: SessionStatic
        abstract TouchBar: TouchBarStatic
        abstract TouchBarButton: TouchBarButtonStatic
        abstract TouchBarColorPicker: TouchBarColorPickerStatic
        abstract TouchBarGroup: TouchBarGroupStatic
        abstract TouchBarLabel: TouchBarLabelStatic
        abstract TouchBarPopover: TouchBarPopoverStatic
        abstract TouchBarScrubber: TouchBarScrubberStatic
        abstract TouchBarSegmentedControl: TouchBarSegmentedControlStatic
        abstract TouchBarSlider: TouchBarSliderStatic
        abstract TouchBarSpacer: TouchBarSpacerStatic
        abstract Tray: TrayStatic
        abstract WebContents: WebContentsStatic
        abstract WebRequest: WebRequestStatic

    type [<AllowNullLiteral>] Accelerator =
        inherit String

    type [<AllowNullLiteral>] AcceleratorStatic =
        [<EmitConstructor>] abstract Create: unit -> Accelerator

    type [<AllowNullLiteral>] CommonInterface =
        abstract app: App with get, set
        abstract autoUpdater: AutoUpdater with get, set
        abstract BrowserView: obj with get, set
        abstract BrowserWindowProxy: obj with get, set
        abstract BrowserWindow: obj with get, set
        abstract ClientRequest: obj with get, set
        abstract clipboard: Clipboard with get, set
        abstract CommandLine: obj with get, set
        abstract contentTracing: ContentTracing with get, set
        abstract contextBridge: ContextBridge with get, set
        abstract Cookies: obj with get, set
        abstract crashReporter: CrashReporter with get, set
        abstract Debugger: obj with get, set
        abstract desktopCapturer: DesktopCapturer with get, set
        abstract dialog: Dialog with get, set
        abstract Dock: obj with get, set
        abstract DownloadItem: obj with get, set
        abstract globalShortcut: GlobalShortcut with get, set
        abstract inAppPurchase: InAppPurchase with get, set
        abstract IncomingMessage: obj with get, set
        abstract ipcMain: IpcMain with get, set
        abstract ipcRenderer: IpcRenderer with get, set
        abstract MenuItem: obj with get, set
        abstract Menu: obj with get, set
        abstract MessageChannelMain: obj with get, set
        abstract MessagePortMain: obj with get, set
        abstract nativeImage: obj with get, set
        abstract nativeTheme: NativeTheme with get, set
        abstract netLog: NetLog with get, set
        abstract net: Net with get, set
        abstract Notification: obj with get, set
        abstract powerMonitor: PowerMonitor with get, set
        abstract powerSaveBlocker: PowerSaveBlocker with get, set
        abstract protocol: Protocol with get, set
        abstract remote: Remote with get, set
        abstract screen: Screen with get, set
        abstract ServiceWorkers: obj with get, set
        abstract session: obj with get, set
        abstract shell: Shell with get, set
        abstract systemPreferences: SystemPreferences with get, set
        abstract TouchBarButton: obj with get, set
        abstract TouchBarColorPicker: obj with get, set
        abstract TouchBarGroup: obj with get, set
        abstract TouchBarLabel: obj with get, set
        abstract TouchBarPopover: obj with get, set
        abstract TouchBarScrubber: obj with get, set
        abstract TouchBarSegmentedControl: obj with get, set
        abstract TouchBarSlider: obj with get, set
        abstract TouchBarSpacer: obj with get, set
        abstract TouchBar: obj with get, set
        abstract Tray: obj with get, set
        abstract webContents: obj with get, set
        abstract webFrame: WebFrame with get, set
        abstract WebRequest: obj with get, set
        abstract webviewTag: WebviewTag with get, set

    type [<AllowNullLiteral>] MainInterface =
        inherit CommonInterface

    type [<AllowNullLiteral>] RendererInterface =
        inherit CommonInterface

    type [<AllowNullLiteral>] AllElectron =
        inherit MainInterface
        inherit RendererInterface

    type nativeImage =
        NativeImage

    type session =
        Session

    type webContents =
        WebContents

    type [<AllowNullLiteral>] App =
        inherit NodeJS.EventEmitter
        /// <summary>
        /// Emitted when Chrome's accessibility support changes. This event fires when
        /// assistive technologies, such as screen readers, are enabled or disabled. See
        /// <see href="https://www.chromium.org/developers/design-documents/accessibility" /> for more
        /// details.
        /// </summary>
        [<Emit "$0.on('accessibility-support-changed',$1)">] abstract ``on_accessibility-support-changed``: listener: (Event -> bool -> unit) -> App
        [<Emit "$0.once('accessibility-support-changed',$1)">] abstract ``once_accessibility-support-changed``: listener: (Event -> bool -> unit) -> App
        [<Emit "$0.addListener('accessibility-support-changed',$1)">] abstract ``addListener_accessibility-support-changed``: listener: (Event -> bool -> unit) -> App
        [<Emit "$0.removeListener('accessibility-support-changed',$1)">] abstract ``removeListener_accessibility-support-changed``: listener: (Event -> bool -> unit) -> App
        /// <summary>
        /// Emitted when the application is activated. Various actions can trigger this
        /// event, such as launching the application for the first time, attempting to
        /// re-launch the application when it's already running, or clicking on the
        /// application's dock or taskbar icon.
        /// </summary>
        [<Emit "$0.on('activate',$1)">] abstract on_activate: listener: (Event -> bool -> unit) -> App
        [<Emit "$0.once('activate',$1)">] abstract once_activate: listener: (Event -> bool -> unit) -> App
        [<Emit "$0.addListener('activate',$1)">] abstract addListener_activate: listener: (Event -> bool -> unit) -> App
        [<Emit "$0.removeListener('activate',$1)">] abstract removeListener_activate: listener: (Event -> bool -> unit) -> App
        /// <summary>
        /// Emitted during Handoff after an activity from this device was successfully
        /// resumed on another one.
        /// </summary>
        [<Emit "$0.on('activity-was-continued',$1)">] abstract ``on_activity-was-continued``: listener: (Event -> string -> obj -> unit) -> App
        [<Emit "$0.once('activity-was-continued',$1)">] abstract ``once_activity-was-continued``: listener: (Event -> string -> obj -> unit) -> App
        [<Emit "$0.addListener('activity-was-continued',$1)">] abstract ``addListener_activity-was-continued``: listener: (Event -> string -> obj -> unit) -> App
        [<Emit "$0.removeListener('activity-was-continued',$1)">] abstract ``removeListener_activity-was-continued``: listener: (Event -> string -> obj -> unit) -> App
        /// <summary>
        /// Emitted before the application starts closing its windows. Calling
        /// <c>event.preventDefault()</c> will prevent the default behavior, which is terminating
        /// the application.
        /// 
        /// **Note:** If application quit was initiated by <c>autoUpdater.quitAndInstall()</c>,
        /// then <c>before-quit</c> is emitted *after* emitting <c>close</c> event on all windows and
        /// closing them.
        /// 
        /// **Note:** On Windows, this event will not be emitted if the app is closed due to
        /// a shutdown/restart of the system or a user logout.
        /// </summary>
        [<Emit "$0.on('before-quit',$1)">] abstract ``on_before-quit``: listener: (Event -> unit) -> App
        [<Emit "$0.once('before-quit',$1)">] abstract ``once_before-quit``: listener: (Event -> unit) -> App
        [<Emit "$0.addListener('before-quit',$1)">] abstract ``addListener_before-quit``: listener: (Event -> unit) -> App
        [<Emit "$0.removeListener('before-quit',$1)">] abstract ``removeListener_before-quit``: listener: (Event -> unit) -> App
        /// Emitted when a browserWindow gets blurred.
        [<Emit "$0.on('browser-window-blur',$1)">] abstract ``on_browser-window-blur``: listener: (Event -> BrowserWindow -> unit) -> App
        [<Emit "$0.once('browser-window-blur',$1)">] abstract ``once_browser-window-blur``: listener: (Event -> BrowserWindow -> unit) -> App
        [<Emit "$0.addListener('browser-window-blur',$1)">] abstract ``addListener_browser-window-blur``: listener: (Event -> BrowserWindow -> unit) -> App
        [<Emit "$0.removeListener('browser-window-blur',$1)">] abstract ``removeListener_browser-window-blur``: listener: (Event -> BrowserWindow -> unit) -> App
        /// Emitted when a new browserWindow is created.
        [<Emit "$0.on('browser-window-created',$1)">] abstract ``on_browser-window-created``: listener: (Event -> BrowserWindow -> unit) -> App
        [<Emit "$0.once('browser-window-created',$1)">] abstract ``once_browser-window-created``: listener: (Event -> BrowserWindow -> unit) -> App
        [<Emit "$0.addListener('browser-window-created',$1)">] abstract ``addListener_browser-window-created``: listener: (Event -> BrowserWindow -> unit) -> App
        [<Emit "$0.removeListener('browser-window-created',$1)">] abstract ``removeListener_browser-window-created``: listener: (Event -> BrowserWindow -> unit) -> App
        /// Emitted when a browserWindow gets focused.
        [<Emit "$0.on('browser-window-focus',$1)">] abstract ``on_browser-window-focus``: listener: (Event -> BrowserWindow -> unit) -> App
        [<Emit "$0.once('browser-window-focus',$1)">] abstract ``once_browser-window-focus``: listener: (Event -> BrowserWindow -> unit) -> App
        [<Emit "$0.addListener('browser-window-focus',$1)">] abstract ``addListener_browser-window-focus``: listener: (Event -> BrowserWindow -> unit) -> App
        [<Emit "$0.removeListener('browser-window-focus',$1)">] abstract ``removeListener_browser-window-focus``: listener: (Event -> BrowserWindow -> unit) -> App
        /// <summary>
        /// Emitted when failed to verify the <c>certificate</c> for <c>url</c>, to trust the
        /// certificate you should prevent the default behavior with
        /// <c>event.preventDefault()</c> and call <c>callback(true)</c>.
        /// </summary>
        [<Emit "$0.on('certificate-error',$1)">] abstract ``on_certificate-error``: listener: (Event -> WebContents -> string -> string -> Certificate -> (bool -> unit) -> unit) -> App
        [<Emit "$0.once('certificate-error',$1)">] abstract ``once_certificate-error``: listener: (Event -> WebContents -> string -> string -> Certificate -> (bool -> unit) -> unit) -> App
        [<Emit "$0.addListener('certificate-error',$1)">] abstract ``addListener_certificate-error``: listener: (Event -> WebContents -> string -> string -> Certificate -> (bool -> unit) -> unit) -> App
        [<Emit "$0.removeListener('certificate-error',$1)">] abstract ``removeListener_certificate-error``: listener: (Event -> WebContents -> string -> string -> Certificate -> (bool -> unit) -> unit) -> App
        /// <summary>
        /// Emitted during Handoff when an activity from a different device wants to be
        /// resumed. You should call <c>event.preventDefault()</c> if you want to handle this
        /// event.
        /// 
        /// A user activity can be continued only in an app that has the same developer Team
        /// ID as the activity's source app and that supports the activity's type. Supported
        /// activity types are specified in the app's <c>Info.plist</c> under the
        /// <c>NSUserActivityTypes</c> key.
        /// </summary>
        [<Emit "$0.on('continue-activity',$1)">] abstract ``on_continue-activity``: listener: (Event -> string -> obj -> unit) -> App
        [<Emit "$0.once('continue-activity',$1)">] abstract ``once_continue-activity``: listener: (Event -> string -> obj -> unit) -> App
        [<Emit "$0.addListener('continue-activity',$1)">] abstract ``addListener_continue-activity``: listener: (Event -> string -> obj -> unit) -> App
        [<Emit "$0.removeListener('continue-activity',$1)">] abstract ``removeListener_continue-activity``: listener: (Event -> string -> obj -> unit) -> App
        /// <summary>
        /// Emitted during Handoff when an activity from a different device fails to be
        /// resumed.
        /// </summary>
        [<Emit "$0.on('continue-activity-error',$1)">] abstract ``on_continue-activity-error``: listener: (Event -> string -> string -> unit) -> App
        [<Emit "$0.once('continue-activity-error',$1)">] abstract ``once_continue-activity-error``: listener: (Event -> string -> string -> unit) -> App
        [<Emit "$0.addListener('continue-activity-error',$1)">] abstract ``addListener_continue-activity-error``: listener: (Event -> string -> string -> unit) -> App
        [<Emit "$0.removeListener('continue-activity-error',$1)">] abstract ``removeListener_continue-activity-error``: listener: (Event -> string -> string -> unit) -> App
        /// <summary>
        /// Emitted when <c>desktopCapturer.getSources()</c> is called in the renderer process of
        /// <c>webContents</c>. Calling <c>event.preventDefault()</c> will make it return empty
        /// sources.
        /// </summary>
        [<Emit "$0.on('desktop-capturer-get-sources',$1)">] abstract ``on_desktop-capturer-get-sources``: listener: (Event -> WebContents -> unit) -> App
        [<Emit "$0.once('desktop-capturer-get-sources',$1)">] abstract ``once_desktop-capturer-get-sources``: listener: (Event -> WebContents -> unit) -> App
        [<Emit "$0.addListener('desktop-capturer-get-sources',$1)">] abstract ``addListener_desktop-capturer-get-sources``: listener: (Event -> WebContents -> unit) -> App
        [<Emit "$0.removeListener('desktop-capturer-get-sources',$1)">] abstract ``removeListener_desktop-capturer-get-sources``: listener: (Event -> WebContents -> unit) -> App
        /// Emitted whenever there is a GPU info update.
        [<Emit "$0.on('gpu-info-update',$1)">] abstract ``on_gpu-info-update``: listener: Function -> App
        [<Emit "$0.once('gpu-info-update',$1)">] abstract ``once_gpu-info-update``: listener: Function -> App
        [<Emit "$0.addListener('gpu-info-update',$1)">] abstract ``addListener_gpu-info-update``: listener: Function -> App
        [<Emit "$0.removeListener('gpu-info-update',$1)">] abstract ``removeListener_gpu-info-update``: listener: Function -> App
        /// Emitted when the GPU process crashes or is killed.
        [<Emit "$0.on('gpu-process-crashed',$1)">] abstract ``on_gpu-process-crashed``: listener: (Event -> bool -> unit) -> App
        [<Emit "$0.once('gpu-process-crashed',$1)">] abstract ``once_gpu-process-crashed``: listener: (Event -> bool -> unit) -> App
        [<Emit "$0.addListener('gpu-process-crashed',$1)">] abstract ``addListener_gpu-process-crashed``: listener: (Event -> bool -> unit) -> App
        [<Emit "$0.removeListener('gpu-process-crashed',$1)">] abstract ``removeListener_gpu-process-crashed``: listener: (Event -> bool -> unit) -> App
        /// <summary>
        /// Emitted when <c>webContents</c> wants to do basic auth.
        /// 
        /// The default behavior is to cancel all authentications. To override this you
        /// should prevent the default behavior with <c>event.preventDefault()</c> and call
        /// <c>callback(username, password)</c> with the credentials.
        /// 
        /// If <c>callback</c> is called without a username or password, the authentication
        /// request will be cancelled and the authentication error will be returned to the
        /// page.
        /// </summary>
        [<Emit "$0.on('login',$1)">] abstract on_login: listener: (Event -> WebContents -> AuthenticationResponseDetails -> AuthInfo -> ((string) option -> (string) option -> unit) -> unit) -> App
        [<Emit "$0.once('login',$1)">] abstract once_login: listener: (Event -> WebContents -> AuthenticationResponseDetails -> AuthInfo -> ((string) option -> (string) option -> unit) -> unit) -> App
        [<Emit "$0.addListener('login',$1)">] abstract addListener_login: listener: (Event -> WebContents -> AuthenticationResponseDetails -> AuthInfo -> ((string) option -> (string) option -> unit) -> unit) -> App
        [<Emit "$0.removeListener('login',$1)">] abstract removeListener_login: listener: (Event -> WebContents -> AuthenticationResponseDetails -> AuthInfo -> ((string) option -> (string) option -> unit) -> unit) -> App
        /// <summary>
        /// Emitted when the user clicks the native macOS new tab button. The new tab button
        /// is only visible if the current <c>BrowserWindow</c> has a <c>tabbingIdentifier</c>
        /// </summary>
        [<Emit "$0.on('new-window-for-tab',$1)">] abstract ``on_new-window-for-tab``: listener: (Event -> unit) -> App
        [<Emit "$0.once('new-window-for-tab',$1)">] abstract ``once_new-window-for-tab``: listener: (Event -> unit) -> App
        [<Emit "$0.addListener('new-window-for-tab',$1)">] abstract ``addListener_new-window-for-tab``: listener: (Event -> unit) -> App
        [<Emit "$0.removeListener('new-window-for-tab',$1)">] abstract ``removeListener_new-window-for-tab``: listener: (Event -> unit) -> App
        /// <summary>
        /// Emitted when the user wants to open a file with the application. The <c>open-file</c>
        /// event is usually emitted when the application is already open and the OS wants
        /// to reuse the application to open the file. <c>open-file</c> is also emitted when a
        /// file is dropped onto the dock and the application is not yet running. Make sure
        /// to listen for the <c>open-file</c> event very early in your application startup to
        /// handle this case (even before the <c>ready</c> event is emitted).
        /// 
        /// You should call <c>event.preventDefault()</c> if you want to handle this event.
        /// 
        /// On Windows, you have to parse <c>process.argv</c> (in the main process) to get the
        /// filepath.
        /// </summary>
        [<Emit "$0.on('open-file',$1)">] abstract ``on_open-file``: listener: (Event -> string -> unit) -> App
        [<Emit "$0.once('open-file',$1)">] abstract ``once_open-file``: listener: (Event -> string -> unit) -> App
        [<Emit "$0.addListener('open-file',$1)">] abstract ``addListener_open-file``: listener: (Event -> string -> unit) -> App
        [<Emit "$0.removeListener('open-file',$1)">] abstract ``removeListener_open-file``: listener: (Event -> string -> unit) -> App
        /// <summary>
        /// Emitted when the user wants to open a URL with the application. Your
        /// application's <c>Info.plist</c> file must define the URL scheme within the
        /// <c>CFBundleURLTypes</c> key, and set <c>NSPrincipalClass</c> to <c>AtomApplication</c>.
        /// 
        /// You should call <c>event.preventDefault()</c> if you want to handle this event.
        /// </summary>
        [<Emit "$0.on('open-url',$1)">] abstract ``on_open-url``: listener: (Event -> string -> unit) -> App
        [<Emit "$0.once('open-url',$1)">] abstract ``once_open-url``: listener: (Event -> string -> unit) -> App
        [<Emit "$0.addListener('open-url',$1)">] abstract ``addListener_open-url``: listener: (Event -> string -> unit) -> App
        [<Emit "$0.removeListener('open-url',$1)">] abstract ``removeListener_open-url``: listener: (Event -> string -> unit) -> App
        /// Emitted when the application is quitting.
        /// 
        /// **Note:** On Windows, this event will not be emitted if the app is closed due to
        /// a shutdown/restart of the system or a user logout.
        [<Emit "$0.on('quit',$1)">] abstract on_quit: listener: (Event -> float -> unit) -> App
        [<Emit "$0.once('quit',$1)">] abstract once_quit: listener: (Event -> float -> unit) -> App
        [<Emit "$0.addListener('quit',$1)">] abstract addListener_quit: listener: (Event -> float -> unit) -> App
        [<Emit "$0.removeListener('quit',$1)">] abstract removeListener_quit: listener: (Event -> float -> unit) -> App
        /// <summary>
        /// Emitted once, when Electron has finished initializing. On macOS, <c>launchInfo</c>
        /// holds the <c>userInfo</c> of the <c>NSUserNotification</c> that was used to open the
        /// application, if it was launched from Notification Center. You can also call
        /// <c>app.isReady()</c> to check if this event has already fired and <c>app.whenReady()</c>
        /// to get a Promise that is fulfilled when Electron is initialized.
        /// </summary>
        [<Emit "$0.on('ready',$1)">] abstract on_ready: listener: (Event -> Record<string, obj option> -> unit) -> App
        [<Emit "$0.once('ready',$1)">] abstract once_ready: listener: (Event -> Record<string, obj option> -> unit) -> App
        [<Emit "$0.addListener('ready',$1)">] abstract addListener_ready: listener: (Event -> Record<string, obj option> -> unit) -> App
        [<Emit "$0.removeListener('ready',$1)">] abstract removeListener_ready: listener: (Event -> Record<string, obj option> -> unit) -> App
        /// <summary>
        /// Emitted when <c>remote.getBuiltin()</c> is called in the renderer process of
        /// <c>webContents</c>. Calling <c>event.preventDefault()</c> will prevent the module from
        /// being returned. Custom value can be returned by setting <c>event.returnValue</c>.
        /// </summary>
        [<Emit "$0.on('remote-get-builtin',$1)">] abstract ``on_remote-get-builtin``: listener: (Event -> WebContents -> string -> unit) -> App
        [<Emit "$0.once('remote-get-builtin',$1)">] abstract ``once_remote-get-builtin``: listener: (Event -> WebContents -> string -> unit) -> App
        [<Emit "$0.addListener('remote-get-builtin',$1)">] abstract ``addListener_remote-get-builtin``: listener: (Event -> WebContents -> string -> unit) -> App
        [<Emit "$0.removeListener('remote-get-builtin',$1)">] abstract ``removeListener_remote-get-builtin``: listener: (Event -> WebContents -> string -> unit) -> App
        /// <summary>
        /// Emitted when <c>remote.getCurrentWebContents()</c> is called in the renderer process
        /// of <c>webContents</c>. Calling <c>event.preventDefault()</c> will prevent the object from
        /// being returned. Custom value can be returned by setting <c>event.returnValue</c>.
        /// </summary>
        [<Emit "$0.on('remote-get-current-web-contents',$1)">] abstract ``on_remote-get-current-web-contents``: listener: (Event -> WebContents -> unit) -> App
        [<Emit "$0.once('remote-get-current-web-contents',$1)">] abstract ``once_remote-get-current-web-contents``: listener: (Event -> WebContents -> unit) -> App
        [<Emit "$0.addListener('remote-get-current-web-contents',$1)">] abstract ``addListener_remote-get-current-web-contents``: listener: (Event -> WebContents -> unit) -> App
        [<Emit "$0.removeListener('remote-get-current-web-contents',$1)">] abstract ``removeListener_remote-get-current-web-contents``: listener: (Event -> WebContents -> unit) -> App
        /// <summary>
        /// Emitted when <c>remote.getCurrentWindow()</c> is called in the renderer process of
        /// <c>webContents</c>. Calling <c>event.preventDefault()</c> will prevent the object from
        /// being returned. Custom value can be returned by setting <c>event.returnValue</c>.
        /// </summary>
        [<Emit "$0.on('remote-get-current-window',$1)">] abstract ``on_remote-get-current-window``: listener: (Event -> WebContents -> unit) -> App
        [<Emit "$0.once('remote-get-current-window',$1)">] abstract ``once_remote-get-current-window``: listener: (Event -> WebContents -> unit) -> App
        [<Emit "$0.addListener('remote-get-current-window',$1)">] abstract ``addListener_remote-get-current-window``: listener: (Event -> WebContents -> unit) -> App
        [<Emit "$0.removeListener('remote-get-current-window',$1)">] abstract ``removeListener_remote-get-current-window``: listener: (Event -> WebContents -> unit) -> App
        /// <summary>
        /// Emitted when <c>remote.getGlobal()</c> is called in the renderer process of
        /// <c>webContents</c>. Calling <c>event.preventDefault()</c> will prevent the global from
        /// being returned. Custom value can be returned by setting <c>event.returnValue</c>.
        /// </summary>
        [<Emit "$0.on('remote-get-global',$1)">] abstract ``on_remote-get-global``: listener: (Event -> WebContents -> string -> unit) -> App
        [<Emit "$0.once('remote-get-global',$1)">] abstract ``once_remote-get-global``: listener: (Event -> WebContents -> string -> unit) -> App
        [<Emit "$0.addListener('remote-get-global',$1)">] abstract ``addListener_remote-get-global``: listener: (Event -> WebContents -> string -> unit) -> App
        [<Emit "$0.removeListener('remote-get-global',$1)">] abstract ``removeListener_remote-get-global``: listener: (Event -> WebContents -> string -> unit) -> App
        /// <summary>
        /// Emitted when <c>remote.require()</c> is called in the renderer process of
        /// <c>webContents</c>. Calling <c>event.preventDefault()</c> will prevent the module from
        /// being returned. Custom value can be returned by setting <c>event.returnValue</c>.
        /// </summary>
        [<Emit "$0.on('remote-require',$1)">] abstract ``on_remote-require``: listener: (Event -> WebContents -> string -> unit) -> App
        [<Emit "$0.once('remote-require',$1)">] abstract ``once_remote-require``: listener: (Event -> WebContents -> string -> unit) -> App
        [<Emit "$0.addListener('remote-require',$1)">] abstract ``addListener_remote-require``: listener: (Event -> WebContents -> string -> unit) -> App
        [<Emit "$0.removeListener('remote-require',$1)">] abstract ``removeListener_remote-require``: listener: (Event -> WebContents -> string -> unit) -> App
        /// Emitted when the renderer process unexpectedly dissapears.  This is normally
        /// because it was crashed or killed.
        [<Emit "$0.on('render-process-gone',$1)">] abstract ``on_render-process-gone``: listener: (Event -> WebContents -> Details -> unit) -> App
        [<Emit "$0.once('render-process-gone',$1)">] abstract ``once_render-process-gone``: listener: (Event -> WebContents -> Details -> unit) -> App
        [<Emit "$0.addListener('render-process-gone',$1)">] abstract ``addListener_render-process-gone``: listener: (Event -> WebContents -> Details -> unit) -> App
        [<Emit "$0.removeListener('render-process-gone',$1)">] abstract ``removeListener_render-process-gone``: listener: (Event -> WebContents -> Details -> unit) -> App
        [<Emit "$0.on('renderer-process-crashed',$1)">] abstract ``on_renderer-process-crashed``: listener: (Event -> WebContents -> bool -> unit) -> App
        [<Emit "$0.once('renderer-process-crashed',$1)">] abstract ``once_renderer-process-crashed``: listener: (Event -> WebContents -> bool -> unit) -> App
        [<Emit "$0.addListener('renderer-process-crashed',$1)">] abstract ``addListener_renderer-process-crashed``: listener: (Event -> WebContents -> bool -> unit) -> App
        [<Emit "$0.removeListener('renderer-process-crashed',$1)">] abstract ``removeListener_renderer-process-crashed``: listener: (Event -> WebContents -> bool -> unit) -> App
        /// <summary>
        /// This event will be emitted inside the primary instance of your application when
        /// a second instance has been executed and calls <c>app.requestSingleInstanceLock()</c>.
        /// 
        /// <c>argv</c> is an Array of the second instance's command line arguments, and
        /// <c>workingDirectory</c> is its current working directory. Usually applications
        /// respond to this by making their primary window focused and non-minimized.
        /// 
        /// This event is guaranteed to be emitted after the <c>ready</c> event of <c>app</c> gets
        /// emitted.
        /// 
        /// **Note:** Extra command line arguments might be added by Chromium, such as
        /// <c>--original-process-start-time</c>.
        /// </summary>
        [<Emit "$0.on('second-instance',$1)">] abstract ``on_second-instance``: listener: (Event -> ResizeArray<string> -> string -> unit) -> App
        [<Emit "$0.once('second-instance',$1)">] abstract ``once_second-instance``: listener: (Event -> ResizeArray<string> -> string -> unit) -> App
        [<Emit "$0.addListener('second-instance',$1)">] abstract ``addListener_second-instance``: listener: (Event -> ResizeArray<string> -> string -> unit) -> App
        [<Emit "$0.removeListener('second-instance',$1)">] abstract ``removeListener_second-instance``: listener: (Event -> ResizeArray<string> -> string -> unit) -> App
        /// <summary>
        /// Emitted when a client certificate is requested.
        /// 
        /// The <c>url</c> corresponds to the navigation entry requesting the client certificate
        /// and <c>callback</c> can be called with an entry filtered from the list. Using
        /// <c>event.preventDefault()</c> prevents the application from using the first
        /// certificate from the store.
        /// </summary>
        [<Emit "$0.on('select-client-certificate',$1)">] abstract ``on_select-client-certificate``: listener: (Event -> WebContents -> string -> ResizeArray<Certificate> -> ((Certificate) option -> unit) -> unit) -> App
        [<Emit "$0.once('select-client-certificate',$1)">] abstract ``once_select-client-certificate``: listener: (Event -> WebContents -> string -> ResizeArray<Certificate> -> ((Certificate) option -> unit) -> unit) -> App
        [<Emit "$0.addListener('select-client-certificate',$1)">] abstract ``addListener_select-client-certificate``: listener: (Event -> WebContents -> string -> ResizeArray<Certificate> -> ((Certificate) option -> unit) -> unit) -> App
        [<Emit "$0.removeListener('select-client-certificate',$1)">] abstract ``removeListener_select-client-certificate``: listener: (Event -> WebContents -> string -> ResizeArray<Certificate> -> ((Certificate) option -> unit) -> unit) -> App
        /// <summary>Emitted when Electron has created a new <c>session</c>.</summary>
        [<Emit "$0.on('session-created',$1)">] abstract ``on_session-created``: listener: (Session -> unit) -> App
        [<Emit "$0.once('session-created',$1)">] abstract ``once_session-created``: listener: (Session -> unit) -> App
        [<Emit "$0.addListener('session-created',$1)">] abstract ``addListener_session-created``: listener: (Session -> unit) -> App
        [<Emit "$0.removeListener('session-created',$1)">] abstract ``removeListener_session-created``: listener: (Session -> unit) -> App
        /// <summary>
        /// Emitted when Handoff is about to be resumed on another device. If you need to
        /// update the state to be transferred, you should call <c>event.preventDefault()</c>
        /// immediately, construct a new <c>userInfo</c> dictionary and call
        /// <c>app.updateCurrentActivity()</c> in a timely manner. Otherwise, the operation will
        /// fail and <c>continue-activity-error</c> will be called.
        /// </summary>
        [<Emit "$0.on('update-activity-state',$1)">] abstract ``on_update-activity-state``: listener: (Event -> string -> obj -> unit) -> App
        [<Emit "$0.once('update-activity-state',$1)">] abstract ``once_update-activity-state``: listener: (Event -> string -> obj -> unit) -> App
        [<Emit "$0.addListener('update-activity-state',$1)">] abstract ``addListener_update-activity-state``: listener: (Event -> string -> obj -> unit) -> App
        [<Emit "$0.removeListener('update-activity-state',$1)">] abstract ``removeListener_update-activity-state``: listener: (Event -> string -> obj -> unit) -> App
        /// Emitted when a new webContents is created.
        [<Emit "$0.on('web-contents-created',$1)">] abstract ``on_web-contents-created``: listener: (Event -> WebContents -> unit) -> App
        [<Emit "$0.once('web-contents-created',$1)">] abstract ``once_web-contents-created``: listener: (Event -> WebContents -> unit) -> App
        [<Emit "$0.addListener('web-contents-created',$1)">] abstract ``addListener_web-contents-created``: listener: (Event -> WebContents -> unit) -> App
        [<Emit "$0.removeListener('web-contents-created',$1)">] abstract ``removeListener_web-contents-created``: listener: (Event -> WebContents -> unit) -> App
        /// <summary>
        /// Emitted during Handoff before an activity from a different device wants to be
        /// resumed. You should call <c>event.preventDefault()</c> if you want to handle this
        /// event.
        /// </summary>
        [<Emit "$0.on('will-continue-activity',$1)">] abstract ``on_will-continue-activity``: listener: (Event -> string -> unit) -> App
        [<Emit "$0.once('will-continue-activity',$1)">] abstract ``once_will-continue-activity``: listener: (Event -> string -> unit) -> App
        [<Emit "$0.addListener('will-continue-activity',$1)">] abstract ``addListener_will-continue-activity``: listener: (Event -> string -> unit) -> App
        [<Emit "$0.removeListener('will-continue-activity',$1)">] abstract ``removeListener_will-continue-activity``: listener: (Event -> string -> unit) -> App
        /// <summary>
        /// Emitted when the application has finished basic startup. On Windows and Linux,
        /// the <c>will-finish-launching</c> event is the same as the <c>ready</c> event; on macOS,
        /// this event represents the <c>applicationWillFinishLaunching</c> notification of
        /// <c>NSApplication</c>. You would usually set up listeners for the <c>open-file</c> and
        /// <c>open-url</c> events here, and start the crash reporter and auto updater.
        /// 
        /// In most cases, you should do everything in the <c>ready</c> event handler.
        /// </summary>
        [<Emit "$0.on('will-finish-launching',$1)">] abstract ``on_will-finish-launching``: listener: Function -> App
        [<Emit "$0.once('will-finish-launching',$1)">] abstract ``once_will-finish-launching``: listener: Function -> App
        [<Emit "$0.addListener('will-finish-launching',$1)">] abstract ``addListener_will-finish-launching``: listener: Function -> App
        [<Emit "$0.removeListener('will-finish-launching',$1)">] abstract ``removeListener_will-finish-launching``: listener: Function -> App
        /// <summary>
        /// Emitted when all windows have been closed and the application will quit. Calling
        /// <c>event.preventDefault()</c> will prevent the default behavior, which is terminating
        /// the application.
        /// 
        /// See the description of the <c>window-all-closed</c> event for the differences between
        /// the <c>will-quit</c> and <c>window-all-closed</c> events.
        /// 
        /// **Note:** On Windows, this event will not be emitted if the app is closed due to
        /// a shutdown/restart of the system or a user logout.
        /// </summary>
        [<Emit "$0.on('will-quit',$1)">] abstract ``on_will-quit``: listener: (Event -> unit) -> App
        [<Emit "$0.once('will-quit',$1)">] abstract ``once_will-quit``: listener: (Event -> unit) -> App
        [<Emit "$0.addListener('will-quit',$1)">] abstract ``addListener_will-quit``: listener: (Event -> unit) -> App
        [<Emit "$0.removeListener('will-quit',$1)">] abstract ``removeListener_will-quit``: listener: (Event -> unit) -> App
        /// <summary>
        /// Emitted when all windows have been closed.
        /// 
        /// If you do not subscribe to this event and all windows are closed, the default
        /// behavior is to quit the app; however, if you subscribe, you control whether the
        /// app quits or not. If the user pressed <c>Cmd + Q</c>, or the developer called
        /// <c>app.quit()</c>, Electron will first try to close all the windows and then emit the
        /// <c>will-quit</c> event, and in this case the <c>window-all-closed</c> event would not be
        /// emitted.
        /// </summary>
        [<Emit "$0.on('window-all-closed',$1)">] abstract ``on_window-all-closed``: listener: Function -> App
        [<Emit "$0.once('window-all-closed',$1)">] abstract ``once_window-all-closed``: listener: Function -> App
        [<Emit "$0.addListener('window-all-closed',$1)">] abstract ``addListener_window-all-closed``: listener: Function -> App
        [<Emit "$0.removeListener('window-all-closed',$1)">] abstract ``removeListener_window-all-closed``: listener: Function -> App
        /// <summary>
        /// Adds <c>path</c> to the recent documents list.
        /// 
        /// This list is managed by the OS. On Windows, you can visit the list from the task
        /// bar, and on macOS, you can visit it from dock menu.
        /// </summary>
        abstract addRecentDocument: path: string -> unit
        /// <summary>Clears the recent documents list.</summary>
        abstract clearRecentDocuments: unit -> unit
        /// By default, Chromium disables 3D APIs (e.g. WebGL) until restart on a per domain
        /// basis if the GPU processes crashes too frequently. This function disables that
        /// behavior.
        /// 
        /// This method can only be called before app is ready.
        abstract disableDomainBlockingFor3DAPIs: unit -> unit
        /// Disables hardware acceleration for current app.
        /// 
        /// This method can only be called before app is ready.
        abstract disableHardwareAcceleration: unit -> unit
        /// <summary>
        /// Enables full sandbox mode on the app.
        /// 
        /// This method can only be called before app is ready.
        /// </summary>
        abstract enableSandbox: unit -> unit
        /// <summary>
        /// Exits immediately with <c>exitCode</c>. <c>exitCode</c> defaults to 0.
        /// 
        /// All windows will be closed immediately without asking the user, and the
        /// <c>before-quit</c> and <c>will-quit</c> events will not be emitted.
        /// </summary>
        abstract exit: ?exitCode: float -> unit
        /// <summary>
        /// On Linux, focuses on the first visible window. On macOS, makes the application
        /// the active app. On Windows, focuses on the application's first window.
        /// 
        /// You should seek to use the <c>steal</c> option as sparingly as possible.
        /// </summary>
        abstract focus: ?options: FocusOptions -> unit
        /// <summary>
        /// Name of the application handling the protocol, or an empty string if there is no
        /// handler. For instance, if Electron is the default handler of the URL, this could
        /// be <c>Electron</c> on Windows and Mac. However, don't rely on the precise format
        /// which is not guaranteed to remain unchanged. Expect a different format on Linux,
        /// possibly with a <c>.desktop</c> suffix.
        /// 
        /// This method returns the application name of the default handler for the protocol
        /// (aka URI scheme) of a URL.
        /// </summary>
        abstract getApplicationNameForProtocol: url: string -> string
        /// <summary>
        /// Array of <c>ProcessMetric</c> objects that correspond to memory and CPU usage
        /// statistics of all the processes associated with the app.
        /// </summary>
        abstract getAppMetrics: unit -> ResizeArray<ProcessMetric>
        /// The current application directory.
        abstract getAppPath: unit -> string
        /// <summary>The current value displayed in the counter badge.</summary>
        abstract getBadgeCount: unit -> float
        /// <summary>The type of the currently running activity.</summary>
        abstract getCurrentActivityType: unit -> string
        /// <summary>
        /// fulfilled with the app's icon, which is a NativeImage.
        /// 
        /// Fetches a path's associated icon.
        /// 
        /// On _Windows_, there a 2 kinds of icons:
        /// 
        /// * Icons associated with certain file extensions, like <c>.mp3</c>, <c>.png</c>, etc.
        /// * Icons inside the file itself, like <c>.exe</c>, <c>.dll</c>, <c>.ico</c>.
        /// 
        /// On _Linux_ and _macOS_, icons depend on the application associated with file
        /// mime type.
        /// </summary>
        abstract getFileIcon: path: string * ?options: FileIconOptions -> Promise<Electron.NativeImage>
        /// <summary>
        /// The Graphics Feature Status from <c>chrome://gpu/</c>.
        /// 
        /// **Note:** This information is only usable after the <c>gpu-info-update</c> event is
        /// emitted.
        /// </summary>
        abstract getGPUFeatureStatus: unit -> GPUFeatureStatus
        /// <summary>
        /// For <c>infoType</c> equal to <c>complete</c>: Promise is fulfilled with <c>Object</c>
        /// containing all the GPU Information as in chromium's GPUInfo object. This
        /// includes the version and driver information that's shown on <c>chrome://gpu</c> page.
        /// 
        /// For <c>infoType</c> equal to <c>basic</c>: Promise is fulfilled with <c>Object</c> containing
        /// fewer attributes than when requested with <c>complete</c>. Here's an example of basic
        /// response:
        /// 
        /// Using <c>basic</c> should be preferred if only basic information like <c>vendorId</c> or
        /// <c>driverId</c> is needed.
        /// </summary>
        abstract getGPUInfo: infoType: AppGetGPUInfoInfoType -> Promise<obj>
        /// <summary>
        /// * <c>minItems</c> Integer - The minimum number of items that will be shown in the
        /// Jump List (for a more detailed description of this value see the MSDN docs).
        /// * <c>removedItems</c> JumpListItem[] - Array of <c>JumpListItem</c> objects that
        /// correspond to items that the user has explicitly removed from custom categories
        /// in the Jump List. These items must not be re-added to the Jump List in the
        /// **next** call to <c>app.setJumpList()</c>, Windows will not display any custom
        /// category that contains any of the removed items.
        /// </summary>
        abstract getJumpListSettings: unit -> JumpListSettings
        /// <summary>
        /// The current application locale. Possible return values are documented here.
        /// 
        /// To set the locale, you'll want to use a command line switch at app startup,
        /// which may be found here.
        /// 
        /// **Note:** When distributing your packaged app, you have to also ship the
        /// <c>locales</c> folder.
        /// 
        /// **Note:** On Windows, you have to call it after the <c>ready</c> events gets emitted.
        /// </summary>
        abstract getLocale: unit -> string
        /// User operating system's locale two-letter ISO 3166 country code. The value is
        /// taken from native OS APIs.
        /// 
        /// *Note:** When unable to detect locale country code, it returns empty string.
        abstract getLocaleCountryCode: unit -> string
        /// <summary>
        /// If you provided <c>path</c> and <c>args</c> options to <c>app.setLoginItemSettings</c>, then
        /// you need to pass the same arguments here for <c>openAtLogin</c> to be set correctly.
        /// 
        /// 
        /// * <c>openAtLogin</c> Boolean - <c>true</c> if the app is set to open at login.
        /// * <c>openAsHidden</c> Boolean _macOS_ - <c>true</c> if the app is set to open as hidden at
        /// login. This setting is not available on MAS builds.
        /// * <c>wasOpenedAtLogin</c> Boolean _macOS_ - <c>true</c> if the app was opened at login
        /// automatically. This setting is not available on MAS builds.
        /// * <c>wasOpenedAsHidden</c> Boolean _macOS_ - <c>true</c> if the app was opened as a hidden
        /// login item. This indicates that the app should not open any windows at startup.
        /// This setting is not available on MAS builds.
        /// * <c>restoreState</c> Boolean _macOS_ - <c>true</c> if the app was opened as a login item
        /// that should restore the state from the previous session. This indicates that the
        /// app should restore the windows that were open the last time the app was closed.
        /// This setting is not available on MAS builds.
        /// </summary>
        abstract getLoginItemSettings: ?options: LoginItemSettingsOptions -> LoginItemSettings
        /// <summary>
        /// The current application's name, which is the name in the application's
        /// <c>package.json</c> file.
        /// 
        /// Usually the <c>name</c> field of <c>package.json</c> is a short lowercase name, according
        /// to the npm modules spec. You should usually also specify a <c>productName</c> field,
        /// which is your application's full capitalized name, and which will be preferred
        /// over <c>name</c> by Electron.
        /// </summary>
        abstract getName: unit -> string
        /// <summary>
        /// A path to a special directory or file associated with <c>name</c>. On failure, an
        /// <c>Error</c> is thrown.
        /// 
        /// If <c>app.getPath('logs')</c> is called without called <c>app.setAppLogsPath()</c> being
        /// called first, a default log directory will be created equivalent to calling
        /// <c>app.setAppLogsPath()</c> without a <c>path</c> parameter.
        /// </summary>
        abstract getPath: name: AppGetPathName -> string
        /// <summary>
        /// The version of the loaded application. If no version is found in the
        /// application's <c>package.json</c> file, the version of the current bundle or
        /// executable is returned.
        /// </summary>
        abstract getVersion: unit -> string
        /// <summary>
        /// This method returns whether or not this instance of your app is currently
        /// holding the single instance lock.  You can request the lock with
        /// <c>app.requestSingleInstanceLock()</c> and release with
        /// <c>app.releaseSingleInstanceLock()</c>
        /// </summary>
        abstract hasSingleInstanceLock: unit -> bool
        /// <summary>Hides all application windows without minimizing them.</summary>
        abstract hide: unit -> unit
        /// <summary>
        /// Imports the certificate in pkcs12 format into the platform certificate store.
        /// <c>callback</c> is called with the <c>result</c> of import operation, a value of <c>0</c>
        /// indicates success while any other value indicates failure according to Chromium
        /// net_error_list.
        /// </summary>
        abstract importCertificate: options: ImportCertificateOptions * callback: (float -> unit) -> unit
        /// <summary>Invalidates the current Handoff user activity.</summary>
        abstract invalidateCurrentActivity: unit -> unit
        /// <summary>
        /// <c>true</c> if Chrome's accessibility support is enabled, <c>false</c> otherwise. This API
        /// will return <c>true</c> if the use of assistive technologies, such as screen readers,
        /// has been detected. See
        /// <see href="https://www.chromium.org/developers/design-documents/accessibility" /> for more
        /// details.
        /// </summary>
        abstract isAccessibilitySupportEnabled: unit -> bool
        /// <summary>
        /// Whether the current executable is the default handler for a protocol (aka URI
        /// scheme).
        /// 
        /// **Note:** On macOS, you can use this method to check if the app has been
        /// registered as the default protocol handler for a protocol. You can also verify
        /// this by checking <c>~/Library/Preferences/com.apple.LaunchServices.plist</c> on the
        /// macOS machine. Please refer to Apple's documentation for details.
        /// 
        /// The API uses the Windows Registry and <c>LSCopyDefaultHandlerForURLScheme</c>
        /// internally.
        /// </summary>
        abstract isDefaultProtocolClient: protocol: string * ?path: string * ?args: ResizeArray<string> -> bool
        /// whether or not the current OS version allows for native emoji pickers.
        abstract isEmojiPanelSupported: unit -> bool
        /// <summary>
        /// Whether the application is currently running from the systems Application
        /// folder. Use in combination with <c>app.moveToApplicationsFolder()</c>
        /// </summary>
        abstract isInApplicationsFolder: unit -> bool
        /// <summary>
        /// <c>true</c> if Electron has finished initializing, <c>false</c> otherwise. See also
        /// <c>app.whenReady()</c>.
        /// </summary>
        abstract isReady: unit -> bool
        /// <summary>Whether the current desktop environment is Unity launcher.</summary>
        abstract isUnityRunning: unit -> bool
        /// <summary>
        /// Whether the move was successful. Please note that if the move is successful,
        /// your application will quit and relaunch.
        /// 
        /// No confirmation dialog will be presented by default. If you wish to allow the
        /// user to confirm the operation, you may do so using the <c>dialog</c> API.
        /// 
        /// **NOTE:** This method throws errors if anything other than the user causes the
        /// move to fail. For instance if the user cancels the authorization dialog, this
        /// method returns false. If we fail to perform the copy, then this method will
        /// throw an error. The message in the error should be informative and tell you
        /// exactly what went wrong.
        /// 
        /// By default, if an app of the same name as the one being moved exists in the
        /// Applications directory and is _not_ running, the existing app will be trashed
        /// and the active app moved into its place. If it _is_ running, the pre-existing
        /// running app will assume focus and the the previously active app will quit
        /// itself. This behavior can be changed by providing the optional conflict handler,
        /// where the boolean returned by the handler determines whether or not the move
        /// conflict is resolved with default behavior.  i.e. returning <c>false</c> will ensure
        /// no further action is taken, returning <c>true</c> will result in the default behavior
        /// and the method continuing.
        /// 
        /// For example:
        /// 
        /// Would mean that if an app already exists in the user directory, if the user
        /// chooses to 'Continue Move' then the function would continue with its default
        /// behavior and the existing app will be trashed and the active app moved into its
        /// place.
        /// </summary>
        abstract moveToApplicationsFolder: ?options: MoveToApplicationsFolderOptions -> bool
        /// <summary>
        /// Try to close all windows. The <c>before-quit</c> event will be emitted first. If all
        /// windows are successfully closed, the <c>will-quit</c> event will be emitted and by
        /// default the application will terminate.
        /// 
        /// This method guarantees that all <c>beforeunload</c> and <c>unload</c> event handlers are
        /// correctly executed. It is possible that a window cancels the quitting by
        /// returning <c>false</c> in the <c>beforeunload</c> event handler.
        /// </summary>
        abstract quit: unit -> unit
        /// <summary>
        /// Relaunches the app when current instance exits.
        /// 
        /// By default, the new instance will use the same working directory and command
        /// line arguments with current instance. When <c>args</c> is specified, the <c>args</c> will
        /// be passed as command line arguments instead. When <c>execPath</c> is specified, the
        /// <c>execPath</c> will be executed for relaunch instead of current app.
        /// 
        /// Note that this method does not quit the app when executed, you have to call
        /// <c>app.quit</c> or <c>app.exit</c> after calling <c>app.relaunch</c> to make the app restart.
        /// 
        /// When <c>app.relaunch</c> is called for multiple times, multiple instances will be
        /// started after current instance exited.
        /// 
        /// An example of restarting current instance immediately and adding a new command
        /// line argument to the new instance:
        /// </summary>
        abstract relaunch: ?options: RelaunchOptions -> unit
        /// <summary>
        /// Releases all locks that were created by <c>requestSingleInstanceLock</c>. This will
        /// allow multiple instances of the application to once again run side by side.
        /// </summary>
        abstract releaseSingleInstanceLock: unit -> unit
        /// <summary>
        /// Whether the call succeeded.
        /// 
        /// This method checks if the current executable as the default handler for a
        /// protocol (aka URI scheme). If so, it will remove the app as the default handler.
        /// </summary>
        abstract removeAsDefaultProtocolClient: protocol: string * ?path: string * ?args: ResizeArray<string> -> bool
        /// <summary>
        /// The return value of this method indicates whether or not this instance of your
        /// application successfully obtained the lock.  If it failed to obtain the lock,
        /// you can assume that another instance of your application is already running with
        /// the lock and exit immediately.
        /// 
        /// I.e. This method returns <c>true</c> if your process is the primary instance of your
        /// application and your app should continue loading.  It returns <c>false</c> if your
        /// process should immediately quit as it has sent its parameters to another
        /// instance that has already acquired the lock.
        /// 
        /// On macOS, the system enforces single instance automatically when users try to
        /// open a second instance of your app in Finder, and the <c>open-file</c> and <c>open-url</c>
        /// events will be emitted for that. However when users start your app in command
        /// line, the system's single instance mechanism will be bypassed, and you have to
        /// use this method to ensure single instance.
        /// 
        /// An example of activating the window of primary instance when a second instance
        /// starts:
        /// </summary>
        abstract requestSingleInstanceLock: unit -> bool
        /// <summary>Marks the current Handoff user activity as inactive without invalidating it.</summary>
        abstract resignCurrentActivity: unit -> unit
        /// <summary>
        /// Set the about panel options. This will override the values defined in the app's
        /// <c>.plist</c> file on macOS. See the Apple docs for more details. On Linux, values
        /// must be set in order to be shown; there are no defaults.
        /// 
        /// If you do not set <c>credits</c> but still wish to surface them in your app, AppKit
        /// will look for a file named "Credits.html", "Credits.rtf", and "Credits.rtfd", in
        /// that order, in the bundle returned by the NSBundle class method main. The first
        /// file found is used, and if none is found, the info area is left blank. See Apple
        /// documentation for more information.
        /// </summary>
        abstract setAboutPanelOptions: options: AboutPanelOptionsOptions -> unit
        /// <summary>
        /// Manually enables Chrome's accessibility support, allowing to expose
        /// accessibility switch to users in application settings. See Chromium's
        /// accessibility docs for more details. Disabled by default.
        /// 
        /// This API must be called after the <c>ready</c> event is emitted.
        /// 
        /// **Note:** Rendering accessibility tree can significantly affect the performance
        /// of your app. It should not be enabled by default.
        /// </summary>
        abstract setAccessibilitySupportEnabled: enabled: bool -> unit
        /// <summary>
        /// Sets the activation policy for a given app.
        /// 
        /// Activation policy types:
        /// 
        /// * 'regular' - The application is an ordinary app that appears in the Dock and
        /// may have a user interface.
        /// * 'accessory' - The application doesn’t appear in the Dock and doesn’t have a
        /// menu bar, but it may be activated programmatically or by clicking on one of its
        /// windows.
        /// * 'prohibited' - The application doesn’t appear in the Dock and may not create
        /// windows or be activated.
        /// </summary>
        abstract setActivationPolicy: policy: AppSetActivationPolicyPolicy -> unit
        /// <summary>
        /// Sets or creates a directory your app's logs which can then be manipulated with
        /// <c>app.getPath()</c> or <c>app.setPath(pathName, newPath)</c>.
        /// 
        /// Calling <c>app.setAppLogsPath()</c> without a <c>path</c> parameter will result in this
        /// directory being set to <c>~/Library/Logs/YourAppName</c> on _macOS_, and inside the
        /// <c>userData</c> directory on _Linux_ and _Windows_.
        /// </summary>
        abstract setAppLogsPath: ?path: string -> unit
        /// <summary>Changes the Application User Model ID to <c>id</c>.</summary>
        abstract setAppUserModelId: id: string -> unit
        /// <summary>
        /// Whether the call succeeded.
        /// 
        /// Sets the current executable as the default handler for a protocol (aka URI
        /// scheme). It allows you to integrate your app deeper into the operating system.
        /// Once registered, all links with <c>your-protocol://</c> will be opened with the
        /// current executable. The whole link, including protocol, will be passed to your
        /// application as a parameter.
        /// 
        /// **Note:** On macOS, you can only register protocols that have been added to your
        /// app's <c>info.plist</c>, which cannot be modified at runtime. However, you can change
        /// the file during build time via Electron Forge, Electron Packager, or by editing
        /// <c>info.plist</c> with a text editor. Please refer to Apple's documentation for
        /// details.
        /// 
        /// **Note:** In a Windows Store environment (when packaged as an <c>appx</c>) this API
        /// will return <c>true</c> for all calls but the registry key it sets won't be
        /// accessible by other applications.  In order to register your Windows Store
        /// application as a default protocol handler you must declare the protocol in your
        /// manifest.
        /// 
        /// The API uses the Windows Registry and <c>LSSetDefaultHandlerForURLScheme</c>
        /// internally.
        /// </summary>
        abstract setAsDefaultProtocolClient: protocol: string * ?path: string * ?args: ResizeArray<string> -> bool
        /// <summary>
        /// Whether the call succeeded.
        /// 
        /// Sets the counter badge for current app. Setting the count to <c>0</c> will hide the
        /// badge.
        /// 
        /// On macOS, it shows on the dock icon. On Linux, it only works for Unity launcher.
        /// 
        /// **Note:** Unity launcher requires the existence of a <c>.desktop</c> file to work,
        /// for more information please read Desktop Environment Integration.
        /// </summary>
        abstract setBadgeCount: count: float -> bool
        /// <summary>
        /// Sets or removes a custom Jump List for the application, and returns one of the
        /// following strings:
        /// 
        /// * <c>ok</c> - Nothing went wrong.
        /// * <c>error</c> - One or more errors occurred, enable runtime logging to figure out
        /// the likely cause.
        /// * <c>invalidSeparatorError</c> - An attempt was made to add a separator to a custom
        /// category in the Jump List. Separators are only allowed in the standard <c>Tasks</c>
        /// category.
        /// * <c>fileTypeRegistrationError</c> - An attempt was made to add a file link to the
        /// Jump List for a file type the app isn't registered to handle.
        /// * <c>customCategoryAccessDeniedError</c> - Custom categories can't be added to the
        /// Jump List due to user privacy or group policy settings.
        /// 
        /// If <c>categories</c> is <c>null</c> the previously set custom Jump List (if any) will be
        /// replaced by the standard Jump List for the app (managed by Windows).
        /// 
        /// **Note:** If a <c>JumpListCategory</c> object has neither the <c>type</c> nor the <c>name</c>
        /// property set then its <c>type</c> is assumed to be <c>tasks</c>. If the <c>name</c> property is
        /// set but the <c>type</c> property is omitted then the <c>type</c> is assumed to be
        /// <c>custom</c>.
        /// 
        /// **Note:** Users can remove items from custom categories, and Windows will not
        /// allow a removed item to be added back into a custom category until **after** the
        /// next successful call to <c>app.setJumpList(categories)</c>. Any attempt to re-add a
        /// removed item to a custom category earlier than that will result in the entire
        /// custom category being omitted from the Jump List. The list of removed items can
        /// be obtained using <c>app.getJumpListSettings()</c>.
        /// 
        /// Here's a very simple example of creating a custom Jump List:
        /// </summary>
        abstract setJumpList: categories: ResizeArray<JumpListCategory> option -> unit
        /// <summary>
        /// Set the app's login item settings.
        /// 
        /// To work with Electron's <c>autoUpdater</c> on Windows, which uses Squirrel, you'll
        /// want to set the launch path to Update.exe, and pass arguments that specify your
        /// application name. For example:
        /// </summary>
        abstract setLoginItemSettings: settings: Settings -> unit
        /// Overrides the current application's name.
        /// 
        /// **Note:** This function overrides the name used internally by Electron; it does
        /// not affect the name that the OS uses.
        abstract setName: name: string -> unit
        /// <summary>
        /// Overrides the <c>path</c> to a special directory or file associated with <c>name</c>. If
        /// the path specifies a directory that does not exist, an <c>Error</c> is thrown. In
        /// that case, the directory should be created with <c>fs.mkdirSync</c> or similar.
        /// 
        /// You can only override paths of a <c>name</c> defined in <c>app.getPath</c>.
        /// 
        /// By default, web pages' cookies and caches will be stored under the <c>userData</c>
        /// directory. If you want to change this location, you have to override the
        /// <c>userData</c> path before the <c>ready</c> event of the <c>app</c> module is emitted.
        /// </summary>
        abstract setPath: name: string * path: string -> unit
        /// <summary>
        /// Creates an <c>NSUserActivity</c> and sets it as the current activity. The activity is
        /// eligible for Handoff to another device afterward.
        /// </summary>
        abstract setUserActivity: ``type``: string * userInfo: obj option * ?webpageURL: string -> unit
        /// <summary>
        /// Adds <c>tasks</c> to the Tasks category of the Jump List on Windows.
        /// 
        /// <c>tasks</c> is an array of <c>Task</c> objects.
        /// 
        /// Whether the call succeeded.
        /// 
        /// **Note:** If you'd like to customize the Jump List even more use
        /// <c>app.setJumpList(categories)</c> instead.
        /// </summary>
        abstract setUserTasks: tasks: ResizeArray<Task> -> bool
        /// <summary>
        /// Shows application windows after they were hidden. Does not automatically focus
        /// them.
        /// </summary>
        abstract show: unit -> unit
        /// <summary>
        /// Show the app's about panel options. These options can be overridden with
        /// <c>app.setAboutPanelOptions(options)</c>.
        /// </summary>
        abstract showAboutPanel: unit -> unit
        /// <summary>Show the platform's native emoji picker.</summary>
        abstract showEmojiPanel: unit -> unit
        /// <summary>
        /// This function **must** be called once you have finished accessing the security
        /// scoped file. If you do not remember to stop accessing the bookmark, kernel
        /// resources will be leaked and your app will lose its ability to reach outside the
        /// sandbox completely, until your app is restarted.
        /// 
        /// Start accessing a security scoped resource. With this method Electron
        /// applications that are packaged for the Mac App Store may reach outside their
        /// sandbox to access files chosen by the user. See Apple's documentation for a
        /// description of how this system works.
        /// </summary>
        abstract startAccessingSecurityScopedResource: bookmarkData: string -> Function
        /// <summary>
        /// Updates the current activity if its type matches <c>type</c>, merging the entries
        /// from <c>userInfo</c> into its current <c>userInfo</c> dictionary.
        /// </summary>
        abstract updateCurrentActivity: ``type``: string * userInfo: obj option -> unit
        /// <summary>
        /// fulfilled when Electron is initialized. May be used as a convenient alternative
        /// to checking <c>app.isReady()</c> and subscribing to the <c>ready</c> event if the app is
        /// not ready yet.
        /// </summary>
        abstract whenReady: unit -> Promise<unit>
        /// <summary>
        /// A <c>Boolean</c> property that's <c>true</c> if Chrome's accessibility support is enabled,
        /// <c>false</c> otherwise. This property will be <c>true</c> if the use of assistive
        /// technologies, such as screen readers, has been detected. Setting this property
        /// to <c>true</c> manually enables Chrome's accessibility support, allowing developers
        /// to expose accessibility switch to users in application settings.
        /// 
        /// See Chromium's accessibility docs for more details. Disabled by default.
        /// 
        /// This API must be called after the <c>ready</c> event is emitted.
        /// 
        /// **Note:** Rendering accessibility tree can significantly affect the performance
        /// of your app. It should not be enabled by default.
        /// </summary>
        abstract accessibilitySupportEnabled: bool with get, set
        /// <summary>
        /// A <c>Boolean</c> which when <c>true</c> disables the overrides that Electron has in place
        /// to ensure renderer processes are restarted on every navigation.  The current
        /// default value for this property is <c>true</c>.
        /// 
        /// The intention is for these overrides to become disabled by default and then at
        /// some point in the future this property will be removed.  This property impacts
        /// which native modules you can use in the renderer process.  For more information
        /// on the direction Electron is going with renderer process restarts and usage of
        /// native modules in the renderer process please check out this Tracking Issue.
        /// </summary>
        abstract allowRendererProcessReuse: bool with get, set
        /// <summary>
        /// A <c>Menu | null</c> property that returns <c>Menu</c> if one has been set and <c>null</c>
        /// otherwise. Users can pass a Menu to set this property.
        /// </summary>
        abstract applicationMenu: Menu option with get, set
        /// <summary>
        /// An <c>Integer</c> property that returns the badge count for current app. Setting the
        /// count to <c>0</c> will hide the badge.
        /// 
        /// On macOS, setting this with any nonzero integer shows on the dock icon. On
        /// Linux, this property only works for Unity launcher.
        /// 
        /// **Note:** Unity launcher requires the existence of a <c>.desktop</c> file to work,
        /// for more information please read Desktop Environment Integration.
        /// </summary>
        abstract badgeCount: float with get, set
        /// <summary>
        /// A <c>CommandLine</c> object that allows you to read and manipulate the command line
        /// arguments that Chromium uses.
        /// </summary>
        abstract commandLine: CommandLine
        /// <summary>
        /// A <c>Dock</c> <c>| undefined</c> object that allows you to perform actions on your app
        /// icon in the user's dock on macOS.
        /// </summary>
        abstract dock: Dock
        /// <summary>
        /// A <c>Boolean</c> property that returns  <c>true</c> if the app is packaged, <c>false</c>
        /// otherwise. For many apps, this property can be used to distinguish development
        /// and production environments.
        /// </summary>
        abstract isPackaged: bool
        /// <summary>
        /// A <c>String</c> property that indicates the current application's name, which is the
        /// name in the application's <c>package.json</c> file.
        /// 
        /// Usually the <c>name</c> field of <c>package.json</c> is a short lowercase name, according
        /// to the npm modules spec. You should usually also specify a <c>productName</c> field,
        /// which is your application's full capitalized name, and which will be preferred
        /// over <c>name</c> by Electron.
        /// </summary>
        abstract name: string with get, set
        /// <summary>
        /// A <c>String</c> which is the user agent string Electron will use as a global
        /// fallback.
        /// 
        /// This is the user agent that will be used when no user agent is set at the
        /// <c>webContents</c> or <c>session</c> level.  It is useful for ensuring that your entire
        /// app has the same user agent.  Set to a custom value as early as possible in your
        /// app's initialization to ensure that your overridden value is used.
        /// </summary>
        abstract userAgentFallback: string with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] AppGetGPUInfoInfoType =
        | Basic
        | Complete

    type [<StringEnum>] [<RequireQualifiedAccess>] AppGetPathName =
        | Home
        | AppData
        | UserData
        | Cache
        | Temp
        | Exe
        | Module
        | Desktop
        | Documents
        | Downloads
        | Music
        | Pictures
        | Videos
        | Logs
        | PepperFlashSystemPlugin
        | CrashDumps

    type [<StringEnum>] [<RequireQualifiedAccess>] AppSetActivationPolicyPolicy =
        | Regular
        | Accessory
        | Prohibited

    type [<AllowNullLiteral>] AutoUpdater =
        inherit NodeJS.EventEmitter
        /// <summary>
        /// This event is emitted after a user calls <c>quitAndInstall()</c>.
        /// 
        /// When this API is called, the <c>before-quit</c> event is not emitted before all
        /// windows are closed. As a result you should listen to this event if you wish to
        /// perform actions before the windows are closed while a process is quitting, as
        /// well as listening to <c>before-quit</c>.
        /// </summary>
        [<Emit "$0.on('before-quit-for-update',$1)">] abstract ``on_before-quit-for-update``: listener: Function -> AutoUpdater
        [<Emit "$0.once('before-quit-for-update',$1)">] abstract ``once_before-quit-for-update``: listener: Function -> AutoUpdater
        [<Emit "$0.addListener('before-quit-for-update',$1)">] abstract ``addListener_before-quit-for-update``: listener: Function -> AutoUpdater
        [<Emit "$0.removeListener('before-quit-for-update',$1)">] abstract ``removeListener_before-quit-for-update``: listener: Function -> AutoUpdater
        /// Emitted when checking if an update has started.
        [<Emit "$0.on('checking-for-update',$1)">] abstract ``on_checking-for-update``: listener: Function -> AutoUpdater
        [<Emit "$0.once('checking-for-update',$1)">] abstract ``once_checking-for-update``: listener: Function -> AutoUpdater
        [<Emit "$0.addListener('checking-for-update',$1)">] abstract ``addListener_checking-for-update``: listener: Function -> AutoUpdater
        [<Emit "$0.removeListener('checking-for-update',$1)">] abstract ``removeListener_checking-for-update``: listener: Function -> AutoUpdater
        /// Emitted when there is an error while updating.
        [<Emit "$0.on('error',$1)">] abstract on_error: listener: (Error -> unit) -> AutoUpdater
        [<Emit "$0.once('error',$1)">] abstract once_error: listener: (Error -> unit) -> AutoUpdater
        [<Emit "$0.addListener('error',$1)">] abstract addListener_error: listener: (Error -> unit) -> AutoUpdater
        [<Emit "$0.removeListener('error',$1)">] abstract removeListener_error: listener: (Error -> unit) -> AutoUpdater
        /// Emitted when there is an available update. The update is downloaded
        /// automatically.
        [<Emit "$0.on('update-available',$1)">] abstract ``on_update-available``: listener: Function -> AutoUpdater
        [<Emit "$0.once('update-available',$1)">] abstract ``once_update-available``: listener: Function -> AutoUpdater
        [<Emit "$0.addListener('update-available',$1)">] abstract ``addListener_update-available``: listener: Function -> AutoUpdater
        [<Emit "$0.removeListener('update-available',$1)">] abstract ``removeListener_update-available``: listener: Function -> AutoUpdater
        /// <summary>
        /// Emitted when an update has been downloaded.
        /// 
        /// On Windows only <c>releaseName</c> is available.
        /// 
        /// **Note:** It is not strictly necessary to handle this event. A successfully
        /// downloaded update will still be applied the next time the application starts.
        /// </summary>
        [<Emit "$0.on('update-downloaded',$1)">] abstract ``on_update-downloaded``: listener: (Event -> string -> string -> DateTime -> string -> unit) -> AutoUpdater
        [<Emit "$0.once('update-downloaded',$1)">] abstract ``once_update-downloaded``: listener: (Event -> string -> string -> DateTime -> string -> unit) -> AutoUpdater
        [<Emit "$0.addListener('update-downloaded',$1)">] abstract ``addListener_update-downloaded``: listener: (Event -> string -> string -> DateTime -> string -> unit) -> AutoUpdater
        [<Emit "$0.removeListener('update-downloaded',$1)">] abstract ``removeListener_update-downloaded``: listener: (Event -> string -> string -> DateTime -> string -> unit) -> AutoUpdater
        /// Emitted when there is no available update.
        [<Emit "$0.on('update-not-available',$1)">] abstract ``on_update-not-available``: listener: Function -> AutoUpdater
        [<Emit "$0.once('update-not-available',$1)">] abstract ``once_update-not-available``: listener: Function -> AutoUpdater
        [<Emit "$0.addListener('update-not-available',$1)">] abstract ``addListener_update-not-available``: listener: Function -> AutoUpdater
        [<Emit "$0.removeListener('update-not-available',$1)">] abstract ``removeListener_update-not-available``: listener: Function -> AutoUpdater
        /// <summary>
        /// Asks the server whether there is an update. You must call <c>setFeedURL</c> before
        /// using this API.
        /// </summary>
        abstract checkForUpdates: unit -> unit
        /// The current update feed URL.
        abstract getFeedURL: unit -> string
        /// <summary>
        /// Restarts the app and installs the update after it has been downloaded. It should
        /// only be called after <c>update-downloaded</c> has been emitted.
        /// 
        /// Under the hood calling <c>autoUpdater.quitAndInstall()</c> will close all application
        /// windows first, and automatically call <c>app.quit()</c> after all windows have been
        /// closed.
        /// 
        /// **Note:** It is not strictly necessary to call this function to apply an update,
        /// as a successfully downloaded update will always be applied the next time the
        /// application starts.
        /// </summary>
        abstract quitAndInstall: unit -> unit
        /// <summary>Sets the <c>url</c> and initialize the auto updater.</summary>
        abstract setFeedURL: options: FeedURLOptions -> unit

    type [<AllowNullLiteral>] BluetoothDevice =
        abstract deviceId: string with get, set
        abstract deviceName: string with get, set

    type [<AllowNullLiteral>] BrowserView =
        /// <summary>
        /// Force closing the view, the <c>unload</c> and <c>beforeunload</c> events won't be emitted
        /// for the web page. After you're done with a view, call this function in order to
        /// free memory and other resources as soon as possible.
        /// </summary>
        abstract destroy: unit -> unit
        /// <summary>The <c>bounds</c> of this BrowserView instance as <c>Object</c>.</summary>
        abstract getBounds: unit -> Rectangle
        /// Whether the view is destroyed.
        abstract isDestroyed: unit -> bool
        abstract setAutoResize: options: AutoResizeOptions -> unit
        abstract setBackgroundColor: color: string -> unit
        /// <summary>Resizes and moves the view to the supplied bounds relative to the window.</summary>
        abstract setBounds: bounds: Rectangle -> unit
        abstract id: float with get, set
        abstract webContents: WebContents with get, set

    type [<AllowNullLiteral>] BrowserViewStatic =
        /// BrowserView
        [<EmitConstructor>] abstract Create: ?options: BrowserViewConstructorOptions -> BrowserView
        /// <summary>The view with the given <c>id</c>.</summary>
        abstract fromId: id: float -> BrowserView
        /// <summary>
        /// The BrowserView that owns the given <c>webContents</c> or <c>null</c> if the contents are
        /// not owned by a BrowserView.
        /// </summary>
        abstract fromWebContents: webContents: WebContents -> BrowserView option
        /// An array of all opened BrowserViews.
        abstract getAllViews: unit -> ResizeArray<BrowserView>

    type [<AllowNullLiteral>] BrowserWindow =
        inherit NodeJS.EventEmitter
        /// Emitted when the window is set or unset to show always on top of other windows.
        [<Emit "$0.on('always-on-top-changed',$1)">] abstract ``on_always-on-top-changed``: listener: (Event -> bool -> unit) -> BrowserWindow
        [<Emit "$0.once('always-on-top-changed',$1)">] abstract ``once_always-on-top-changed``: listener: (Event -> bool -> unit) -> BrowserWindow
        [<Emit "$0.addListener('always-on-top-changed',$1)">] abstract ``addListener_always-on-top-changed``: listener: (Event -> bool -> unit) -> BrowserWindow
        [<Emit "$0.removeListener('always-on-top-changed',$1)">] abstract ``removeListener_always-on-top-changed``: listener: (Event -> bool -> unit) -> BrowserWindow
        /// <summary>
        /// Emitted when an App Command is invoked. These are typically related to keyboard
        /// media keys or browser commands, as well as the "Back" button built into some
        /// mice on Windows.
        /// 
        /// Commands are lowercased, underscores are replaced with hyphens, and the
        /// <c>APPCOMMAND_</c> prefix is stripped off. e.g. <c>APPCOMMAND_BROWSER_BACKWARD</c> is
        /// emitted as <c>browser-backward</c>.
        /// 
        /// The following app commands are explicitly supported on Linux:
        /// 
        /// <c>browser-backward</c>
        /// <c>browser-forward</c>
        /// </summary>
        [<Emit "$0.on('app-command',$1)">] abstract ``on_app-command``: listener: (Event -> string -> unit) -> BrowserWindow
        [<Emit "$0.once('app-command',$1)">] abstract ``once_app-command``: listener: (Event -> string -> unit) -> BrowserWindow
        [<Emit "$0.addListener('app-command',$1)">] abstract ``addListener_app-command``: listener: (Event -> string -> unit) -> BrowserWindow
        [<Emit "$0.removeListener('app-command',$1)">] abstract ``removeListener_app-command``: listener: (Event -> string -> unit) -> BrowserWindow
        /// Emitted when the window loses focus.
        [<Emit "$0.on('blur',$1)">] abstract on_blur: listener: Function -> BrowserWindow
        [<Emit "$0.once('blur',$1)">] abstract once_blur: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('blur',$1)">] abstract addListener_blur: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('blur',$1)">] abstract removeListener_blur: listener: Function -> BrowserWindow
        /// <summary>
        /// Emitted when the window is going to be closed. It's emitted before the
        /// <c>beforeunload</c> and <c>unload</c> event of the DOM. Calling <c>event.preventDefault()</c>
        /// will cancel the close.
        /// 
        /// Usually you would want to use the <c>beforeunload</c> handler to decide whether the
        /// window should be closed, which will also be called when the window is reloaded.
        /// In Electron, returning any value other than <c>undefined</c> would cancel the close.
        /// For example:
        /// 
        /// _**Note**: There is a subtle difference between the behaviors of
        /// <c>window.onbeforeunload = handler</c> and `window.addEventListener('beforeunload',
        /// handler)<c>. It is recommended to always set the </c>event.returnValue` explicitly,
        /// instead of only returning a value, as the former works more consistently within
        /// Electron._
        /// </summary>
        [<Emit "$0.on('close',$1)">] abstract on_close: listener: (Event -> unit) -> BrowserWindow
        [<Emit "$0.once('close',$1)">] abstract once_close: listener: (Event -> unit) -> BrowserWindow
        [<Emit "$0.addListener('close',$1)">] abstract addListener_close: listener: (Event -> unit) -> BrowserWindow
        [<Emit "$0.removeListener('close',$1)">] abstract removeListener_close: listener: (Event -> unit) -> BrowserWindow
        /// Emitted when the window is closed. After you have received this event you should
        /// remove the reference to the window and avoid using it any more.
        [<Emit "$0.on('closed',$1)">] abstract on_closed: listener: Function -> BrowserWindow
        [<Emit "$0.once('closed',$1)">] abstract once_closed: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('closed',$1)">] abstract addListener_closed: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('closed',$1)">] abstract removeListener_closed: listener: Function -> BrowserWindow
        /// Emitted when the window enters a full-screen state.
        [<Emit "$0.on('enter-full-screen',$1)">] abstract ``on_enter-full-screen``: listener: Function -> BrowserWindow
        [<Emit "$0.once('enter-full-screen',$1)">] abstract ``once_enter-full-screen``: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('enter-full-screen',$1)">] abstract ``addListener_enter-full-screen``: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('enter-full-screen',$1)">] abstract ``removeListener_enter-full-screen``: listener: Function -> BrowserWindow
        /// Emitted when the window enters a full-screen state triggered by HTML API.
        [<Emit "$0.on('enter-html-full-screen',$1)">] abstract ``on_enter-html-full-screen``: listener: Function -> BrowserWindow
        [<Emit "$0.once('enter-html-full-screen',$1)">] abstract ``once_enter-html-full-screen``: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('enter-html-full-screen',$1)">] abstract ``addListener_enter-html-full-screen``: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('enter-html-full-screen',$1)">] abstract ``removeListener_enter-html-full-screen``: listener: Function -> BrowserWindow
        /// Emitted when the window gains focus.
        [<Emit "$0.on('focus',$1)">] abstract on_focus: listener: Function -> BrowserWindow
        [<Emit "$0.once('focus',$1)">] abstract once_focus: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('focus',$1)">] abstract addListener_focus: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('focus',$1)">] abstract removeListener_focus: listener: Function -> BrowserWindow
        /// Emitted when the window is hidden.
        [<Emit "$0.on('hide',$1)">] abstract on_hide: listener: Function -> BrowserWindow
        [<Emit "$0.once('hide',$1)">] abstract once_hide: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('hide',$1)">] abstract addListener_hide: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('hide',$1)">] abstract removeListener_hide: listener: Function -> BrowserWindow
        /// Emitted when the window leaves a full-screen state.
        [<Emit "$0.on('leave-full-screen',$1)">] abstract ``on_leave-full-screen``: listener: Function -> BrowserWindow
        [<Emit "$0.once('leave-full-screen',$1)">] abstract ``once_leave-full-screen``: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('leave-full-screen',$1)">] abstract ``addListener_leave-full-screen``: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('leave-full-screen',$1)">] abstract ``removeListener_leave-full-screen``: listener: Function -> BrowserWindow
        /// Emitted when the window leaves a full-screen state triggered by HTML API.
        [<Emit "$0.on('leave-html-full-screen',$1)">] abstract ``on_leave-html-full-screen``: listener: Function -> BrowserWindow
        [<Emit "$0.once('leave-html-full-screen',$1)">] abstract ``once_leave-html-full-screen``: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('leave-html-full-screen',$1)">] abstract ``addListener_leave-html-full-screen``: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('leave-html-full-screen',$1)">] abstract ``removeListener_leave-html-full-screen``: listener: Function -> BrowserWindow
        /// Emitted when window is maximized.
        [<Emit "$0.on('maximize',$1)">] abstract on_maximize: listener: Function -> BrowserWindow
        [<Emit "$0.once('maximize',$1)">] abstract once_maximize: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('maximize',$1)">] abstract addListener_maximize: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('maximize',$1)">] abstract removeListener_maximize: listener: Function -> BrowserWindow
        /// Emitted when the window is minimized.
        [<Emit "$0.on('minimize',$1)">] abstract on_minimize: listener: Function -> BrowserWindow
        [<Emit "$0.once('minimize',$1)">] abstract once_minimize: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('minimize',$1)">] abstract addListener_minimize: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('minimize',$1)">] abstract removeListener_minimize: listener: Function -> BrowserWindow
        /// <summary>
        /// Emitted when the window is being moved to a new position.
        /// 
        /// __Note__: On macOS this event is an alias of <c>moved</c>.
        /// </summary>
        [<Emit "$0.on('move',$1)">] abstract on_move: listener: Function -> BrowserWindow
        [<Emit "$0.once('move',$1)">] abstract once_move: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('move',$1)">] abstract addListener_move: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('move',$1)">] abstract removeListener_move: listener: Function -> BrowserWindow
        /// <summary>Emitted once when the window is moved to a new position.</summary>
        [<Emit "$0.on('moved',$1)">] abstract on_moved: listener: Function -> BrowserWindow
        [<Emit "$0.once('moved',$1)">] abstract once_moved: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('moved',$1)">] abstract addListener_moved: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('moved',$1)">] abstract removeListener_moved: listener: Function -> BrowserWindow
        /// <summary>Emitted when the native new tab button is clicked.</summary>
        [<Emit "$0.on('new-window-for-tab',$1)">] abstract ``on_new-window-for-tab``: listener: Function -> BrowserWindow
        [<Emit "$0.once('new-window-for-tab',$1)">] abstract ``once_new-window-for-tab``: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('new-window-for-tab',$1)">] abstract ``addListener_new-window-for-tab``: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('new-window-for-tab',$1)">] abstract ``removeListener_new-window-for-tab``: listener: Function -> BrowserWindow
        /// <summary>
        /// Emitted when the document changed its title, calling <c>event.preventDefault()</c>
        /// will prevent the native window's title from changing. <c>explicitSet</c> is false
        /// when title is synthesized from file URL.
        /// </summary>
        [<Emit "$0.on('page-title-updated',$1)">] abstract ``on_page-title-updated``: listener: (Event -> string -> bool -> unit) -> BrowserWindow
        [<Emit "$0.once('page-title-updated',$1)">] abstract ``once_page-title-updated``: listener: (Event -> string -> bool -> unit) -> BrowserWindow
        [<Emit "$0.addListener('page-title-updated',$1)">] abstract ``addListener_page-title-updated``: listener: (Event -> string -> bool -> unit) -> BrowserWindow
        [<Emit "$0.removeListener('page-title-updated',$1)">] abstract ``removeListener_page-title-updated``: listener: (Event -> string -> bool -> unit) -> BrowserWindow
        /// <summary>
        /// Emitted when the web page has been rendered (while not being shown) and window
        /// can be displayed without a visual flash.
        /// 
        /// Please note that using this event implies that the renderer will be considered
        /// "visible" and paint even though <c>show</c> is false.  This event will never fire if
        /// you use <c>paintWhenInitiallyHidden: false</c>
        /// </summary>
        [<Emit "$0.on('ready-to-show',$1)">] abstract ``on_ready-to-show``: listener: Function -> BrowserWindow
        [<Emit "$0.once('ready-to-show',$1)">] abstract ``once_ready-to-show``: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('ready-to-show',$1)">] abstract ``addListener_ready-to-show``: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('ready-to-show',$1)">] abstract ``removeListener_ready-to-show``: listener: Function -> BrowserWindow
        /// Emitted after the window has been resized.
        [<Emit "$0.on('resize',$1)">] abstract on_resize: listener: Function -> BrowserWindow
        [<Emit "$0.once('resize',$1)">] abstract once_resize: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('resize',$1)">] abstract addListener_resize: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('resize',$1)">] abstract removeListener_resize: listener: Function -> BrowserWindow
        /// Emitted when the unresponsive web page becomes responsive again.
        [<Emit "$0.on('responsive',$1)">] abstract on_responsive: listener: Function -> BrowserWindow
        [<Emit "$0.once('responsive',$1)">] abstract once_responsive: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('responsive',$1)">] abstract addListener_responsive: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('responsive',$1)">] abstract removeListener_responsive: listener: Function -> BrowserWindow
        /// Emitted when the window is restored from a minimized state.
        [<Emit "$0.on('restore',$1)">] abstract on_restore: listener: Function -> BrowserWindow
        [<Emit "$0.once('restore',$1)">] abstract once_restore: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('restore',$1)">] abstract addListener_restore: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('restore',$1)">] abstract removeListener_restore: listener: Function -> BrowserWindow
        /// <summary>
        /// Emitted on trackpad rotation gesture. Continually emitted until rotation gesture
        /// is ended. The <c>rotation</c> value on each emission is the angle in degrees rotated
        /// since the last emission. The last emitted event upon a rotation gesture will
        /// always be of value <c>0</c>. Counter-clockwise rotation values are positive, while
        /// clockwise ones are negative.
        /// </summary>
        [<Emit "$0.on('rotate-gesture',$1)">] abstract ``on_rotate-gesture``: listener: (Event -> float -> unit) -> BrowserWindow
        [<Emit "$0.once('rotate-gesture',$1)">] abstract ``once_rotate-gesture``: listener: (Event -> float -> unit) -> BrowserWindow
        [<Emit "$0.addListener('rotate-gesture',$1)">] abstract ``addListener_rotate-gesture``: listener: (Event -> float -> unit) -> BrowserWindow
        [<Emit "$0.removeListener('rotate-gesture',$1)">] abstract ``removeListener_rotate-gesture``: listener: (Event -> float -> unit) -> BrowserWindow
        /// <summary>Emitted when scroll wheel event phase has begun.</summary>
        [<Emit "$0.on('scroll-touch-begin',$1)">] abstract ``on_scroll-touch-begin``: listener: Function -> BrowserWindow
        [<Emit "$0.once('scroll-touch-begin',$1)">] abstract ``once_scroll-touch-begin``: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('scroll-touch-begin',$1)">] abstract ``addListener_scroll-touch-begin``: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('scroll-touch-begin',$1)">] abstract ``removeListener_scroll-touch-begin``: listener: Function -> BrowserWindow
        /// <summary>Emitted when scroll wheel event phase filed upon reaching the edge of element.</summary>
        [<Emit "$0.on('scroll-touch-edge',$1)">] abstract ``on_scroll-touch-edge``: listener: Function -> BrowserWindow
        [<Emit "$0.once('scroll-touch-edge',$1)">] abstract ``once_scroll-touch-edge``: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('scroll-touch-edge',$1)">] abstract ``addListener_scroll-touch-edge``: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('scroll-touch-edge',$1)">] abstract ``removeListener_scroll-touch-edge``: listener: Function -> BrowserWindow
        /// <summary>Emitted when scroll wheel event phase has ended.</summary>
        [<Emit "$0.on('scroll-touch-end',$1)">] abstract ``on_scroll-touch-end``: listener: Function -> BrowserWindow
        [<Emit "$0.once('scroll-touch-end',$1)">] abstract ``once_scroll-touch-end``: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('scroll-touch-end',$1)">] abstract ``addListener_scroll-touch-end``: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('scroll-touch-end',$1)">] abstract ``removeListener_scroll-touch-end``: listener: Function -> BrowserWindow
        /// <summary>
        /// Emitted when window session is going to end due to force shutdown or machine
        /// restart or session log off.
        /// </summary>
        [<Emit "$0.on('session-end',$1)">] abstract ``on_session-end``: listener: Function -> BrowserWindow
        [<Emit "$0.once('session-end',$1)">] abstract ``once_session-end``: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('session-end',$1)">] abstract ``addListener_session-end``: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('session-end',$1)">] abstract ``removeListener_session-end``: listener: Function -> BrowserWindow
        /// <summary>Emitted when the window opens a sheet.</summary>
        [<Emit "$0.on('sheet-begin',$1)">] abstract ``on_sheet-begin``: listener: Function -> BrowserWindow
        [<Emit "$0.once('sheet-begin',$1)">] abstract ``once_sheet-begin``: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('sheet-begin',$1)">] abstract ``addListener_sheet-begin``: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('sheet-begin',$1)">] abstract ``removeListener_sheet-begin``: listener: Function -> BrowserWindow
        /// <summary>Emitted when the window has closed a sheet.</summary>
        [<Emit "$0.on('sheet-end',$1)">] abstract ``on_sheet-end``: listener: Function -> BrowserWindow
        [<Emit "$0.once('sheet-end',$1)">] abstract ``once_sheet-end``: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('sheet-end',$1)">] abstract ``addListener_sheet-end``: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('sheet-end',$1)">] abstract ``removeListener_sheet-end``: listener: Function -> BrowserWindow
        /// Emitted when the window is shown.
        [<Emit "$0.on('show',$1)">] abstract on_show: listener: Function -> BrowserWindow
        [<Emit "$0.once('show',$1)">] abstract once_show: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('show',$1)">] abstract addListener_show: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('show',$1)">] abstract removeListener_show: listener: Function -> BrowserWindow
        /// <summary>
        /// Emitted on 3-finger swipe. Possible directions are <c>up</c>, <c>right</c>, <c>down</c>,
        /// <c>left</c>.
        /// 
        /// The method underlying this event is built to handle older macOS-style trackpad
        /// swiping, where the content on the screen doesn't move with the swipe. Most macOS
        /// trackpads are not configured to allow this kind of swiping anymore, so in order
        /// for it to emit properly the 'Swipe between pages' preference in `System
        /// Preferences &gt; Trackpad &gt; More Gestures` must be set to 'Swipe with two or three
        /// fingers'.
        /// </summary>
        [<Emit "$0.on('swipe',$1)">] abstract on_swipe: listener: (Event -> string -> unit) -> BrowserWindow
        [<Emit "$0.once('swipe',$1)">] abstract once_swipe: listener: (Event -> string -> unit) -> BrowserWindow
        [<Emit "$0.addListener('swipe',$1)">] abstract addListener_swipe: listener: (Event -> string -> unit) -> BrowserWindow
        [<Emit "$0.removeListener('swipe',$1)">] abstract removeListener_swipe: listener: (Event -> string -> unit) -> BrowserWindow
        /// Emitted when the window exits from a maximized state.
        [<Emit "$0.on('unmaximize',$1)">] abstract on_unmaximize: listener: Function -> BrowserWindow
        [<Emit "$0.once('unmaximize',$1)">] abstract once_unmaximize: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('unmaximize',$1)">] abstract addListener_unmaximize: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('unmaximize',$1)">] abstract removeListener_unmaximize: listener: Function -> BrowserWindow
        /// Emitted when the web page becomes unresponsive.
        [<Emit "$0.on('unresponsive',$1)">] abstract on_unresponsive: listener: Function -> BrowserWindow
        [<Emit "$0.once('unresponsive',$1)">] abstract once_unresponsive: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('unresponsive',$1)">] abstract addListener_unresponsive: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('unresponsive',$1)">] abstract removeListener_unresponsive: listener: Function -> BrowserWindow
        /// <summary>
        /// Emitted before the window is moved. On Windows, calling <c>event.preventDefault()</c>
        /// will prevent the window from being moved.
        /// 
        /// Note that this is only emitted when the window is being resized manually.
        /// Resizing the window with <c>setBounds</c>/<c>setSize</c> will not emit this event.
        /// </summary>
        [<Emit "$0.on('will-move',$1)">] abstract ``on_will-move``: listener: (Event -> Rectangle -> unit) -> BrowserWindow
        [<Emit "$0.once('will-move',$1)">] abstract ``once_will-move``: listener: (Event -> Rectangle -> unit) -> BrowserWindow
        [<Emit "$0.addListener('will-move',$1)">] abstract ``addListener_will-move``: listener: (Event -> Rectangle -> unit) -> BrowserWindow
        [<Emit "$0.removeListener('will-move',$1)">] abstract ``removeListener_will-move``: listener: (Event -> Rectangle -> unit) -> BrowserWindow
        /// <summary>
        /// Emitted before the window is resized. Calling <c>event.preventDefault()</c> will
        /// prevent the window from being resized.
        /// 
        /// Note that this is only emitted when the window is being resized manually.
        /// Resizing the window with <c>setBounds</c>/<c>setSize</c> will not emit this event.
        /// </summary>
        [<Emit "$0.on('will-resize',$1)">] abstract ``on_will-resize``: listener: (Event -> Rectangle -> unit) -> BrowserWindow
        [<Emit "$0.once('will-resize',$1)">] abstract ``once_will-resize``: listener: (Event -> Rectangle -> unit) -> BrowserWindow
        [<Emit "$0.addListener('will-resize',$1)">] abstract ``addListener_will-resize``: listener: (Event -> Rectangle -> unit) -> BrowserWindow
        [<Emit "$0.removeListener('will-resize',$1)">] abstract ``removeListener_will-resize``: listener: (Event -> Rectangle -> unit) -> BrowserWindow
        /// <summary>Replacement API for setBrowserView supporting work with multi browser views.</summary>
        abstract addBrowserView: browserView: BrowserView -> unit
        /// <summary>Adds a window as a tab on this window, after the tab for the window instance.</summary>
        abstract addTabbedWindow: browserWindow: BrowserWindow -> unit
        /// Removes focus from the window.
        abstract blur: unit -> unit
        abstract blurWebView: unit -> unit
        /// <summary>
        /// Resolves with a NativeImage
        /// 
        /// Captures a snapshot of the page within <c>rect</c>. Omitting <c>rect</c> will capture the
        /// whole visible page.
        /// </summary>
        abstract capturePage: ?rect: Rectangle -> Promise<Electron.NativeImage>
        /// Moves window to the center of the screen.
        abstract center: unit -> unit
        /// Try to close the window. This has the same effect as a user manually clicking
        /// the close button of the window. The web page may cancel the close though. See
        /// the close event.
        abstract close: unit -> unit
        /// <summary>Closes the currently open Quick Look panel.</summary>
        abstract closeFilePreview: unit -> unit
        /// <summary>
        /// Force closing the window, the <c>unload</c> and <c>beforeunload</c> event won't be emitted
        /// for the web page, and <c>close</c> event will also not be emitted for this window,
        /// but it guarantees the <c>closed</c> event will be emitted.
        /// </summary>
        abstract destroy: unit -> unit
        /// Starts or stops flashing the window to attract user's attention.
        abstract flashFrame: flag: bool -> unit
        /// Focuses on the window.
        abstract focus: unit -> unit
        abstract focusOnWebView: unit -> unit
        /// <summary>Gets the background color of the window. See Setting <c>backgroundColor</c>.</summary>
        abstract getBackgroundColor: unit -> string
        /// <summary>The <c>bounds</c> of the window as <c>Object</c>.</summary>
        abstract getBounds: unit -> Rectangle
        /// <summary>
        /// The <c>BrowserView</c> attached to <c>win</c>. Returns <c>null</c> if one is not attached.
        /// Throws an error if multiple <c>BrowserView</c>s are attached.
        /// </summary>
        abstract getBrowserView: unit -> BrowserView option
        /// <summary>
        /// an array of all BrowserViews that have been attached with <c>addBrowserView</c> or
        /// <c>setBrowserView</c>.
        /// 
        /// **Note:** The BrowserView API is currently experimental and may change or be
        /// removed in future Electron releases.
        /// </summary>
        abstract getBrowserViews: unit -> ResizeArray<BrowserView>
        /// All child windows.
        abstract getChildWindows: unit -> ResizeArray<BrowserWindow>
        /// <summary>The <c>bounds</c> of the window's client area as <c>Object</c>.</summary>
        abstract getContentBounds: unit -> Rectangle
        /// Contains the window's client area's width and height.
        abstract getContentSize: unit -> ResizeArray<float>
        /// Contains the window's maximum width and height.
        abstract getMaximumSize: unit -> ResizeArray<float>
        /// <summary>
        /// Window id in the format of DesktopCapturerSource's id. For example
        /// "window:1234:0".
        /// 
        /// More precisely the format is <c>window:id:other_id</c> where <c>id</c> is <c>HWND</c> on
        /// Windows, <c>CGWindowID</c> (<c>uint64_t</c>) on macOS and <c>Window</c> (<c>unsigned long</c>) on
        /// Linux. <c>other_id</c> is used to identify web contents (tabs) so within the same top
        /// level window.
        /// </summary>
        abstract getMediaSourceId: unit -> string
        /// Contains the window's minimum width and height.
        abstract getMinimumSize: unit -> ResizeArray<float>
        /// <summary>
        /// The platform-specific handle of the window.
        /// 
        /// The native type of the handle is <c>HWND</c> on Windows, <c>NSView*</c> on macOS, and
        /// <c>Window</c> (<c>unsigned long</c>) on Linux.
        /// </summary>
        abstract getNativeWindowHandle: unit -> Buffer
        /// <summary>
        /// Contains the window bounds of the normal state
        /// 
        /// **Note:** whatever the current state of the window : maximized, minimized or in
        /// fullscreen, this function always returns the position and size of the window in
        /// normal state. In normal state, getBounds and getNormalBounds returns the same
        /// <c>Rectangle</c>.
        /// </summary>
        abstract getNormalBounds: unit -> Rectangle
        /// between 0.0 (fully transparent) and 1.0 (fully opaque). On Linux, always returns
        /// 1.
        abstract getOpacity: unit -> float
        /// The parent window.
        abstract getParentWindow: unit -> BrowserWindow
        /// Contains the window's current position.
        abstract getPosition: unit -> ResizeArray<float>
        /// <summary>The pathname of the file the window represents.</summary>
        abstract getRepresentedFilename: unit -> string
        /// Contains the window's width and height.
        abstract getSize: unit -> ResizeArray<float>
        /// The title of the native window.
        /// 
        /// **Note:** The title of the web page can be different from the title of the
        /// native window.
        abstract getTitle: unit -> string
        /// <summary>
        /// The current position for the traffic light buttons. Can only be used with
        /// <c>titleBarStyle</c> set to <c>hidden</c>.
        /// </summary>
        abstract getTrafficLightPosition: unit -> Point
        /// Whether the window has a shadow.
        abstract hasShadow: unit -> bool
        /// Hides the window.
        abstract hide: unit -> unit
        /// <summary>
        /// Hooks a windows message. The <c>callback</c> is called when the message is received
        /// in the WndProc.
        /// </summary>
        abstract hookWindowMessage: message: float * callback: (unit -> unit) -> unit
        /// Whether the window is always on top of other windows.
        abstract isAlwaysOnTop: unit -> bool
        /// <summary>
        /// Whether the window can be manually closed by user.
        /// 
        /// On Linux always returns <c>true</c>.
        /// </summary>
        abstract isClosable: unit -> bool
        /// Whether the window is destroyed.
        abstract isDestroyed: unit -> bool
        /// <summary>Whether the window's document has been edited.</summary>
        abstract isDocumentEdited: unit -> bool
        /// whether the window is enabled.
        abstract isEnabled: unit -> bool
        /// Whether the window is focused.
        abstract isFocused: unit -> bool
        /// Whether the window is in fullscreen mode.
        abstract isFullScreen: unit -> bool
        /// Whether the maximize/zoom window button toggles fullscreen mode or maximizes the
        /// window.
        abstract isFullScreenable: unit -> bool
        /// Whether the window is in kiosk mode.
        abstract isKiosk: unit -> bool
        /// <summary>
        /// Whether the window can be manually maximized by user.
        /// 
        /// On Linux always returns <c>true</c>.
        /// </summary>
        abstract isMaximizable: unit -> bool
        /// Whether the window is maximized.
        abstract isMaximized: unit -> bool
        /// Whether menu bar automatically hides itself.
        abstract isMenuBarAutoHide: unit -> bool
        /// Whether the menu bar is visible.
        abstract isMenuBarVisible: unit -> bool
        /// <summary>
        /// Whether the window can be manually minimized by the user.
        /// 
        /// On Linux always returns <c>true</c>.
        /// </summary>
        abstract isMinimizable: unit -> bool
        /// Whether the window is minimized.
        abstract isMinimized: unit -> bool
        /// Whether current window is a modal window.
        abstract isModal: unit -> bool
        /// <summary>
        /// Whether the window can be moved by user.
        /// 
        /// On Linux always returns <c>true</c>.
        /// </summary>
        abstract isMovable: unit -> bool
        /// Whether the window is in normal state (not maximized, not minimized, not in
        /// fullscreen mode).
        abstract isNormal: unit -> bool
        /// Whether the window can be manually resized by the user.
        abstract isResizable: unit -> bool
        /// <summary>Whether the window is in simple (pre-Lion) fullscreen mode.</summary>
        abstract isSimpleFullScreen: unit -> bool
        /// Whether the window is visible to the user.
        abstract isVisible: unit -> bool
        /// Whether the window is visible on all workspaces.
        /// 
        /// *Note:** This API always returns false on Windows.
        abstract isVisibleOnAllWorkspaces: unit -> bool
        /// <summary><c>true</c> or <c>false</c> depending on whether the message is hooked.</summary>
        abstract isWindowMessageHooked: message: float -> bool
        /// <summary>
        /// the promise will resolve when the page has finished loading (see
        /// <c>did-finish-load</c>), and rejects if the page fails to load (see <c>did-fail-load</c>).
        /// 
        /// Same as <c>webContents.loadFile</c>, <c>filePath</c> should be a path to an HTML file
        /// relative to the root of your application.  See the <c>webContents</c> docs for more
        /// information.
        /// </summary>
        abstract loadFile: filePath: string * ?options: LoadFileOptions -> Promise<unit>
        /// <summary>
        /// the promise will resolve when the page has finished loading (see
        /// <c>did-finish-load</c>), and rejects if the page fails to load (see <c>did-fail-load</c>).
        /// 
        /// Same as <c>webContents.loadURL(url[, options])</c>.
        /// 
        /// The <c>url</c> can be a remote address (e.g. <c>http://</c>) or a path to a local HTML
        /// file using the <c>file://</c> protocol.
        /// 
        /// To ensure that file URLs are properly formatted, it is recommended to use Node's
        /// <c>url.format</c> method:
        /// 
        /// You can load a URL using a <c>POST</c> request with URL-encoded data by doing the
        /// following:
        /// </summary>
        abstract loadURL: url: string * ?options: LoadURLOptions -> Promise<unit>
        /// Maximizes the window. This will also show (but not focus) the window if it isn't
        /// being displayed already.
        abstract maximize: unit -> unit
        /// <summary>
        /// Merges all windows into one window with multiple tabs when native tabs are
        /// enabled and there is more than one open window.
        /// </summary>
        abstract mergeAllWindows: unit -> unit
        /// Minimizes the window. On some platforms the minimized window will be shown in
        /// the Dock.
        abstract minimize: unit -> unit
        /// <summary>
        /// Moves window above the source window in the sense of z-order. If the
        /// <c>mediaSourceId</c> is not of type window or if the window does not exist then this
        /// method throws an error.
        /// </summary>
        abstract moveAbove: mediaSourceId: string -> unit
        /// <summary>
        /// Moves the current tab into a new window if native tabs are enabled and there is
        /// more than one tab in the current window.
        /// </summary>
        abstract moveTabToNewWindow: unit -> unit
        /// Moves window to top(z-order) regardless of focus
        abstract moveTop: unit -> unit
        /// <summary>Uses Quick Look to preview a file at a given path.</summary>
        abstract previewFile: path: string * ?displayName: string -> unit
        /// <summary>Same as <c>webContents.reload</c>.</summary>
        abstract reload: unit -> unit
        abstract removeBrowserView: browserView: BrowserView -> unit
        /// <summary>Remove the window's menu bar.</summary>
        abstract removeMenu: unit -> unit
        /// Restores the window from minimized state to its previous state.
        abstract restore: unit -> unit
        /// <summary>
        /// Selects the next tab when native tabs are enabled and there are other tabs in
        /// the window.
        /// </summary>
        abstract selectNextTab: unit -> unit
        /// <summary>
        /// Selects the previous tab when native tabs are enabled and there are other tabs
        /// in the window.
        /// </summary>
        abstract selectPreviousTab: unit -> unit
        /// Sets whether the window should show always on top of other windows. After
        /// setting this, the window is still a normal window, not a toolbox window which
        /// can not be focused on.
        abstract setAlwaysOnTop: flag: bool * ?level: BrowserWindowSetAlwaysOnTopLevel * ?relativeLevel: float -> unit
        /// <summary>
        /// Sets the properties for the window's taskbar button.
        /// 
        /// **Note:** <c>relaunchCommand</c> and <c>relaunchDisplayName</c> must always be set
        /// together. If one of those properties is not set, then neither will be used.
        /// </summary>
        abstract setAppDetails: options: AppDetailsOptions -> unit
        /// <summary>
        /// This will make a window maintain an aspect ratio. The extra size allows a
        /// developer to have space, specified in pixels, not included within the aspect
        /// ratio calculations. This API already takes into account the difference between a
        /// window's size and its content size.
        /// 
        /// Consider a normal window with an HD video player and associated controls.
        /// Perhaps there are 15 pixels of controls on the left edge, 25 pixels of controls
        /// on the right edge and 50 pixels of controls below the player. In order to
        /// maintain a 16:9 aspect ratio (standard aspect ratio for HD @1920x1080) within
        /// the player itself we would call this function with arguments of 16/9 and {
        /// width: 40, height: 50 }. The second argument doesn't care where the extra width
        /// and height are within the content view--only that they exist. Sum any extra
        /// width and height areas you have within the overall content view.
        /// </summary>
        abstract setAspectRatio: aspectRatio: float * ?extraSize: Size -> unit
        /// <summary>Controls whether to hide cursor when typing.</summary>
        abstract setAutoHideCursor: autoHide: bool -> unit
        /// <summary>
        /// Sets whether the window menu bar should hide itself automatically. Once set the
        /// menu bar will only show when users press the single <c>Alt</c> key.
        /// 
        /// If the menu bar is already visible, calling <c>setAutoHideMenuBar(true)</c> won't
        /// hide it immediately.
        /// </summary>
        abstract setAutoHideMenuBar: hide: bool -> unit
        /// <summary>Sets the background color of the window. See Setting <c>backgroundColor</c>.</summary>
        abstract setBackgroundColor: backgroundColor: string -> unit
        /// Resizes and moves the window to the supplied bounds. Any properties that are not
        /// supplied will default to their current values.
        abstract setBounds: bounds: obj * ?animate: bool -> unit
        abstract setBrowserView: browserView: BrowserView option -> unit
        /// <summary>Sets whether the window can be manually closed by user. On Linux does nothing.</summary>
        abstract setClosable: closable: bool -> unit
        /// Resizes and moves the window's client area (e.g. the web page) to the supplied
        /// bounds.
        abstract setContentBounds: bounds: Rectangle * ?animate: bool -> unit
        /// <summary>
        /// Prevents the window contents from being captured by other apps.
        /// 
        /// On macOS it sets the NSWindow's sharingType to NSWindowSharingNone. On Windows
        /// it calls SetWindowDisplayAffinity with <c>WDA_MONITOR</c>.
        /// </summary>
        abstract setContentProtection: enable: bool -> unit
        /// <summary>Resizes the window's client area (e.g. the web page) to <c>width</c> and <c>height</c>.</summary>
        abstract setContentSize: width: float * height: float * ?animate: bool -> unit
        /// <summary>
        /// Specifies whether the window’s document has been edited, and the icon in title
        /// bar will become gray when set to <c>true</c>.
        /// </summary>
        abstract setDocumentEdited: edited: bool -> unit
        /// Disable or enable the window.
        abstract setEnabled: enable: bool -> unit
        /// <summary>
        /// Changes whether the window can be focused.
        /// 
        /// On macOS it does not remove the focus from the window.
        /// </summary>
        abstract setFocusable: focusable: bool -> unit
        /// Sets whether the window should be in fullscreen mode.
        abstract setFullScreen: flag: bool -> unit
        /// Sets whether the maximize/zoom window button toggles fullscreen mode or
        /// maximizes the window.
        abstract setFullScreenable: fullscreenable: bool -> unit
        /// Sets whether the window should have a shadow.
        abstract setHasShadow: hasShadow: bool -> unit
        /// <summary>Changes window icon.</summary>
        abstract setIcon: icon: U2<NativeImage, string> -> unit
        /// Makes the window ignore all mouse events.
        /// 
        /// All mouse events happened in this window will be passed to the window below this
        /// window, but if this window has focus, it will still receive keyboard events.
        abstract setIgnoreMouseEvents: ignore: bool * ?options: IgnoreMouseEventsOptions -> unit
        /// Enters or leaves kiosk mode.
        abstract setKiosk: flag: bool -> unit
        /// <summary>
        /// Sets whether the window can be manually maximized by user. On Linux does
        /// nothing.
        /// </summary>
        abstract setMaximizable: maximizable: bool -> unit
        /// <summary>Sets the maximum size of window to <c>width</c> and <c>height</c>.</summary>
        abstract setMaximumSize: width: float * height: float -> unit
        /// <summary>Sets the <c>menu</c> as the window's menu bar.</summary>
        abstract setMenu: menu: Menu option -> unit
        /// <summary>
        /// Sets whether the menu bar should be visible. If the menu bar is auto-hide, users
        /// can still bring up the menu bar by pressing the single <c>Alt</c> key.
        /// </summary>
        abstract setMenuBarVisibility: visible: bool -> unit
        /// <summary>
        /// Sets whether the window can be manually minimized by user. On Linux does
        /// nothing.
        /// </summary>
        abstract setMinimizable: minimizable: bool -> unit
        /// <summary>Sets the minimum size of window to <c>width</c> and <c>height</c>.</summary>
        abstract setMinimumSize: width: float * height: float -> unit
        /// <summary>Sets whether the window can be moved by user. On Linux does nothing.</summary>
        abstract setMovable: movable: bool -> unit
        /// <summary>
        /// Sets the opacity of the window. On Linux, does nothing. Out of bound number
        /// values are clamped to the [0, 1] range.
        /// </summary>
        abstract setOpacity: opacity: float -> unit
        /// <summary>
        /// Sets a 16 x 16 pixel overlay onto the current taskbar icon, usually used to
        /// convey some sort of application status or to passively notify the user.
        /// </summary>
        abstract setOverlayIcon: overlay: NativeImage option * description: string -> unit
        /// <summary>
        /// Sets <c>parent</c> as current window's parent window, passing <c>null</c> will turn
        /// current window into a top-level window.
        /// </summary>
        abstract setParentWindow: parent: BrowserWindow option -> unit
        /// <summary>Moves window to <c>x</c> and <c>y</c>.</summary>
        abstract setPosition: x: float * y: float * ?animate: bool -> unit
        /// <summary>
        /// Sets progress value in progress bar. Valid range is [0, 1.0].
        /// 
        /// Remove progress bar when progress &lt; 0; Change to indeterminate mode when
        /// progress &gt; 1.
        /// 
        /// On Linux platform, only supports Unity desktop environment, you need to specify
        /// the <c>*.desktop</c> file name to <c>desktopName</c> field in <c>package.json</c>. By default,
        /// it will assume <c>{app.name}.desktop</c>.
        /// 
        /// On Windows, a mode can be passed. Accepted values are <c>none</c>, <c>normal</c>,
        /// <c>indeterminate</c>, <c>error</c>, and <c>paused</c>. If you call <c>setProgressBar</c> without a
        /// mode set (but with a value within the valid range), <c>normal</c> will be assumed.
        /// </summary>
        abstract setProgressBar: progress: float * ?options: ProgressBarOptions -> unit
        /// <summary>
        /// Sets the pathname of the file the window represents, and the icon of the file
        /// will show in window's title bar.
        /// </summary>
        abstract setRepresentedFilename: filename: string -> unit
        /// Sets whether the window can be manually resized by the user.
        abstract setResizable: resizable: bool -> unit
        /// <summary>
        /// Setting a window shape determines the area within the window where the system
        /// permits drawing and user interaction. Outside of the given region, no pixels
        /// will be drawn and no mouse events will be registered. Mouse events outside of
        /// the region will not be received by that window, but will fall through to
        /// whatever is behind the window.
        /// </summary>
        abstract setShape: rects: ResizeArray<Rectangle> -> unit
        /// <summary>
        /// Changes the attachment point for sheets on macOS. By default, sheets are
        /// attached just below the window frame, but you may want to display them beneath a
        /// HTML-rendered toolbar. For example:
        /// </summary>
        abstract setSheetOffset: offsetY: float * ?offsetX: float -> unit
        /// <summary>
        /// Enters or leaves simple fullscreen mode.
        /// 
        /// Simple fullscreen mode emulates the native fullscreen behavior found in versions
        /// of macOS prior to Lion (10.7).
        /// </summary>
        abstract setSimpleFullScreen: flag: bool -> unit
        /// <summary>
        /// Resizes the window to <c>width</c> and <c>height</c>. If <c>width</c> or <c>height</c> are below any
        /// set minimum size constraints the window will snap to its minimum size.
        /// </summary>
        abstract setSize: width: float * height: float * ?animate: bool -> unit
        /// Makes the window not show in the taskbar.
        abstract setSkipTaskbar: skip: bool -> unit
        /// <summary>
        /// Whether the buttons were added successfully
        /// 
        /// Add a thumbnail toolbar with a specified set of buttons to the thumbnail image
        /// of a window in a taskbar button layout. Returns a <c>Boolean</c> object indicates
        /// whether the thumbnail has been added successfully.
        /// 
        /// The number of buttons in thumbnail toolbar should be no greater than 7 due to
        /// the limited room. Once you setup the thumbnail toolbar, the toolbar cannot be
        /// removed due to the platform's limitation. But you can call the API with an empty
        /// array to clean the buttons.
        /// 
        /// The <c>buttons</c> is an array of <c>Button</c> objects:
        /// 
        /// * <c>Button</c> Object
        ///    * <c>icon</c> NativeImage - The icon showing in thumbnail toolbar.
        ///    * <c>click</c> Function
        ///    * <c>tooltip</c> String (optional) - The text of the button's tooltip.
        ///    * <c>flags</c> String[] (optional) - Control specific states and behaviors of the
        /// button. By default, it is <c>['enabled']</c>.
        /// 
        /// The <c>flags</c> is an array that can include following <c>String</c>s:
        /// 
        /// * <c>enabled</c> - The button is active and available to the user.
        /// * <c>disabled</c> - The button is disabled. It is present, but has a visual state
        /// indicating it will not respond to user action.
        /// * <c>dismissonclick</c> - When the button is clicked, the thumbnail window closes
        /// immediately.
        /// * <c>nobackground</c> - Do not draw a button border, use only the image.
        /// * <c>hidden</c> - The button is not shown to the user.
        /// * <c>noninteractive</c> - The button is enabled but not interactive; no pressed
        /// button state is drawn. This value is intended for instances where the button is
        /// used in a notification.
        /// </summary>
        abstract setThumbarButtons: buttons: ResizeArray<ThumbarButton> -> bool
        /// <summary>
        /// Sets the region of the window to show as the thumbnail image displayed when
        /// hovering over the window in the taskbar. You can reset the thumbnail to be the
        /// entire window by specifying an empty region: `{ x: 0, y: 0, width: 0, height: 0
        /// }`.
        /// </summary>
        abstract setThumbnailClip: region: Rectangle -> unit
        /// <summary>
        /// Sets the toolTip that is displayed when hovering over the window thumbnail in
        /// the taskbar.
        /// </summary>
        abstract setThumbnailToolTip: toolTip: string -> unit
        /// <summary>Changes the title of native window to <c>title</c>.</summary>
        abstract setTitle: title: string -> unit
        /// <summary>
        /// Sets the touchBar layout for the current window. Specifying <c>null</c> or
        /// <c>undefined</c> clears the touch bar. This method only has an effect if the machine
        /// has a touch bar and is running on macOS 10.12.1+.
        /// 
        /// **Note:** The TouchBar API is currently experimental and may change or be
        /// removed in future Electron releases.
        /// </summary>
        abstract setTouchBar: touchBar: TouchBar option -> unit
        /// <summary>
        /// Set a custom position for the traffic light buttons. Can only be used with
        /// <c>titleBarStyle</c> set to <c>hidden</c>.
        /// </summary>
        abstract setTrafficLightPosition: position: Point -> unit
        /// <summary>
        /// Adds a vibrancy effect to the browser window. Passing <c>null</c> or an empty string
        /// will remove the vibrancy effect on the window.
        /// 
        /// Note that <c>appearance-based</c>, <c>light</c>, <c>dark</c>, <c>medium-light</c>, and <c>ultra-dark</c>
        /// have been deprecated and will be removed in an upcoming version of macOS.
        /// </summary>
        abstract setVibrancy: ``type``: BrowserWindowSetVibrancy option -> unit
        /// Sets whether the window should be visible on all workspaces.
        /// 
        /// *Note:** This API does nothing on Windows.
        abstract setVisibleOnAllWorkspaces: visible: bool * ?options: VisibleOnAllWorkspacesOptions -> unit
        /// <summary>
        /// Sets whether the window traffic light buttons should be visible.
        /// 
        /// This cannot be called when <c>titleBarStyle</c> is set to <c>customButtonsOnHover</c>.
        /// </summary>
        abstract setWindowButtonVisibility: visible: bool -> unit
        /// Shows and gives focus to the window.
        abstract show: unit -> unit
        /// <summary>Same as <c>webContents.showDefinitionForSelection()</c>.</summary>
        abstract showDefinitionForSelection: unit -> unit
        /// Shows the window but doesn't focus on it.
        abstract showInactive: unit -> unit
        /// <summary>
        /// Toggles the visibility of the tab bar if native tabs are enabled and there is
        /// only one tab in the current window.
        /// </summary>
        abstract toggleTabBar: unit -> unit
        /// <summary>Unhooks all of the window messages.</summary>
        abstract unhookAllWindowMessages: unit -> unit
        /// <summary>Unhook the window message.</summary>
        abstract unhookWindowMessage: message: float -> unit
        /// Unmaximizes the window.
        abstract unmaximize: unit -> unit
        abstract accessibleTitle: string with get, set
        abstract autoHideMenuBar: bool with get, set
        abstract closable: bool with get, set
        abstract documentEdited: bool with get, set
        abstract excludedFromShownWindowsMenu: bool with get, set
        abstract fullScreen: bool with get, set
        abstract fullScreenable: bool with get, set
        abstract id: float
        abstract kiosk: bool with get, set
        abstract maximizable: bool with get, set
        abstract menuBarVisible: bool with get, set
        abstract minimizable: bool with get, set
        abstract movable: bool with get, set
        abstract representedFilename: string with get, set
        abstract resizable: bool with get, set
        abstract shadow: bool with get, set
        abstract simpleFullScreen: bool with get, set
        abstract title: string with get, set
        abstract visibleOnAllWorkspaces: bool with get, set
        abstract webContents: WebContents

    type [<StringEnum>] [<RequireQualifiedAccess>] BrowserWindowSetAlwaysOnTopLevel =
        | Normal
        | Floating
        | [<CompiledName "torn-off-menu">] TornOffMenu
        | [<CompiledName "modal-panel">] ModalPanel
        | [<CompiledName "main-menu">] MainMenu
        | Status
        | [<CompiledName "pop-up-menu">] PopUpMenu
        | [<CompiledName "screen-saver">] ScreenSaver

    type [<AllowNullLiteral>] BrowserWindowStatic =
        /// BrowserWindow
        [<EmitConstructor>] abstract Create: ?options: BrowserWindowConstructorOptions -> BrowserWindow
        /// <summary>
        /// Adds DevTools extension located at <c>path</c>, and returns extension's name.
        /// 
        /// The extension will be remembered so you only need to call this API once, this
        /// API is not for programming use. If you try to add an extension that has already
        /// been loaded, this method will not return and instead log a warning to the
        /// console.
        /// 
        /// The method will also not return if the extension's manifest is missing or
        /// incomplete.
        /// 
        /// **Note:** This API cannot be called before the <c>ready</c> event of the <c>app</c> module
        /// is emitted.
        /// 
        /// *Note:** This method is deprecated. Instead, use <c>ses.loadExtension(path)</c>.
        /// </summary>
        [<Obsolete("")>]
        abstract addDevToolsExtension: path: string -> unit
        /// <summary>
        /// Adds Chrome extension located at <c>path</c>, and returns extension's name.
        /// 
        /// The method will also not return if the extension's manifest is missing or
        /// incomplete.
        /// 
        /// **Note:** This API cannot be called before the <c>ready</c> event of the <c>app</c> module
        /// is emitted.
        /// 
        /// *Note:** This method is deprecated. Instead, use <c>ses.loadExtension(path)</c>.
        /// </summary>
        [<Obsolete("")>]
        abstract addExtension: path: string -> unit
        /// <summary>
        /// The window that owns the given <c>browserView</c>. If the given view is not attached
        /// to any window, returns <c>null</c>.
        /// </summary>
        abstract fromBrowserView: browserView: BrowserView -> BrowserWindow option
        /// <summary>The window with the given <c>id</c>.</summary>
        abstract fromId: id: float -> BrowserWindow
        /// <summary>
        /// The window that owns the given <c>webContents</c> or <c>null</c> if the contents are not
        /// owned by a window.
        /// </summary>
        abstract fromWebContents: webContents: WebContents -> BrowserWindow option
        /// An array of all opened browser windows.
        abstract getAllWindows: unit -> ResizeArray<BrowserWindow>
        /// <summary>
        /// The keys are the extension names and each value is an Object containing <c>name</c>
        /// and <c>version</c> properties.
        /// 
        /// To check if a DevTools extension is installed you can run the following:
        /// 
        /// **Note:** This API cannot be called before the <c>ready</c> event of the <c>app</c> module
        /// is emitted.
        /// 
        /// *Note:** This method is deprecated. Instead, use <c>ses.getAllExtensions()</c>.
        /// </summary>
        [<Obsolete("")>]
        abstract getDevToolsExtensions: unit -> Record<string, ExtensionInfo>
        /// <summary>
        /// The keys are the extension names and each value is an Object containing <c>name</c>
        /// and <c>version</c> properties.
        /// 
        /// **Note:** This API cannot be called before the <c>ready</c> event of the <c>app</c> module
        /// is emitted.
        /// 
        /// *Note:** This method is deprecated. Instead, use <c>ses.getAllExtensions()</c>.
        /// </summary>
        [<Obsolete("")>]
        abstract getExtensions: unit -> Record<string, ExtensionInfo>
        /// <summary>The window that is focused in this application, otherwise returns <c>null</c>.</summary>
        abstract getFocusedWindow: unit -> BrowserWindow option
        /// <summary>
        /// Remove a DevTools extension by name.
        /// 
        /// **Note:** This API cannot be called before the <c>ready</c> event of the <c>app</c> module
        /// is emitted.
        /// 
        /// **Note:** This method is deprecated. Instead, use
        /// <c>ses.removeExtension(extension_id)</c>.
        /// </summary>
        [<Obsolete("")>]
        abstract removeDevToolsExtension: name: string -> unit
        /// <summary>
        /// Remove a Chrome extension by name.
        /// 
        /// **Note:** This API cannot be called before the <c>ready</c> event of the <c>app</c> module
        /// is emitted.
        /// 
        /// **Note:** This method is deprecated. Instead, use
        /// <c>ses.removeExtension(extension_id)</c>.
        /// </summary>
        [<Obsolete("")>]
        abstract removeExtension: name: string -> unit

    type [<AllowNullLiteral>] BrowserWindowProxy =
        /// Removes focus from the child window.
        abstract blur: unit -> unit
        /// Forcefully closes the child window without calling its unload event.
        abstract close: unit -> unit
        /// Evaluates the code in the child window.
        abstract eval: code: string -> unit
        /// Focuses the child window (brings the window to front).
        abstract focus: unit -> unit
        /// <summary>
        /// Sends a message to the child window with the specified origin or <c>*</c> for no
        /// origin preference.
        /// 
        /// In addition to these methods, the child window implements <c>window.opener</c> object
        /// with no properties and a single method.
        /// </summary>
        abstract postMessage: message: obj option * targetOrigin: string -> unit
        /// Invokes the print dialog on the child window.
        abstract print: unit -> unit
        abstract closed: bool with get, set

    type [<AllowNullLiteral>] BrowserWindowProxyStatic =
        [<EmitConstructor>] abstract Create: unit -> BrowserWindowProxy

    type [<AllowNullLiteral>] Certificate =
        /// PEM encoded data
        abstract data: string with get, set
        /// Fingerprint of the certificate
        abstract fingerprint: string with get, set
        /// Issuer principal
        abstract issuer: CertificatePrincipal with get, set
        /// Issuer certificate (if not self-signed)
        abstract issuerCert: Certificate with get, set
        /// Issuer's Common Name
        abstract issuerName: string with get, set
        /// Hex value represented string
        abstract serialNumber: string with get, set
        /// Subject principal
        abstract subject: CertificatePrincipal with get, set
        /// Subject's Common Name
        abstract subjectName: string with get, set
        /// End date of the certificate being valid in seconds
        abstract validExpiry: float with get, set
        /// Start date of the certificate being valid in seconds
        abstract validStart: float with get, set

    type [<AllowNullLiteral>] CertificatePrincipal =
        /// Common Name.
        abstract commonName: string with get, set
        /// Country or region.
        abstract country: string with get, set
        /// Locality.
        abstract locality: string with get, set
        /// Organization names.
        abstract organizations: ResizeArray<string> with get, set
        /// Organization Unit names.
        abstract organizationUnits: ResizeArray<string> with get, set
        /// State or province.
        abstract state: string with get, set

    type [<AllowNullLiteral>] ClientRequest =
        inherit NodeJS.EventEmitter
        /// <summary>
        /// Emitted when the <c>request</c> is aborted. The <c>abort</c> event will not be fired if
        /// the <c>request</c> is already closed.
        /// </summary>
        [<Emit "$0.on('abort',$1)">] abstract on_abort: listener: Function -> ClientRequest
        [<Emit "$0.once('abort',$1)">] abstract once_abort: listener: Function -> ClientRequest
        [<Emit "$0.addListener('abort',$1)">] abstract addListener_abort: listener: Function -> ClientRequest
        [<Emit "$0.removeListener('abort',$1)">] abstract removeListener_abort: listener: Function -> ClientRequest
        /// <summary>
        /// Emitted as the last event in the HTTP request-response transaction. The <c>close</c>
        /// event indicates that no more events will be emitted on either the <c>request</c> or
        /// <c>response</c> objects.
        /// </summary>
        [<Emit "$0.on('close',$1)">] abstract on_close: listener: Function -> ClientRequest
        [<Emit "$0.once('close',$1)">] abstract once_close: listener: Function -> ClientRequest
        [<Emit "$0.addListener('close',$1)">] abstract addListener_close: listener: Function -> ClientRequest
        [<Emit "$0.removeListener('close',$1)">] abstract removeListener_close: listener: Function -> ClientRequest
        /// <summary>
        /// Emitted when the <c>net</c> module fails to issue a network request. Typically when
        /// the <c>request</c> object emits an <c>error</c> event, a <c>close</c> event will subsequently
        /// follow and no response object will be provided.
        /// </summary>
        [<Emit "$0.on('error',$1)">] abstract on_error: listener: (Error -> unit) -> ClientRequest
        [<Emit "$0.once('error',$1)">] abstract once_error: listener: (Error -> unit) -> ClientRequest
        [<Emit "$0.addListener('error',$1)">] abstract addListener_error: listener: (Error -> unit) -> ClientRequest
        [<Emit "$0.removeListener('error',$1)">] abstract removeListener_error: listener: (Error -> unit) -> ClientRequest
        /// <summary>
        /// Emitted just after the last chunk of the <c>request</c>'s data has been written into
        /// the <c>request</c> object.
        /// </summary>
        [<Emit "$0.on('finish',$1)">] abstract on_finish: listener: Function -> ClientRequest
        [<Emit "$0.once('finish',$1)">] abstract once_finish: listener: Function -> ClientRequest
        [<Emit "$0.addListener('finish',$1)">] abstract addListener_finish: listener: Function -> ClientRequest
        [<Emit "$0.removeListener('finish',$1)">] abstract removeListener_finish: listener: Function -> ClientRequest
        /// <summary>
        /// Emitted when an authenticating proxy is asking for user credentials.
        /// 
        /// The <c>callback</c> function is expected to be called back with user credentials:
        /// 
        /// * <c>username</c> String
        /// * <c>password</c> String
        /// 
        /// Providing empty credentials will cancel the request and report an authentication
        /// error on the response object:
        /// </summary>
        [<Emit "$0.on('login',$1)">] abstract on_login: listener: (AuthInfo -> ((string) option -> (string) option -> unit) -> unit) -> ClientRequest
        [<Emit "$0.once('login',$1)">] abstract once_login: listener: (AuthInfo -> ((string) option -> (string) option -> unit) -> unit) -> ClientRequest
        [<Emit "$0.addListener('login',$1)">] abstract addListener_login: listener: (AuthInfo -> ((string) option -> (string) option -> unit) -> unit) -> ClientRequest
        [<Emit "$0.removeListener('login',$1)">] abstract removeListener_login: listener: (AuthInfo -> ((string) option -> (string) option -> unit) -> unit) -> ClientRequest
        /// <summary>
        /// Emitted when the server returns a redirect response (e.g. 301 Moved
        /// Permanently). Calling <c>request.followRedirect</c> will continue with the
        /// redirection.  If this event is handled, <c>request.followRedirect</c> must be called
        /// **synchronously**, otherwise the request will be cancelled.
        /// </summary>
        [<Emit "$0.on('redirect',$1)">] abstract on_redirect: listener: (float -> string -> string -> Record<string, ResizeArray<string>> -> unit) -> ClientRequest
        [<Emit "$0.once('redirect',$1)">] abstract once_redirect: listener: (float -> string -> string -> Record<string, ResizeArray<string>> -> unit) -> ClientRequest
        [<Emit "$0.addListener('redirect',$1)">] abstract addListener_redirect: listener: (float -> string -> string -> Record<string, ResizeArray<string>> -> unit) -> ClientRequest
        [<Emit "$0.removeListener('redirect',$1)">] abstract removeListener_redirect: listener: (float -> string -> string -> Record<string, ResizeArray<string>> -> unit) -> ClientRequest
        [<Emit "$0.on('response',$1)">] abstract on_response: listener: (IncomingMessage -> unit) -> ClientRequest
        [<Emit "$0.once('response',$1)">] abstract once_response: listener: (IncomingMessage -> unit) -> ClientRequest
        [<Emit "$0.addListener('response',$1)">] abstract addListener_response: listener: (IncomingMessage -> unit) -> ClientRequest
        [<Emit "$0.removeListener('response',$1)">] abstract removeListener_response: listener: (IncomingMessage -> unit) -> ClientRequest
        /// <summary>
        /// Cancels an ongoing HTTP transaction. If the request has already emitted the
        /// <c>close</c> event, the abort operation will have no effect. Otherwise an ongoing
        /// event will emit <c>abort</c> and <c>close</c> events. Additionally, if there is an ongoing
        /// response object,it will emit the <c>aborted</c> event.
        /// </summary>
        abstract abort: unit -> unit
        /// <summary>
        /// Sends the last chunk of the request data. Subsequent write or end operations
        /// will not be allowed. The <c>finish</c> event is emitted just after the end operation.
        /// </summary>
        abstract ``end``: ?chunk: U2<string, Buffer> * ?encoding: string * ?callback: (unit -> unit) -> unit
        /// <summary>
        /// Continues any pending redirection. Can only be called during a <c>'redirect'</c>
        /// event.
        /// </summary>
        abstract followRedirect: unit -> unit
        /// The value of a previously set extra header name.
        abstract getHeader: name: string -> string
        /// <summary>
        /// * <c>active</c> Boolean - Whether the request is currently active. If this is false
        /// no other properties will be set
        /// * <c>started</c> Boolean - Whether the upload has started. If this is false both
        /// <c>current</c> and <c>total</c> will be set to 0.
        /// * <c>current</c> Integer - The number of bytes that have been uploaded so far
        /// * <c>total</c> Integer - The number of bytes that will be uploaded this request
        /// 
        /// You can use this method in conjunction with <c>POST</c> requests to get the progress
        /// of a file upload or other data transfer.
        /// </summary>
        abstract getUploadProgress: unit -> UploadProgress
        /// Removes a previously set extra header name. This method can be called only
        /// before first write. Trying to call it after the first write will throw an error.
        abstract removeHeader: name: string -> unit
        /// <summary>
        /// Adds an extra HTTP header. The header name will be issued as-is without
        /// lowercasing. It can be called only before first write. Calling this method after
        /// the first write will throw an error. If the passed value is not a <c>String</c>, its
        /// <c>toString()</c> method will be called to obtain the final value.
        /// </summary>
        abstract setHeader: name: string * value: string -> unit
        /// <summary>
        /// <c>callback</c> is essentially a dummy function introduced in the purpose of keeping
        /// similarity with the Node.js API. It is called asynchronously in the next tick
        /// after <c>chunk</c> content have been delivered to the Chromium networking layer.
        /// Contrary to the Node.js implementation, it is not guaranteed that <c>chunk</c>
        /// content have been flushed on the wire before <c>callback</c> is called.
        /// 
        /// Adds a chunk of data to the request body. The first write operation may cause
        /// the request headers to be issued on the wire. After the first write operation,
        /// it is not allowed to add or remove a custom header.
        /// </summary>
        abstract write: chunk: U2<string, Buffer> * ?encoding: string * ?callback: (unit -> unit) -> unit
        abstract chunkedEncoding: bool with get, set

    type [<AllowNullLiteral>] ClientRequestStatic =
        /// ClientRequest
        [<EmitConstructor>] abstract Create: options: U2<ClientRequestConstructorOptions, string> -> ClientRequest

    type [<AllowNullLiteral>] Clipboard =
        /// <summary>An array of supported formats for the clipboard <c>type</c>.</summary>
        abstract availableFormats: ?``type``: ClipboardAvailableFormatsType -> ResizeArray<string>
        /// Clears the clipboard content.
        abstract clear: ?``type``: ClipboardClearType -> unit
        /// <summary>Whether the clipboard supports the specified <c>format</c>.</summary>
        abstract has: format: string * ?``type``: ClipboardHasType -> bool
        /// <summary>Reads <c>format</c> type from the clipboard.</summary>
        abstract read: format: string -> string
        /// <summary>
        /// * <c>title</c> String
        /// * <c>url</c> String
        /// 
        /// Returns an Object containing <c>title</c> and <c>url</c> keys representing the bookmark in
        /// the clipboard. The <c>title</c> and <c>url</c> values will be empty strings when the
        /// bookmark is unavailable.
        /// </summary>
        abstract readBookmark: unit -> ReadBookmark
        /// <summary>Reads <c>format</c> type from the clipboard.</summary>
        abstract readBuffer: format: string -> Buffer
        /// <summary>
        /// The text on the find pasteboard, which is the pasteboard that holds information
        /// about the current state of the active application’s find panel.
        /// 
        /// This method uses synchronous IPC when called from the renderer process. The
        /// cached value is reread from the find pasteboard whenever the application is
        /// activated.
        /// </summary>
        abstract readFindText: unit -> string
        /// The content in the clipboard as markup.
        abstract readHTML: ?``type``: ClipboardReadHTMLType -> string
        /// The image content in the clipboard.
        abstract readImage: ?``type``: ClipboardReadImageType -> NativeImage
        /// The content in the clipboard as RTF.
        abstract readRTF: ?``type``: ClipboardReadRTFType -> string
        /// The content in the clipboard as plain text.
        abstract readText: ?``type``: ClipboardReadTextType -> string
        /// <summary>Writes <c>data</c> to the clipboard.</summary>
        abstract write: data: Data * ?``type``: ClipboardWriteType -> unit
        /// <summary>
        /// Writes the <c>title</c> and <c>url</c> into the clipboard as a bookmark.
        /// 
        /// **Note:** Most apps on Windows don't support pasting bookmarks into them so you
        /// can use <c>clipboard.write</c> to write both a bookmark and fallback text to the
        /// clipboard.
        /// </summary>
        abstract writeBookmark: title: string * url: string * ?``type``: ClipboardWriteBookmarkType -> unit
        /// <summary>Writes the <c>buffer</c> into the clipboard as <c>format</c>.</summary>
        abstract writeBuffer: format: string * buffer: Buffer * ?``type``: ClipboardWriteBufferType -> unit
        /// <summary>
        /// Writes the <c>text</c> into the find pasteboard (the pasteboard that holds
        /// information about the current state of the active application’s find panel) as
        /// plain text. This method uses synchronous IPC when called from the renderer
        /// process.
        /// </summary>
        abstract writeFindText: text: string -> unit
        /// <summary>Writes <c>markup</c> to the clipboard.</summary>
        abstract writeHTML: markup: string * ?``type``: ClipboardWriteHTMLType -> unit
        /// <summary>Writes <c>image</c> to the clipboard.</summary>
        abstract writeImage: image: NativeImage * ?``type``: ClipboardWriteImageType -> unit
        /// <summary>Writes the <c>text</c> into the clipboard in RTF.</summary>
        abstract writeRTF: text: string * ?``type``: ClipboardWriteRTFType -> unit
        /// <summary>Writes the <c>text</c> into the clipboard as plain text.</summary>
        abstract writeText: text: string * ?``type``: ClipboardWriteTextType -> unit

    type [<StringEnum>] [<RequireQualifiedAccess>] ClipboardAvailableFormatsType =
        | Selection
        | Clipboard

    type [<StringEnum>] [<RequireQualifiedAccess>] ClipboardClearType =
        | Selection
        | Clipboard

    type [<StringEnum>] [<RequireQualifiedAccess>] ClipboardHasType =
        | Selection
        | Clipboard

    type [<StringEnum>] [<RequireQualifiedAccess>] ClipboardReadHTMLType =
        | Selection
        | Clipboard

    type [<StringEnum>] [<RequireQualifiedAccess>] ClipboardReadImageType =
        | Selection
        | Clipboard

    type [<StringEnum>] [<RequireQualifiedAccess>] ClipboardReadRTFType =
        | Selection
        | Clipboard

    type [<StringEnum>] [<RequireQualifiedAccess>] ClipboardReadTextType =
        | Selection
        | Clipboard

    type [<StringEnum>] [<RequireQualifiedAccess>] ClipboardWriteType =
        | Selection
        | Clipboard

    type [<StringEnum>] [<RequireQualifiedAccess>] ClipboardWriteBookmarkType =
        | Selection
        | Clipboard

    type [<StringEnum>] [<RequireQualifiedAccess>] ClipboardWriteBufferType =
        | Selection
        | Clipboard

    type [<StringEnum>] [<RequireQualifiedAccess>] ClipboardWriteHTMLType =
        | Selection
        | Clipboard

    type [<StringEnum>] [<RequireQualifiedAccess>] ClipboardWriteImageType =
        | Selection
        | Clipboard

    type [<StringEnum>] [<RequireQualifiedAccess>] ClipboardWriteRTFType =
        | Selection
        | Clipboard

    type [<StringEnum>] [<RequireQualifiedAccess>] ClipboardWriteTextType =
        | Selection
        | Clipboard

    type [<AllowNullLiteral>] CommandLine =
        /// <summary>
        /// Append an argument to Chromium's command line. The argument will be quoted
        /// correctly. Switches will precede arguments regardless of appending order.
        /// 
        /// If you're appending an argument like <c>--switch=value</c>, consider using
        /// <c>appendSwitch('switch', 'value')</c> instead.
        /// 
        /// **Note:** This will not affect <c>process.argv</c>. The intended usage of this
        /// function is to control Chromium's behavior.
        /// </summary>
        abstract appendArgument: value: string -> unit
        /// <summary>
        /// Append a switch (with optional <c>value</c>) to Chromium's command line.
        /// 
        /// **Note:** This will not affect <c>process.argv</c>. The intended usage of this
        /// function is to control Chromium's behavior.
        /// </summary>
        abstract appendSwitch: the_switch: string * ?value: string -> unit
        /// The command-line switch value.
        /// 
        /// **Note:** When the switch is not present or has no value, it returns empty
        /// string.
        abstract getSwitchValue: the_switch: string -> string
        /// Whether the command-line switch is present.
        abstract hasSwitch: the_switch: string -> bool

    type [<AllowNullLiteral>] CommandLineStatic =
        [<EmitConstructor>] abstract Create: unit -> CommandLine

    type [<AllowNullLiteral>] ContentTracing =
        /// <summary>
        /// resolves with an array of category groups once all child processes have
        /// acknowledged the <c>getCategories</c> request
        /// 
        /// Get a set of category groups. The category groups can change as new code paths
        /// are reached. See also the list of built-in tracing categories.
        /// 
        /// &gt; **NOTE:** Electron adds a non-default tracing category called <c>"electron"</c>.
        /// This category can be used to capture Electron-specific tracing events.
        /// </summary>
        abstract getCategories: unit -> Promise<ResizeArray<string>>
        /// <summary>
        /// Resolves with an object containing the <c>value</c> and <c>percentage</c> of trace buffer
        /// maximum usage
        /// 
        /// * <c>value</c> Number
        /// * <c>percentage</c> Number
        /// 
        /// Get the maximum usage across processes of trace buffer as a percentage of the
        /// full state.
        /// </summary>
        abstract getTraceBufferUsage: unit -> Promise<Electron.TraceBufferUsageReturnValue>
        /// <summary>
        /// resolved once all child processes have acknowledged the <c>startRecording</c>
        /// request.
        /// 
        /// Start recording on all processes.
        /// 
        /// Recording begins immediately locally and asynchronously on child processes as
        /// soon as they receive the EnableRecording request.
        /// 
        /// If a recording is already running, the promise will be immediately resolved, as
        /// only one trace operation can be in progress at a time.
        /// </summary>
        abstract startRecording: options: U2<TraceConfig, TraceCategoriesAndOptions> -> Promise<unit>
        /// <summary>
        /// resolves with a path to a file that contains the traced data once all child
        /// processes have acknowledged the <c>stopRecording</c> request
        /// 
        /// Stop recording on all processes.
        /// 
        /// Child processes typically cache trace data and only rarely flush and send trace
        /// data back to the main process. This helps to minimize the runtime overhead of
        /// tracing since sending trace data over IPC can be an expensive operation. So, to
        /// end tracing, Chromium asynchronously asks all child processes to flush any
        /// pending trace data.
        /// 
        /// Trace data will be written into <c>resultFilePath</c>. If <c>resultFilePath</c> is empty
        /// or not provided, trace data will be written to a temporary file, and the path
        /// will be returned in the promise.
        /// </summary>
        abstract stopRecording: ?resultFilePath: string -> Promise<string>

    type [<AllowNullLiteral>] ContextBridge =
        inherit NodeJS.EventEmitter
        abstract exposeInMainWorld: apiKey: string * api: Record<string, obj option> -> unit

    type [<AllowNullLiteral>] Cookie =
        /// The domain of the cookie; this will be normalized with a preceding dot so that
        /// it's also valid for subdomains.
        abstract domain: string option with get, set
        /// The expiration date of the cookie as the number of seconds since the UNIX epoch.
        /// Not provided for session cookies.
        abstract expirationDate: float option with get, set
        /// <summary>
        /// Whether the cookie is a host-only cookie; this will only be <c>true</c> if no domain
        /// was passed.
        /// </summary>
        abstract hostOnly: bool option with get, set
        /// Whether the cookie is marked as HTTP only.
        abstract httpOnly: bool option with get, set
        /// The name of the cookie.
        abstract name: string with get, set
        /// The path of the cookie.
        abstract path: string option with get, set
        /// Whether the cookie is marked as secure.
        abstract secure: bool option with get, set
        /// Whether the cookie is a session cookie or a persistent cookie with an expiration
        /// date.
        abstract session: bool option with get, set
        /// The value of the cookie.
        abstract value: string with get, set

    type [<AllowNullLiteral>] Cookies =
        inherit NodeJS.EventEmitter
        /// Emitted when a cookie is changed because it was added, edited, removed, or
        /// expired.
        [<Emit "$0.on('changed',$1)">] abstract on_changed: listener: Function -> Cookies
        [<Emit "$0.once('changed',$1)">] abstract once_changed: listener: Function -> Cookies
        [<Emit "$0.addListener('changed',$1)">] abstract addListener_changed: listener: Function -> Cookies
        [<Emit "$0.removeListener('changed',$1)">] abstract removeListener_changed: listener: Function -> Cookies
        /// A promise which resolves when the cookie store has been flushed
        /// 
        /// Writes any unwritten cookies data to disk.
        abstract flushStore: unit -> Promise<unit>
        /// <summary>
        /// A promise which resolves an array of cookie objects.
        /// 
        /// Sends a request to get all cookies matching <c>filter</c>, and resolves a promise
        /// with the response.
        /// </summary>
        abstract get: filter: CookiesGetFilter -> Promise<ResizeArray<Electron.Cookie>>
        /// <summary>
        /// A promise which resolves when the cookie has been removed
        /// 
        /// Removes the cookies matching <c>url</c> and <c>name</c>
        /// </summary>
        abstract remove: url: string * name: string -> Promise<unit>
        /// <summary>
        /// A promise which resolves when the cookie has been set
        /// 
        /// Sets a cookie with <c>details</c>.
        /// </summary>
        abstract set: details: CookiesSetDetails -> Promise<unit>

    type [<AllowNullLiteral>] CookiesStatic =
        [<EmitConstructor>] abstract Create: unit -> Cookies

    type [<AllowNullLiteral>] CPUUsage =
        /// The number of average idle CPU wakeups per second since the last call to
        /// getCPUUsage. First call returns 0. Will always return 0 on Windows.
        abstract idleWakeupsPerSecond: float with get, set
        /// Percentage of CPU used since the last call to getCPUUsage. First call returns 0.
        abstract percentCPUUsage: float with get, set

    type [<AllowNullLiteral>] CrashReport =
        abstract date: DateTime with get, set
        abstract id: string with get, set

    type [<AllowNullLiteral>] CrashReporter =
        /// <summary>
        /// Set an extra parameter to be sent with the crash report. The values specified
        /// here will be sent in addition to any values set via the <c>extra</c> option when
        /// <c>start</c> was called.
        /// 
        /// Parameters added in this fashion (or via the <c>extra</c> parameter to
        /// <c>crashReporter.start</c>) are specific to the calling process. Adding extra
        /// parameters in the main process will not cause those parameters to be sent along
        /// with crashes from renderer or other child processes. Similarly, adding extra
        /// parameters in a renderer process will not result in those parameters being sent
        /// with crashes that occur in other renderer processes or in the main process.
        /// 
        /// **Note:** Parameters have limits on the length of the keys and values. Key names
        /// must be no longer than 39 bytes, and values must be no longer than 20320 bytes.
        /// Keys with names longer than the maximum will be silently ignored. Key values
        /// longer than the maximum length will be truncated.
        /// 
        /// **Note:** On linux values that are longer than 127 bytes will be chunked into
        /// multiple keys, each 127 bytes in length.  E.g. `addExtraParameter('foo',
        /// 'a'.repeat(130))<c> will result in two chunked keys </c>foo__1<c> and </c>foo__2`, the
        /// first will contain the first 127 bytes and the second will contain the remaining
        /// 3 bytes.  On your crash reporting backend you should stitch together keys in
        /// this format.
        /// </summary>
        abstract addExtraParameter: key: string * value: string -> unit
        /// <summary>
        /// The directory where crashes are temporarily stored before being uploaded.
        /// 
        /// *Note:** This method is deprecated, use <c>app.getPath('crashDumps')</c> instead.
        /// </summary>
        [<Obsolete("")>]
        abstract getCrashesDirectory: unit -> string
        /// <summary>
        /// The date and ID of the last crash report. Only crash reports that have been
        /// uploaded will be returned; even if a crash report is present on disk it will not
        /// be returned until it is uploaded. In the case that there are no uploaded
        /// reports, <c>null</c> is returned.
        /// 
        /// *Note:** Calling this method from the renderer process is deprecated.
        /// </summary>
        abstract getLastCrashReport: unit -> CrashReport
        /// The current 'extra' parameters of the crash reporter.
        abstract getParameters: unit -> Record<string, string>
        /// Returns all uploaded crash reports. Each report contains the date and uploaded
        /// ID.
        /// 
        /// *Note:** Calling this method from the renderer process is deprecated.
        abstract getUploadedReports: unit -> ResizeArray<CrashReport>
        /// <summary>
        /// Whether reports should be submitted to the server. Set through the <c>start</c>
        /// method or <c>setUploadToServer</c>.
        /// 
        /// *Note:** Calling this method from the renderer process is deprecated.
        /// </summary>
        abstract getUploadToServer: unit -> bool
        /// Remove a extra parameter from the current set of parameters. Future crashes will
        /// not include this parameter.
        abstract removeExtraParameter: key: string -> unit
        /// <summary>
        /// This would normally be controlled by user preferences. This has no effect if
        /// called before <c>start</c> is called.
        /// 
        /// *Note:** Calling this method from the renderer process is deprecated.
        /// </summary>
        abstract setUploadToServer: uploadToServer: bool -> unit
        /// <summary>
        /// This method must be called before using any other <c>crashReporter</c> APIs. Once
        /// initialized this way, the crashpad handler collects crashes from all
        /// subsequently created processes. The crash reporter cannot be disabled once
        /// started.
        /// 
        /// This method should be called as early as possible in app startup, preferably
        /// before <c>app.on('ready')</c>. If the crash reporter is not initialized at the time a
        /// renderer process is created, then that renderer process will not be monitored by
        /// the crash reporter.
        /// 
        /// **Note:** You can test out the crash reporter by generating a crash using
        /// <c>process.crash()</c>.
        /// 
        /// **Note:** If you need to send additional/updated <c>extra</c> parameters after your
        /// first call <c>start</c> you can call <c>addExtraParameter</c>.
        /// 
        /// **Note:** Parameters passed in <c>extra</c>, <c>globalExtra</c> or set with
        /// <c>addExtraParameter</c> have limits on the length of the keys and values. Key names
        /// must be at most 39 bytes long, and values must be no longer than 127 bytes. Keys
        /// with names longer than the maximum will be silently ignored. Key values longer
        /// than the maximum length will be truncated.
        /// 
        /// *Note:** Calling this method from the renderer process is deprecated.
        /// </summary>
        abstract start: options: CrashReporterStartOptions -> unit

    type [<AllowNullLiteral>] CustomScheme =
        abstract privileges: Privileges option with get, set
        /// Custom schemes to be registered with options.
        abstract scheme: string with get, set

    type [<AllowNullLiteral>] Debugger =
        inherit NodeJS.EventEmitter
        /// <summary>
        /// Emitted when the debugging session is terminated. This happens either when
        /// <c>webContents</c> is closed or devtools is invoked for the attached <c>webContents</c>.
        /// </summary>
        [<Emit "$0.on('detach',$1)">] abstract on_detach: listener: (Event -> string -> unit) -> Debugger
        [<Emit "$0.once('detach',$1)">] abstract once_detach: listener: (Event -> string -> unit) -> Debugger
        [<Emit "$0.addListener('detach',$1)">] abstract addListener_detach: listener: (Event -> string -> unit) -> Debugger
        [<Emit "$0.removeListener('detach',$1)">] abstract removeListener_detach: listener: (Event -> string -> unit) -> Debugger
        /// Emitted whenever the debugging target issues an instrumentation event.
        [<Emit "$0.on('message',$1)">] abstract on_message: listener: (Event -> string -> obj option -> string -> unit) -> Debugger
        [<Emit "$0.once('message',$1)">] abstract once_message: listener: (Event -> string -> obj option -> string -> unit) -> Debugger
        [<Emit "$0.addListener('message',$1)">] abstract addListener_message: listener: (Event -> string -> obj option -> string -> unit) -> Debugger
        [<Emit "$0.removeListener('message',$1)">] abstract removeListener_message: listener: (Event -> string -> obj option -> string -> unit) -> Debugger
        /// <summary>Attaches the debugger to the <c>webContents</c>.</summary>
        abstract attach: ?protocolVersion: string -> unit
        /// <summary>Detaches the debugger from the <c>webContents</c>.</summary>
        abstract detach: unit -> unit
        /// <summary>Whether a debugger is attached to the <c>webContents</c>.</summary>
        abstract isAttached: unit -> bool
        /// A promise that resolves with the response defined by the 'returns' attribute of
        /// the command description in the remote debugging protocol or is rejected
        /// indicating the failure of the command.
        /// 
        /// Send given command to the debugging target.
        abstract sendCommand: method: string * ?commandParams: obj * ?sessionId: string -> Promise<obj option>

    type [<AllowNullLiteral>] DebuggerStatic =
        [<EmitConstructor>] abstract Create: unit -> Debugger

    type [<AllowNullLiteral>] DesktopCapturer =
        /// <summary>
        /// Resolves with an array of <c>DesktopCapturerSource</c> objects, each
        /// <c>DesktopCapturerSource</c> represents a screen or an individual window that can be
        /// captured.
        /// 
        /// **Note** Capturing the screen contents requires user consent on macOS 10.15
        /// Catalina or higher, which can detected by
        /// <c>systemPreferences.getMediaAccessStatus</c>.
        /// </summary>
        abstract getSources: options: SourcesOptions -> Promise<ResizeArray<Electron.DesktopCapturerSource>>

    type [<AllowNullLiteral>] DesktopCapturerSource =
        /// An icon image of the application that owns the window or null if the source has
        /// a type screen. The size of the icon is not known in advance and depends on what
        /// the the application provides.
        abstract appIcon: NativeImage with get, set
        /// <summary>
        /// A unique identifier that will correspond to the <c>id</c> of the matching Display
        /// returned by the Screen API. On some platforms, this is equivalent to the <c>XX</c>
        /// portion of the <c>id</c> field above and on others it will differ. It will be an
        /// empty string if not available.
        /// </summary>
        abstract display_id: string with get, set
        /// <summary>
        /// The identifier of a window or screen that can be used as a <c>chromeMediaSourceId</c>
        /// constraint when calling [<c>navigator.webkitGetUserMedia</c>]. The format of the
        /// identifier will be <c>window:XX</c> or <c>screen:XX</c>, where <c>XX</c> is a random generated
        /// number.
        /// </summary>
        abstract id: string with get, set
        /// <summary>
        /// A screen source will be named either <c>Entire Screen</c> or <c>Screen &lt;index&gt;</c>, while
        /// the name of a window source will match the window title.
        /// </summary>
        abstract name: string with get, set
        /// <summary>
        /// A thumbnail image. **Note:** There is no guarantee that the size of the
        /// thumbnail is the same as the <c>thumbnailSize</c> specified in the <c>options</c> passed
        /// to <c>desktopCapturer.getSources</c>. The actual size depends on the scale of the
        /// screen or window.
        /// </summary>
        abstract thumbnail: NativeImage with get, set

    type [<AllowNullLiteral>] Dialog =
        /// <summary>
        /// resolves when the certificate trust dialog is shown.
        /// 
        /// On macOS, this displays a modal dialog that shows a message and certificate
        /// information, and gives the user the option of trusting/importing the
        /// certificate. If you provide a <c>browserWindow</c> argument the dialog will be
        /// attached to the parent window, making it modal.
        /// 
        /// On Windows the options are more limited, due to the Win32 APIs used:
        /// 
        /// * The <c>message</c> argument is not used, as the OS provides its own confirmation
        /// dialog.
        /// * The <c>browserWindow</c> argument is ignored since it is not possible to make this
        /// confirmation dialog modal.
        /// </summary>
        abstract showCertificateTrustDialog: browserWindow: BrowserWindow * options: CertificateTrustDialogOptions -> Promise<unit>
        /// <summary>
        /// resolves when the certificate trust dialog is shown.
        /// 
        /// On macOS, this displays a modal dialog that shows a message and certificate
        /// information, and gives the user the option of trusting/importing the
        /// certificate. If you provide a <c>browserWindow</c> argument the dialog will be
        /// attached to the parent window, making it modal.
        /// 
        /// On Windows the options are more limited, due to the Win32 APIs used:
        /// 
        /// * The <c>message</c> argument is not used, as the OS provides its own confirmation
        /// dialog.
        /// * The <c>browserWindow</c> argument is ignored since it is not possible to make this
        /// confirmation dialog modal.
        /// </summary>
        abstract showCertificateTrustDialog: options: CertificateTrustDialogOptions -> Promise<unit>
        /// <summary>
        /// Displays a modal dialog that shows an error message.
        /// 
        /// This API can be called safely before the <c>ready</c> event the <c>app</c> module emits,
        /// it is usually used to report errors in early stage of startup. If called before
        /// the app <c>ready</c>event on Linux, the message will be emitted to stderr, and no GUI
        /// dialog will appear.
        /// </summary>
        abstract showErrorBox: title: string * content: string -> unit
        /// <summary>
        /// resolves with a promise containing the following properties:
        /// 
        /// * <c>response</c> Number - The index of the clicked button.
        /// * <c>checkboxChecked</c> Boolean - The checked state of the checkbox if
        /// <c>checkboxLabel</c> was set. Otherwise <c>false</c>.
        /// 
        /// Shows a message box, it will block the process until the message box is closed.
        /// 
        /// The <c>browserWindow</c> argument allows the dialog to attach itself to a parent
        /// window, making it modal.
        /// </summary>
        abstract showMessageBox: browserWindow: BrowserWindow * options: MessageBoxOptions -> Promise<Electron.MessageBoxReturnValue>
        /// <summary>
        /// resolves with a promise containing the following properties:
        /// 
        /// * <c>response</c> Number - The index of the clicked button.
        /// * <c>checkboxChecked</c> Boolean - The checked state of the checkbox if
        /// <c>checkboxLabel</c> was set. Otherwise <c>false</c>.
        /// 
        /// Shows a message box, it will block the process until the message box is closed.
        /// 
        /// The <c>browserWindow</c> argument allows the dialog to attach itself to a parent
        /// window, making it modal.
        /// </summary>
        abstract showMessageBox: options: MessageBoxOptions -> Promise<Electron.MessageBoxReturnValue>
        /// <summary>
        /// the index of the clicked button.
        /// 
        /// Shows a message box, it will block the process until the message box is closed.
        /// It returns the index of the clicked button.
        /// 
        /// The <c>browserWindow</c> argument allows the dialog to attach itself to a parent
        /// window, making it modal. If <c>browserWindow</c> is not shown dialog will not be
        /// attached to it. In such case It will be displayed as independed window.
        /// </summary>
        abstract showMessageBoxSync: browserWindow: BrowserWindow * options: MessageBoxSyncOptions -> float
        /// <summary>
        /// the index of the clicked button.
        /// 
        /// Shows a message box, it will block the process until the message box is closed.
        /// It returns the index of the clicked button.
        /// 
        /// The <c>browserWindow</c> argument allows the dialog to attach itself to a parent
        /// window, making it modal. If <c>browserWindow</c> is not shown dialog will not be
        /// attached to it. In such case It will be displayed as independed window.
        /// </summary>
        abstract showMessageBoxSync: options: MessageBoxSyncOptions -> float
        /// <summary>
        /// Resolve with an object containing the following:
        /// 
        /// * <c>canceled</c> Boolean - whether or not the dialog was canceled.
        /// * <c>filePaths</c> String[] - An array of file paths chosen by the user. If the
        /// dialog is cancelled this will be an empty array.
        /// * <c>bookmarks</c> String[] (optional) _macOS_ _mas_ - An array matching the
        /// <c>filePaths</c> array of base64 encoded strings which contains security scoped
        /// bookmark data. <c>securityScopedBookmarks</c> must be enabled for this to be
        /// populated. (For return values, see table here.)
        /// 
        /// The <c>browserWindow</c> argument allows the dialog to attach itself to a parent
        /// window, making it modal.
        /// 
        /// The <c>filters</c> specifies an array of file types that can be displayed or selected
        /// when you want to limit the user to a specific type. For example:
        /// 
        /// The <c>extensions</c> array should contain extensions without wildcards or dots (e.g.
        /// <c>'png'</c> is good but <c>'.png'</c> and <c>'*.png'</c> are bad). To show all files, use the
        /// <c>'*'</c> wildcard (no other wildcard is supported).
        /// 
        /// **Note:** On Windows and Linux an open dialog can not be both a file selector
        /// and a directory selector, so if you set <c>properties</c> to `['openFile',
        /// 'openDirectory']` on these platforms, a directory selector will be shown.
        /// </summary>
        abstract showOpenDialog: browserWindow: BrowserWindow * options: OpenDialogOptions -> Promise<Electron.OpenDialogReturnValue>
        /// <summary>
        /// Resolve with an object containing the following:
        /// 
        /// * <c>canceled</c> Boolean - whether or not the dialog was canceled.
        /// * <c>filePaths</c> String[] - An array of file paths chosen by the user. If the
        /// dialog is cancelled this will be an empty array.
        /// * <c>bookmarks</c> String[] (optional) _macOS_ _mas_ - An array matching the
        /// <c>filePaths</c> array of base64 encoded strings which contains security scoped
        /// bookmark data. <c>securityScopedBookmarks</c> must be enabled for this to be
        /// populated. (For return values, see table here.)
        /// 
        /// The <c>browserWindow</c> argument allows the dialog to attach itself to a parent
        /// window, making it modal.
        /// 
        /// The <c>filters</c> specifies an array of file types that can be displayed or selected
        /// when you want to limit the user to a specific type. For example:
        /// 
        /// The <c>extensions</c> array should contain extensions without wildcards or dots (e.g.
        /// <c>'png'</c> is good but <c>'.png'</c> and <c>'*.png'</c> are bad). To show all files, use the
        /// <c>'*'</c> wildcard (no other wildcard is supported).
        /// 
        /// **Note:** On Windows and Linux an open dialog can not be both a file selector
        /// and a directory selector, so if you set <c>properties</c> to `['openFile',
        /// 'openDirectory']` on these platforms, a directory selector will be shown.
        /// </summary>
        abstract showOpenDialog: options: OpenDialogOptions -> Promise<Electron.OpenDialogReturnValue>
        /// <summary>
        /// the file paths chosen by the user; if the dialog is cancelled it returns
        /// <c>undefined</c>.
        /// 
        /// The <c>browserWindow</c> argument allows the dialog to attach itself to a parent
        /// window, making it modal.
        /// 
        /// The <c>filters</c> specifies an array of file types that can be displayed or selected
        /// when you want to limit the user to a specific type. For example:
        /// 
        /// The <c>extensions</c> array should contain extensions without wildcards or dots (e.g.
        /// <c>'png'</c> is good but <c>'.png'</c> and <c>'*.png'</c> are bad). To show all files, use the
        /// <c>'*'</c> wildcard (no other wildcard is supported).
        /// 
        /// **Note:** On Windows and Linux an open dialog can not be both a file selector
        /// and a directory selector, so if you set <c>properties</c> to `['openFile',
        /// 'openDirectory']` on these platforms, a directory selector will be shown.
        /// </summary>
        abstract showOpenDialogSync: browserWindow: BrowserWindow * options: OpenDialogSyncOptions -> ResizeArray<string> option
        /// <summary>
        /// the file paths chosen by the user; if the dialog is cancelled it returns
        /// <c>undefined</c>.
        /// 
        /// The <c>browserWindow</c> argument allows the dialog to attach itself to a parent
        /// window, making it modal.
        /// 
        /// The <c>filters</c> specifies an array of file types that can be displayed or selected
        /// when you want to limit the user to a specific type. For example:
        /// 
        /// The <c>extensions</c> array should contain extensions without wildcards or dots (e.g.
        /// <c>'png'</c> is good but <c>'.png'</c> and <c>'*.png'</c> are bad). To show all files, use the
        /// <c>'*'</c> wildcard (no other wildcard is supported).
        /// 
        /// **Note:** On Windows and Linux an open dialog can not be both a file selector
        /// and a directory selector, so if you set <c>properties</c> to `['openFile',
        /// 'openDirectory']` on these platforms, a directory selector will be shown.
        /// </summary>
        abstract showOpenDialogSync: options: OpenDialogSyncOptions -> ResizeArray<string> option
        /// <summary>
        /// Resolve with an object containing the following:
        /// 
        /// * <c>canceled</c> Boolean - whether or not the dialog was canceled.
        /// * <c>filePath</c> String (optional) - If the dialog is canceled, this will be
        /// <c>undefined</c>.
        /// * <c>bookmark</c> String (optional) _macOS_ _mas_ - Base64 encoded string which
        /// contains the security scoped bookmark data for the saved file.
        /// <c>securityScopedBookmarks</c> must be enabled for this to be present. (For return
        /// values, see table here.)
        /// 
        /// The <c>browserWindow</c> argument allows the dialog to attach itself to a parent
        /// window, making it modal.
        /// 
        /// The <c>filters</c> specifies an array of file types that can be displayed, see
        /// <c>dialog.showOpenDialog</c> for an example.
        /// 
        /// **Note:** On macOS, using the asynchronous version is recommended to avoid
        /// issues when expanding and collapsing the dialog.
        /// </summary>
        abstract showSaveDialog: browserWindow: BrowserWindow * options: SaveDialogOptions -> Promise<Electron.SaveDialogReturnValue>
        /// <summary>
        /// Resolve with an object containing the following:
        /// 
        /// * <c>canceled</c> Boolean - whether or not the dialog was canceled.
        /// * <c>filePath</c> String (optional) - If the dialog is canceled, this will be
        /// <c>undefined</c>.
        /// * <c>bookmark</c> String (optional) _macOS_ _mas_ - Base64 encoded string which
        /// contains the security scoped bookmark data for the saved file.
        /// <c>securityScopedBookmarks</c> must be enabled for this to be present. (For return
        /// values, see table here.)
        /// 
        /// The <c>browserWindow</c> argument allows the dialog to attach itself to a parent
        /// window, making it modal.
        /// 
        /// The <c>filters</c> specifies an array of file types that can be displayed, see
        /// <c>dialog.showOpenDialog</c> for an example.
        /// 
        /// **Note:** On macOS, using the asynchronous version is recommended to avoid
        /// issues when expanding and collapsing the dialog.
        /// </summary>
        abstract showSaveDialog: options: SaveDialogOptions -> Promise<Electron.SaveDialogReturnValue>
        /// <summary>
        /// the path of the file chosen by the user; if the dialog is cancelled it returns
        /// <c>undefined</c>.
        /// 
        /// The <c>browserWindow</c> argument allows the dialog to attach itself to a parent
        /// window, making it modal.
        /// 
        /// The <c>filters</c> specifies an array of file types that can be displayed, see
        /// <c>dialog.showOpenDialog</c> for an example.
        /// </summary>
        abstract showSaveDialogSync: browserWindow: BrowserWindow * options: SaveDialogSyncOptions -> string option
        /// <summary>
        /// the path of the file chosen by the user; if the dialog is cancelled it returns
        /// <c>undefined</c>.
        /// 
        /// The <c>browserWindow</c> argument allows the dialog to attach itself to a parent
        /// window, making it modal.
        /// 
        /// The <c>filters</c> specifies an array of file types that can be displayed, see
        /// <c>dialog.showOpenDialog</c> for an example.
        /// </summary>
        abstract showSaveDialogSync: options: SaveDialogSyncOptions -> string option

    type [<AllowNullLiteral>] Display =
        /// <summary>Can be <c>available</c>, <c>unavailable</c>, <c>unknown</c>.</summary>
        abstract accelerometerSupport: DisplayAccelerometerSupport with get, set
        abstract bounds: Rectangle with get, set
        /// The number of bits per pixel.
        abstract colorDepth: float with get, set
        /// represent a color space (three-dimensional object which contains all realizable
        /// color combinations) for the purpose of color conversions
        abstract colorSpace: string with get, set
        /// The number of bits per color component.
        abstract depthPerComponent: float with get, set
        /// Unique identifier associated with the display.
        abstract id: float with get, set
        /// <summary><c>true</c> for an internal display and <c>false</c> for an external display</summary>
        abstract ``internal``: bool with get, set
        /// Whether or not the display is a monochrome display.
        abstract monochrome: bool with get, set
        /// Can be 0, 90, 180, 270, represents screen rotation in clock-wise degrees.
        abstract rotation: float with get, set
        /// Output device's pixel scale factor.
        abstract scaleFactor: float with get, set
        abstract size: Size with get, set
        /// <summary>Can be <c>available</c>, <c>unavailable</c>, <c>unknown</c>.</summary>
        abstract touchSupport: DisplayAccelerometerSupport with get, set
        abstract workArea: Rectangle with get, set
        abstract workAreaSize: Size with get, set

    type [<AllowNullLiteral>] Dock =
        /// <summary>
        /// an ID representing the request.
        /// 
        /// When <c>critical</c> is passed, the dock icon will bounce until either the
        /// application becomes active or the request is canceled.
        /// 
        /// When <c>informational</c> is passed, the dock icon will bounce for one second.
        /// However, the request remains active until either the application becomes active
        /// or the request is canceled.
        /// 
        /// **Nota Bene:** This method can only be used while the app is not focused; when
        /// the app is focused it will return -1.
        /// </summary>
        abstract bounce: ?``type``: DockBounceType -> float
        /// <summary>Cancel the bounce of <c>id</c>.</summary>
        abstract cancelBounce: id: float -> unit
        /// <summary>Bounces the Downloads stack if the filePath is inside the Downloads folder.</summary>
        abstract downloadFinished: filePath: string -> unit
        /// <summary>The badge string of the dock.</summary>
        abstract getBadge: unit -> string
        /// <summary>The application's [dock menu][dock-menu].</summary>
        abstract getMenu: unit -> Menu option
        /// <summary>Hides the dock icon.</summary>
        abstract hide: unit -> unit
        /// <summary>Whether the dock icon is visible.</summary>
        abstract isVisible: unit -> bool
        /// <summary>Sets the string to be displayed in the dock’s badging area.</summary>
        abstract setBadge: text: string -> unit
        /// <summary>Sets the <c>image</c> associated with this dock icon.</summary>
        abstract setIcon: image: U2<NativeImage, string> -> unit
        /// <summary>Sets the application's [dock menu][dock-menu].</summary>
        abstract setMenu: menu: Menu -> unit
        /// <summary>Resolves when the dock icon is shown.</summary>
        abstract show: unit -> Promise<unit>

    type [<StringEnum>] [<RequireQualifiedAccess>] DockBounceType =
        | Critical
        | Informational

    type [<AllowNullLiteral>] DockStatic =
        [<EmitConstructor>] abstract Create: unit -> Dock

    type [<AllowNullLiteral>] DownloadItem =
        inherit NodeJS.EventEmitter
        /// <summary>
        /// Emitted when the download is in a terminal state. This includes a completed
        /// download, a cancelled download (via <c>downloadItem.cancel()</c>), and interrupted
        /// download that can't be resumed.
        /// 
        /// The <c>state</c> can be one of following:
        /// 
        /// * <c>completed</c> - The download completed successfully.
        /// * <c>cancelled</c> - The download has been cancelled.
        /// * <c>interrupted</c> - The download has interrupted and can not resume.
        /// </summary>
        [<Emit "$0.on('done',$1)">] abstract on_done: listener: (Event -> DownloadItemOn_done -> unit) -> DownloadItem
        [<Emit "$0.once('done',$1)">] abstract once_done: listener: (Event -> DownloadItemOn_done -> unit) -> DownloadItem
        [<Emit "$0.addListener('done',$1)">] abstract addListener_done: listener: (Event -> DownloadItemOn_done -> unit) -> DownloadItem
        [<Emit "$0.removeListener('done',$1)">] abstract removeListener_done: listener: (Event -> DownloadItemOn_done -> unit) -> DownloadItem
        /// <summary>
        /// Emitted when the download has been updated and is not done.
        /// 
        /// The <c>state</c> can be one of following:
        /// 
        /// * <c>progressing</c> - The download is in-progress.
        /// * <c>interrupted</c> - The download has interrupted and can be resumed.
        /// </summary>
        [<Emit "$0.on('updated',$1)">] abstract on_updated: listener: (Event -> DownloadItemOn_updated -> unit) -> DownloadItem
        [<Emit "$0.once('updated',$1)">] abstract once_updated: listener: (Event -> DownloadItemOn_updated -> unit) -> DownloadItem
        [<Emit "$0.addListener('updated',$1)">] abstract addListener_updated: listener: (Event -> DownloadItemOn_updated -> unit) -> DownloadItem
        [<Emit "$0.removeListener('updated',$1)">] abstract removeListener_updated: listener: (Event -> DownloadItemOn_updated -> unit) -> DownloadItem
        /// Cancels the download operation.
        abstract cancel: unit -> unit
        /// Whether the download can resume.
        abstract canResume: unit -> bool
        /// The Content-Disposition field from the response header.
        abstract getContentDisposition: unit -> string
        /// ETag header value.
        abstract getETag: unit -> string
        /// The file name of the download item.
        /// 
        /// **Note:** The file name is not always the same as the actual one saved in local
        /// disk. If user changes the file name in a prompted download saving dialog, the
        /// actual name of saved file will be different.
        abstract getFilename: unit -> string
        /// Last-Modified header value.
        abstract getLastModifiedTime: unit -> string
        /// The files mime type.
        abstract getMimeType: unit -> string
        /// The received bytes of the download item.
        abstract getReceivedBytes: unit -> float
        /// <summary>
        /// Returns the object previously set by
        /// <c>downloadItem.setSaveDialogOptions(options)</c>.
        /// </summary>
        abstract getSaveDialogOptions: unit -> SaveDialogOptions
        /// <summary>
        /// The save path of the download item. This will be either the path set via
        /// <c>downloadItem.setSavePath(path)</c> or the path selected from the shown save
        /// dialog.
        /// </summary>
        abstract getSavePath: unit -> string
        /// Number of seconds since the UNIX epoch when the download was started.
        abstract getStartTime: unit -> float
        /// <summary>
        /// The current state. Can be <c>progressing</c>, <c>completed</c>, <c>cancelled</c> or
        /// <c>interrupted</c>.
        /// 
        /// **Note:** The following methods are useful specifically to resume a <c>cancelled</c>
        /// item when session is restarted.
        /// </summary>
        abstract getState: unit -> DownloadItemGetStateReturn
        /// The total size in bytes of the download item.
        /// 
        /// If the size is unknown, it returns 0.
        abstract getTotalBytes: unit -> float
        /// The origin URL where the item is downloaded from.
        abstract getURL: unit -> string
        /// The complete URL chain of the item including any redirects.
        abstract getURLChain: unit -> ResizeArray<string>
        /// Whether the download has user gesture.
        abstract hasUserGesture: unit -> bool
        /// Whether the download is paused.
        abstract isPaused: unit -> bool
        /// Pauses the download.
        abstract pause: unit -> unit
        /// <summary>
        /// Resumes the download that has been paused.
        /// 
        /// **Note:** To enable resumable downloads the server you are downloading from must
        /// support range requests and provide both <c>Last-Modified</c> and <c>ETag</c> header
        /// values. Otherwise <c>resume()</c> will dismiss previously received bytes and restart
        /// the download from the beginning.
        /// </summary>
        abstract resume: unit -> unit
        /// <summary>
        /// This API allows the user to set custom options for the save dialog that opens
        /// for the download item by default. The API is only available in session's
        /// <c>will-download</c> callback function.
        /// </summary>
        abstract setSaveDialogOptions: options: SaveDialogOptions -> unit
        /// <summary>
        /// The API is only available in session's <c>will-download</c> callback function. If
        /// user doesn't set the save path via the API, Electron will use the original
        /// routine to determine the save path; this usually prompts a save dialog.
        /// </summary>
        abstract setSavePath: path: string -> unit
        abstract savePath: string with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] DownloadItemGetStateReturn =
        | Progressing
        | Completed
        | Cancelled
        | Interrupted

    type [<AllowNullLiteral>] DownloadItemStatic =
        [<EmitConstructor>] abstract Create: unit -> DownloadItem

    type [<AllowNullLiteral>] Event =
        inherit GlobalEvent
        abstract preventDefault: (unit -> unit) with get, set

    type [<AllowNullLiteral>] Extension =
        abstract id: string with get, set
        /// Copy of the extension's manifest data.
        abstract manifest: obj option with get, set
        abstract name: string with get, set
        /// The extension's file path.
        abstract path: string with get, set
        /// <summary>The extension's <c>chrome-extension://</c> URL.</summary>
        abstract url: string with get, set
        abstract version: string with get, set

    type [<AllowNullLiteral>] ExtensionInfo =
        abstract name: string with get, set
        abstract version: string with get, set

    type [<AllowNullLiteral>] FileFilter =
        abstract extensions: ResizeArray<string> with get, set
        abstract name: string with get, set

    type [<AllowNullLiteral>] FilePathWithHeaders =
        /// Additional headers to be sent.
        abstract headers: Record<string, string> option with get, set
        /// The path to the file to send.
        abstract path: string with get, set

    type [<AllowNullLiteral>] GlobalShortcut =
        /// <summary>
        /// Whether this application has registered <c>accelerator</c>.
        /// 
        /// When the accelerator is already taken by other applications, this call will
        /// still return <c>false</c>. This behavior is intended by operating systems, since they
        /// don't want applications to fight for global shortcuts.
        /// </summary>
        abstract isRegistered: accelerator: Accelerator -> bool
        /// <summary>
        /// Whether or not the shortcut was registered successfully.
        /// 
        /// Registers a global shortcut of <c>accelerator</c>. The <c>callback</c> is called when the
        /// registered shortcut is pressed by the user.
        /// 
        /// When the accelerator is already taken by other applications, this call will
        /// silently fail. This behavior is intended by operating systems, since they don't
        /// want applications to fight for global shortcuts.
        /// 
        /// The following accelerators will not be registered successfully on macOS 10.14
        /// Mojave unless the app has been authorized as a trusted accessibility client:
        /// 
        /// * "Media Play/Pause"
        /// * "Media Next Track"
        /// "Media Previous Track"
        /// "Media Stop"
        /// </summary>
        abstract register: accelerator: Accelerator * callback: (unit -> unit) -> bool
        /// <summary>
        /// Registers a global shortcut of all <c>accelerator</c> items in <c>accelerators</c>. The
        /// <c>callback</c> is called when any of the registered shortcuts are pressed by the
        /// user.
        /// 
        /// When a given accelerator is already taken by other applications, this call will
        /// silently fail. This behavior is intended by operating systems, since they don't
        /// want applications to fight for global shortcuts.
        /// 
        /// The following accelerators will not be registered successfully on macOS 10.14
        /// Mojave unless the app has been authorized as a trusted accessibility client:
        /// 
        /// * "Media Play/Pause"
        /// * "Media Next Track"
        /// "Media Previous Track"
        /// "Media Stop"
        /// </summary>
        abstract registerAll: accelerators: ResizeArray<string> * callback: (unit -> unit) -> unit
        /// <summary>Unregisters the global shortcut of <c>accelerator</c>.</summary>
        abstract unregister: accelerator: Accelerator -> unit
        /// Unregisters all of the global shortcuts.
        abstract unregisterAll: unit -> unit

    type [<AllowNullLiteral>] GPUFeatureStatus =
        /// Canvas.
        abstract ``2d_canvas``: string with get, set
        /// Flash.
        abstract flash_3d: string with get, set
        /// Flash Stage3D.
        abstract flash_stage3d: string with get, set
        /// Flash Stage3D Baseline profile.
        abstract flash_stage3d_baseline: string with get, set
        /// Compositing.
        abstract gpu_compositing: string with get, set
        /// Multiple Raster Threads.
        abstract multiple_raster_threads: string with get, set
        /// Native GpuMemoryBuffers.
        abstract native_gpu_memory_buffers: string with get, set
        /// Rasterization.
        abstract rasterization: string with get, set
        /// Video Decode.
        abstract video_decode: string with get, set
        /// Video Encode.
        abstract video_encode: string with get, set
        /// VPx Video Decode.
        abstract vpx_decode: string with get, set
        /// WebGL.
        abstract webgl: string with get, set
        /// WebGL2.
        abstract webgl2: string with get, set

    type [<AllowNullLiteral>] InAppPurchase =
        inherit NodeJS.EventEmitter
        [<Emit "$0.on('transactions-updated',$1)">] abstract ``on_transactions-updated``: listener: Function -> InAppPurchase
        [<Emit "$0.once('transactions-updated',$1)">] abstract ``once_transactions-updated``: listener: Function -> InAppPurchase
        [<Emit "$0.addListener('transactions-updated',$1)">] abstract ``addListener_transactions-updated``: listener: Function -> InAppPurchase
        [<Emit "$0.removeListener('transactions-updated',$1)">] abstract ``removeListener_transactions-updated``: listener: Function -> InAppPurchase
        /// whether a user can make a payment.
        abstract canMakePayments: unit -> bool
        /// Completes all pending transactions.
        abstract finishAllTransactions: unit -> unit
        /// Completes the pending transactions corresponding to the date.
        abstract finishTransactionByDate: date: string -> unit
        /// <summary>
        /// Resolves with an array of <c>Product</c> objects.
        /// 
        /// Retrieves the product descriptions.
        /// </summary>
        abstract getProducts: productIDs: ResizeArray<string> -> Promise<ResizeArray<Electron.Product>>
        /// the path to the receipt.
        abstract getReceiptURL: unit -> string
        /// <summary>
        /// Returns <c>true</c> if the product is valid and added to the payment queue.
        /// 
        /// You should listen for the <c>transactions-updated</c> event as soon as possible and
        /// certainly before you call <c>purchaseProduct</c>.
        /// </summary>
        abstract purchaseProduct: productID: string * ?quantity: float -> Promise<bool>
        /// Restores finished transactions. This method can be called either to install
        /// purchases on additional devices, or to restore purchases for an application that
        /// the user deleted and reinstalled.
        /// 
        /// The payment queue delivers a new transaction for each previously completed
        /// transaction that can be restored. Each transaction includes a copy of the
        /// original transaction.
        abstract restoreCompletedTransactions: unit -> unit

    type [<AllowNullLiteral>] IncomingMessage =
        inherit NodeJS.EventEmitter
        /// Emitted when a request has been canceled during an ongoing HTTP transaction.
        [<Emit "$0.on('aborted',$1)">] abstract on_aborted: listener: Function -> IncomingMessage
        [<Emit "$0.once('aborted',$1)">] abstract once_aborted: listener: Function -> IncomingMessage
        [<Emit "$0.addListener('aborted',$1)">] abstract addListener_aborted: listener: Function -> IncomingMessage
        [<Emit "$0.removeListener('aborted',$1)">] abstract removeListener_aborted: listener: Function -> IncomingMessage
        /// <summary>
        /// The <c>data</c> event is the usual method of transferring response data into
        /// applicative code.
        /// </summary>
        [<Emit "$0.on('data',$1)">] abstract on_data: listener: (Buffer -> unit) -> IncomingMessage
        [<Emit "$0.once('data',$1)">] abstract once_data: listener: (Buffer -> unit) -> IncomingMessage
        [<Emit "$0.addListener('data',$1)">] abstract addListener_data: listener: (Buffer -> unit) -> IncomingMessage
        [<Emit "$0.removeListener('data',$1)">] abstract removeListener_data: listener: (Buffer -> unit) -> IncomingMessage
        /// Indicates that response body has ended.
        [<Emit "$0.on('end',$1)">] abstract on_end: listener: Function -> IncomingMessage
        [<Emit "$0.once('end',$1)">] abstract once_end: listener: Function -> IncomingMessage
        [<Emit "$0.addListener('end',$1)">] abstract addListener_end: listener: Function -> IncomingMessage
        [<Emit "$0.removeListener('end',$1)">] abstract removeListener_end: listener: Function -> IncomingMessage
        /// <summary>
        /// Returns:
        /// 
        /// <c>error</c> Error - Typically holds an error string identifying failure root cause.
        /// 
        /// Emitted when an error was encountered while streaming response data events. For
        /// instance, if the server closes the underlying while the response is still
        /// streaming, an <c>error</c> event will be emitted on the response object and a <c>close</c>
        /// event will subsequently follow on the request object.
        /// </summary>
        [<Emit "$0.on('error',$1)">] abstract on_error: listener: Function -> IncomingMessage
        [<Emit "$0.once('error',$1)">] abstract once_error: listener: Function -> IncomingMessage
        [<Emit "$0.addListener('error',$1)">] abstract addListener_error: listener: Function -> IncomingMessage
        [<Emit "$0.removeListener('error',$1)">] abstract removeListener_error: listener: Function -> IncomingMessage
        abstract headers: Record<string, ResizeArray<string>> with get, set
        abstract httpVersion: string with get, set
        abstract httpVersionMajor: float with get, set
        abstract httpVersionMinor: float with get, set
        abstract statusCode: float with get, set
        abstract statusMessage: string with get, set

    type [<AllowNullLiteral>] IncomingMessageStatic =
        [<EmitConstructor>] abstract Create: unit -> IncomingMessage

    type [<AllowNullLiteral>] InputEvent =
        /// <summary>
        /// An array of modifiers of the event, can be <c>shift</c>, <c>control</c>, <c>ctrl</c>, <c>alt</c>,
        /// <c>meta</c>, <c>command</c>, <c>cmd</c>, <c>isKeypad</c>, <c>isAutoRepeat</c>, <c>leftButtonDown</c>,
        /// <c>middleButtonDown</c>, <c>rightButtonDown</c>, <c>capsLock</c>, <c>numLock</c>, <c>left</c>, <c>right</c>.
        /// </summary>
        abstract modifiers: Array<InputEventModifiersArray> option with get, set

    type [<AllowNullLiteral>] IOCounters =
        /// Then number of I/O other operations.
        abstract otherOperationCount: float with get, set
        /// Then number of I/O other transfers.
        abstract otherTransferCount: float with get, set
        /// The number of I/O read operations.
        abstract readOperationCount: float with get, set
        /// The number of I/O read transfers.
        abstract readTransferCount: float with get, set
        /// The number of I/O write operations.
        abstract writeOperationCount: float with get, set
        /// The number of I/O write transfers.
        abstract writeTransferCount: float with get, set

    type [<AllowNullLiteral>] IpcMain =
        inherit NodeJS.EventEmitter
        /// <summary>
        /// Adds a handler for an <c>invoke</c>able IPC. This handler will be called whenever a
        /// renderer calls <c>ipcRenderer.invoke(channel, ...args)</c>.
        /// 
        /// If <c>listener</c> returns a Promise, the eventual result of the promise will be
        /// returned as a reply to the remote caller. Otherwise, the return value of the
        /// listener will be used as the value of the reply.
        /// 
        /// The <c>event</c> that is passed as the first argument to the handler is the same as
        /// that passed to a regular event listener. It includes information about which
        /// WebContents is the source of the invoke request.
        /// </summary>
        abstract handle: channel: string * listener: (IpcMainInvokeEvent -> ResizeArray<obj option> -> U2<Promise<unit>, obj option>) -> unit
        /// <summary>
        /// Handles a single <c>invoke</c>able IPC message, then removes the listener. See
        /// <c>ipcMain.handle(channel, listener)</c>.
        /// </summary>
        abstract handleOnce: channel: string * listener: (IpcMainInvokeEvent -> ResizeArray<obj option> -> U2<Promise<unit>, obj option>) -> unit
        /// <summary>
        /// Listens to <c>channel</c>, when a new message arrives <c>listener</c> would be called with
        /// <c>listener(event, args...)</c>.
        /// </summary>
        abstract on: channel: string * listener: (IpcMainEvent -> ResizeArray<obj option> -> unit) -> IpcMain
        /// <summary>
        /// Adds a one time <c>listener</c> function for the event. This <c>listener</c> is invoked
        /// only the next time a message is sent to <c>channel</c>, after which it is removed.
        /// </summary>
        abstract once: channel: string * listener: (IpcMainEvent -> ResizeArray<obj option> -> unit) -> IpcMain
        /// <summary>Removes listeners of the specified <c>channel</c>.</summary>
        abstract removeAllListeners: ?channel: string -> IpcMain
        /// <summary>Removes any handler for <c>channel</c>, if present.</summary>
        abstract removeHandler: channel: string -> unit
        /// <summary>
        /// Removes the specified <c>listener</c> from the listener array for the specified
        /// <c>channel</c>.
        /// </summary>
        abstract removeListener: channel: string * listener: (ResizeArray<obj option> -> unit) -> IpcMain

    type [<AllowNullLiteral>] IpcMainEvent =
        inherit Event
        /// The ID of the renderer frame that sent this message
        abstract frameId: float with get, set
        /// A list of MessagePorts that were transferred with this message
        abstract ports: ResizeArray<MessagePortMain> with get, set
        /// The internal ID of the renderer process that sent this message
        abstract processId: float with get, set
        /// A function that will send an IPC message to the renderer frame that sent the
        /// original message that you are currently handling.  You should use this method to
        /// "reply" to the sent message in order to guarantee the reply will go to the
        /// correct process and frame.
        abstract reply: Function with get, set
        /// Set this to the value to be returned in a synchronous message
        abstract returnValue: obj option with get, set
        /// <summary>Returns the <c>webContents</c> that sent the message</summary>
        abstract sender: WebContents with get, set

    type [<AllowNullLiteral>] IpcMainInvokeEvent =
        inherit Event
        /// The ID of the renderer frame that sent this message
        abstract frameId: float with get, set
        /// The internal ID of the renderer process that sent this message
        abstract processId: float with get, set
        /// <summary>Returns the <c>webContents</c> that sent the message</summary>
        abstract sender: WebContents with get, set

    type [<AllowNullLiteral>] IpcRenderer =
        inherit NodeJS.EventEmitter
        /// <summary>
        /// Resolves with the response from the main process.
        /// 
        /// Send a message to the main process via <c>channel</c> and expect a result
        /// asynchronously. Arguments will be serialized with the Structured Clone
        /// Algorithm, just like <c>window.postMessage</c>, so prototype chains will not be
        /// included. Sending Functions, Promises, Symbols, WeakMaps, or WeakSets will throw
        /// an exception.
        /// 
        /// &gt; **NOTE**: Sending non-standard JavaScript types such as DOM objects or special
        /// Electron objects is deprecated, and will begin throwing an exception starting
        /// with Electron 9.
        /// 
        /// The main process should listen for <c>channel</c> with <c>ipcMain.handle()</c>.
        /// 
        /// For example:
        /// 
        /// If you need to transfer a <c>MessagePort</c> to the main process, use
        /// <c>ipcRenderer.postMessage</c>.
        /// 
        /// If you do not need a respons to the message, consider using <c>ipcRenderer.send</c>.
        /// </summary>
        abstract invoke: channel: string * [<ParamArray>] args: obj option[] -> Promise<obj option>
        /// <summary>
        /// Listens to <c>channel</c>, when a new message arrives <c>listener</c> would be called with
        /// <c>listener(event, args...)</c>.
        /// </summary>
        abstract on: channel: string * listener: (IpcRendererEvent -> ResizeArray<obj option> -> unit) -> IpcRenderer
        /// <summary>
        /// Adds a one time <c>listener</c> function for the event. This <c>listener</c> is invoked
        /// only the next time a message is sent to <c>channel</c>, after which it is removed.
        /// </summary>
        abstract once: channel: string * listener: (IpcRendererEvent -> ResizeArray<obj option> -> unit) -> IpcRenderer
        /// <summary>
        /// Send a message to the main process, optionally transferring ownership of zero or
        /// more <c>MessagePort</c> objects.
        /// 
        /// The transferred <c>MessagePort</c> objects will be available in the main process as
        /// <c>MessagePortMain</c> objects by accessing the <c>ports</c> property of the emitted
        /// event.
        /// 
        /// For example:
        /// 
        /// For more information on using <c>MessagePort</c> and <c>MessageChannel</c>, see the MDN
        /// documentation.
        /// </summary>
        abstract postMessage: channel: string * message: obj option * ?transfer: ResizeArray<MessagePort> -> unit
        /// <summary>Removes all listeners, or those of the specified <c>channel</c>.</summary>
        abstract removeAllListeners: channel: string -> IpcRenderer
        /// <summary>
        /// Removes the specified <c>listener</c> from the listener array for the specified
        /// <c>channel</c>.
        /// </summary>
        abstract removeListener: channel: string * listener: (ResizeArray<obj option> -> unit) -> IpcRenderer
        /// <summary>
        /// Send an asynchronous message to the main process via <c>channel</c>, along with
        /// arguments. Arguments will be serialized with the Structured Clone Algorithm,
        /// just like <c>window.postMessage</c>, so prototype chains will not be included.
        /// Sending Functions, Promises, Symbols, WeakMaps, or WeakSets will throw an
        /// exception.
        /// 
        /// &gt; **NOTE**: Sending non-standard JavaScript types such as DOM objects or special
        /// Electron objects is deprecated, and will begin throwing an exception starting
        /// with Electron 9.
        /// 
        /// The main process handles it by listening for <c>channel</c> with the <c>ipcMain</c>
        /// module.
        /// 
        /// If you need to transfer a <c>MessagePort</c> to the main process, use
        /// <c>ipcRenderer.postMessage</c>.
        /// 
        /// If you want to receive a single response from the main process, like the result
        /// of a method call, consider using <c>ipcRenderer.invoke</c>.
        /// </summary>
        abstract send: channel: string * [<ParamArray>] args: obj option[] -> unit
        /// <summary>
        /// The value sent back by the <c>ipcMain</c> handler.
        /// 
        /// Send a message to the main process via <c>channel</c> and expect a result
        /// synchronously. Arguments will be serialized with the Structured Clone Algorithm,
        /// just like <c>window.postMessage</c>, so prototype chains will not be included.
        /// Sending Functions, Promises, Symbols, WeakMaps, or WeakSets will throw an
        /// exception.
        /// 
        /// &gt; **NOTE**: Sending non-standard JavaScript types such as DOM objects or special
        /// Electron objects is deprecated, and will begin throwing an exception starting
        /// with Electron 9.
        /// 
        /// The main process handles it by listening for <c>channel</c> with <c>ipcMain</c> module,
        /// and replies by setting <c>event.returnValue</c>.
        /// 
        /// &gt; :warning: **WARNING**: Sending a synchronous message will block the whole
        /// renderer process until the reply is received, so use this method only as a last
        /// resort. It's much better to use the asynchronous version, <c>invoke()</c>.
        /// </summary>
        abstract sendSync: channel: string * [<ParamArray>] args: obj option[] -> obj option
        /// <summary>Sends a message to a window with <c>webContentsId</c> via <c>channel</c>.</summary>
        abstract sendTo: webContentsId: float * channel: string * [<ParamArray>] args: obj option[] -> unit
        /// <summary>
        /// Like <c>ipcRenderer.send</c> but the event will be sent to the <c>&lt;webview&gt;</c> element in
        /// the host page instead of the main process.
        /// </summary>
        abstract sendToHost: channel: string * [<ParamArray>] args: obj option[] -> unit

    type [<AllowNullLiteral>] IpcRendererEvent =
        inherit Event
        /// A list of MessagePorts that were transferred with this message
        abstract ports: ResizeArray<MessagePort> with get, set
        /// <summary>The <c>IpcRenderer</c> instance that emitted the event originally</summary>
        abstract sender: IpcRenderer with get, set
        /// <summary>
        /// The <c>webContents.id</c> that sent the message, you can call
        /// <c>event.sender.sendTo(event.senderId, ...)</c> to reply to the message, see
        /// ipcRenderer.sendTo for more information. This only applies to messages sent from
        /// a different renderer. Messages sent directly from the main process set
        /// <c>event.senderId</c> to <c>0</c>.
        /// </summary>
        abstract senderId: float with get, set

    type [<AllowNullLiteral>] JumpListCategory =
        /// <summary>
        /// Array of <c>JumpListItem</c> objects if <c>type</c> is <c>tasks</c> or <c>custom</c>, otherwise it
        /// should be omitted.
        /// </summary>
        abstract items: ResizeArray<JumpListItem> option with get, set
        /// <summary>Must be set if <c>type</c> is <c>custom</c>, otherwise it should be omitted.</summary>
        abstract name: string option with get, set
        /// One of the following:
        abstract ``type``: JumpListCategoryType option with get, set

    type [<AllowNullLiteral>] JumpListItem =
        /// <summary>
        /// The command line arguments when <c>program</c> is executed. Should only be set if
        /// <c>type</c> is <c>task</c>.
        /// </summary>
        abstract args: string option with get, set
        /// <summary>
        /// Description of the task (displayed in a tooltip). Should only be set if <c>type</c>
        /// is <c>task</c>.
        /// </summary>
        abstract description: string option with get, set
        /// The index of the icon in the resource file. If a resource file contains multiple
        /// icons this value can be used to specify the zero-based index of the icon that
        /// should be displayed for this task. If a resource file contains only one icon,
        /// this property should be set to zero.
        abstract iconIndex: float option with get, set
        /// <summary>
        /// The absolute path to an icon to be displayed in a Jump List, which can be an
        /// arbitrary resource file that contains an icon (e.g. <c>.ico</c>, <c>.exe</c>, <c>.dll</c>). You
        /// can usually specify <c>process.execPath</c> to show the program icon.
        /// </summary>
        abstract iconPath: string option with get, set
        /// <summary>Path of the file to open, should only be set if <c>type</c> is <c>file</c>.</summary>
        abstract path: string option with get, set
        /// <summary>
        /// Path of the program to execute, usually you should specify <c>process.execPath</c>
        /// which opens the current program. Should only be set if <c>type</c> is <c>task</c>.
        /// </summary>
        abstract program: string option with get, set
        /// <summary>
        /// The text to be displayed for the item in the Jump List. Should only be set if
        /// <c>type</c> is <c>task</c>.
        /// </summary>
        abstract title: string option with get, set
        /// One of the following:
        abstract ``type``: JumpListItemType option with get, set
        /// The working directory. Default is empty.
        abstract workingDirectory: string option with get, set

    type [<AllowNullLiteral>] KeyboardEvent =
        inherit Event
        /// whether an Alt key was used in an accelerator to trigger the Event
        abstract altKey: bool option with get, set
        /// whether the Control key was used in an accelerator to trigger the Event
        abstract ctrlKey: bool option with get, set
        /// whether a meta key was used in an accelerator to trigger the Event
        abstract metaKey: bool option with get, set
        /// whether a Shift key was used in an accelerator to trigger the Event
        abstract shiftKey: bool option with get, set
        /// whether an accelerator was used to trigger the event as opposed to another user
        /// gesture like mouse click
        abstract triggeredByAccelerator: bool option with get, set

    type [<AllowNullLiteral>] KeyboardInputEvent =
        inherit InputEvent
        /// The character that will be sent as the keyboard event. Should only use the valid
        /// key codes in Accelerator.
        abstract keyCode: string with get, set
        /// <summary>The type of the event, can be <c>keyDown</c>, <c>keyUp</c> or <c>char</c>.</summary>
        abstract ``type``: KeyboardInputEventType with get, set

    type [<AllowNullLiteral>] MemoryInfo =
        /// The maximum amount of memory that has ever been pinned to actual physical RAM.
        abstract peakWorkingSetSize: float with get, set
        /// <summary>
        /// The amount of memory not shared by other processes, such as JS heap or HTML
        /// content.
        /// </summary>
        abstract privateBytes: float option with get, set
        /// The amount of memory currently pinned to actual physical RAM.
        abstract workingSetSize: float with get, set

    type [<AllowNullLiteral>] MemoryUsageDetails =
        abstract count: float with get, set
        abstract liveSize: float with get, set
        abstract size: float with get, set

    type [<AllowNullLiteral>] Menu =
        /// <summary>Emitted when a popup is closed either manually or with <c>menu.closePopup()</c>.</summary>
        [<Emit "$0.on('menu-will-close',$1)">] abstract ``on_menu-will-close``: listener: (Event -> unit) -> Menu
        [<Emit "$0.once('menu-will-close',$1)">] abstract ``once_menu-will-close``: listener: (Event -> unit) -> Menu
        [<Emit "$0.addListener('menu-will-close',$1)">] abstract ``addListener_menu-will-close``: listener: (Event -> unit) -> Menu
        [<Emit "$0.removeListener('menu-will-close',$1)">] abstract ``removeListener_menu-will-close``: listener: (Event -> unit) -> Menu
        /// <summary>Emitted when <c>menu.popup()</c> is called.</summary>
        [<Emit "$0.on('menu-will-show',$1)">] abstract ``on_menu-will-show``: listener: (Event -> unit) -> Menu
        [<Emit "$0.once('menu-will-show',$1)">] abstract ``once_menu-will-show``: listener: (Event -> unit) -> Menu
        [<Emit "$0.addListener('menu-will-show',$1)">] abstract ``addListener_menu-will-show``: listener: (Event -> unit) -> Menu
        [<Emit "$0.removeListener('menu-will-show',$1)">] abstract ``removeListener_menu-will-show``: listener: (Event -> unit) -> Menu
        /// <summary>Appends the <c>menuItem</c> to the menu.</summary>
        abstract append: menuItem: MenuItem -> unit
        /// <summary>Closes the context menu in the <c>browserWindow</c>.</summary>
        abstract closePopup: ?browserWindow: BrowserWindow -> unit
        /// <summary>the item with the specified <c>id</c></summary>
        abstract getMenuItemById: id: string -> MenuItem
        /// <summary>Inserts the <c>menuItem</c> to the <c>pos</c> position of the menu.</summary>
        abstract insert: pos: float * menuItem: MenuItem -> unit
        /// <summary>Pops up this menu as a context menu in the <c>BrowserWindow</c>.</summary>
        abstract popup: ?options: PopupOptions -> unit
        abstract items: ResizeArray<MenuItem> with get, set

    type [<AllowNullLiteral>] MenuStatic =
        /// Menu
        [<EmitConstructor>] abstract Create: unit -> Menu
        /// <summary>
        /// Generally, the <c>template</c> is an array of <c>options</c> for constructing a MenuItem.
        /// The usage can be referenced above.
        /// 
        /// You can also attach other fields to the element of the <c>template</c> and they will
        /// become properties of the constructed menu items.
        /// </summary>
        abstract buildFromTemplate: template: Array<U2<MenuItemConstructorOptions, MenuItem>> -> Menu
        /// <summary>
        /// The application menu, if set, or <c>null</c>, if not set.
        /// 
        /// **Note:** The returned <c>Menu</c> instance doesn't support dynamic addition or
        /// removal of menu items. Instance properties can still be dynamically modified.
        /// </summary>
        abstract getApplicationMenu: unit -> Menu option
        /// <summary>
        /// Sends the <c>action</c> to the first responder of application. This is used for
        /// emulating default macOS menu behaviors. Usually you would use the <c>role</c>
        /// property of a <c>MenuItem</c>.
        /// 
        /// See the macOS Cocoa Event Handling Guide for more information on macOS' native
        /// actions.
        /// </summary>
        abstract sendActionToFirstResponder: action: string -> unit
        /// <summary>
        /// Sets <c>menu</c> as the application menu on macOS. On Windows and Linux, the <c>menu</c>
        /// will be set as each window's top menu.
        /// 
        /// Also on Windows and Linux, you can use a <c>&amp;</c> in the top-level item name to
        /// indicate which letter should get a generated accelerator. For example, using
        /// <c>&amp;File</c> for the file menu would result in a generated <c>Alt-F</c> accelerator that
        /// opens the associated menu. The indicated character in the button label gets an
        /// underline. The <c>&amp;</c> character is not displayed on the button label.
        /// 
        /// Passing <c>null</c> will suppress the default menu. On Windows and Linux, this has
        /// the additional effect of removing the menu bar from the window.
        /// 
        /// **Note:** The default menu will be created automatically if the app does not set
        /// one. It contains standard items such as <c>File</c>, <c>Edit</c>, <c>View</c>, <c>Window</c> and
        /// <c>Help</c>.
        /// </summary>
        abstract setApplicationMenu: menu: Menu option -> unit

    type [<AllowNullLiteral>] MenuItem =
        abstract accelerator: Accelerator option with get, set
        abstract ``checked``: bool with get, set
        abstract click: Function with get, set
        abstract commandId: float with get, set
        abstract enabled: bool with get, set
        abstract icon: U2<NativeImage, string> option with get, set
        abstract id: string with get, set
        abstract label: string with get, set
        abstract menu: Menu with get, set
        abstract registerAccelerator: bool with get, set
        abstract role: MenuItemRole option with get, set
        abstract sublabel: string with get, set
        abstract submenu: Menu option with get, set
        abstract toolTip: string with get, set
        abstract ``type``: MenuItemType with get, set
        abstract visible: bool with get, set

    type [<AllowNullLiteral>] MenuItemStatic =
        /// MenuItem
        [<EmitConstructor>] abstract Create: options: MenuItemConstructorOptions -> MenuItem

    type [<AllowNullLiteral>] MessageChannelMain =
        inherit NodeJS.EventEmitter
        abstract port1: MessagePortMain with get, set
        abstract port2: MessagePortMain with get, set

    type [<AllowNullLiteral>] MessageChannelMainStatic =
        [<EmitConstructor>] abstract Create: unit -> MessageChannelMain

    type [<AllowNullLiteral>] MessagePortMain =
        inherit NodeJS.EventEmitter
        /// Emitted when a MessagePortMain object receives a message.
        [<Emit "$0.on('message',$1)">] abstract on_message: listener: (MessageEvent -> unit) -> MessagePortMain
        [<Emit "$0.once('message',$1)">] abstract once_message: listener: (MessageEvent -> unit) -> MessagePortMain
        [<Emit "$0.addListener('message',$1)">] abstract addListener_message: listener: (MessageEvent -> unit) -> MessagePortMain
        [<Emit "$0.removeListener('message',$1)">] abstract removeListener_message: listener: (MessageEvent -> unit) -> MessagePortMain
        /// Disconnects the port, so it is no longer active.
        abstract close: unit -> unit
        /// Sends a message from the port, and optionally, transfers ownership of objects to
        /// other browsing contexts.
        abstract postMessage: message: obj option * ?transfer: ResizeArray<MessagePortMain> -> unit
        /// Starts the sending of messages queued on the port. Messages will be queued until
        /// this method is called.
        abstract start: unit -> unit

    type [<AllowNullLiteral>] MessagePortMainStatic =
        [<EmitConstructor>] abstract Create: unit -> MessagePortMain

    type [<AllowNullLiteral>] MimeTypedBuffer =
        /// The actual Buffer content.
        abstract data: Buffer with get, set
        /// The mimeType of the Buffer that you are sending.
        abstract mimeType: string with get, set

    type [<AllowNullLiteral>] MouseInputEvent =
        inherit InputEvent
        /// <summary>The button pressed, can be <c>left</c>, <c>middle</c>, <c>right</c>.</summary>
        abstract button: MouseInputEventButton option with get, set
        abstract clickCount: float option with get, set
        abstract globalX: float option with get, set
        abstract globalY: float option with get, set
        abstract movementX: float option with get, set
        abstract movementY: float option with get, set
        /// <summary>
        /// The type of the event, can be <c>mouseDown</c>, <c>mouseUp</c>, <c>mouseEnter</c>,
        /// <c>mouseLeave</c>, <c>contextMenu</c>, <c>mouseWheel</c> or <c>mouseMove</c>.
        /// </summary>
        abstract ``type``: MouseInputEventType with get, set
        abstract x: float with get, set
        abstract y: float with get, set

    type [<AllowNullLiteral>] MouseWheelInputEvent =
        inherit MouseInputEvent
        abstract accelerationRatioX: float option with get, set
        abstract accelerationRatioY: float option with get, set
        abstract canScroll: bool option with get, set
        abstract deltaX: float option with get, set
        abstract deltaY: float option with get, set
        abstract hasPreciseScrollingDeltas: bool option with get, set
        /// <summary>The type of the event, can be <c>mouseWheel</c>.</summary>
        abstract ``type``: string with get, set
        abstract wheelTicksX: float option with get, set
        abstract wheelTicksY: float option with get, set

    type [<AllowNullLiteral>] NativeImage =
        /// Add an image representation for a specific scale factor. This can be used to
        /// explicitly add different scale factor representations to an image. This can be
        /// called on empty images.
        abstract addRepresentation: options: AddRepresentationOptions -> unit
        /// The cropped image.
        abstract crop: rect: Rectangle -> NativeImage
        /// The image's aspect ratio.
        abstract getAspectRatio: unit -> float
        /// <summary>
        /// A Buffer that contains the image's raw bitmap pixel data.
        /// 
        /// The difference between <c>getBitmap()</c> and <c>toBitmap()</c> is that <c>getBitmap()</c> does
        /// not copy the bitmap data, so you have to use the returned Buffer immediately in
        /// current event loop tick; otherwise the data might be changed or destroyed.
        /// </summary>
        abstract getBitmap: ?options: BitmapOptions -> Buffer
        /// <summary>
        /// A Buffer that stores C pointer to underlying native handle of the image. On
        /// macOS, a pointer to <c>NSImage</c> instance would be returned.
        /// 
        /// Notice that the returned pointer is a weak pointer to the underlying native
        /// image instead of a copy, so you _must_ ensure that the associated <c>nativeImage</c>
        /// instance is kept around.
        /// </summary>
        abstract getNativeHandle: unit -> Buffer
        abstract getSize: unit -> Size
        /// Whether the image is empty.
        abstract isEmpty: unit -> bool
        /// Whether the image is a template image.
        abstract isTemplateImage: unit -> bool
        /// <summary>
        /// The resized image.
        /// 
        /// If only the <c>height</c> or the <c>width</c> are specified then the current aspect ratio
        /// will be preserved in the resized image.
        /// </summary>
        abstract resize: options: ResizeOptions -> NativeImage
        /// Marks the image as a template image.
        abstract setTemplateImage: option: bool -> unit
        /// A Buffer that contains a copy of the image's raw bitmap pixel data.
        abstract toBitmap: ?options: ToBitmapOptions -> Buffer
        /// The data URL of the image.
        abstract toDataURL: ?options: ToDataURLOptions -> string
        /// <summary>A Buffer that contains the image's <c>JPEG</c> encoded data.</summary>
        abstract toJPEG: quality: float -> Buffer
        /// <summary>A Buffer that contains the image's <c>PNG</c> encoded data.</summary>
        abstract toPNG: ?options: ToPNGOptions -> Buffer
        abstract isMacTemplateImage: bool with get, set

    type [<AllowNullLiteral>] NativeImageStatic =
        [<EmitConstructor>] abstract Create: unit -> NativeImage
        /// <summary>Creates an empty <c>NativeImage</c> instance.</summary>
        abstract createEmpty: unit -> NativeImage
        /// <summary>
        /// Creates a new <c>NativeImage</c> instance from <c>buffer</c> that contains the raw bitmap
        /// pixel data returned by <c>toBitmap()</c>. The specific format is platform-dependent.
        /// </summary>
        abstract createFromBitmap: buffer: Buffer * options: CreateFromBitmapOptions -> NativeImage
        /// <summary>
        /// Creates a new <c>NativeImage</c> instance from <c>buffer</c>. Tries to decode as PNG or
        /// JPEG first.
        /// </summary>
        abstract createFromBuffer: buffer: Buffer * ?options: CreateFromBufferOptions -> NativeImage
        /// <summary>Creates a new <c>NativeImage</c> instance from <c>dataURL</c>.</summary>
        abstract createFromDataURL: dataURL: string -> NativeImage
        /// <summary>
        /// Creates a new <c>NativeImage</c> instance from the NSImage that maps to the given
        /// image name. See <c>System Icons</c> for a list of possible values.
        /// 
        /// The <c>hslShift</c> is applied to the image with the following rules:
        /// 
        /// * <c>hsl_shift[0]</c> (hue): The absolute hue value for the image - 0 and 1 map to 0
        /// and 360 on the hue color wheel (red).
        /// * <c>hsl_shift[1]</c> (saturation): A saturation shift for the image, with the
        /// following key values: 0 = remove all color. 0.5 = leave unchanged. 1 = fully
        /// saturate the image.
        /// * <c>hsl_shift[2]</c> (lightness): A lightness shift for the image, with the
        /// following key values: 0 = remove all lightness (make all pixels black). 0.5 =
        /// leave unchanged. 1 = full lightness (make all pixels white).
        /// 
        /// This means that <c>[-1, 0, 1]</c> will make the image completely white and `[-1, 1,
        /// 0]` will make the image completely black.
        /// 
        /// In some cases, the <c>NSImageName</c> doesn't match its string representation; one
        /// example of this is <c>NSFolderImageName</c>, whose string representation would
        /// actually be <c>NSFolder</c>. Therefore, you'll need to determine the correct string
        /// representation for your image before passing it in. This can be done with the
        /// following:
        /// 
        /// `echo -e '#import &lt;Cocoa/Cocoa.h&gt;\nint main() { NSLog(@"%@", SYSTEM_IMAGE_NAME);
        /// }' | clang -otest -x objective-c -framework Cocoa - &amp;&amp; ./test`
        /// 
        /// where <c>SYSTEM_IMAGE_NAME</c> should be replaced with any value from this list.
        /// </summary>
        abstract createFromNamedImage: imageName: string * ?hslShift: ResizeArray<float> -> NativeImage
        /// <summary>
        /// Creates a new <c>NativeImage</c> instance from a file located at <c>path</c>. This method
        /// returns an empty image if the <c>path</c> does not exist, cannot be read, or is not a
        /// valid image.
        /// </summary>
        abstract createFromPath: path: string -> NativeImage

    type [<AllowNullLiteral>] NativeTheme =
        inherit NodeJS.EventEmitter
        /// <summary>
        /// Emitted when something in the underlying NativeTheme has changed. This normally
        /// means that either the value of <c>shouldUseDarkColors</c>,
        /// <c>shouldUseHighContrastColors</c> or <c>shouldUseInvertedColorScheme</c> has changed. You
        /// will have to check them to determine which one has changed.
        /// </summary>
        [<Emit "$0.on('updated',$1)">] abstract on_updated: listener: Function -> NativeTheme
        [<Emit "$0.once('updated',$1)">] abstract once_updated: listener: Function -> NativeTheme
        [<Emit "$0.addListener('updated',$1)">] abstract addListener_updated: listener: Function -> NativeTheme
        [<Emit "$0.removeListener('updated',$1)">] abstract removeListener_updated: listener: Function -> NativeTheme
        /// <summary>
        /// A <c>Boolean</c> for if the OS / Chromium currently has a dark mode enabled or is
        /// being instructed to show a dark-style UI.  If you want to modify this value you
        /// should use <c>themeSource</c> below.
        /// </summary>
        abstract shouldUseDarkColors: bool
        /// <summary>
        /// A <c>Boolean</c> for if the OS / Chromium currently has high-contrast mode enabled or
        /// is being instructed to show a high-constrast UI.
        /// </summary>
        abstract shouldUseHighContrastColors: bool
        /// <summary>
        /// A <c>Boolean</c> for if the OS / Chromium currently has an inverted color scheme or
        /// is being instructed to use an inverted color scheme.
        /// </summary>
        abstract shouldUseInvertedColorScheme: bool
        /// <summary>
        /// A <c>String</c> property that can be <c>system</c>, <c>light</c> or <c>dark</c>.  It is used to
        /// override and supersede the value that Chromium has chosen to use internally.
        /// 
        /// Setting this property to <c>system</c> will remove the override and everything will
        /// be reset to the OS default.  By default <c>themeSource</c> is <c>system</c>.
        /// 
        /// Settings this property to <c>dark</c> will have the following effects:
        /// 
        /// * <c>nativeTheme.shouldUseDarkColors</c> will be <c>true</c> when accessed
        /// * Any UI Electron renders on Linux and Windows including context menus,
        /// devtools, etc. will use the dark UI.
        /// * Any UI the OS renders on macOS including menus, window frames, etc. will use
        /// the dark UI.
        /// * The <c>prefers-color-scheme</c> CSS query will match <c>dark</c> mode.
        /// * The <c>updated</c> event will be emitted
        /// 
        /// Settings this property to <c>light</c> will have the following effects:
        /// 
        /// * <c>nativeTheme.shouldUseDarkColors</c> will be <c>false</c> when accessed
        /// * Any UI Electron renders on Linux and Windows including context menus,
        /// devtools, etc. will use the light UI.
        /// * Any UI the OS renders on macOS including menus, window frames, etc. will use
        /// the light UI.
        /// * The <c>prefers-color-scheme</c> CSS query will match <c>light</c> mode.
        /// * The <c>updated</c> event will be emitted
        /// 
        /// The usage of this property should align with a classic "dark mode" state machine
        /// in your application where the user has three options.
        /// 
        /// * <c>Follow OS</c> --&gt; <c>themeSource = 'system'</c>
        /// * <c>Dark Mode</c> --&gt; <c>themeSource = 'dark'</c>
        /// * <c>Light Mode</c> --&gt; <c>themeSource = 'light'</c>
        /// 
        /// Your application should then always use <c>shouldUseDarkColors</c> to determine what
        /// CSS to apply.
        /// </summary>
        abstract themeSource: NativeThemeThemeSource with get, set

    type [<AllowNullLiteral>] Net =
        /// <summary>
        /// Creates a <c>ClientRequest</c> instance using the provided <c>options</c> which are
        /// directly forwarded to the <c>ClientRequest</c> constructor. The <c>net.request</c> method
        /// would be used to issue both secure and insecure HTTP requests according to the
        /// specified protocol scheme in the <c>options</c> object.
        /// </summary>
        abstract request: options: U2<ClientRequestConstructorOptions, string> -> ClientRequest

    type [<AllowNullLiteral>] NetLog =
        /// <summary>
        /// resolves when the net log has begun recording.
        /// 
        /// Starts recording network events to <c>path</c>.
        /// </summary>
        abstract startLogging: path: string * ?options: StartLoggingOptions -> Promise<unit>
        /// resolves with a file path to which network logs were recorded.
        /// 
        /// Stops recording network events. If not called, net logging will automatically
        /// end when app quits.
        abstract stopLogging: unit -> Promise<string>
        /// <summary>A <c>Boolean</c> property that indicates whether network logs are recorded.</summary>
        abstract currentlyLogging: bool
        /// <summary>A <c>String</c> property that returns the path to the current log file.</summary>
        [<Obsolete("")>]
        abstract currentlyLoggingPath: string

    type [<AllowNullLiteral>] NewWindowEvent =
        inherit Event
        abstract newGuest: BrowserWindow option with get, set
        abstract url: string with get, set
        abstract frameName: string with get, set
        /// <summary>
        /// Can be <c>default</c>, <c>foreground-tab</c>, <c>background-tab</c>, <c>new-window</c>,
        /// <c>save-to-disk</c> and <c>other</c>.
        /// </summary>
        abstract disposition: NewWindowEventDisposition with get, set
        /// <summary>The options which should be used for creating the new <c>BrowserWindow</c>.</summary>
        abstract options: BrowserWindowConstructorOptions with get, set

    type [<AllowNullLiteral>] Notification =
        inherit NodeJS.EventEmitter
        [<Emit "$0.on('action',$1)">] abstract on_action: listener: (Event -> float -> unit) -> Notification
        [<Emit "$0.once('action',$1)">] abstract once_action: listener: (Event -> float -> unit) -> Notification
        [<Emit "$0.addListener('action',$1)">] abstract addListener_action: listener: (Event -> float -> unit) -> Notification
        [<Emit "$0.removeListener('action',$1)">] abstract removeListener_action: listener: (Event -> float -> unit) -> Notification
        /// Emitted when the notification is clicked by the user.
        [<Emit "$0.on('click',$1)">] abstract on_click: listener: (Event -> unit) -> Notification
        [<Emit "$0.once('click',$1)">] abstract once_click: listener: (Event -> unit) -> Notification
        [<Emit "$0.addListener('click',$1)">] abstract addListener_click: listener: (Event -> unit) -> Notification
        [<Emit "$0.removeListener('click',$1)">] abstract removeListener_click: listener: (Event -> unit) -> Notification
        /// Emitted when the notification is closed by manual intervention from the user.
        /// 
        /// This event is not guaranteed to be emitted in all cases where the notification
        /// is closed.
        [<Emit "$0.on('close',$1)">] abstract on_close: listener: (Event -> unit) -> Notification
        [<Emit "$0.once('close',$1)">] abstract once_close: listener: (Event -> unit) -> Notification
        [<Emit "$0.addListener('close',$1)">] abstract addListener_close: listener: (Event -> unit) -> Notification
        [<Emit "$0.removeListener('close',$1)">] abstract removeListener_close: listener: (Event -> unit) -> Notification
        /// <summary>
        /// Emitted when the user clicks the "Reply" button on a notification with
        /// <c>hasReply: true</c>.
        /// </summary>
        [<Emit "$0.on('reply',$1)">] abstract on_reply: listener: (Event -> string -> unit) -> Notification
        [<Emit "$0.once('reply',$1)">] abstract once_reply: listener: (Event -> string -> unit) -> Notification
        [<Emit "$0.addListener('reply',$1)">] abstract addListener_reply: listener: (Event -> string -> unit) -> Notification
        [<Emit "$0.removeListener('reply',$1)">] abstract removeListener_reply: listener: (Event -> string -> unit) -> Notification
        /// <summary>
        /// Emitted when the notification is shown to the user, note this could be fired
        /// multiple times as a notification can be shown multiple times through the
        /// <c>show()</c> method.
        /// </summary>
        [<Emit "$0.on('show',$1)">] abstract on_show: listener: (Event -> unit) -> Notification
        [<Emit "$0.once('show',$1)">] abstract once_show: listener: (Event -> unit) -> Notification
        [<Emit "$0.addListener('show',$1)">] abstract addListener_show: listener: (Event -> unit) -> Notification
        [<Emit "$0.removeListener('show',$1)">] abstract removeListener_show: listener: (Event -> unit) -> Notification
        /// Dismisses the notification.
        abstract close: unit -> unit
        /// <summary>
        /// Immediately shows the notification to the user, please note this means unlike
        /// the HTML5 Notification implementation, instantiating a <c>new Notification</c> does
        /// not immediately show it to the user, you need to call this method before the OS
        /// will display it.
        /// 
        /// If the notification has been shown before, this method will dismiss the
        /// previously shown notification and create a new one with identical properties.
        /// </summary>
        abstract show: unit -> unit
        abstract actions: ResizeArray<NotificationAction> with get, set
        abstract body: string with get, set
        abstract closeButtonText: string with get, set
        abstract hasReply: bool with get, set
        abstract replyPlaceholder: string with get, set
        abstract silent: bool with get, set
        abstract sound: string with get, set
        abstract subtitle: string with get, set
        abstract timeoutType: NotificationTimeoutType with get, set
        abstract title: string with get, set
        abstract urgency: NotificationUrgency with get, set

    type [<AllowNullLiteral>] NotificationStatic =
        /// Notification
        [<EmitConstructor>] abstract Create: ?options: NotificationConstructorOptions -> Notification
        /// Whether or not desktop notifications are supported on the current system
        abstract isSupported: unit -> bool

    type [<AllowNullLiteral>] NotificationAction =
        /// The label for the given action.
        abstract text: string option with get, set
        /// <summary>The type of action, can be <c>button</c>.</summary>
        abstract ``type``: string with get, set

    type [<AllowNullLiteral>] Point =
        abstract x: float with get, set
        abstract y: float with get, set

    type [<AllowNullLiteral>] PowerMonitor =
        inherit NodeJS.EventEmitter
        /// <summary>Emitted when the system is about to lock the screen.</summary>
        [<Emit "$0.on('lock-screen',$1)">] abstract ``on_lock-screen``: listener: Function -> PowerMonitor
        [<Emit "$0.once('lock-screen',$1)">] abstract ``once_lock-screen``: listener: Function -> PowerMonitor
        [<Emit "$0.addListener('lock-screen',$1)">] abstract ``addListener_lock-screen``: listener: Function -> PowerMonitor
        [<Emit "$0.removeListener('lock-screen',$1)">] abstract ``removeListener_lock-screen``: listener: Function -> PowerMonitor
        /// <summary>Emitted when the system changes to AC power.</summary>
        [<Emit "$0.on('on-ac',$1)">] abstract ``on_on-ac``: listener: Function -> PowerMonitor
        [<Emit "$0.once('on-ac',$1)">] abstract ``once_on-ac``: listener: Function -> PowerMonitor
        [<Emit "$0.addListener('on-ac',$1)">] abstract ``addListener_on-ac``: listener: Function -> PowerMonitor
        [<Emit "$0.removeListener('on-ac',$1)">] abstract ``removeListener_on-ac``: listener: Function -> PowerMonitor
        /// <summary>Emitted when system changes to battery power.</summary>
        [<Emit "$0.on('on-battery',$1)">] abstract ``on_on-battery``: listener: Function -> PowerMonitor
        [<Emit "$0.once('on-battery',$1)">] abstract ``once_on-battery``: listener: Function -> PowerMonitor
        [<Emit "$0.addListener('on-battery',$1)">] abstract ``addListener_on-battery``: listener: Function -> PowerMonitor
        [<Emit "$0.removeListener('on-battery',$1)">] abstract ``removeListener_on-battery``: listener: Function -> PowerMonitor
        /// <summary>Emitted when system is resuming.</summary>
        [<Emit "$0.on('resume',$1)">] abstract on_resume: listener: Function -> PowerMonitor
        [<Emit "$0.once('resume',$1)">] abstract once_resume: listener: Function -> PowerMonitor
        [<Emit "$0.addListener('resume',$1)">] abstract addListener_resume: listener: Function -> PowerMonitor
        [<Emit "$0.removeListener('resume',$1)">] abstract removeListener_resume: listener: Function -> PowerMonitor
        /// <summary>
        /// Emitted when the system is about to reboot or shut down. If the event handler
        /// invokes <c>e.preventDefault()</c>, Electron will attempt to delay system shutdown in
        /// order for the app to exit cleanly. If <c>e.preventDefault()</c> is called, the app
        /// should exit as soon as possible by calling something like <c>app.quit()</c>.
        /// </summary>
        [<Emit "$0.on('shutdown',$1)">] abstract on_shutdown: listener: Function -> PowerMonitor
        [<Emit "$0.once('shutdown',$1)">] abstract once_shutdown: listener: Function -> PowerMonitor
        [<Emit "$0.addListener('shutdown',$1)">] abstract addListener_shutdown: listener: Function -> PowerMonitor
        [<Emit "$0.removeListener('shutdown',$1)">] abstract removeListener_shutdown: listener: Function -> PowerMonitor
        /// <summary>Emitted when the system is suspending.</summary>
        [<Emit "$0.on('suspend',$1)">] abstract on_suspend: listener: Function -> PowerMonitor
        [<Emit "$0.once('suspend',$1)">] abstract once_suspend: listener: Function -> PowerMonitor
        [<Emit "$0.addListener('suspend',$1)">] abstract addListener_suspend: listener: Function -> PowerMonitor
        [<Emit "$0.removeListener('suspend',$1)">] abstract removeListener_suspend: listener: Function -> PowerMonitor
        /// <summary>Emitted as soon as the systems screen is unlocked.</summary>
        [<Emit "$0.on('unlock-screen',$1)">] abstract ``on_unlock-screen``: listener: Function -> PowerMonitor
        [<Emit "$0.once('unlock-screen',$1)">] abstract ``once_unlock-screen``: listener: Function -> PowerMonitor
        [<Emit "$0.addListener('unlock-screen',$1)">] abstract ``addListener_unlock-screen``: listener: Function -> PowerMonitor
        [<Emit "$0.removeListener('unlock-screen',$1)">] abstract ``removeListener_unlock-screen``: listener: Function -> PowerMonitor
        /// <summary>
        /// The system's current state. Can be <c>active</c>, <c>idle</c>, <c>locked</c> or <c>unknown</c>.
        /// 
        /// Calculate the system idle state. <c>idleThreshold</c> is the amount of time (in
        /// seconds) before considered idle.  <c>locked</c> is available on supported systems
        /// only.
        /// </summary>
        abstract getSystemIdleState: idleThreshold: float -> PowerMonitorGetSystemIdleStateReturn
        /// Idle time in seconds
        /// 
        /// Calculate system idle time in seconds.
        abstract getSystemIdleTime: unit -> float

    type [<StringEnum>] [<RequireQualifiedAccess>] PowerMonitorGetSystemIdleStateReturn =
        | Active
        | Idle
        | Locked
        | Unknown

    type [<AllowNullLiteral>] PowerSaveBlocker =
        /// <summary>Whether the corresponding <c>powerSaveBlocker</c> has started.</summary>
        abstract isStarted: id: float -> bool
        /// <summary>
        /// The blocker ID that is assigned to this power blocker.
        /// 
        /// Starts preventing the system from entering lower-power mode. Returns an integer
        /// identifying the power save blocker.
        /// 
        /// **Note:** <c>prevent-display-sleep</c> has higher precedence over
        /// <c>prevent-app-suspension</c>. Only the highest precedence type takes effect. In
        /// other words, <c>prevent-display-sleep</c> always takes precedence over
        /// <c>prevent-app-suspension</c>.
        /// 
        /// For example, an API calling A requests for <c>prevent-app-suspension</c>, and another
        /// calling B requests for <c>prevent-display-sleep</c>. <c>prevent-display-sleep</c> will be
        /// used until B stops its request. After that, <c>prevent-app-suspension</c> is used.
        /// </summary>
        abstract start: ``type``: PowerSaveBlockerStartType -> float
        /// Stops the specified power save blocker.
        abstract stop: id: float -> unit

    type [<StringEnum>] [<RequireQualifiedAccess>] PowerSaveBlockerStartType =
        | [<CompiledName "prevent-app-suspension">] PreventAppSuspension
        | [<CompiledName "prevent-display-sleep">] PreventDisplaySleep

    type [<AllowNullLiteral>] PrinterInfo =
        /// a longer description of the printer's type.
        abstract description: string with get, set
        /// the name of the printer as shown in Print Preview.
        abstract displayName: string with get, set
        /// whether or not a given printer is set as the default printer on the OS.
        abstract isDefault: bool with get, set
        /// the name of the printer as understood by the OS.
        abstract name: string with get, set
        /// an object containing a variable number of platform-specific printer information.
        abstract options: Options with get, set
        /// the current status of the printer.
        abstract status: float with get, set

    type [<AllowNullLiteral>] ProcessMemoryInfo =
        /// The amount of memory not shared by other processes, such as JS heap or HTML
        /// content in Kilobytes.
        abstract ``private``: float with get, set
        /// <summary>The amount of memory currently pinned to actual physical RAM in Kilobytes.</summary>
        abstract residentSet: float with get, set
        /// The amount of memory shared between processes, typically memory consumed by the
        /// Electron code itself in Kilobytes.
        abstract shared: float with get, set

    type [<AllowNullLiteral>] ProcessMetric =
        /// CPU usage of the process.
        abstract cpu: CPUUsage with get, set
        /// <summary>
        /// Creation time for this process. The time is represented as number of
        /// milliseconds since epoch. Since the <c>pid</c> can be reused after a process dies, it
        /// is useful to use both the <c>pid</c> and the <c>creationTime</c> to uniquely identify a
        /// process.
        /// </summary>
        abstract creationTime: float with get, set
        /// <summary>One of the following values:</summary>
        abstract integrityLevel: ProcessMetricIntegrityLevel option with get, set
        /// Memory information for the process.
        abstract memory: MemoryInfo with get, set
        /// Process id of the process.
        abstract pid: float with get, set
        /// <summary>Whether the process is sandboxed on OS level.</summary>
        abstract sandboxed: bool option with get, set
        /// Process type. One of the following values:
        abstract ``type``: ProcessMetricType with get, set

    type [<AllowNullLiteral>] Product =
        /// The total size of the content, in bytes.
        abstract contentLengths: ResizeArray<float> with get, set
        /// A string that identifies the version of the content.
        abstract contentVersion: string with get, set
        /// 3 character code presenting a product's currency based on the ISO 4217 standard.
        abstract currencyCode: string with get, set
        /// The locale formatted price of the product.
        abstract formattedPrice: string with get, set
        /// <summary>
        /// A Boolean value that indicates whether the App Store has downloadable content
        /// for this product. <c>true</c> if at least one file has been associated with the
        /// product.
        /// </summary>
        abstract isDownloadable: bool with get, set
        /// A description of the product.
        abstract localizedDescription: string with get, set
        /// The name of the product.
        abstract localizedTitle: string with get, set
        /// The cost of the product in the local currency.
        abstract price: float with get, set
        /// The string that identifies the product to the Apple App Store.
        abstract productIdentifier: string with get, set

    type [<AllowNullLiteral>] Protocol =
        /// <summary>
        /// Intercepts <c>scheme</c> protocol and uses <c>handler</c> as the protocol's new handler
        /// which sends a <c>Buffer</c> as a response.
        /// </summary>
        abstract interceptBufferProtocol: scheme: string * handler: (Request -> ((Buffer) option -> unit) -> unit) * ?completion: (Error -> unit) -> unit
        /// <summary>
        /// Intercepts <c>scheme</c> protocol and uses <c>handler</c> as the protocol's new handler
        /// which sends a file as a response.
        /// </summary>
        abstract interceptFileProtocol: scheme: string * handler: (Request -> (string -> unit) -> unit) * ?completion: (Error -> unit) -> unit
        /// <summary>
        /// Intercepts <c>scheme</c> protocol and uses <c>handler</c> as the protocol's new handler
        /// which sends a new HTTP request as a response.
        /// </summary>
        abstract interceptHttpProtocol: scheme: string * handler: (Request -> (RedirectRequest -> unit) -> unit) * ?completion: (Error -> unit) -> unit
        /// <summary>
        /// Same as <c>protocol.registerStreamProtocol</c>, except that it replaces an existing
        /// protocol handler.
        /// </summary>
        abstract interceptStreamProtocol: scheme: string * handler: (Request -> ((U2<NodeJS.ReadableStream, StreamProtocolResponse>) option -> unit) -> unit) * ?completion: (Error -> unit) -> unit
        /// <summary>
        /// Intercepts <c>scheme</c> protocol and uses <c>handler</c> as the protocol's new handler
        /// which sends a <c>String</c> as a response.
        /// </summary>
        abstract interceptStringProtocol: scheme: string * handler: (Request -> ((U2<string, StringProtocolResponse>) option -> unit) -> unit) * ?completion: (Error -> unit) -> unit
        /// <summary>
        /// fulfilled with a boolean that indicates whether there is already a handler for
        /// <c>scheme</c>.
        /// </summary>
        abstract isProtocolHandled: scheme: string -> Promise<bool>
        /// <summary>
        /// Registers a protocol of <c>scheme</c> that will send a <c>Buffer</c> as a response.
        /// 
        /// The usage is the same with <c>registerFileProtocol</c>, except that the <c>callback</c>
        /// should be called with either a <c>Buffer</c> object or an object that has the <c>data</c>,
        /// <c>mimeType</c>, and <c>charset</c> properties.
        /// 
        /// Example:
        /// </summary>
        abstract registerBufferProtocol: scheme: string * handler: (Request -> ((U2<Buffer, MimeTypedBuffer>) option -> unit) -> unit) * ?completion: (Error -> unit) -> unit
        /// <summary>
        /// Registers a protocol of <c>scheme</c> that will send the file as a response. The
        /// <c>handler</c> will be called with <c>handler(request, callback)</c> when a <c>request</c> is
        /// going to be created with <c>scheme</c>. <c>completion</c> will be called with
        /// <c>completion(null)</c> when <c>scheme</c> is successfully registered or
        /// <c>completion(error)</c> when failed.
        /// 
        /// To handle the <c>request</c>, the <c>callback</c> should be called with either the file's
        /// path or an object that has a <c>path</c> property, e.g. <c>callback(filePath)</c> or
        /// <c>callback({ path: filePath })</c>. The object may also have a <c>headers</c> property
        /// which gives a map of headers to values for the response headers, e.g.
        /// `callback({ path: filePath, headers: {"Content-Security-Policy": "default-src
        /// 'none'"]})`.
        /// 
        /// When <c>callback</c> is called with nothing, a number, or an object that has an
        /// <c>error</c> property, the <c>request</c> will fail with the <c>error</c> number you specified.
        /// For the available error numbers you can use, please see the net error list.
        /// 
        /// By default the <c>scheme</c> is treated like <c>http:</c>, which is parsed differently
        /// than protocols that follow the "generic URI syntax" like <c>file:</c>.
        /// </summary>
        abstract registerFileProtocol: scheme: string * handler: (Request -> ((U2<string, FilePathWithHeaders>) option -> unit) -> unit) * ?completion: (Error -> unit) -> unit
        /// <summary>
        /// Registers a protocol of <c>scheme</c> that will send an HTTP request as a response.
        /// 
        /// The usage is the same with <c>registerFileProtocol</c>, except that the <c>callback</c>
        /// should be called with a <c>redirectRequest</c> object that has the <c>url</c>, <c>method</c>,
        /// <c>referrer</c>, <c>uploadData</c> and <c>session</c> properties.
        /// 
        /// By default the HTTP request will reuse the current session. If you want the
        /// request to have a different session you should set <c>session</c> to <c>null</c>.
        /// 
        /// For POST requests the <c>uploadData</c> object must be provided.
        /// </summary>
        abstract registerHttpProtocol: scheme: string * handler: (Request -> (RedirectRequest -> unit) -> unit) * ?completion: (Error -> unit) -> unit
        /// <summary>
        /// **Note:** This method can only be used before the <c>ready</c> event of the <c>app</c>
        /// module gets emitted and can be called only once.
        /// 
        /// Registers the <c>scheme</c> as standard, secure, bypasses content security policy for
        /// resources, allows registering ServiceWorker and supports fetch API.
        /// 
        /// Specify a privilege with the value of <c>true</c> to enable the capability. An
        /// example of registering a privileged scheme, with bypassing Content Security
        /// Policy:
        /// 
        /// A standard scheme adheres to what RFC 3986 calls generic URI syntax. For example
        /// <c>http</c> and <c>https</c> are standard schemes, while <c>file</c> is not.
        /// 
        /// Registering a scheme as standard, will allow relative and absolute resources to
        /// be resolved correctly when served. Otherwise the scheme will behave like the
        /// <c>file</c> protocol, but without the ability to resolve relative URLs.
        /// 
        /// For example when you load following page with custom protocol without
        /// registering it as standard scheme, the image will not be loaded because
        /// non-standard schemes can not recognize relative URLs:
        /// 
        /// Registering a scheme as standard will allow access to files through the
        /// FileSystem API. Otherwise the renderer will throw a security error for the
        /// scheme.
        /// 
        /// By default web storage apis (localStorage, sessionStorage, webSQL, indexedDB,
        /// cookies) are disabled for non standard schemes. So in general if you want to
        /// register a custom protocol to replace the <c>http</c> protocol, you have to register
        /// it as a standard scheme.
        /// 
        /// <c>protocol.registerSchemesAsPrivileged</c> can be used to replicate the
        /// functionality of the previous <c>protocol.registerStandardSchemes</c>,
        /// <c>webFrame.registerURLSchemeAs*</c> and <c>protocol.registerServiceWorkerSchemes</c>
        /// functions that existed prior to Electron 5.0.0, for example:
        /// 
        /// *before (&lt;= v4.x)**
        /// 
        /// *after (&gt;= v5.x)**
        /// </summary>
        abstract registerSchemesAsPrivileged: customSchemes: ResizeArray<CustomScheme> -> unit
        /// <summary>
        /// Registers a protocol of <c>scheme</c> that will send a <c>Readable</c> as a response.
        /// 
        /// The usage is similar to the other <c>register{Any}Protocol</c>, except that the
        /// <c>callback</c> should be called with either a <c>Readable</c> object or an object that
        /// has the <c>data</c>, <c>statusCode</c>, and <c>headers</c> properties.
        /// 
        /// Example:
        /// 
        /// It is possible to pass any object that implements the readable stream API (emits
        /// <c>data</c>/<c>end</c>/<c>error</c> events). For example, here's how a file could be returned:
        /// </summary>
        abstract registerStreamProtocol: scheme: string * handler: (Request -> ((U2<NodeJS.ReadableStream, StreamProtocolResponse>) option -> unit) -> unit) * ?completion: (Error -> unit) -> unit
        /// <summary>
        /// Registers a protocol of <c>scheme</c> that will send a <c>String</c> as a response.
        /// 
        /// The usage is the same with <c>registerFileProtocol</c>, except that the <c>callback</c>
        /// should be called with either a <c>String</c> or an object that has the <c>data</c>,
        /// <c>mimeType</c>, and <c>charset</c> properties.
        /// </summary>
        abstract registerStringProtocol: scheme: string * handler: (Request -> ((U2<string, StringProtocolResponse>) option -> unit) -> unit) * ?completion: (Error -> unit) -> unit
        /// <summary>Remove the interceptor installed for <c>scheme</c> and restore its original handler.</summary>
        abstract uninterceptProtocol: scheme: string * ?completion: (Error -> unit) -> unit
        /// <summary>Unregisters the custom protocol of <c>scheme</c>.</summary>
        abstract unregisterProtocol: scheme: string * ?completion: (Error -> unit) -> unit

    type [<AllowNullLiteral>] ProtocolRequest =
        abstract method: string with get, set
        abstract referrer: string with get, set
        abstract uploadData: ResizeArray<UploadData> option with get, set
        abstract url: string with get, set

    type [<AllowNullLiteral>] ProtocolResponse =
        /// <summary>The charset of response body, default is <c>"utf-8"</c>.</summary>
        abstract charset: string option with get, set
        /// <summary>
        /// The response body. When returning stream as response, this is a Node.js readable
        /// stream representing the response body. When returning <c>Buffer</c> as response, this
        /// is a <c>Buffer</c>. When returning <c>String</c> as response, this is a <c>String</c>. This is
        /// ignored for other types of responses.
        /// </summary>
        abstract data: U3<Buffer, string, NodeJS.ReadableStream> option with get, set
        /// <summary>
        /// When assigned, the <c>request</c> will fail with the <c>error</c> number . For the
        /// available error numbers you can use, please see the net error list.
        /// </summary>
        abstract error: float option with get, set
        /// An object containing the response headers. The keys must be String, and values
        /// must be either String or Array of String.
        abstract headers: Record<string, U2<string, ResizeArray<string>>> option with get, set
        /// <summary>The HTTP <c>method</c>. This is only used for file and URL responses.</summary>
        abstract method: string option with get, set
        /// <summary>
        /// The MIME type of response body, default is <c>"text/html"</c>. Setting <c>mimeType</c>
        /// would implicitly set the <c>content-type</c> header in response, but if
        /// <c>content-type</c> is already set in <c>headers</c>, the <c>mimeType</c> would be ignored.
        /// </summary>
        abstract mimeType: string option with get, set
        /// Path to the file which would be sent as response body. This is only used for
        /// file responses.
        abstract path: string option with get, set
        /// <summary>The <c>referrer</c> URL. This is only used for file and URL responses.</summary>
        abstract referrer: string option with get, set
        /// <summary>
        /// The session used for requesting URL, by default the HTTP request will reuse the
        /// current session. Setting <c>session</c> to <c>null</c> would use a random independent
        /// session. This is only used for URL responses.
        /// </summary>
        abstract session: Session option with get, set
        /// The HTTP response code, default is 200.
        abstract statusCode: float option with get, set
        /// <summary>
        /// The data used as upload data. This is only used for URL responses when <c>method</c>
        /// is <c>"POST"</c>.
        /// </summary>
        abstract uploadData: ProtocolResponseUploadData option with get, set
        /// <summary>
        /// Download the <c>url</c> and pipe the result as response body. This is only used for
        /// URL responses.
        /// </summary>
        abstract url: string option with get, set

    type [<AllowNullLiteral>] ProtocolResponseUploadData =
        /// MIME type of the content.
        abstract contentType: string with get, set
        /// Content to be sent.
        abstract data: U2<string, Buffer> with get, set

    type [<AllowNullLiteral>] Rectangle =
        /// The height of the rectangle (must be an integer).
        abstract height: float with get, set
        /// The width of the rectangle (must be an integer).
        abstract width: float with get, set
        /// The x coordinate of the origin of the rectangle (must be an integer).
        abstract x: float with get, set
        /// The y coordinate of the origin of the rectangle (must be an integer).
        abstract y: float with get, set

    type [<AllowNullLiteral>] Referrer =
        /// <summary>
        /// Can be <c>default</c>, <c>unsafe-url</c>, <c>no-referrer-when-downgrade</c>, <c>no-referrer</c>,
        /// <c>origin</c>, <c>strict-origin-when-cross-origin</c>, <c>same-origin</c> or <c>strict-origin</c>.
        /// See the Referrer-Policy spec for more details on the meaning of these values.
        /// </summary>
        abstract policy: ReferrerPolicy with get, set
        /// HTTP Referrer URL.
        abstract url: string with get, set

    type [<AllowNullLiteral>] Remote =
        inherit MainInterface
        /// The web contents of this web page.
        abstract getCurrentWebContents: unit -> WebContents
        /// <summary>
        /// The window to which this web page belongs.
        /// 
        /// **Note:** Do not use <c>removeAllListeners</c> on <c>BrowserWindow</c>. Use of this can
        /// remove all <c>blur</c> listeners, disable click events on touch bar buttons, and
        /// other unintended consequences.
        /// </summary>
        abstract getCurrentWindow: unit -> BrowserWindow
        /// <summary>The global variable of <c>name</c> (e.g. <c>global[name]</c>) in the main process.</summary>
        abstract getGlobal: name: string -> obj option
        /// <summary>
        /// The object returned by <c>require(module)</c> in the main process. Modules specified
        /// by their relative path will resolve relative to the entrypoint of the main
        /// process.
        /// 
        /// e.g.
        /// </summary>
        abstract require: ``module``: string -> obj option
        /// <summary>
        /// A <c>NodeJS.Process</c> object.  The <c>process</c> object in the main process. This is
        /// the same as <c>remote.getGlobal('process')</c> but is cached.
        /// </summary>
        abstract ``process``: NodeJS.Process

    type [<AllowNullLiteral>] RemoveClientCertificate =
        /// Origin of the server whose associated client certificate must be removed from
        /// the cache.
        abstract origin: string with get, set
        /// <summary><c>clientCertificate</c>.</summary>
        abstract ``type``: string with get, set

    type [<AllowNullLiteral>] RemovePassword =
        /// When provided, the authentication info related to the origin will only be
        /// removed otherwise the entire cache will be cleared.
        abstract origin: string option with get, set
        /// <summary>Credentials of the authentication. Must be provided if removing by <c>origin</c>.</summary>
        abstract password: string option with get, set
        /// <summary>Realm of the authentication. Must be provided if removing by <c>origin</c>.</summary>
        abstract realm: string option with get, set
        /// <summary>
        /// Scheme of the authentication. Can be <c>basic</c>, <c>digest</c>, <c>ntlm</c>, <c>negotiate</c>.
        /// Must be provided if removing by <c>origin</c>.
        /// </summary>
        abstract scheme: RemovePasswordScheme option with get, set
        /// <summary><c>password</c>.</summary>
        abstract ``type``: string with get, set
        /// <summary>Credentials of the authentication. Must be provided if removing by <c>origin</c>.</summary>
        abstract username: string option with get, set

    type [<AllowNullLiteral>] Screen =
        inherit NodeJS.EventEmitter
        /// <summary>Emitted when <c>newDisplay</c> has been added.</summary>
        [<Emit "$0.on('display-added',$1)">] abstract ``on_display-added``: listener: (Event -> Display -> unit) -> Screen
        [<Emit "$0.once('display-added',$1)">] abstract ``once_display-added``: listener: (Event -> Display -> unit) -> Screen
        [<Emit "$0.addListener('display-added',$1)">] abstract ``addListener_display-added``: listener: (Event -> Display -> unit) -> Screen
        [<Emit "$0.removeListener('display-added',$1)">] abstract ``removeListener_display-added``: listener: (Event -> Display -> unit) -> Screen
        /// <summary>
        /// Emitted when one or more metrics change in a <c>display</c>. The <c>changedMetrics</c> is
        /// an array of strings that describe the changes. Possible changes are <c>bounds</c>,
        /// <c>workArea</c>, <c>scaleFactor</c> and <c>rotation</c>.
        /// </summary>
        [<Emit "$0.on('display-metrics-changed',$1)">] abstract ``on_display-metrics-changed``: listener: (Event -> Display -> ResizeArray<string> -> unit) -> Screen
        [<Emit "$0.once('display-metrics-changed',$1)">] abstract ``once_display-metrics-changed``: listener: (Event -> Display -> ResizeArray<string> -> unit) -> Screen
        [<Emit "$0.addListener('display-metrics-changed',$1)">] abstract ``addListener_display-metrics-changed``: listener: (Event -> Display -> ResizeArray<string> -> unit) -> Screen
        [<Emit "$0.removeListener('display-metrics-changed',$1)">] abstract ``removeListener_display-metrics-changed``: listener: (Event -> Display -> ResizeArray<string> -> unit) -> Screen
        /// <summary>Emitted when <c>oldDisplay</c> has been removed.</summary>
        [<Emit "$0.on('display-removed',$1)">] abstract ``on_display-removed``: listener: (Event -> Display -> unit) -> Screen
        [<Emit "$0.once('display-removed',$1)">] abstract ``once_display-removed``: listener: (Event -> Display -> unit) -> Screen
        [<Emit "$0.addListener('display-removed',$1)">] abstract ``addListener_display-removed``: listener: (Event -> Display -> unit) -> Screen
        [<Emit "$0.removeListener('display-removed',$1)">] abstract ``removeListener_display-removed``: listener: (Event -> Display -> unit) -> Screen
        /// <summary>
        /// Converts a screen DIP point to a screen physical point. The DPI scale is
        /// performed relative to the display containing the DIP point.
        /// </summary>
        abstract dipToScreenPoint: point: Point -> Point
        /// <summary>
        /// Converts a screen DIP rect to a screen physical rect. The DPI scale is performed
        /// relative to the display nearest to <c>window</c>. If <c>window</c> is null, scaling will
        /// be performed to the display nearest to <c>rect</c>.
        /// </summary>
        abstract dipToScreenRect: window: BrowserWindow option * rect: Rectangle -> Rectangle
        /// An array of displays that are currently available.
        abstract getAllDisplays: unit -> ResizeArray<Display>
        /// The current absolute position of the mouse pointer.
        abstract getCursorScreenPoint: unit -> Point
        /// The display that most closely intersects the provided bounds.
        abstract getDisplayMatching: rect: Rectangle -> Display
        /// The display nearest the specified point.
        abstract getDisplayNearestPoint: point: Point -> Display
        /// The primary display.
        abstract getPrimaryDisplay: unit -> Display
        /// <summary>
        /// Converts a screen physical point to a screen DIP point. The DPI scale is
        /// performed relative to the display containing the physical point.
        /// </summary>
        abstract screenToDipPoint: point: Point -> Point
        /// <summary>
        /// Converts a screen physical rect to a screen DIP rect. The DPI scale is performed
        /// relative to the display nearest to <c>window</c>. If <c>window</c> is null, scaling will
        /// be performed to the display nearest to <c>rect</c>.
        /// </summary>
        abstract screenToDipRect: window: BrowserWindow option * rect: Rectangle -> Rectangle

    type [<AllowNullLiteral>] ScrubberItem =
        /// The image to appear in this item.
        abstract icon: NativeImage option with get, set
        /// The text to appear in this item.
        abstract label: string option with get, set

    type [<AllowNullLiteral>] SegmentedControlSegment =
        /// Whether this segment is selectable. Default: true.
        abstract enabled: bool option with get, set
        /// The image to appear in this segment.
        abstract icon: NativeImage option with get, set
        /// The text to appear in this segment.
        abstract label: string option with get, set

    type [<AllowNullLiteral>] ServiceWorkerInfo =
        /// <summary>
        /// The virtual ID of the process that this service worker is running in.  This is
        /// not an OS level PID.  This aligns with the ID set used for
        /// <c>webContents.getProcessId()</c>.
        /// </summary>
        abstract renderProcessId: float with get, set
        /// The base URL that this service worker is active for.
        abstract scope: string with get, set
        /// The full URL to the script that this service worker runs
        abstract scriptUrl: string with get, set

    type [<AllowNullLiteral>] ServiceWorkers =
        inherit NodeJS.EventEmitter
        /// Emitted when a service worker logs something to the console.
        [<Emit "$0.on('console-message',$1)">] abstract ``on_console-message``: listener: (Event -> MessageDetails -> unit) -> ServiceWorkers
        [<Emit "$0.once('console-message',$1)">] abstract ``once_console-message``: listener: (Event -> MessageDetails -> unit) -> ServiceWorkers
        [<Emit "$0.addListener('console-message',$1)">] abstract ``addListener_console-message``: listener: (Event -> MessageDetails -> unit) -> ServiceWorkers
        [<Emit "$0.removeListener('console-message',$1)">] abstract ``removeListener_console-message``: listener: (Event -> MessageDetails -> unit) -> ServiceWorkers
        /// A ServiceWorkerInfo object where the keys are the service worker version ID and
        /// the values are the information about that service worker.
        abstract getAllRunning: unit -> Record<float, ServiceWorkerInfo>
        /// Information about this service worker
        /// 
        /// If the service worker does not exist or is not running this method will throw an
        /// exception.
        abstract getFromVersionID: versionId: float -> ServiceWorkerInfo

    type [<AllowNullLiteral>] ServiceWorkersStatic =
        [<EmitConstructor>] abstract Create: unit -> ServiceWorkers

    type [<AllowNullLiteral>] Session =
        inherit NodeJS.EventEmitter
        /// Emitted when a render process requests preconnection to a URL, generally due to
        /// a resource hint.
        [<Emit "$0.on('preconnect',$1)">] abstract on_preconnect: listener: (Event -> string -> bool -> unit) -> Session
        [<Emit "$0.once('preconnect',$1)">] abstract once_preconnect: listener: (Event -> string -> bool -> unit) -> Session
        [<Emit "$0.addListener('preconnect',$1)">] abstract addListener_preconnect: listener: (Event -> string -> bool -> unit) -> Session
        [<Emit "$0.removeListener('preconnect',$1)">] abstract removeListener_preconnect: listener: (Event -> string -> bool -> unit) -> Session
        /// Emitted when a hunspell dictionary file starts downloading
        [<Emit "$0.on('spellcheck-dictionary-download-begin',$1)">] abstract ``on_spellcheck-dictionary-download-begin``: listener: (Event -> string -> unit) -> Session
        [<Emit "$0.once('spellcheck-dictionary-download-begin',$1)">] abstract ``once_spellcheck-dictionary-download-begin``: listener: (Event -> string -> unit) -> Session
        [<Emit "$0.addListener('spellcheck-dictionary-download-begin',$1)">] abstract ``addListener_spellcheck-dictionary-download-begin``: listener: (Event -> string -> unit) -> Session
        [<Emit "$0.removeListener('spellcheck-dictionary-download-begin',$1)">] abstract ``removeListener_spellcheck-dictionary-download-begin``: listener: (Event -> string -> unit) -> Session
        /// Emitted when a hunspell dictionary file download fails.  For details on the
        /// failure you should collect a netlog and inspect the download request.
        [<Emit "$0.on('spellcheck-dictionary-download-failure',$1)">] abstract ``on_spellcheck-dictionary-download-failure``: listener: (Event -> string -> unit) -> Session
        [<Emit "$0.once('spellcheck-dictionary-download-failure',$1)">] abstract ``once_spellcheck-dictionary-download-failure``: listener: (Event -> string -> unit) -> Session
        [<Emit "$0.addListener('spellcheck-dictionary-download-failure',$1)">] abstract ``addListener_spellcheck-dictionary-download-failure``: listener: (Event -> string -> unit) -> Session
        [<Emit "$0.removeListener('spellcheck-dictionary-download-failure',$1)">] abstract ``removeListener_spellcheck-dictionary-download-failure``: listener: (Event -> string -> unit) -> Session
        /// Emitted when a hunspell dictionary file has been successfully downloaded
        [<Emit "$0.on('spellcheck-dictionary-download-success',$1)">] abstract ``on_spellcheck-dictionary-download-success``: listener: (Event -> string -> unit) -> Session
        [<Emit "$0.once('spellcheck-dictionary-download-success',$1)">] abstract ``once_spellcheck-dictionary-download-success``: listener: (Event -> string -> unit) -> Session
        [<Emit "$0.addListener('spellcheck-dictionary-download-success',$1)">] abstract ``addListener_spellcheck-dictionary-download-success``: listener: (Event -> string -> unit) -> Session
        [<Emit "$0.removeListener('spellcheck-dictionary-download-success',$1)">] abstract ``removeListener_spellcheck-dictionary-download-success``: listener: (Event -> string -> unit) -> Session
        /// Emitted when a hunspell dictionary file has been successfully initialized. This
        /// occurs after the file has been downloaded.
        [<Emit "$0.on('spellcheck-dictionary-initialized',$1)">] abstract ``on_spellcheck-dictionary-initialized``: listener: (Event -> string -> unit) -> Session
        [<Emit "$0.once('spellcheck-dictionary-initialized',$1)">] abstract ``once_spellcheck-dictionary-initialized``: listener: (Event -> string -> unit) -> Session
        [<Emit "$0.addListener('spellcheck-dictionary-initialized',$1)">] abstract ``addListener_spellcheck-dictionary-initialized``: listener: (Event -> string -> unit) -> Session
        [<Emit "$0.removeListener('spellcheck-dictionary-initialized',$1)">] abstract ``removeListener_spellcheck-dictionary-initialized``: listener: (Event -> string -> unit) -> Session
        /// <summary>
        /// Emitted when Electron is about to download <c>item</c> in <c>webContents</c>.
        /// 
        /// Calling <c>event.preventDefault()</c> will cancel the download and <c>item</c> will not be
        /// available from next tick of the process.
        /// </summary>
        [<Emit "$0.on('will-download',$1)">] abstract ``on_will-download``: listener: (Event -> DownloadItem -> WebContents -> unit) -> Session
        [<Emit "$0.once('will-download',$1)">] abstract ``once_will-download``: listener: (Event -> DownloadItem -> WebContents -> unit) -> Session
        [<Emit "$0.addListener('will-download',$1)">] abstract ``addListener_will-download``: listener: (Event -> DownloadItem -> WebContents -> unit) -> Session
        [<Emit "$0.removeListener('will-download',$1)">] abstract ``removeListener_will-download``: listener: (Event -> DownloadItem -> WebContents -> unit) -> Session
        /// Whether the word was successfully written to the custom dictionary. This API
        /// will not work on non-persistent (in-memory) sessions.
        /// 
        /// **Note:** On macOS and Windows 10 this word will be written to the OS custom
        /// dictionary as well
        abstract addWordToSpellCheckerDictionary: word: string -> bool
        /// Dynamically sets whether to always send credentials for HTTP NTLM or Negotiate
        /// authentication.
        abstract allowNTLMCredentialsForDomains: domains: string -> unit
        /// resolves when the session’s HTTP authentication cache has been cleared.
        abstract clearAuthCache: options: U2<RemovePassword, RemoveClientCertificate> -> Promise<unit>
        /// resolves when the cache clear operation is complete.
        /// 
        /// Clears the session’s HTTP cache.
        abstract clearCache: unit -> Promise<unit>
        /// Resolves when the operation is complete.
        /// 
        /// Clears the host resolver cache.
        abstract clearHostResolverCache: unit -> Promise<unit>
        /// resolves when the storage data has been cleared.
        abstract clearStorageData: ?options: ClearStorageDataOptions -> Promise<unit>
        /// <summary>
        /// Allows resuming <c>cancelled</c> or <c>interrupted</c> downloads from previous <c>Session</c>.
        /// The API will generate a DownloadItem that can be accessed with the will-download
        /// event. The DownloadItem will not have any <c>WebContents</c> associated with it and
        /// the initial state will be <c>interrupted</c>. The download will start only when the
        /// <c>resume</c> API is called on the DownloadItem.
        /// </summary>
        abstract createInterruptedDownload: options: CreateInterruptedDownloadOptions -> unit
        /// <summary>
        /// Disables any network emulation already active for the <c>session</c>. Resets to the
        /// original network configuration.
        /// </summary>
        abstract disableNetworkEmulation: unit -> unit
        /// <summary>
        /// Initiates a download of the resource at <c>url</c>. The API will generate a
        /// DownloadItem that can be accessed with the will-download event.
        /// 
        /// **Note:** This does not perform any security checks that relate to a page's
        /// origin, unlike <c>webContents.downloadURL</c>.
        /// </summary>
        abstract downloadURL: url: string -> unit
        /// <summary>Emulates network with the given configuration for the <c>session</c>.</summary>
        abstract enableNetworkEmulation: options: EnableNetworkEmulationOptions -> unit
        /// Writes any unwritten DOMStorage data to disk.
        abstract flushStorageData: unit -> unit
        /// <summary>
        /// A list of all loaded extensions.
        /// 
        /// **Note:** This API cannot be called before the <c>ready</c> event of the <c>app</c> module
        /// is emitted.
        /// </summary>
        abstract getAllExtensions: unit -> ResizeArray<Extension>
        /// resolves with blob data.
        abstract getBlobData: identifier: string -> Promise<Buffer>
        /// the session's current cache size, in bytes.
        abstract getCacheSize: unit -> Promise<float>
        /// <summary>
        /// | <c>null</c> - The loaded extension with the given ID.
        /// 
        /// **Note:** This API cannot be called before the <c>ready</c> event of the <c>app</c> module
        /// is emitted.
        /// </summary>
        abstract getExtension: extensionId: string -> Extension
        /// an array of paths to preload scripts that have been registered.
        abstract getPreloads: unit -> ResizeArray<string>
        /// <summary>
        /// An array of language codes the spellchecker is enabled for.  If this list is
        /// empty the spellchecker will fallback to using <c>en-US</c>.  By default on launch if
        /// this setting is an empty list Electron will try to populate this setting with
        /// the current OS locale.  This setting is persisted across restarts.
        /// 
        /// **Note:** On macOS the OS spellchecker is used and has it's own list of
        /// languages.  This API is a no-op on macOS.
        /// </summary>
        abstract getSpellCheckerLanguages: unit -> ResizeArray<string>
        /// The user agent for this session.
        abstract getUserAgent: unit -> string
        /// An array of all words in app's custom dictionary. Resolves when the full
        /// dictionary is loaded from disk.
        abstract listWordsInSpellCheckerDictionary: unit -> Promise<ResizeArray<string>>
        /// <summary>
        /// resolves when the extension is loaded.
        /// 
        /// This method will raise an exception if the extension could not be loaded. If
        /// there are warnings when installing the extension (e.g. if the extension requests
        /// an API that Electron does not support) then they will be logged to the console.
        /// 
        /// Note that Electron does not support the full range of Chrome extensions APIs.
        /// 
        /// Note that in previous versions of Electron, extensions that were loaded would be
        /// remembered for future runs of the application. This is no longer the case:
        /// <c>loadExtension</c> must be called on every boot of your app if you want the
        /// extension to be loaded.
        /// 
        /// This API does not support loading packed (.crx) extensions.
        /// 
        /// **Note:** This API cannot be called before the <c>ready</c> event of the <c>app</c> module
        /// is emitted.
        /// </summary>
        abstract loadExtension: path: string -> Promise<Electron.Extension>
        /// Preconnects the given number of sockets to an origin.
        abstract preconnect: options: PreconnectOptions -> unit
        /// <summary>
        /// Unloads an extension.
        /// 
        /// **Note:** This API cannot be called before the <c>ready</c> event of the <c>app</c> module
        /// is emitted.
        /// </summary>
        abstract removeExtension: extensionId: string -> unit
        /// Whether the word was successfully removed from the custom dictionary. This API
        /// will not work on non-persistent (in-memory) sessions.
        /// 
        /// **Note:** On macOS and Windows 10 this word will be removed from the OS custom
        /// dictionary as well
        abstract removeWordFromSpellCheckerDictionary: word: string -> bool
        /// <summary>Resolves with the proxy information for <c>url</c>.</summary>
        abstract resolveProxy: url: string -> Promise<string>
        /// <summary>
        /// Sets the certificate verify proc for <c>session</c>, the <c>proc</c> will be called with
        /// <c>proc(request, callback)</c> whenever a server certificate verification is
        /// requested. Calling <c>callback(0)</c> accepts the certificate, calling <c>callback(-2)</c>
        /// rejects it.
        /// 
        /// Calling <c>setCertificateVerifyProc(null)</c> will revert back to default certificate
        /// verify proc.
        /// </summary>
        abstract setCertificateVerifyProc: proc: (CertificateVerifyProcProcRequest -> (float -> unit) -> unit) option -> unit
        /// <summary>
        /// Sets download saving directory. By default, the download directory will be the
        /// <c>Downloads</c> under the respective app folder.
        /// </summary>
        abstract setDownloadPath: path: string -> unit
        /// <summary>
        /// Sets the handler which can be used to respond to permission checks for the
        /// <c>session</c>. Returning <c>true</c> will allow the permission and <c>false</c> will reject
        /// it. To clear the handler, call <c>setPermissionCheckHandler(null)</c>.
        /// </summary>
        abstract setPermissionCheckHandler: handler: (WebContents -> string -> string -> PermissionCheckHandlerHandlerDetails -> bool) option -> unit
        /// <summary>
        /// Sets the handler which can be used to respond to permission requests for the
        /// <c>session</c>. Calling <c>callback(true)</c> will allow the permission and
        /// <c>callback(false)</c> will reject it. To clear the handler, call
        /// <c>setPermissionRequestHandler(null)</c>.
        /// </summary>
        abstract setPermissionRequestHandler: handler: (WebContents -> string -> (bool -> unit) -> PermissionRequestHandlerHandlerDetails -> unit) option -> unit
        /// <summary>
        /// Adds scripts that will be executed on ALL web contents that are associated with
        /// this session just before normal <c>preload</c> scripts run.
        /// </summary>
        abstract setPreloads: preloads: ResizeArray<string> -> unit
        /// <summary>
        /// Resolves when the proxy setting process is complete.
        /// 
        /// Sets the proxy settings.
        /// 
        /// When <c>pacScript</c> and <c>proxyRules</c> are provided together, the <c>proxyRules</c> option
        /// is ignored and <c>pacScript</c> configuration is applied.
        /// 
        /// The <c>proxyRules</c> has to follow the rules below:
        /// 
        /// For example:
        /// 
        /// * <c>http=foopy:80;ftp=foopy2</c> - Use HTTP proxy <c>foopy:80</c> for <c>http://</c> URLs, and
        /// HTTP proxy <c>foopy2:80</c> for <c>ftp://</c> URLs.
        /// * <c>foopy:80</c> - Use HTTP proxy <c>foopy:80</c> for all URLs.
        /// * <c>foopy:80,bar,direct://</c> - Use HTTP proxy <c>foopy:80</c> for all URLs, failing
        /// over to <c>bar</c> if <c>foopy:80</c> is unavailable, and after that using no proxy.
        /// * <c>socks4://foopy</c> - Use SOCKS v4 proxy <c>foopy:1080</c> for all URLs.
        /// * <c>http=foopy,socks5://bar.com</c> - Use HTTP proxy <c>foopy</c> for http URLs, and fail
        /// over to the SOCKS5 proxy <c>bar.com</c> if <c>foopy</c> is unavailable.
        /// * <c>http=foopy,direct://</c> - Use HTTP proxy <c>foopy</c> for http URLs, and use no
        /// proxy if <c>foopy</c> is unavailable.
        /// * <c>http=foopy;socks=foopy2</c> - Use HTTP proxy <c>foopy</c> for http URLs, and use
        /// <c>socks4://foopy2</c> for all other URLs.
        /// 
        /// The <c>proxyBypassRules</c> is a comma separated list of rules described below:
        /// 
        /// * <c>[ URL_SCHEME "://" ] HOSTNAME_PATTERN [ ":" &lt;port&gt; ]</c>
        /// 
        /// Match all hostnames that match the pattern HOSTNAME_PATTERN.
        /// 
        /// Examples: "foobar.com", "*foobar.com", "*.foobar.com", "*foobar.com:99",
        /// "<see href="https://x.*.y.com:99"" />
        /// * <c>"." HOSTNAME_SUFFIX_PATTERN [ ":" PORT ]</c>
        /// 
        /// Match a particular domain suffix.
        /// 
        /// Examples: ".google.com", ".com", "<see href="http://.google.com"" />
        /// * <c>[ SCHEME "://" ] IP_LITERAL [ ":" PORT ]</c>
        /// 
        /// Match URLs which are IP address literals.
        /// 
        /// Examples: "127.0.1", "[0:0::1]", "[::1]", "<see href="http://[::1]:99"" />
        /// * <c>IP_LITERAL "/" PREFIX_LENGTH_IN_BITS</c>
        /// 
        /// Match any URL that is to an IP literal that falls between the given range. IP
        /// range is specified using CIDR notation.
        /// 
        /// Examples: "192.168.1.1/16", "fefe:13::abc/33".
        /// * <c>&lt;local&gt;</c>
        /// 
        /// Match local addresses. The meaning of <c>&lt;local&gt;</c> is whether the host matches one
        /// of: "127.0.0.1", "::1", "localhost".
        /// </summary>
        abstract setProxy: config: Config -> Promise<unit>
        /// <summary>
        /// By default Electron will download hunspell dictionaries from the Chromium CDN.
        /// If you want to override this behavior you can use this API to point the
        /// dictionary downloader at your own hosted version of the hunspell dictionaries.
        /// We publish a <c>hunspell_dictionaries.zip</c> file with each release which contains
        /// the files you need to host here, the file server must be **case insensitive**
        /// you must upload each file twice, once with the case it has in the ZIP file and
        /// once with the filename as all lower case.
        /// 
        /// If the files present in <c>hunspell_dictionaries.zip</c> are available at
        /// <c>https://example.com/dictionaries/language-code.bdic</c> then you should call this
        /// api with
        /// <c>ses.setSpellCheckerDictionaryDownloadURL('https://example.com/dictionaries/')</c>.
        ///   Please note the trailing slash.  The URL to the dictionaries is formed as
        /// <c>${url}${filename}</c>.
        /// 
        /// **Note:** On macOS the OS spellchecker is used and therefore we do not download
        /// any dictionary files.  This API is a no-op on macOS.
        /// </summary>
        abstract setSpellCheckerDictionaryDownloadURL: url: string -> unit
        /// <summary>
        /// The built in spellchecker does not automatically detect what language a user is
        /// typing in.  In order for the spell checker to correctly check their words you
        /// must call this API with an array of language codes.  You can get the list of
        /// supported language codes with the <c>ses.availableSpellCheckerLanguages</c> property.
        /// 
        /// **Note:** On macOS the OS spellchecker is used and will detect your language
        /// automatically.  This API is a no-op on macOS.
        /// </summary>
        abstract setSpellCheckerLanguages: languages: ResizeArray<string> -> unit
        /// <summary>
        /// Overrides the <c>userAgent</c> and <c>acceptLanguages</c> for this session.
        /// 
        /// The <c>acceptLanguages</c> must a comma separated ordered list of language codes, for
        /// example <c>"en-US,fr,de,ko,zh-CN,ja"</c>.
        /// 
        /// This doesn't affect existing <c>WebContents</c>, and each <c>WebContents</c> can use
        /// <c>webContents.setUserAgent</c> to override the session-wide user agent.
        /// </summary>
        abstract setUserAgent: userAgent: string * ?acceptLanguages: string -> unit
        abstract availableSpellCheckerLanguages: ResizeArray<string>
        abstract cookies: Cookies
        abstract netLog: NetLog
        abstract protocol: Protocol
        abstract serviceWorkers: ServiceWorkers
        abstract webRequest: WebRequest

    type [<AllowNullLiteral>] SessionStatic =
        [<EmitConstructor>] abstract Create: unit -> Session
        /// <summary>
        /// A session instance from <c>partition</c> string. When there is an existing <c>Session</c>
        /// with the same <c>partition</c>, it will be returned; otherwise a new <c>Session</c>
        /// instance will be created with <c>options</c>.
        /// 
        /// If <c>partition</c> starts with <c>persist:</c>, the page will use a persistent session
        /// available to all pages in the app with the same <c>partition</c>. if there is no
        /// <c>persist:</c> prefix, the page will use an in-memory session. If the <c>partition</c> is
        /// empty then default session of the app will be returned.
        /// 
        /// To create a <c>Session</c> with <c>options</c>, you have to ensure the <c>Session</c> with the
        /// <c>partition</c> has never been used before. There is no way to change the <c>options</c>
        /// of an existing <c>Session</c> object.
        /// </summary>
        abstract fromPartition: partition: string * ?options: FromPartitionOptions -> Session
        /// <summary>A <c>Session</c> object, the default session object of the app.</summary>
        abstract defaultSession: Session with get, set

    type [<AllowNullLiteral>] SharedWorkerInfo =
        /// The unique id of the shared worker.
        abstract id: string with get, set
        /// The url of the shared worker.
        abstract url: string with get, set

    type [<AllowNullLiteral>] Shell =
        /// Play the beep sound.
        abstract beep: unit -> unit
        /// Whether the item was successfully moved to the trash or otherwise deleted.
        /// 
        /// Move the given file to trash and returns a boolean status for the operation.
        abstract moveItemToTrash: fullPath: string * ?deleteOnFail: bool -> bool
        /// Open the given external protocol URL in the desktop's default manner. (For
        /// example, mailto: URLs in the user's default mail agent).
        abstract openExternal: url: string * ?options: OpenExternalOptions -> Promise<unit>
        /// Resolves with an string containing the error message corresponding to the
        /// failure if a failure occurred, otherwise "".
        /// 
        /// Open the given file in the desktop's default manner.
        abstract openPath: path: string -> Promise<string>
        /// <summary>
        /// Resolves the shortcut link at <c>shortcutPath</c>.
        /// 
        /// An exception will be thrown when any error happens.
        /// </summary>
        abstract readShortcutLink: shortcutPath: string -> ShortcutDetails
        /// Show the given file in a file manager. If possible, select the file.
        abstract showItemInFolder: fullPath: string -> unit
        /// <summary>
        /// Whether the shortcut was created successfully.
        /// 
        /// Creates or updates a shortcut link at <c>shortcutPath</c>.
        /// </summary>
        abstract writeShortcutLink: shortcutPath: string * operation: ShellWriteShortcutLinkOperation * options: ShortcutDetails -> bool
        /// <summary>
        /// Whether the shortcut was created successfully.
        /// 
        /// Creates or updates a shortcut link at <c>shortcutPath</c>.
        /// </summary>
        abstract writeShortcutLink: shortcutPath: string * options: ShortcutDetails -> bool

    type [<StringEnum>] [<RequireQualifiedAccess>] ShellWriteShortcutLinkOperation =
        | Create
        | Update
        | Replace

    type [<AllowNullLiteral>] ShortcutDetails =
        /// The Application User Model ID. Default is empty.
        abstract appUserModelId: string option with get, set
        /// <summary>
        /// The arguments to be applied to <c>target</c> when launching from this shortcut.
        /// Default is empty.
        /// </summary>
        abstract args: string option with get, set
        /// The working directory. Default is empty.
        abstract cwd: string option with get, set
        /// The description of the shortcut. Default is empty.
        abstract description: string option with get, set
        /// <summary>
        /// The path to the icon, can be a DLL or EXE. <c>icon</c> and <c>iconIndex</c> have to be set
        /// together. Default is empty, which uses the target's icon.
        /// </summary>
        abstract icon: string option with get, set
        /// <summary>The resource ID of icon when <c>icon</c> is a DLL or EXE. Default is 0.</summary>
        abstract iconIndex: float option with get, set
        /// The target to launch from this shortcut.
        abstract target: string with get, set

    type [<AllowNullLiteral>] Size =
        abstract height: float with get, set
        abstract width: float with get, set

    type [<AllowNullLiteral>] StreamProtocolResponse =
        /// A Node.js readable stream representing the response body.
        abstract data: NodeJS.ReadableStream option with get, set
        /// An object containing the response headers.
        abstract headers: Record<string, U2<string, ResizeArray<string>>> option with get, set
        /// The HTTP response code.
        abstract statusCode: float option with get, set

    type [<AllowNullLiteral>] StringProtocolResponse =
        /// Charset of the response.
        abstract charset: string option with get, set
        /// A string representing the response body.
        abstract data: string option with get, set
        /// MIME type of the response.
        abstract mimeType: string option with get, set

    type [<AllowNullLiteral>] SystemPreferences =
        inherit NodeJS.EventEmitter
        [<Emit "$0.on('accent-color-changed',$1)">] abstract ``on_accent-color-changed``: listener: (Event -> string -> unit) -> SystemPreferences
        [<Emit "$0.once('accent-color-changed',$1)">] abstract ``once_accent-color-changed``: listener: (Event -> string -> unit) -> SystemPreferences
        [<Emit "$0.addListener('accent-color-changed',$1)">] abstract ``addListener_accent-color-changed``: listener: (Event -> string -> unit) -> SystemPreferences
        [<Emit "$0.removeListener('accent-color-changed',$1)">] abstract ``removeListener_accent-color-changed``: listener: (Event -> string -> unit) -> SystemPreferences
        [<Emit "$0.on('color-changed',$1)">] abstract ``on_color-changed``: listener: (Event -> unit) -> SystemPreferences
        [<Emit "$0.once('color-changed',$1)">] abstract ``once_color-changed``: listener: (Event -> unit) -> SystemPreferences
        [<Emit "$0.addListener('color-changed',$1)">] abstract ``addListener_color-changed``: listener: (Event -> unit) -> SystemPreferences
        [<Emit "$0.removeListener('color-changed',$1)">] abstract ``removeListener_color-changed``: listener: (Event -> unit) -> SystemPreferences
        /// <summary>**Deprecated:** Should use the new <c>updated</c> event on the <c>nativeTheme</c> module.</summary>
        [<Obsolete("")>]
        [<Emit "$0.on('high-contrast-color-scheme-changed',$1)">] abstract ``on_high-contrast-color-scheme-changed``: listener: (Event -> bool -> unit) -> SystemPreferences
        [<Emit "$0.once('high-contrast-color-scheme-changed',$1)">] abstract ``once_high-contrast-color-scheme-changed``: listener: (Event -> bool -> unit) -> SystemPreferences
        [<Emit "$0.addListener('high-contrast-color-scheme-changed',$1)">] abstract ``addListener_high-contrast-color-scheme-changed``: listener: (Event -> bool -> unit) -> SystemPreferences
        [<Emit "$0.removeListener('high-contrast-color-scheme-changed',$1)">] abstract ``removeListener_high-contrast-color-scheme-changed``: listener: (Event -> bool -> unit) -> SystemPreferences
        /// <summary>**Deprecated:** Should use the new <c>updated</c> event on the <c>nativeTheme</c> module.</summary>
        [<Obsolete("")>]
        [<Emit "$0.on('inverted-color-scheme-changed',$1)">] abstract ``on_inverted-color-scheme-changed``: listener: (Event -> bool -> unit) -> SystemPreferences
        [<Emit "$0.once('inverted-color-scheme-changed',$1)">] abstract ``once_inverted-color-scheme-changed``: listener: (Event -> bool -> unit) -> SystemPreferences
        [<Emit "$0.addListener('inverted-color-scheme-changed',$1)">] abstract ``addListener_inverted-color-scheme-changed``: listener: (Event -> bool -> unit) -> SystemPreferences
        [<Emit "$0.removeListener('inverted-color-scheme-changed',$1)">] abstract ``removeListener_inverted-color-scheme-changed``: listener: (Event -> bool -> unit) -> SystemPreferences
        /// <summary>
        /// A promise that resolves with <c>true</c> if consent was granted and <c>false</c> if it was
        /// denied. If an invalid <c>mediaType</c> is passed, the promise will be rejected. If an
        /// access request was denied and later is changed through the System Preferences
        /// pane, a restart of the app will be required for the new permissions to take
        /// effect. If access has already been requested and denied, it _must_ be changed
        /// through the preference pane; an alert will not pop up and the promise will
        /// resolve with the existing access status.
        /// 
        /// **Important:** In order to properly leverage this API, you must set the
        /// <c>NSMicrophoneUsageDescription</c> and <c>NSCameraUsageDescription</c> strings in your
        /// app's <c>Info.plist</c> file. The values for these keys will be used to populate the
        /// permission dialogs so that the user will be properly informed as to the purpose
        /// of the permission request. See Electron Application Distribution for more
        /// information about how to set these in the context of Electron.
        /// 
        /// This user consent was not required until macOS 10.14 Mojave, so this method will
        /// always return <c>true</c> if your system is running 10.13 High Sierra or lower.
        /// </summary>
        abstract askForMediaAccess: mediaType: SystemPreferencesAskForMediaAccessMediaType -> Promise<bool>
        /// <summary>
        /// whether or not this device has the ability to use Touch ID.
        /// 
        /// **NOTE:** This API will return <c>false</c> on macOS systems older than Sierra
        /// 10.12.2.
        /// </summary>
        abstract canPromptTouchID: unit -> bool
        /// <summary>
        /// The users current system wide accent color preference in RGBA hexadecimal form.
        /// 
        /// This API is only available on macOS 10.14 Mojave or newer.
        /// </summary>
        abstract getAccentColor: unit -> string
        /// <summary>
        /// * <c>shouldRenderRichAnimation</c> Boolean - Returns true if rich animations should
        /// be rendered. Looks at session type (e.g. remote desktop) and accessibility
        /// settings to give guidance for heavy animations.
        /// * <c>scrollAnimationsEnabledBySystem</c> Boolean - Determines on a per-platform basis
        /// whether scroll animations (e.g. produced by home/end key) should be enabled.
        /// * <c>prefersReducedMotion</c> Boolean - Determines whether the user desires reduced
        /// motion based on platform APIs.
        /// 
        /// Returns an object with system animation settings.
        /// </summary>
        abstract getAnimationSettings: unit -> AnimationSettings
        /// <summary>
        /// | <c>null</c> - Can be <c>dark</c>, <c>light</c> or <c>unknown</c>.
        /// 
        /// Gets the macOS appearance setting that you have declared you want for your
        /// application, maps to NSApplication.appearance. You can use the
        /// <c>setAppLevelAppearance</c> API to set this value.
        /// </summary>
        [<Obsolete("")>]
        abstract getAppLevelAppearance: unit -> SystemPreferencesGetAppLevelAppearanceReturn
        /// <summary>
        /// The system color setting in RGB hexadecimal form (<c>#ABCDEF</c>). See the Windows
        /// docs and the macOS docs for more details.
        /// 
        /// The following colors are only available on macOS 10.14: <c>find-highlight</c>,
        /// <c>selected-content-background</c>, <c>separator</c>,
        /// <c>unemphasized-selected-content-background</c>,
        /// <c>unemphasized-selected-text-background</c>, and <c>unemphasized-selected-text</c>.
        /// </summary>
        abstract getColor: color: SystemPreferencesGetColorColor -> string
        /// <summary>
        /// Can be <c>dark</c>, <c>light</c> or <c>unknown</c>.
        /// 
        /// Gets the macOS appearance setting that is currently applied to your application,
        /// maps to NSApplication.effectiveAppearance
        /// </summary>
        abstract getEffectiveAppearance: unit -> SystemPreferencesGetEffectiveAppearanceReturn
        /// <summary>
        /// Can be <c>not-determined</c>, <c>granted</c>, <c>denied</c>, <c>restricted</c> or <c>unknown</c>.
        /// 
        /// This user consent was not required on macOS 10.13 High Sierra or lower so this
        /// method will always return <c>granted</c>. macOS 10.14 Mojave or higher requires
        /// consent for <c>microphone</c> and <c>camera</c> access. macOS 10.15 Catalina or higher
        /// requires consent for <c>screen</c> access.
        /// 
        /// Windows 10 has a global setting controlling <c>microphone</c> and <c>camera</c> access for
        /// all win32 applications. It will always return <c>granted</c> for <c>screen</c> and for all
        /// media types on older versions of Windows.
        /// </summary>
        abstract getMediaAccessStatus: mediaType: SystemPreferencesGetMediaAccessStatusMediaType -> SystemPreferencesGetMediaAccessStatusReturn
        /// <summary>
        /// The standard system color formatted as <c>#RRGGBBAA</c>.
        /// 
        /// Returns one of several standard system colors that automatically adapt to
        /// vibrancy and changes in accessibility settings like 'Increase contrast' and
        /// 'Reduce transparency'. See Apple Documentation for  more details.
        /// </summary>
        abstract getSystemColor: color: SystemPreferencesGetSystemColorColor -> string
        /// <summary>
        /// The value of <c>key</c> in <c>NSUserDefaults</c>.
        /// 
        /// Some popular <c>key</c> and <c>type</c>s are:
        /// 
        /// * <c>AppleInterfaceStyle</c>: <c>string</c>
        /// * <c>AppleAquaColorVariant</c>: <c>integer</c>
        /// * <c>AppleHighlightColor</c>: <c>string</c>
        /// * <c>AppleShowScrollBars</c>: <c>string</c>
        /// * <c>NSNavRecentPlaces</c>: <c>array</c>
        /// * <c>NSPreferredWebServices</c>: <c>dictionary</c>
        /// * <c>NSUserDictionaryReplacementItems</c>: <c>array</c>
        /// </summary>
        abstract getUserDefault: key: string * ``type``: SystemPreferencesGetUserDefaultType -> obj option
        /// <summary>
        /// <c>true</c> if DWM composition (Aero Glass) is enabled, and <c>false</c> otherwise.
        /// 
        /// An example of using it to determine if you should create a transparent window or
        /// not (transparent windows won't work correctly when DWM composition is disabled):
        /// </summary>
        abstract isAeroGlassEnabled: unit -> bool
        /// <summary>
        /// Whether the system is in Dark Mode.
        /// 
        /// **Note:** On macOS 10.15 Catalina in order for this API to return the correct
        /// value when in the "automatic" dark mode setting you must either have
        /// <c>NSRequiresAquaSystemAppearance=false</c> in your <c>Info.plist</c> or be on Electron
        /// <c>&gt;=7.0.0</c>.  See the dark mode guide for more information.
        /// 
        /// *Deprecated:** Should use the new <c>nativeTheme.shouldUseDarkColors</c> API.
        /// </summary>
        [<Obsolete("")>]
        abstract isDarkMode: unit -> bool
        /// <summary>
        /// <c>true</c> if a high contrast theme is active, <c>false</c> otherwise.
        /// 
        /// **Deprecated:** Should use the new <c>nativeTheme.shouldUseHighContrastColors</c>
        /// API.
        /// </summary>
        [<Obsolete("")>]
        abstract isHighContrastColorScheme: unit -> bool
        /// <summary>
        /// <c>true</c> if an inverted color scheme (a high contrast color scheme with light text
        /// and dark backgrounds) is active, <c>false</c> otherwise.
        /// 
        /// **Deprecated:** Should use the new <c>nativeTheme.shouldUseInvertedColorScheme</c>
        /// API.
        /// </summary>
        [<Obsolete("")>]
        abstract isInvertedColorScheme: unit -> bool
        /// <summary>Whether the Swipe between pages setting is on.</summary>
        abstract isSwipeTrackingFromScrollEventsEnabled: unit -> bool
        /// <summary>
        /// <c>true</c> if the current process is a trusted accessibility client and <c>false</c> if
        /// it is not.
        /// </summary>
        abstract isTrustedAccessibilityClient: prompt: bool -> bool
        /// <summary>
        /// Posts <c>event</c> as native notifications of macOS. The <c>userInfo</c> is an Object that
        /// contains the user information dictionary sent along with the notification.
        /// </summary>
        abstract postLocalNotification: ``event``: string * userInfo: Record<string, obj option> -> unit
        /// <summary>
        /// Posts <c>event</c> as native notifications of macOS. The <c>userInfo</c> is an Object that
        /// contains the user information dictionary sent along with the notification.
        /// </summary>
        abstract postNotification: ``event``: string * userInfo: Record<string, obj option> * ?deliverImmediately: bool -> unit
        /// <summary>
        /// Posts <c>event</c> as native notifications of macOS. The <c>userInfo</c> is an Object that
        /// contains the user information dictionary sent along with the notification.
        /// </summary>
        abstract postWorkspaceNotification: ``event``: string * userInfo: Record<string, obj option> -> unit
        /// <summary>
        /// resolves if the user has successfully authenticated with Touch ID.
        /// 
        /// This API itself will not protect your user data; rather, it is a mechanism to
        /// allow you to do so. Native apps will need to set Access Control Constants like
        /// <c>kSecAccessControlUserPresence</c> on the their keychain entry so that reading it
        /// would auto-prompt for Touch ID biometric consent. This could be done with
        /// <c>node-keytar</c>, such that one would store an encryption key with <c>node-keytar</c>
        /// and only fetch it if <c>promptTouchID()</c> resolves.
        /// 
        /// **NOTE:** This API will return a rejected Promise on macOS systems older than
        /// Sierra 10.12.2.
        /// </summary>
        abstract promptTouchID: reason: string -> Promise<unit>
        /// <summary>Add the specified defaults to your application's <c>NSUserDefaults</c>.</summary>
        abstract registerDefaults: defaults: Record<string, U3<string, bool, float>> -> unit
        /// <summary>
        /// Removes the <c>key</c> in <c>NSUserDefaults</c>. This can be used to restore the default
        /// or global value of a <c>key</c> previously set with <c>setUserDefault</c>.
        /// </summary>
        abstract removeUserDefault: key: string -> unit
        /// <summary>
        /// Sets the appearance setting for your application, this should override the
        /// system default and override the value of <c>getEffectiveAppearance</c>.
        /// </summary>
        [<Obsolete("")>]
        abstract setAppLevelAppearance: appearance: SystemPreferencesSetAppLevelAppearance option -> unit
        /// <summary>
        /// Set the value of <c>key</c> in <c>NSUserDefaults</c>.
        /// 
        /// Note that <c>type</c> should match actual type of <c>value</c>. An exception is thrown if
        /// they don't.
        /// 
        /// Some popular <c>key</c> and <c>type</c>s are:
        /// 
        /// <c>ApplePressAndHoldEnabled</c>: <c>boolean</c>
        /// </summary>
        abstract setUserDefault: key: string * ``type``: string * value: string -> unit
        /// <summary>
        /// The ID of this subscription
        /// 
        /// Same as <c>subscribeNotification</c>, but uses <c>NSNotificationCenter</c> for local
        /// defaults. This is necessary for events such as
        /// <c>NSUserDefaultsDidChangeNotification</c>.
        /// </summary>
        abstract subscribeLocalNotification: ``event``: string * callback: (string -> Record<string, obj> -> string -> unit) -> float
        /// <summary>
        /// The ID of this subscription
        /// 
        /// Subscribes to native notifications of macOS, <c>callback</c> will be called with
        /// <c>callback(event, userInfo)</c> when the corresponding <c>event</c> happens. The
        /// <c>userInfo</c> is an Object that contains the user information dictionary sent along
        /// with the notification. The <c>object</c> is the sender of the notification, and only
        /// supports <c>NSString</c> values for now.
        /// 
        /// The <c>id</c> of the subscriber is returned, which can be used to unsubscribe the
        /// <c>event</c>.
        /// 
        /// Under the hood this API subscribes to <c>NSDistributedNotificationCenter</c>, example
        /// values of <c>event</c> are:
        /// 
        /// * <c>AppleInterfaceThemeChangedNotification</c>
        /// * <c>AppleAquaColorVariantChanged</c>
        /// * <c>AppleColorPreferencesChangedNotification</c>
        /// * <c>AppleShowScrollBarsSettingChanged</c>
        /// </summary>
        abstract subscribeNotification: ``event``: string * callback: (string -> Record<string, obj> -> string -> unit) -> float
        /// <summary>
        /// Same as <c>subscribeNotification</c>, but uses
        /// <c>NSWorkspace.sharedWorkspace.notificationCenter</c>. This is necessary for events
        /// such as <c>NSWorkspaceDidActivateApplicationNotification</c>.
        /// </summary>
        abstract subscribeWorkspaceNotification: ``event``: string * callback: (string -> Record<string, obj> -> string -> unit) -> unit
        /// <summary>
        /// Same as <c>unsubscribeNotification</c>, but removes the subscriber from
        /// <c>NSNotificationCenter</c>.
        /// </summary>
        abstract unsubscribeLocalNotification: id: float -> unit
        /// <summary>Removes the subscriber with <c>id</c>.</summary>
        abstract unsubscribeNotification: id: float -> unit
        /// <summary>
        /// Same as <c>unsubscribeNotification</c>, but removes the subscriber from
        /// <c>NSWorkspace.sharedWorkspace.notificationCenter</c>.
        /// </summary>
        abstract unsubscribeWorkspaceNotification: id: float -> unit
        /// <summary>
        /// A <c>String</c> property that can be <c>dark</c>, <c>light</c> or <c>unknown</c>. It determines the
        /// macOS appearance setting for your application. This maps to values in:
        /// NSApplication.appearance. Setting this will override the system default as well
        /// as the value of <c>getEffectiveAppearance</c>.
        /// 
        /// Possible values that can be set are <c>dark</c> and <c>light</c>, and possible return
        /// values are <c>dark</c>, <c>light</c>, and <c>unknown</c>.
        /// 
        /// This property is only available on macOS 10.14 Mojave or newer.
        /// </summary>
        abstract appLevelAppearance: SystemPreferencesAppLevelAppearance with get, set
        /// <summary>
        /// A <c>String</c> property that can be <c>dark</c>, <c>light</c> or <c>unknown</c>.
        /// 
        /// Returns the macOS appearance setting that is currently applied to your
        /// application, maps to NSApplication.effectiveAppearance
        /// </summary>
        abstract effectiveAppearance: SystemPreferencesAppLevelAppearance

    type [<StringEnum>] [<RequireQualifiedAccess>] SystemPreferencesAskForMediaAccessMediaType =
        | Microphone
        | Camera

    type [<StringEnum>] [<RequireQualifiedAccess>] SystemPreferencesGetAppLevelAppearanceReturn =
        | Dark
        | Light
        | Unknown

    type [<StringEnum>] [<RequireQualifiedAccess>] SystemPreferencesGetColorColor =
        | [<CompiledName "3d-dark-shadow">] N3dDarkShadow
        | [<CompiledName "3d-face">] N3dFace
        | [<CompiledName "3d-highlight">] N3dHighlight
        | [<CompiledName "3d-light">] N3dLight
        | [<CompiledName "3d-shadow">] N3dShadow
        | [<CompiledName "active-border">] ActiveBorder
        | [<CompiledName "active-caption">] ActiveCaption
        | [<CompiledName "active-caption-gradient">] ActiveCaptionGradient
        | [<CompiledName "app-workspace">] AppWorkspace
        | [<CompiledName "button-text">] ButtonText
        | [<CompiledName "caption-text">] CaptionText
        | Desktop
        | [<CompiledName "disabled-text">] DisabledText
        | Highlight
        | [<CompiledName "highlight-text">] HighlightText
        | Hotlight
        | [<CompiledName "inactive-border">] InactiveBorder
        | [<CompiledName "inactive-caption">] InactiveCaption
        | [<CompiledName "inactive-caption-gradient">] InactiveCaptionGradient
        | [<CompiledName "inactive-caption-text">] InactiveCaptionText
        | [<CompiledName "info-background">] InfoBackground
        | [<CompiledName "info-text">] InfoText
        | Menu
        | [<CompiledName "menu-highlight">] MenuHighlight
        | Menubar
        | [<CompiledName "menu-text">] MenuText
        | Scrollbar
        | Window
        | [<CompiledName "window-frame">] WindowFrame
        | [<CompiledName "window-text">] WindowText
        | [<CompiledName "alternate-selected-control-text">] AlternateSelectedControlText
        | [<CompiledName "control-background">] ControlBackground
        | Control
        | [<CompiledName "control-text">] ControlText
        | [<CompiledName "disabled-control-text">] DisabledControlText
        | [<CompiledName "find-highlight">] FindHighlight
        | Grid
        | [<CompiledName "header-text">] HeaderText
        | Highlight
        | [<CompiledName "keyboard-focus-indicator">] KeyboardFocusIndicator
        | Label
        | Link
        | [<CompiledName "placeholder-text">] PlaceholderText
        | [<CompiledName "quaternary-label">] QuaternaryLabel
        | [<CompiledName "scrubber-textured-background">] ScrubberTexturedBackground
        | [<CompiledName "secondary-label">] SecondaryLabel
        | [<CompiledName "selected-content-background">] SelectedContentBackground
        | [<CompiledName "selected-control">] SelectedControl
        | [<CompiledName "selected-control-text">] SelectedControlText
        | [<CompiledName "selected-menu-item-text">] SelectedMenuItemText
        | [<CompiledName "selected-text-background">] SelectedTextBackground
        | [<CompiledName "selected-text">] SelectedText
        | Separator
        | Shadow
        | [<CompiledName "tertiary-label">] TertiaryLabel
        | [<CompiledName "text-background">] TextBackground
        | Text
        | [<CompiledName "under-page-background">] UnderPageBackground
        | [<CompiledName "unemphasized-selected-content-background">] UnemphasizedSelectedContentBackground
        | [<CompiledName "unemphasized-selected-text-background">] UnemphasizedSelectedTextBackground
        | [<CompiledName "unemphasized-selected-text">] UnemphasizedSelectedText
        | [<CompiledName "window-background">] WindowBackground
        | [<CompiledName "window-frame-text">] WindowFrameText

    type [<StringEnum>] [<RequireQualifiedAccess>] SystemPreferencesGetEffectiveAppearanceReturn =
        | Dark
        | Light
        | Unknown

    type [<StringEnum>] [<RequireQualifiedAccess>] SystemPreferencesGetMediaAccessStatusMediaType =
        | Microphone
        | Camera
        | Screen

    type [<StringEnum>] [<RequireQualifiedAccess>] SystemPreferencesGetMediaAccessStatusReturn =
        | [<CompiledName "not-determined">] NotDetermined
        | Granted
        | Denied
        | Restricted
        | Unknown

    type [<StringEnum>] [<RequireQualifiedAccess>] SystemPreferencesGetSystemColorColor =
        | Blue
        | Brown
        | Gray
        | Green
        | Orange
        | Pink
        | Purple
        | Red
        | Yellow

    type [<StringEnum>] [<RequireQualifiedAccess>] SystemPreferencesGetUserDefaultType =
        | String
        | Boolean
        | Integer
        | Float
        | Double
        | Url
        | Array
        | Dictionary

    type [<AllowNullLiteral>] Task =
        /// <summary>The command line arguments when <c>program</c> is executed.</summary>
        abstract arguments: string with get, set
        /// Description of this task.
        abstract description: string with get, set
        /// The icon index in the icon file. If an icon file consists of two or more icons,
        /// set this value to identify the icon. If an icon file consists of one icon, this
        /// value is 0.
        abstract iconIndex: float with get, set
        /// <summary>
        /// The absolute path to an icon to be displayed in a JumpList, which can be an
        /// arbitrary resource file that contains an icon. You can usually specify
        /// <c>process.execPath</c> to show the icon of the program.
        /// </summary>
        abstract iconPath: string with get, set
        /// <summary>
        /// Path of the program to execute, usually you should specify <c>process.execPath</c>
        /// which opens the current program.
        /// </summary>
        abstract program: string with get, set
        /// The string to be displayed in a JumpList.
        abstract title: string with get, set
        /// The working directory. Default is empty.
        abstract workingDirectory: string option with get, set

    type [<AllowNullLiteral>] ThumbarButton =
        abstract click: Function with get, set
        /// <summary>
        /// Control specific states and behaviors of the button. By default, it is
        /// <c>['enabled']</c>.
        /// </summary>
        abstract flags: ResizeArray<string> option with get, set
        /// The icon showing in thumbnail toolbar.
        abstract icon: NativeImage with get, set
        /// The text of the button's tooltip.
        abstract tooltip: string option with get, set

    type [<AllowNullLiteral>] TouchBar =
        abstract escapeItem: obj with get, set

    type [<AllowNullLiteral>] TouchBarStatic =
        /// TouchBar
        [<EmitConstructor>] abstract Create: options: TouchBarConstructorOptions -> TouchBar
        abstract TouchBarButton: obj with get, set
        abstract TouchBarColorPicker: obj with get, set
        abstract TouchBarGroup: obj with get, set
        abstract TouchBarLabel: obj with get, set
        abstract TouchBarPopover: obj with get, set
        abstract TouchBarScrubber: obj with get, set
        abstract TouchBarSegmentedControl: obj with get, set
        abstract TouchBarSlider: obj with get, set
        abstract TouchBarSpacer: obj with get, set

    type [<AllowNullLiteral>] TouchBarButton =
        abstract accessibilityLabel: string with get, set
        abstract backgroundColor: string with get, set
        abstract enabled: bool with get, set
        abstract icon: NativeImage with get, set
        abstract label: string with get, set

    type [<AllowNullLiteral>] TouchBarButtonStatic =
        /// TouchBarButton
        [<EmitConstructor>] abstract Create: options: TouchBarButtonConstructorOptions -> TouchBarButton

    type [<AllowNullLiteral>] TouchBarColorPicker =
        inherit NodeJS.EventEmitter
        abstract availableColors: ResizeArray<string> with get, set
        abstract selectedColor: string with get, set

    type [<AllowNullLiteral>] TouchBarColorPickerStatic =
        /// TouchBarColorPicker
        [<EmitConstructor>] abstract Create: options: TouchBarColorPickerConstructorOptions -> TouchBarColorPicker

    type [<AllowNullLiteral>] TouchBarGroup =
        inherit NodeJS.EventEmitter

    type [<AllowNullLiteral>] TouchBarGroupStatic =
        /// TouchBarGroup
        [<EmitConstructor>] abstract Create: options: TouchBarGroupConstructorOptions -> TouchBarGroup

    type [<AllowNullLiteral>] TouchBarLabel =
        inherit NodeJS.EventEmitter
        abstract accessibilityLabel: string with get, set
        abstract label: string with get, set
        abstract textColor: string with get, set

    type [<AllowNullLiteral>] TouchBarLabelStatic =
        /// TouchBarLabel
        [<EmitConstructor>] abstract Create: options: TouchBarLabelConstructorOptions -> TouchBarLabel

    type [<AllowNullLiteral>] TouchBarPopover =
        inherit NodeJS.EventEmitter
        abstract icon: NativeImage with get, set
        abstract label: string with get, set

    type [<AllowNullLiteral>] TouchBarPopoverStatic =
        /// TouchBarPopover
        [<EmitConstructor>] abstract Create: options: TouchBarPopoverConstructorOptions -> TouchBarPopover

    type [<AllowNullLiteral>] TouchBarScrubber =
        inherit NodeJS.EventEmitter
        abstract continuous: bool with get, set
        abstract items: ResizeArray<ScrubberItem> with get, set
        abstract mode: TouchBarScrubberMode with get, set
        abstract overlayStyle: TouchBarScrubberOverlayStyle with get, set
        abstract selectedStyle: TouchBarScrubberOverlayStyle with get, set
        abstract showArrowButtons: bool with get, set

    type [<AllowNullLiteral>] TouchBarScrubberStatic =
        /// TouchBarScrubber
        [<EmitConstructor>] abstract Create: options: TouchBarScrubberConstructorOptions -> TouchBarScrubber

    type [<AllowNullLiteral>] TouchBarSegmentedControl =
        inherit NodeJS.EventEmitter
        abstract segments: ResizeArray<SegmentedControlSegment> with get, set
        abstract segmentStyle: string with get, set
        abstract selectedIndex: float with get, set

    type [<AllowNullLiteral>] TouchBarSegmentedControlStatic =
        /// TouchBarSegmentedControl
        [<EmitConstructor>] abstract Create: options: TouchBarSegmentedControlConstructorOptions -> TouchBarSegmentedControl

    type [<AllowNullLiteral>] TouchBarSlider =
        inherit NodeJS.EventEmitter
        abstract label: string with get, set
        abstract maxValue: float with get, set
        abstract minValue: float with get, set
        abstract value: float with get, set

    type [<AllowNullLiteral>] TouchBarSliderStatic =
        /// TouchBarSlider
        [<EmitConstructor>] abstract Create: options: TouchBarSliderConstructorOptions -> TouchBarSlider

    type [<AllowNullLiteral>] TouchBarSpacer =
        inherit NodeJS.EventEmitter

    type [<AllowNullLiteral>] TouchBarSpacerStatic =
        /// TouchBarSpacer
        [<EmitConstructor>] abstract Create: options: TouchBarSpacerConstructorOptions -> TouchBarSpacer

    type [<AllowNullLiteral>] TraceCategoriesAndOptions =
        /// <summary>
        /// A filter to control what category groups should be traced. A filter can have an
        /// optional '-' prefix to exclude category groups that contain a matching category.
        /// Having both included and excluded category patterns in the same list is not
        /// supported. Examples: <c>test_MyTest*</c>, <c>test_MyTest*,test_OtherStuff</c>,
        /// <c>-excluded_category1,-excluded_category2</c>.
        /// </summary>
        abstract categoryFilter: string with get, set
        /// <summary>
        /// Controls what kind of tracing is enabled, it is a comma-delimited sequence of
        /// the following strings: <c>record-until-full</c>, <c>record-continuously</c>,
        /// <c>trace-to-console</c>, <c>enable-sampling</c>, <c>enable-systrace</c>, e.g.
        /// <c>'record-until-full,enable-sampling'</c>. The first 3 options are trace recording
        /// modes and hence mutually exclusive. If more than one trace recording modes
        /// appear in the <c>traceOptions</c> string, the last one takes precedence. If none of
        /// the trace recording modes are specified, recording mode is <c>record-until-full</c>.
        /// The trace option will first be reset to the default option (<c>record_mode</c> set to
        /// <c>record-until-full</c>, <c>enable_sampling</c> and <c>enable_systrace</c> set to <c>false</c>)
        /// before options parsed from <c>traceOptions</c> are applied on it.
        /// </summary>
        abstract traceOptions: string with get, set

    type [<AllowNullLiteral>] TraceConfig =
        /// if true, filter event data according to a whitelist of events that have been
        /// manually vetted to not include any PII. See the implementation in Chromium for
        /// specifics.
        abstract enable_argument_filter: bool option with get, set
        /// <summary>
        /// a list of tracing categories to exclude. Can include glob-like patterns using
        /// <c>*</c> at the end of the category name. See tracing categories for the list of
        /// categories.
        /// </summary>
        abstract excluded_categories: ResizeArray<string> option with get, set
        /// a list of histogram names to report with the trace.
        abstract histogram_names: ResizeArray<string> option with get, set
        /// <summary>
        /// a list of tracing categories to include. Can include glob-like patterns using
        /// <c>*</c> at the end of the category name. See tracing categories for the list of
        /// categories.
        /// </summary>
        abstract included_categories: ResizeArray<string> option with get, set
        /// a list of process IDs to include in the trace. If not specified, trace all
        /// processes.
        abstract included_process_ids: ResizeArray<float> option with get, set
        /// <summary>
        /// if the <c>disabled-by-default-memory-infra</c> category is enabled, this contains
        /// optional additional configuration for data collection. See the Chromium
        /// memory-infra docs for more information.
        /// </summary>
        abstract memory_dump_config: Record<string, obj option> option with get, set
        /// <summary>
        /// Can be <c>record-until-full</c>, <c>record-continuously</c>, <c>record-as-much-as-possible</c>
        /// or <c>trace-to-console</c>. Defaults to <c>record-until-full</c>.
        /// </summary>
        abstract recording_mode: TraceConfigRecording_mode option with get, set
        /// maximum size of the trace recording buffer in events.
        abstract trace_buffer_size_in_events: float option with get, set
        /// maximum size of the trace recording buffer in kilobytes. Defaults to 100MB.
        abstract trace_buffer_size_in_kb: float option with get, set

    type [<AllowNullLiteral>] Transaction =
        /// The error code if an error occurred while processing the transaction.
        abstract errorCode: float with get, set
        /// The error message if an error occurred while processing the transaction.
        abstract errorMessage: string with get, set
        /// The identifier of the restored transaction by the App Store.
        abstract originalTransactionIdentifier: string with get, set
        abstract payment: Payment with get, set
        /// The date the transaction was added to the App Store’s payment queue.
        abstract transactionDate: string with get, set
        /// A string that uniquely identifies a successful payment transaction.
        abstract transactionIdentifier: string with get, set
        /// <summary>
        /// The transaction state, can be <c>purchasing</c>, <c>purchased</c>, <c>failed</c>, <c>restored</c> or
        /// <c>deferred</c>.
        /// </summary>
        abstract transactionState: TransactionTransactionState with get, set

    type [<AllowNullLiteral>] Tray =
        inherit NodeJS.EventEmitter
        /// <summary>Emitted when the tray balloon is clicked.</summary>
        [<Emit "$0.on('balloon-click',$1)">] abstract ``on_balloon-click``: listener: Function -> Tray
        [<Emit "$0.once('balloon-click',$1)">] abstract ``once_balloon-click``: listener: Function -> Tray
        [<Emit "$0.addListener('balloon-click',$1)">] abstract ``addListener_balloon-click``: listener: Function -> Tray
        [<Emit "$0.removeListener('balloon-click',$1)">] abstract ``removeListener_balloon-click``: listener: Function -> Tray
        /// <summary>
        /// Emitted when the tray balloon is closed because of timeout or user manually
        /// closes it.
        /// </summary>
        [<Emit "$0.on('balloon-closed',$1)">] abstract ``on_balloon-closed``: listener: Function -> Tray
        [<Emit "$0.once('balloon-closed',$1)">] abstract ``once_balloon-closed``: listener: Function -> Tray
        [<Emit "$0.addListener('balloon-closed',$1)">] abstract ``addListener_balloon-closed``: listener: Function -> Tray
        [<Emit "$0.removeListener('balloon-closed',$1)">] abstract ``removeListener_balloon-closed``: listener: Function -> Tray
        /// <summary>Emitted when the tray balloon shows.</summary>
        [<Emit "$0.on('balloon-show',$1)">] abstract ``on_balloon-show``: listener: Function -> Tray
        [<Emit "$0.once('balloon-show',$1)">] abstract ``once_balloon-show``: listener: Function -> Tray
        [<Emit "$0.addListener('balloon-show',$1)">] abstract ``addListener_balloon-show``: listener: Function -> Tray
        [<Emit "$0.removeListener('balloon-show',$1)">] abstract ``removeListener_balloon-show``: listener: Function -> Tray
        /// Emitted when the tray icon is clicked.
        [<Emit "$0.on('click',$1)">] abstract on_click: listener: (KeyboardEvent -> Rectangle -> Point -> unit) -> Tray
        [<Emit "$0.once('click',$1)">] abstract once_click: listener: (KeyboardEvent -> Rectangle -> Point -> unit) -> Tray
        [<Emit "$0.addListener('click',$1)">] abstract addListener_click: listener: (KeyboardEvent -> Rectangle -> Point -> unit) -> Tray
        [<Emit "$0.removeListener('click',$1)">] abstract removeListener_click: listener: (KeyboardEvent -> Rectangle -> Point -> unit) -> Tray
        /// <summary>Emitted when the tray icon is double clicked.</summary>
        [<Emit "$0.on('double-click',$1)">] abstract ``on_double-click``: listener: (KeyboardEvent -> Rectangle -> unit) -> Tray
        [<Emit "$0.once('double-click',$1)">] abstract ``once_double-click``: listener: (KeyboardEvent -> Rectangle -> unit) -> Tray
        [<Emit "$0.addListener('double-click',$1)">] abstract ``addListener_double-click``: listener: (KeyboardEvent -> Rectangle -> unit) -> Tray
        [<Emit "$0.removeListener('double-click',$1)">] abstract ``removeListener_double-click``: listener: (KeyboardEvent -> Rectangle -> unit) -> Tray
        /// <summary>Emitted when a drag operation ends on the tray or ends at another location.</summary>
        [<Emit "$0.on('drag-end',$1)">] abstract ``on_drag-end``: listener: Function -> Tray
        [<Emit "$0.once('drag-end',$1)">] abstract ``once_drag-end``: listener: Function -> Tray
        [<Emit "$0.addListener('drag-end',$1)">] abstract ``addListener_drag-end``: listener: Function -> Tray
        [<Emit "$0.removeListener('drag-end',$1)">] abstract ``removeListener_drag-end``: listener: Function -> Tray
        /// <summary>Emitted when a drag operation enters the tray icon.</summary>
        [<Emit "$0.on('drag-enter',$1)">] abstract ``on_drag-enter``: listener: Function -> Tray
        [<Emit "$0.once('drag-enter',$1)">] abstract ``once_drag-enter``: listener: Function -> Tray
        [<Emit "$0.addListener('drag-enter',$1)">] abstract ``addListener_drag-enter``: listener: Function -> Tray
        [<Emit "$0.removeListener('drag-enter',$1)">] abstract ``removeListener_drag-enter``: listener: Function -> Tray
        /// <summary>Emitted when a drag operation exits the tray icon.</summary>
        [<Emit "$0.on('drag-leave',$1)">] abstract ``on_drag-leave``: listener: Function -> Tray
        [<Emit "$0.once('drag-leave',$1)">] abstract ``once_drag-leave``: listener: Function -> Tray
        [<Emit "$0.addListener('drag-leave',$1)">] abstract ``addListener_drag-leave``: listener: Function -> Tray
        [<Emit "$0.removeListener('drag-leave',$1)">] abstract ``removeListener_drag-leave``: listener: Function -> Tray
        /// <summary>Emitted when any dragged items are dropped on the tray icon.</summary>
        [<Emit "$0.on('drop',$1)">] abstract on_drop: listener: Function -> Tray
        [<Emit "$0.once('drop',$1)">] abstract once_drop: listener: Function -> Tray
        [<Emit "$0.addListener('drop',$1)">] abstract addListener_drop: listener: Function -> Tray
        [<Emit "$0.removeListener('drop',$1)">] abstract removeListener_drop: listener: Function -> Tray
        /// <summary>Emitted when dragged files are dropped in the tray icon.</summary>
        [<Emit "$0.on('drop-files',$1)">] abstract ``on_drop-files``: listener: (Event -> ResizeArray<string> -> unit) -> Tray
        [<Emit "$0.once('drop-files',$1)">] abstract ``once_drop-files``: listener: (Event -> ResizeArray<string> -> unit) -> Tray
        [<Emit "$0.addListener('drop-files',$1)">] abstract ``addListener_drop-files``: listener: (Event -> ResizeArray<string> -> unit) -> Tray
        [<Emit "$0.removeListener('drop-files',$1)">] abstract ``removeListener_drop-files``: listener: (Event -> ResizeArray<string> -> unit) -> Tray
        /// <summary>Emitted when dragged text is dropped in the tray icon.</summary>
        [<Emit "$0.on('drop-text',$1)">] abstract ``on_drop-text``: listener: (Event -> string -> unit) -> Tray
        [<Emit "$0.once('drop-text',$1)">] abstract ``once_drop-text``: listener: (Event -> string -> unit) -> Tray
        [<Emit "$0.addListener('drop-text',$1)">] abstract ``addListener_drop-text``: listener: (Event -> string -> unit) -> Tray
        [<Emit "$0.removeListener('drop-text',$1)">] abstract ``removeListener_drop-text``: listener: (Event -> string -> unit) -> Tray
        /// <summary>Emitted when the mouse clicks the tray icon.</summary>
        [<Emit "$0.on('mouse-down',$1)">] abstract ``on_mouse-down``: listener: (KeyboardEvent -> Point -> unit) -> Tray
        [<Emit "$0.once('mouse-down',$1)">] abstract ``once_mouse-down``: listener: (KeyboardEvent -> Point -> unit) -> Tray
        [<Emit "$0.addListener('mouse-down',$1)">] abstract ``addListener_mouse-down``: listener: (KeyboardEvent -> Point -> unit) -> Tray
        [<Emit "$0.removeListener('mouse-down',$1)">] abstract ``removeListener_mouse-down``: listener: (KeyboardEvent -> Point -> unit) -> Tray
        /// <summary>Emitted when the mouse enters the tray icon.</summary>
        [<Emit "$0.on('mouse-enter',$1)">] abstract ``on_mouse-enter``: listener: (KeyboardEvent -> Point -> unit) -> Tray
        [<Emit "$0.once('mouse-enter',$1)">] abstract ``once_mouse-enter``: listener: (KeyboardEvent -> Point -> unit) -> Tray
        [<Emit "$0.addListener('mouse-enter',$1)">] abstract ``addListener_mouse-enter``: listener: (KeyboardEvent -> Point -> unit) -> Tray
        [<Emit "$0.removeListener('mouse-enter',$1)">] abstract ``removeListener_mouse-enter``: listener: (KeyboardEvent -> Point -> unit) -> Tray
        /// <summary>Emitted when the mouse exits the tray icon.</summary>
        [<Emit "$0.on('mouse-leave',$1)">] abstract ``on_mouse-leave``: listener: (KeyboardEvent -> Point -> unit) -> Tray
        [<Emit "$0.once('mouse-leave',$1)">] abstract ``once_mouse-leave``: listener: (KeyboardEvent -> Point -> unit) -> Tray
        [<Emit "$0.addListener('mouse-leave',$1)">] abstract ``addListener_mouse-leave``: listener: (KeyboardEvent -> Point -> unit) -> Tray
        [<Emit "$0.removeListener('mouse-leave',$1)">] abstract ``removeListener_mouse-leave``: listener: (KeyboardEvent -> Point -> unit) -> Tray
        /// <summary>Emitted when the mouse moves in the tray icon.</summary>
        [<Emit "$0.on('mouse-move',$1)">] abstract ``on_mouse-move``: listener: (KeyboardEvent -> Point -> unit) -> Tray
        [<Emit "$0.once('mouse-move',$1)">] abstract ``once_mouse-move``: listener: (KeyboardEvent -> Point -> unit) -> Tray
        [<Emit "$0.addListener('mouse-move',$1)">] abstract ``addListener_mouse-move``: listener: (KeyboardEvent -> Point -> unit) -> Tray
        [<Emit "$0.removeListener('mouse-move',$1)">] abstract ``removeListener_mouse-move``: listener: (KeyboardEvent -> Point -> unit) -> Tray
        /// <summary>
        /// Emitted when the mouse is released from clicking the tray icon.
        /// 
        /// Note: This will not be emitted if you have set a context menu for your Tray
        /// using <c>tray.setContextMenu</c>, as a result of macOS-level constraints.
        /// </summary>
        [<Emit "$0.on('mouse-up',$1)">] abstract ``on_mouse-up``: listener: (KeyboardEvent -> Point -> unit) -> Tray
        [<Emit "$0.once('mouse-up',$1)">] abstract ``once_mouse-up``: listener: (KeyboardEvent -> Point -> unit) -> Tray
        [<Emit "$0.addListener('mouse-up',$1)">] abstract ``addListener_mouse-up``: listener: (KeyboardEvent -> Point -> unit) -> Tray
        [<Emit "$0.removeListener('mouse-up',$1)">] abstract ``removeListener_mouse-up``: listener: (KeyboardEvent -> Point -> unit) -> Tray
        /// <summary>Emitted when the tray icon is right clicked.</summary>
        [<Emit "$0.on('right-click',$1)">] abstract ``on_right-click``: listener: (KeyboardEvent -> Rectangle -> unit) -> Tray
        [<Emit "$0.once('right-click',$1)">] abstract ``once_right-click``: listener: (KeyboardEvent -> Rectangle -> unit) -> Tray
        [<Emit "$0.addListener('right-click',$1)">] abstract ``addListener_right-click``: listener: (KeyboardEvent -> Rectangle -> unit) -> Tray
        [<Emit "$0.removeListener('right-click',$1)">] abstract ``removeListener_right-click``: listener: (KeyboardEvent -> Rectangle -> unit) -> Tray
        /// <summary>Closes an open context menu, as set by <c>tray.setContextMenu()</c>.</summary>
        abstract closeContextMenu: unit -> unit
        /// Destroys the tray icon immediately.
        abstract destroy: unit -> unit
        /// <summary>Displays a tray balloon.</summary>
        abstract displayBalloon: options: DisplayBalloonOptions -> unit
        /// <summary>
        /// Returns focus to the taskbar notification area. Notification area icons should
        /// use this message when they have completed their UI operation. For example, if
        /// the icon displays a shortcut menu, but the user presses ESC to cancel it, use
        /// <c>tray.focus()</c> to return focus to the notification area.
        /// </summary>
        abstract focus: unit -> unit
        /// <summary>The <c>bounds</c> of this tray icon as <c>Object</c>.</summary>
        abstract getBounds: unit -> Rectangle
        /// <summary>Whether double click events will be ignored.</summary>
        abstract getIgnoreDoubleClickEvents: unit -> bool
        /// <summary>the title displayed next to the tray icon in the status bar</summary>
        abstract getTitle: unit -> string
        /// Whether the tray icon is destroyed.
        abstract isDestroyed: unit -> bool
        /// <summary>
        /// Pops up the context menu of the tray icon. When <c>menu</c> is passed, the <c>menu</c>
        /// will be shown instead of the tray icon's context menu.
        /// 
        /// The <c>position</c> is only available on Windows, and it is (0, 0) by default.
        /// </summary>
        abstract popUpContextMenu: ?menu: Menu * ?position: Point -> unit
        /// <summary>Removes a tray balloon.</summary>
        abstract removeBalloon: unit -> unit
        /// Sets the context menu for this icon.
        abstract setContextMenu: menu: Menu option -> unit
        /// <summary>
        /// Sets the option to ignore double click events. Ignoring these events allows you
        /// to detect every individual click of the tray icon.
        /// 
        /// This value is set to false by default.
        /// </summary>
        abstract setIgnoreDoubleClickEvents: ignore: bool -> unit
        /// <summary>Sets the <c>image</c> associated with this tray icon.</summary>
        abstract setImage: image: U2<NativeImage, string> -> unit
        /// <summary>Sets the <c>image</c> associated with this tray icon when pressed on macOS.</summary>
        abstract setPressedImage: image: U2<NativeImage, string> -> unit
        /// <summary>
        /// Sets the title displayed next to the tray icon in the status bar (Support ANSI
        /// colors).
        /// </summary>
        abstract setTitle: title: string -> unit
        /// Sets the hover text for this tray icon.
        abstract setToolTip: toolTip: string -> unit

    type [<AllowNullLiteral>] TrayStatic =
        /// Tray
        [<EmitConstructor>] abstract Create: image: U2<NativeImage, string> * ?guid: string -> Tray

    type [<AllowNullLiteral>] UploadBlob =
        /// UUID of blob data to upload.
        abstract blobUUID: string with get, set
        /// <summary><c>blob</c>.</summary>
        abstract ``type``: string with get, set

    type [<AllowNullLiteral>] UploadData =
        /// UUID of blob data. Use ses.getBlobData method to retrieve the data.
        abstract blobUUID: string option with get, set
        /// Content being sent.
        abstract bytes: Buffer with get, set
        /// Path of file being uploaded.
        abstract file: string option with get, set

    type [<AllowNullLiteral>] UploadFile =
        /// Path of file to be uploaded.
        abstract filePath: string with get, set
        /// <summary>Number of bytes to read from <c>offset</c>. Defaults to <c>0</c>.</summary>
        abstract length: float with get, set
        /// Last Modification time in number of seconds since the UNIX epoch.
        abstract modificationTime: float with get, set
        /// <summary>Defaults to <c>0</c>.</summary>
        abstract offset: float with get, set
        /// <summary><c>file</c>.</summary>
        abstract ``type``: string with get, set

    type [<AllowNullLiteral>] UploadRawData =
        /// Data to be uploaded.
        abstract bytes: Buffer with get, set
        /// <summary><c>rawData</c>.</summary>
        abstract ``type``: string with get, set

    type [<AllowNullLiteral>] WebContents =
        inherit NodeJS.EventEmitter
        /// <summary>
        /// Emitted before dispatching the <c>keydown</c> and <c>keyup</c> events in the page. Calling
        /// <c>event.preventDefault</c> will prevent the page <c>keydown</c>/<c>keyup</c> events and the
        /// menu shortcuts.
        /// 
        /// To only prevent the menu shortcuts, use <c>setIgnoreMenuShortcuts</c>:
        /// </summary>
        [<Emit "$0.on('before-input-event',$1)">] abstract ``on_before-input-event``: listener: (Event -> Input -> unit) -> WebContents
        [<Emit "$0.once('before-input-event',$1)">] abstract ``once_before-input-event``: listener: (Event -> Input -> unit) -> WebContents
        [<Emit "$0.addListener('before-input-event',$1)">] abstract ``addListener_before-input-event``: listener: (Event -> Input -> unit) -> WebContents
        [<Emit "$0.removeListener('before-input-event',$1)">] abstract ``removeListener_before-input-event``: listener: (Event -> Input -> unit) -> WebContents
        /// <summary>
        /// Emitted when failed to verify the <c>certificate</c> for <c>url</c>.
        /// 
        /// The usage is the same with the <c>certificate-error</c> event of <c>app</c>.
        /// </summary>
        [<Emit "$0.on('certificate-error',$1)">] abstract ``on_certificate-error``: listener: (Event -> string -> string -> Certificate -> (bool -> unit) -> unit) -> WebContents
        [<Emit "$0.once('certificate-error',$1)">] abstract ``once_certificate-error``: listener: (Event -> string -> string -> Certificate -> (bool -> unit) -> unit) -> WebContents
        [<Emit "$0.addListener('certificate-error',$1)">] abstract ``addListener_certificate-error``: listener: (Event -> string -> string -> Certificate -> (bool -> unit) -> unit) -> WebContents
        [<Emit "$0.removeListener('certificate-error',$1)">] abstract ``removeListener_certificate-error``: listener: (Event -> string -> string -> Certificate -> (bool -> unit) -> unit) -> WebContents
        /// Emitted when the associated window logs a console message.
        [<Emit "$0.on('console-message',$1)">] abstract ``on_console-message``: listener: (Event -> float -> string -> float -> string -> unit) -> WebContents
        [<Emit "$0.once('console-message',$1)">] abstract ``once_console-message``: listener: (Event -> float -> string -> float -> string -> unit) -> WebContents
        [<Emit "$0.addListener('console-message',$1)">] abstract ``addListener_console-message``: listener: (Event -> float -> string -> float -> string -> unit) -> WebContents
        [<Emit "$0.removeListener('console-message',$1)">] abstract ``removeListener_console-message``: listener: (Event -> float -> string -> float -> string -> unit) -> WebContents
        /// Emitted when there is a new context menu that needs to be handled.
        [<Emit "$0.on('context-menu',$1)">] abstract ``on_context-menu``: listener: (Event -> ContextMenuParams -> unit) -> WebContents
        [<Emit "$0.once('context-menu',$1)">] abstract ``once_context-menu``: listener: (Event -> ContextMenuParams -> unit) -> WebContents
        [<Emit "$0.addListener('context-menu',$1)">] abstract ``addListener_context-menu``: listener: (Event -> ContextMenuParams -> unit) -> WebContents
        [<Emit "$0.removeListener('context-menu',$1)">] abstract ``removeListener_context-menu``: listener: (Event -> ContextMenuParams -> unit) -> WebContents
        /// <summary>
        /// Emitted when the renderer process crashes or is killed.
        /// 
        /// **Deprecated:** This event is superceded by the <c>render-process-gone</c> event
        /// which contains more information about why the render process dissapeared. It
        /// isn't always because it crashed.  The <c>killed</c> boolean can be replaced by
        /// checking <c>reason === 'killed'</c> when you switch to that event.
        /// </summary>
        [<Obsolete("")>]
        [<Emit "$0.on('crashed',$1)">] abstract on_crashed: listener: (Event -> bool -> unit) -> WebContents
        [<Emit "$0.once('crashed',$1)">] abstract once_crashed: listener: (Event -> bool -> unit) -> WebContents
        [<Emit "$0.addListener('crashed',$1)">] abstract addListener_crashed: listener: (Event -> bool -> unit) -> WebContents
        [<Emit "$0.removeListener('crashed',$1)">] abstract removeListener_crashed: listener: (Event -> bool -> unit) -> WebContents
        /// <summary>
        /// Emitted when the cursor's type changes. The <c>type</c> parameter can be <c>default</c>,
        /// <c>crosshair</c>, <c>pointer</c>, <c>text</c>, <c>wait</c>, <c>help</c>, <c>e-resize</c>, <c>n-resize</c>,
        /// <c>ne-resize</c>, <c>nw-resize</c>, <c>s-resize</c>, <c>se-resize</c>, <c>sw-resize</c>, <c>w-resize</c>,
        /// <c>ns-resize</c>, <c>ew-resize</c>, <c>nesw-resize</c>, <c>nwse-resize</c>, <c>col-resize</c>,
        /// <c>row-resize</c>, <c>m-panning</c>, <c>e-panning</c>, <c>n-panning</c>, <c>ne-panning</c>, <c>nw-panning</c>,
        /// <c>s-panning</c>, <c>se-panning</c>, <c>sw-panning</c>, <c>w-panning</c>, <c>move</c>, <c>vertical-text</c>,
        /// <c>cell</c>, <c>context-menu</c>, <c>alias</c>, <c>progress</c>, <c>nodrop</c>, <c>copy</c>, <c>none</c>,
        /// <c>not-allowed</c>, <c>zoom-in</c>, <c>zoom-out</c>, <c>grab</c>, <c>grabbing</c> or <c>custom</c>.
        /// 
        /// If the <c>type</c> parameter is <c>custom</c>, the <c>image</c> parameter will hold the custom
        /// cursor image in a <c>NativeImage</c>, and <c>scale</c>, <c>size</c> and <c>hotspot</c> will hold
        /// additional information about the custom cursor.
        /// </summary>
        [<Emit "$0.on('cursor-changed',$1)">] abstract ``on_cursor-changed``: listener: (Event -> string -> NativeImage -> float -> Size -> Point -> unit) -> WebContents
        [<Emit "$0.once('cursor-changed',$1)">] abstract ``once_cursor-changed``: listener: (Event -> string -> NativeImage -> float -> Size -> Point -> unit) -> WebContents
        [<Emit "$0.addListener('cursor-changed',$1)">] abstract ``addListener_cursor-changed``: listener: (Event -> string -> NativeImage -> float -> Size -> Point -> unit) -> WebContents
        [<Emit "$0.removeListener('cursor-changed',$1)">] abstract ``removeListener_cursor-changed``: listener: (Event -> string -> NativeImage -> float -> Size -> Point -> unit) -> WebContents
        /// <summary>
        /// Emitted when <c>desktopCapturer.getSources()</c> is called in the renderer process.
        /// Calling <c>event.preventDefault()</c> will make it return empty sources.
        /// </summary>
        [<Emit "$0.on('desktop-capturer-get-sources',$1)">] abstract ``on_desktop-capturer-get-sources``: listener: (Event -> unit) -> WebContents
        [<Emit "$0.once('desktop-capturer-get-sources',$1)">] abstract ``once_desktop-capturer-get-sources``: listener: (Event -> unit) -> WebContents
        [<Emit "$0.addListener('desktop-capturer-get-sources',$1)">] abstract ``addListener_desktop-capturer-get-sources``: listener: (Event -> unit) -> WebContents
        [<Emit "$0.removeListener('desktop-capturer-get-sources',$1)">] abstract ``removeListener_desktop-capturer-get-sources``: listener: (Event -> unit) -> WebContents
        /// <summary>Emitted when <c>webContents</c> is destroyed.</summary>
        [<Emit "$0.on('destroyed',$1)">] abstract on_destroyed: listener: Function -> WebContents
        [<Emit "$0.once('destroyed',$1)">] abstract once_destroyed: listener: Function -> WebContents
        [<Emit "$0.addListener('destroyed',$1)">] abstract addListener_destroyed: listener: Function -> WebContents
        [<Emit "$0.removeListener('destroyed',$1)">] abstract removeListener_destroyed: listener: Function -> WebContents
        /// Emitted when DevTools is closed.
        [<Emit "$0.on('devtools-closed',$1)">] abstract ``on_devtools-closed``: listener: Function -> WebContents
        [<Emit "$0.once('devtools-closed',$1)">] abstract ``once_devtools-closed``: listener: Function -> WebContents
        [<Emit "$0.addListener('devtools-closed',$1)">] abstract ``addListener_devtools-closed``: listener: Function -> WebContents
        [<Emit "$0.removeListener('devtools-closed',$1)">] abstract ``removeListener_devtools-closed``: listener: Function -> WebContents
        /// Emitted when DevTools is focused / opened.
        [<Emit "$0.on('devtools-focused',$1)">] abstract ``on_devtools-focused``: listener: Function -> WebContents
        [<Emit "$0.once('devtools-focused',$1)">] abstract ``once_devtools-focused``: listener: Function -> WebContents
        [<Emit "$0.addListener('devtools-focused',$1)">] abstract ``addListener_devtools-focused``: listener: Function -> WebContents
        [<Emit "$0.removeListener('devtools-focused',$1)">] abstract ``removeListener_devtools-focused``: listener: Function -> WebContents
        /// Emitted when DevTools is opened.
        [<Emit "$0.on('devtools-opened',$1)">] abstract ``on_devtools-opened``: listener: Function -> WebContents
        [<Emit "$0.once('devtools-opened',$1)">] abstract ``once_devtools-opened``: listener: Function -> WebContents
        [<Emit "$0.addListener('devtools-opened',$1)">] abstract ``addListener_devtools-opened``: listener: Function -> WebContents
        [<Emit "$0.removeListener('devtools-opened',$1)">] abstract ``removeListener_devtools-opened``: listener: Function -> WebContents
        /// Emitted when the devtools window instructs the webContents to reload
        [<Emit "$0.on('devtools-reload-page',$1)">] abstract ``on_devtools-reload-page``: listener: Function -> WebContents
        [<Emit "$0.once('devtools-reload-page',$1)">] abstract ``once_devtools-reload-page``: listener: Function -> WebContents
        [<Emit "$0.addListener('devtools-reload-page',$1)">] abstract ``addListener_devtools-reload-page``: listener: Function -> WebContents
        [<Emit "$0.removeListener('devtools-reload-page',$1)">] abstract ``removeListener_devtools-reload-page``: listener: Function -> WebContents
        /// <summary>Emitted when a <c>&lt;webview&gt;</c> has been attached to this web contents.</summary>
        [<Emit "$0.on('did-attach-webview',$1)">] abstract ``on_did-attach-webview``: listener: (Event -> WebContents -> unit) -> WebContents
        [<Emit "$0.once('did-attach-webview',$1)">] abstract ``once_did-attach-webview``: listener: (Event -> WebContents -> unit) -> WebContents
        [<Emit "$0.addListener('did-attach-webview',$1)">] abstract ``addListener_did-attach-webview``: listener: (Event -> WebContents -> unit) -> WebContents
        [<Emit "$0.removeListener('did-attach-webview',$1)">] abstract ``removeListener_did-attach-webview``: listener: (Event -> WebContents -> unit) -> WebContents
        /// Emitted when a page's theme color changes. This is usually due to encountering a
        /// meta tag:
        [<Emit "$0.on('did-change-theme-color',$1)">] abstract ``on_did-change-theme-color``: listener: (Event -> string option -> unit) -> WebContents
        [<Emit "$0.once('did-change-theme-color',$1)">] abstract ``once_did-change-theme-color``: listener: (Event -> string option -> unit) -> WebContents
        [<Emit "$0.addListener('did-change-theme-color',$1)">] abstract ``addListener_did-change-theme-color``: listener: (Event -> string option -> unit) -> WebContents
        [<Emit "$0.removeListener('did-change-theme-color',$1)">] abstract ``removeListener_did-change-theme-color``: listener: (Event -> string option -> unit) -> WebContents
        /// <summary>
        /// This event is like <c>did-finish-load</c> but emitted when the load failed. The full
        /// list of error codes and their meaning is available here.
        /// </summary>
        [<Emit "$0.on('did-fail-load',$1)">] abstract ``on_did-fail-load``: listener: (Event -> float -> string -> string -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.once('did-fail-load',$1)">] abstract ``once_did-fail-load``: listener: (Event -> float -> string -> string -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.addListener('did-fail-load',$1)">] abstract ``addListener_did-fail-load``: listener: (Event -> float -> string -> string -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.removeListener('did-fail-load',$1)">] abstract ``removeListener_did-fail-load``: listener: (Event -> float -> string -> string -> bool -> float -> float -> unit) -> WebContents
        /// <summary>
        /// This event is like <c>did-fail-load</c> but emitted when the load was cancelled (e.g.
        /// <c>window.stop()</c> was invoked).
        /// </summary>
        [<Emit "$0.on('did-fail-provisional-load',$1)">] abstract ``on_did-fail-provisional-load``: listener: (Event -> float -> string -> string -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.once('did-fail-provisional-load',$1)">] abstract ``once_did-fail-provisional-load``: listener: (Event -> float -> string -> string -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.addListener('did-fail-provisional-load',$1)">] abstract ``addListener_did-fail-provisional-load``: listener: (Event -> float -> string -> string -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.removeListener('did-fail-provisional-load',$1)">] abstract ``removeListener_did-fail-provisional-load``: listener: (Event -> float -> string -> string -> bool -> float -> float -> unit) -> WebContents
        /// <summary>
        /// Emitted when the navigation is done, i.e. the spinner of the tab has stopped
        /// spinning, and the <c>onload</c> event was dispatched.
        /// </summary>
        [<Emit "$0.on('did-finish-load',$1)">] abstract ``on_did-finish-load``: listener: Function -> WebContents
        [<Emit "$0.once('did-finish-load',$1)">] abstract ``once_did-finish-load``: listener: Function -> WebContents
        [<Emit "$0.addListener('did-finish-load',$1)">] abstract ``addListener_did-finish-load``: listener: Function -> WebContents
        [<Emit "$0.removeListener('did-finish-load',$1)">] abstract ``removeListener_did-finish-load``: listener: Function -> WebContents
        /// Emitted when a frame has done navigation.
        [<Emit "$0.on('did-frame-finish-load',$1)">] abstract ``on_did-frame-finish-load``: listener: (Event -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.once('did-frame-finish-load',$1)">] abstract ``once_did-frame-finish-load``: listener: (Event -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.addListener('did-frame-finish-load',$1)">] abstract ``addListener_did-frame-finish-load``: listener: (Event -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.removeListener('did-frame-finish-load',$1)">] abstract ``removeListener_did-frame-finish-load``: listener: (Event -> bool -> float -> float -> unit) -> WebContents
        /// <summary>
        /// Emitted when any frame navigation is done.
        /// 
        /// This event is not emitted for in-page navigations, such as clicking anchor links
        /// or updating the <c>window.location.hash</c>. Use <c>did-navigate-in-page</c> event for
        /// this purpose.
        /// </summary>
        [<Emit "$0.on('did-frame-navigate',$1)">] abstract ``on_did-frame-navigate``: listener: (Event -> string -> float -> string -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.once('did-frame-navigate',$1)">] abstract ``once_did-frame-navigate``: listener: (Event -> string -> float -> string -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.addListener('did-frame-navigate',$1)">] abstract ``addListener_did-frame-navigate``: listener: (Event -> string -> float -> string -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.removeListener('did-frame-navigate',$1)">] abstract ``removeListener_did-frame-navigate``: listener: (Event -> string -> float -> string -> bool -> float -> float -> unit) -> WebContents
        /// <summary>
        /// Emitted when a main frame navigation is done.
        /// 
        /// This event is not emitted for in-page navigations, such as clicking anchor links
        /// or updating the <c>window.location.hash</c>. Use <c>did-navigate-in-page</c> event for
        /// this purpose.
        /// </summary>
        [<Emit "$0.on('did-navigate',$1)">] abstract ``on_did-navigate``: listener: (Event -> string -> float -> string -> unit) -> WebContents
        [<Emit "$0.once('did-navigate',$1)">] abstract ``once_did-navigate``: listener: (Event -> string -> float -> string -> unit) -> WebContents
        [<Emit "$0.addListener('did-navigate',$1)">] abstract ``addListener_did-navigate``: listener: (Event -> string -> float -> string -> unit) -> WebContents
        [<Emit "$0.removeListener('did-navigate',$1)">] abstract ``removeListener_did-navigate``: listener: (Event -> string -> float -> string -> unit) -> WebContents
        /// <summary>
        /// Emitted when an in-page navigation happened in any frame.
        /// 
        /// When in-page navigation happens, the page URL changes but does not cause
        /// navigation outside of the page. Examples of this occurring are when anchor links
        /// are clicked or when the DOM <c>hashchange</c> event is triggered.
        /// </summary>
        [<Emit "$0.on('did-navigate-in-page',$1)">] abstract ``on_did-navigate-in-page``: listener: (Event -> string -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.once('did-navigate-in-page',$1)">] abstract ``once_did-navigate-in-page``: listener: (Event -> string -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.addListener('did-navigate-in-page',$1)">] abstract ``addListener_did-navigate-in-page``: listener: (Event -> string -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.removeListener('did-navigate-in-page',$1)">] abstract ``removeListener_did-navigate-in-page``: listener: (Event -> string -> bool -> float -> float -> unit) -> WebContents
        /// <summary>
        /// Emitted after a server side redirect occurs during navigation.  For example a
        /// 302 redirect.
        /// 
        /// This event can not be prevented, if you want to prevent redirects you should
        /// checkout out the <c>will-redirect</c> event above.
        /// </summary>
        [<Emit "$0.on('did-redirect-navigation',$1)">] abstract ``on_did-redirect-navigation``: listener: (Event -> string -> bool -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.once('did-redirect-navigation',$1)">] abstract ``once_did-redirect-navigation``: listener: (Event -> string -> bool -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.addListener('did-redirect-navigation',$1)">] abstract ``addListener_did-redirect-navigation``: listener: (Event -> string -> bool -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.removeListener('did-redirect-navigation',$1)">] abstract ``removeListener_did-redirect-navigation``: listener: (Event -> string -> bool -> bool -> float -> float -> unit) -> WebContents
        /// Corresponds to the points in time when the spinner of the tab started spinning.
        [<Emit "$0.on('did-start-loading',$1)">] abstract ``on_did-start-loading``: listener: Function -> WebContents
        [<Emit "$0.once('did-start-loading',$1)">] abstract ``once_did-start-loading``: listener: Function -> WebContents
        [<Emit "$0.addListener('did-start-loading',$1)">] abstract ``addListener_did-start-loading``: listener: Function -> WebContents
        [<Emit "$0.removeListener('did-start-loading',$1)">] abstract ``removeListener_did-start-loading``: listener: Function -> WebContents
        /// <summary>
        /// Emitted when any frame (including main) starts navigating. <c>isInplace</c> will be
        /// <c>true</c> for in-page navigations.
        /// </summary>
        [<Emit "$0.on('did-start-navigation',$1)">] abstract ``on_did-start-navigation``: listener: (Event -> string -> bool -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.once('did-start-navigation',$1)">] abstract ``once_did-start-navigation``: listener: (Event -> string -> bool -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.addListener('did-start-navigation',$1)">] abstract ``addListener_did-start-navigation``: listener: (Event -> string -> bool -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.removeListener('did-start-navigation',$1)">] abstract ``removeListener_did-start-navigation``: listener: (Event -> string -> bool -> bool -> float -> float -> unit) -> WebContents
        /// Corresponds to the points in time when the spinner of the tab stopped spinning.
        [<Emit "$0.on('did-stop-loading',$1)">] abstract ``on_did-stop-loading``: listener: Function -> WebContents
        [<Emit "$0.once('did-stop-loading',$1)">] abstract ``once_did-stop-loading``: listener: Function -> WebContents
        [<Emit "$0.addListener('did-stop-loading',$1)">] abstract ``addListener_did-stop-loading``: listener: Function -> WebContents
        [<Emit "$0.removeListener('did-stop-loading',$1)">] abstract ``removeListener_did-stop-loading``: listener: Function -> WebContents
        /// Emitted when the document in the given frame is loaded.
        [<Emit "$0.on('dom-ready',$1)">] abstract ``on_dom-ready``: listener: (Event -> unit) -> WebContents
        [<Emit "$0.once('dom-ready',$1)">] abstract ``once_dom-ready``: listener: (Event -> unit) -> WebContents
        [<Emit "$0.addListener('dom-ready',$1)">] abstract ``addListener_dom-ready``: listener: (Event -> unit) -> WebContents
        [<Emit "$0.removeListener('dom-ready',$1)">] abstract ``removeListener_dom-ready``: listener: (Event -> unit) -> WebContents
        /// Emitted when the window enters a full-screen state triggered by HTML API.
        [<Emit "$0.on('enter-html-full-screen',$1)">] abstract ``on_enter-html-full-screen``: listener: Function -> WebContents
        [<Emit "$0.once('enter-html-full-screen',$1)">] abstract ``once_enter-html-full-screen``: listener: Function -> WebContents
        [<Emit "$0.addListener('enter-html-full-screen',$1)">] abstract ``addListener_enter-html-full-screen``: listener: Function -> WebContents
        [<Emit "$0.removeListener('enter-html-full-screen',$1)">] abstract ``removeListener_enter-html-full-screen``: listener: Function -> WebContents
        /// <summary>Emitted when a result is available for [<c>webContents.findInPage</c>] request.</summary>
        [<Emit "$0.on('found-in-page',$1)">] abstract ``on_found-in-page``: listener: (Event -> Result -> unit) -> WebContents
        [<Emit "$0.once('found-in-page',$1)">] abstract ``once_found-in-page``: listener: (Event -> Result -> unit) -> WebContents
        [<Emit "$0.addListener('found-in-page',$1)">] abstract ``addListener_found-in-page``: listener: (Event -> Result -> unit) -> WebContents
        [<Emit "$0.removeListener('found-in-page',$1)">] abstract ``removeListener_found-in-page``: listener: (Event -> Result -> unit) -> WebContents
        /// <summary>
        /// Emitted when the renderer process sends an asynchronous message via
        /// <c>ipcRenderer.send()</c>.
        /// </summary>
        [<Emit "$0.on('ipc-message',$1)">] abstract ``on_ipc-message``: listener: (Event -> string -> ResizeArray<obj option> -> unit) -> WebContents
        [<Emit "$0.once('ipc-message',$1)">] abstract ``once_ipc-message``: listener: (Event -> string -> ResizeArray<obj option> -> unit) -> WebContents
        [<Emit "$0.addListener('ipc-message',$1)">] abstract ``addListener_ipc-message``: listener: (Event -> string -> ResizeArray<obj option> -> unit) -> WebContents
        [<Emit "$0.removeListener('ipc-message',$1)">] abstract ``removeListener_ipc-message``: listener: (Event -> string -> ResizeArray<obj option> -> unit) -> WebContents
        /// <summary>
        /// Emitted when the renderer process sends a synchronous message via
        /// <c>ipcRenderer.sendSync()</c>.
        /// </summary>
        [<Emit "$0.on('ipc-message-sync',$1)">] abstract ``on_ipc-message-sync``: listener: (Event -> string -> ResizeArray<obj option> -> unit) -> WebContents
        [<Emit "$0.once('ipc-message-sync',$1)">] abstract ``once_ipc-message-sync``: listener: (Event -> string -> ResizeArray<obj option> -> unit) -> WebContents
        [<Emit "$0.addListener('ipc-message-sync',$1)">] abstract ``addListener_ipc-message-sync``: listener: (Event -> string -> ResizeArray<obj option> -> unit) -> WebContents
        [<Emit "$0.removeListener('ipc-message-sync',$1)">] abstract ``removeListener_ipc-message-sync``: listener: (Event -> string -> ResizeArray<obj option> -> unit) -> WebContents
        /// Emitted when the window leaves a full-screen state triggered by HTML API.
        [<Emit "$0.on('leave-html-full-screen',$1)">] abstract ``on_leave-html-full-screen``: listener: Function -> WebContents
        [<Emit "$0.once('leave-html-full-screen',$1)">] abstract ``once_leave-html-full-screen``: listener: Function -> WebContents
        [<Emit "$0.addListener('leave-html-full-screen',$1)">] abstract ``addListener_leave-html-full-screen``: listener: Function -> WebContents
        [<Emit "$0.removeListener('leave-html-full-screen',$1)">] abstract ``removeListener_leave-html-full-screen``: listener: Function -> WebContents
        /// <summary>
        /// Emitted when <c>webContents</c> wants to do basic auth.
        /// 
        /// The usage is the same with the <c>login</c> event of <c>app</c>.
        /// </summary>
        [<Emit "$0.on('login',$1)">] abstract on_login: listener: (Event -> AuthenticationResponseDetails -> AuthInfo -> ((string) option -> (string) option -> unit) -> unit) -> WebContents
        [<Emit "$0.once('login',$1)">] abstract once_login: listener: (Event -> AuthenticationResponseDetails -> AuthInfo -> ((string) option -> (string) option -> unit) -> unit) -> WebContents
        [<Emit "$0.addListener('login',$1)">] abstract addListener_login: listener: (Event -> AuthenticationResponseDetails -> AuthInfo -> ((string) option -> (string) option -> unit) -> unit) -> WebContents
        [<Emit "$0.removeListener('login',$1)">] abstract removeListener_login: listener: (Event -> AuthenticationResponseDetails -> AuthInfo -> ((string) option -> (string) option -> unit) -> unit) -> WebContents
        /// Emitted when media is paused or done playing.
        [<Emit "$0.on('media-paused',$1)">] abstract ``on_media-paused``: listener: Function -> WebContents
        [<Emit "$0.once('media-paused',$1)">] abstract ``once_media-paused``: listener: Function -> WebContents
        [<Emit "$0.addListener('media-paused',$1)">] abstract ``addListener_media-paused``: listener: Function -> WebContents
        [<Emit "$0.removeListener('media-paused',$1)">] abstract ``removeListener_media-paused``: listener: Function -> WebContents
        /// Emitted when media starts playing.
        [<Emit "$0.on('media-started-playing',$1)">] abstract ``on_media-started-playing``: listener: Function -> WebContents
        [<Emit "$0.once('media-started-playing',$1)">] abstract ``once_media-started-playing``: listener: Function -> WebContents
        [<Emit "$0.addListener('media-started-playing',$1)">] abstract ``addListener_media-started-playing``: listener: Function -> WebContents
        [<Emit "$0.removeListener('media-started-playing',$1)">] abstract ``removeListener_media-started-playing``: listener: Function -> WebContents
        /// <summary>
        /// Emitted when the page requests to open a new window for a <c>url</c>. It could be
        /// requested by <c>window.open</c> or an external link like <c>&lt;a target='_blank'&gt;</c>.
        /// 
        /// By default a new <c>BrowserWindow</c> will be created for the <c>url</c>.
        /// 
        /// Calling <c>event.preventDefault()</c> will prevent Electron from automatically
        /// creating a new <c>BrowserWindow</c>. If you call <c>event.preventDefault()</c> and
        /// manually create a new <c>BrowserWindow</c> then you must set <c>event.newGuest</c> to
        /// reference the new <c>BrowserWindow</c> instance, failing to do so may result in
        /// unexpected behavior. For example:
        /// </summary>
        [<Emit "$0.on('new-window',$1)">] abstract ``on_new-window``: listener: (NewWindowEvent -> string -> string -> NewWindowEventDisposition -> BrowserWindowConstructorOptions -> ResizeArray<string> -> Referrer -> unit) -> WebContents
        [<Emit "$0.once('new-window',$1)">] abstract ``once_new-window``: listener: (NewWindowEvent -> string -> string -> NewWindowEventDisposition -> BrowserWindowConstructorOptions -> ResizeArray<string> -> Referrer -> unit) -> WebContents
        [<Emit "$0.addListener('new-window',$1)">] abstract ``addListener_new-window``: listener: (NewWindowEvent -> string -> string -> NewWindowEventDisposition -> BrowserWindowConstructorOptions -> ResizeArray<string> -> Referrer -> unit) -> WebContents
        [<Emit "$0.removeListener('new-window',$1)">] abstract ``removeListener_new-window``: listener: (NewWindowEvent -> string -> string -> NewWindowEventDisposition -> BrowserWindowConstructorOptions -> ResizeArray<string> -> Referrer -> unit) -> WebContents
        /// Emitted when page receives favicon urls.
        [<Emit "$0.on('page-favicon-updated',$1)">] abstract ``on_page-favicon-updated``: listener: (Event -> ResizeArray<string> -> unit) -> WebContents
        [<Emit "$0.once('page-favicon-updated',$1)">] abstract ``once_page-favicon-updated``: listener: (Event -> ResizeArray<string> -> unit) -> WebContents
        [<Emit "$0.addListener('page-favicon-updated',$1)">] abstract ``addListener_page-favicon-updated``: listener: (Event -> ResizeArray<string> -> unit) -> WebContents
        [<Emit "$0.removeListener('page-favicon-updated',$1)">] abstract ``removeListener_page-favicon-updated``: listener: (Event -> ResizeArray<string> -> unit) -> WebContents
        /// <summary>
        /// Fired when page title is set during navigation. <c>explicitSet</c> is false when
        /// title is synthesized from file url.
        /// </summary>
        [<Emit "$0.on('page-title-updated',$1)">] abstract ``on_page-title-updated``: listener: (Event -> string -> bool -> unit) -> WebContents
        [<Emit "$0.once('page-title-updated',$1)">] abstract ``once_page-title-updated``: listener: (Event -> string -> bool -> unit) -> WebContents
        [<Emit "$0.addListener('page-title-updated',$1)">] abstract ``addListener_page-title-updated``: listener: (Event -> string -> bool -> unit) -> WebContents
        [<Emit "$0.removeListener('page-title-updated',$1)">] abstract ``removeListener_page-title-updated``: listener: (Event -> string -> bool -> unit) -> WebContents
        /// Emitted when a new frame is generated. Only the dirty area is passed in the
        /// buffer.
        [<Emit "$0.on('paint',$1)">] abstract on_paint: listener: (Event -> Rectangle -> NativeImage -> unit) -> WebContents
        [<Emit "$0.once('paint',$1)">] abstract once_paint: listener: (Event -> Rectangle -> NativeImage -> unit) -> WebContents
        [<Emit "$0.addListener('paint',$1)">] abstract addListener_paint: listener: (Event -> Rectangle -> NativeImage -> unit) -> WebContents
        [<Emit "$0.removeListener('paint',$1)">] abstract removeListener_paint: listener: (Event -> Rectangle -> NativeImage -> unit) -> WebContents
        /// Emitted when a plugin process has crashed.
        [<Emit "$0.on('plugin-crashed',$1)">] abstract ``on_plugin-crashed``: listener: (Event -> string -> string -> unit) -> WebContents
        [<Emit "$0.once('plugin-crashed',$1)">] abstract ``once_plugin-crashed``: listener: (Event -> string -> string -> unit) -> WebContents
        [<Emit "$0.addListener('plugin-crashed',$1)">] abstract ``addListener_plugin-crashed``: listener: (Event -> string -> string -> unit) -> WebContents
        [<Emit "$0.removeListener('plugin-crashed',$1)">] abstract ``removeListener_plugin-crashed``: listener: (Event -> string -> string -> unit) -> WebContents
        /// <summary>
        /// Emitted when the preload script <c>preloadPath</c> throws an unhandled exception
        /// <c>error</c>.
        /// </summary>
        [<Emit "$0.on('preload-error',$1)">] abstract ``on_preload-error``: listener: (Event -> string -> Error -> unit) -> WebContents
        [<Emit "$0.once('preload-error',$1)">] abstract ``once_preload-error``: listener: (Event -> string -> Error -> unit) -> WebContents
        [<Emit "$0.addListener('preload-error',$1)">] abstract ``addListener_preload-error``: listener: (Event -> string -> Error -> unit) -> WebContents
        [<Emit "$0.removeListener('preload-error',$1)">] abstract ``removeListener_preload-error``: listener: (Event -> string -> Error -> unit) -> WebContents
        /// <summary>
        /// Emitted when <c>remote.getBuiltin()</c> is called in the renderer process. Calling
        /// <c>event.preventDefault()</c> will prevent the module from being returned. Custom
        /// value can be returned by setting <c>event.returnValue</c>.
        /// </summary>
        [<Emit "$0.on('remote-get-builtin',$1)">] abstract ``on_remote-get-builtin``: listener: (IpcMainEvent -> string -> unit) -> WebContents
        [<Emit "$0.once('remote-get-builtin',$1)">] abstract ``once_remote-get-builtin``: listener: (IpcMainEvent -> string -> unit) -> WebContents
        [<Emit "$0.addListener('remote-get-builtin',$1)">] abstract ``addListener_remote-get-builtin``: listener: (IpcMainEvent -> string -> unit) -> WebContents
        [<Emit "$0.removeListener('remote-get-builtin',$1)">] abstract ``removeListener_remote-get-builtin``: listener: (IpcMainEvent -> string -> unit) -> WebContents
        /// <summary>
        /// Emitted when <c>remote.getCurrentWebContents()</c> is called in the renderer process.
        /// Calling <c>event.preventDefault()</c> will prevent the object from being returned.
        /// Custom value can be returned by setting <c>event.returnValue</c>.
        /// </summary>
        [<Emit "$0.on('remote-get-current-web-contents',$1)">] abstract ``on_remote-get-current-web-contents``: listener: (IpcMainEvent -> unit) -> WebContents
        [<Emit "$0.once('remote-get-current-web-contents',$1)">] abstract ``once_remote-get-current-web-contents``: listener: (IpcMainEvent -> unit) -> WebContents
        [<Emit "$0.addListener('remote-get-current-web-contents',$1)">] abstract ``addListener_remote-get-current-web-contents``: listener: (IpcMainEvent -> unit) -> WebContents
        [<Emit "$0.removeListener('remote-get-current-web-contents',$1)">] abstract ``removeListener_remote-get-current-web-contents``: listener: (IpcMainEvent -> unit) -> WebContents
        /// <summary>
        /// Emitted when <c>remote.getCurrentWindow()</c> is called in the renderer process.
        /// Calling <c>event.preventDefault()</c> will prevent the object from being returned.
        /// Custom value can be returned by setting <c>event.returnValue</c>.
        /// </summary>
        [<Emit "$0.on('remote-get-current-window',$1)">] abstract ``on_remote-get-current-window``: listener: (IpcMainEvent -> unit) -> WebContents
        [<Emit "$0.once('remote-get-current-window',$1)">] abstract ``once_remote-get-current-window``: listener: (IpcMainEvent -> unit) -> WebContents
        [<Emit "$0.addListener('remote-get-current-window',$1)">] abstract ``addListener_remote-get-current-window``: listener: (IpcMainEvent -> unit) -> WebContents
        [<Emit "$0.removeListener('remote-get-current-window',$1)">] abstract ``removeListener_remote-get-current-window``: listener: (IpcMainEvent -> unit) -> WebContents
        /// <summary>
        /// Emitted when <c>remote.getGlobal()</c> is called in the renderer process. Calling
        /// <c>event.preventDefault()</c> will prevent the global from being returned. Custom
        /// value can be returned by setting <c>event.returnValue</c>.
        /// </summary>
        [<Emit "$0.on('remote-get-global',$1)">] abstract ``on_remote-get-global``: listener: (IpcMainEvent -> string -> unit) -> WebContents
        [<Emit "$0.once('remote-get-global',$1)">] abstract ``once_remote-get-global``: listener: (IpcMainEvent -> string -> unit) -> WebContents
        [<Emit "$0.addListener('remote-get-global',$1)">] abstract ``addListener_remote-get-global``: listener: (IpcMainEvent -> string -> unit) -> WebContents
        [<Emit "$0.removeListener('remote-get-global',$1)">] abstract ``removeListener_remote-get-global``: listener: (IpcMainEvent -> string -> unit) -> WebContents
        /// <summary>
        /// Emitted when <c>remote.require()</c> is called in the renderer process. Calling
        /// <c>event.preventDefault()</c> will prevent the module from being returned. Custom
        /// value can be returned by setting <c>event.returnValue</c>.
        /// </summary>
        [<Emit "$0.on('remote-require',$1)">] abstract ``on_remote-require``: listener: (IpcMainEvent -> string -> unit) -> WebContents
        [<Emit "$0.once('remote-require',$1)">] abstract ``once_remote-require``: listener: (IpcMainEvent -> string -> unit) -> WebContents
        [<Emit "$0.addListener('remote-require',$1)">] abstract ``addListener_remote-require``: listener: (IpcMainEvent -> string -> unit) -> WebContents
        [<Emit "$0.removeListener('remote-require',$1)">] abstract ``removeListener_remote-require``: listener: (IpcMainEvent -> string -> unit) -> WebContents
        /// Emitted when the renderer process unexpectedly dissapears.  This is normally
        /// because it was crashed or killed.
        [<Emit "$0.on('render-process-gone',$1)">] abstract ``on_render-process-gone``: listener: (Event -> Details -> unit) -> WebContents
        [<Emit "$0.once('render-process-gone',$1)">] abstract ``once_render-process-gone``: listener: (Event -> Details -> unit) -> WebContents
        [<Emit "$0.addListener('render-process-gone',$1)">] abstract ``addListener_render-process-gone``: listener: (Event -> Details -> unit) -> WebContents
        [<Emit "$0.removeListener('render-process-gone',$1)">] abstract ``removeListener_render-process-gone``: listener: (Event -> Details -> unit) -> WebContents
        /// Emitted when the unresponsive web page becomes responsive again.
        [<Emit "$0.on('responsive',$1)">] abstract on_responsive: listener: Function -> WebContents
        [<Emit "$0.once('responsive',$1)">] abstract once_responsive: listener: Function -> WebContents
        [<Emit "$0.addListener('responsive',$1)">] abstract addListener_responsive: listener: Function -> WebContents
        [<Emit "$0.removeListener('responsive',$1)">] abstract removeListener_responsive: listener: Function -> WebContents
        /// <summary>
        /// Emitted when bluetooth device needs to be selected on call to
        /// <c>navigator.bluetooth.requestDevice</c>. To use <c>navigator.bluetooth</c> api
        /// <c>webBluetooth</c> should be enabled. If <c>event.preventDefault</c> is not called, first
        /// available device will be selected. <c>callback</c> should be called with <c>deviceId</c>
        /// to be selected, passing empty string to <c>callback</c> will cancel the request.
        /// </summary>
        [<Emit "$0.on('select-bluetooth-device',$1)">] abstract ``on_select-bluetooth-device``: listener: (Event -> ResizeArray<BluetoothDevice> -> (string -> unit) -> unit) -> WebContents
        [<Emit "$0.once('select-bluetooth-device',$1)">] abstract ``once_select-bluetooth-device``: listener: (Event -> ResizeArray<BluetoothDevice> -> (string -> unit) -> unit) -> WebContents
        [<Emit "$0.addListener('select-bluetooth-device',$1)">] abstract ``addListener_select-bluetooth-device``: listener: (Event -> ResizeArray<BluetoothDevice> -> (string -> unit) -> unit) -> WebContents
        [<Emit "$0.removeListener('select-bluetooth-device',$1)">] abstract ``removeListener_select-bluetooth-device``: listener: (Event -> ResizeArray<BluetoothDevice> -> (string -> unit) -> unit) -> WebContents
        /// <summary>
        /// Emitted when a client certificate is requested.
        /// 
        /// The usage is the same with the <c>select-client-certificate</c> event of <c>app</c>.
        /// </summary>
        [<Emit "$0.on('select-client-certificate',$1)">] abstract ``on_select-client-certificate``: listener: (Event -> string -> ResizeArray<Certificate> -> (Certificate -> unit) -> unit) -> WebContents
        [<Emit "$0.once('select-client-certificate',$1)">] abstract ``once_select-client-certificate``: listener: (Event -> string -> ResizeArray<Certificate> -> (Certificate -> unit) -> unit) -> WebContents
        [<Emit "$0.addListener('select-client-certificate',$1)">] abstract ``addListener_select-client-certificate``: listener: (Event -> string -> ResizeArray<Certificate> -> (Certificate -> unit) -> unit) -> WebContents
        [<Emit "$0.removeListener('select-client-certificate',$1)">] abstract ``removeListener_select-client-certificate``: listener: (Event -> string -> ResizeArray<Certificate> -> (Certificate -> unit) -> unit) -> WebContents
        /// Emitted when the web page becomes unresponsive.
        [<Emit "$0.on('unresponsive',$1)">] abstract on_unresponsive: listener: Function -> WebContents
        [<Emit "$0.once('unresponsive',$1)">] abstract once_unresponsive: listener: Function -> WebContents
        [<Emit "$0.addListener('unresponsive',$1)">] abstract addListener_unresponsive: listener: Function -> WebContents
        [<Emit "$0.removeListener('unresponsive',$1)">] abstract removeListener_unresponsive: listener: Function -> WebContents
        /// Emitted when mouse moves over a link or the keyboard moves the focus to a link.
        [<Emit "$0.on('update-target-url',$1)">] abstract ``on_update-target-url``: listener: (Event -> string -> unit) -> WebContents
        [<Emit "$0.once('update-target-url',$1)">] abstract ``once_update-target-url``: listener: (Event -> string -> unit) -> WebContents
        [<Emit "$0.addListener('update-target-url',$1)">] abstract ``addListener_update-target-url``: listener: (Event -> string -> unit) -> WebContents
        [<Emit "$0.removeListener('update-target-url',$1)">] abstract ``removeListener_update-target-url``: listener: (Event -> string -> unit) -> WebContents
        /// <summary>
        /// Emitted when a <c>&lt;webview&gt;</c>'s web contents is being attached to this web
        /// contents. Calling <c>event.preventDefault()</c> will destroy the guest page.
        /// 
        /// This event can be used to configure <c>webPreferences</c> for the <c>webContents</c> of a
        /// <c>&lt;webview&gt;</c> before it's loaded, and provides the ability to set settings that
        /// can't be set via <c>&lt;webview&gt;</c> attributes.
        /// 
        /// **Note:** The specified <c>preload</c> script option will be appear as <c>preloadURL</c>
        /// (not <c>preload</c>) in the <c>webPreferences</c> object emitted with this event.
        /// </summary>
        [<Emit "$0.on('will-attach-webview',$1)">] abstract ``on_will-attach-webview``: listener: (Event -> WebPreferences -> Record<string, string> -> unit) -> WebContents
        [<Emit "$0.once('will-attach-webview',$1)">] abstract ``once_will-attach-webview``: listener: (Event -> WebPreferences -> Record<string, string> -> unit) -> WebContents
        [<Emit "$0.addListener('will-attach-webview',$1)">] abstract ``addListener_will-attach-webview``: listener: (Event -> WebPreferences -> Record<string, string> -> unit) -> WebContents
        [<Emit "$0.removeListener('will-attach-webview',$1)">] abstract ``removeListener_will-attach-webview``: listener: (Event -> WebPreferences -> Record<string, string> -> unit) -> WebContents
        /// <summary>
        /// Emitted when a user or the page wants to start navigation. It can happen when
        /// the <c>window.location</c> object is changed or a user clicks a link in the page.
        /// 
        /// This event will not emit when the navigation is started programmatically with
        /// APIs like <c>webContents.loadURL</c> and <c>webContents.back</c>.
        /// 
        /// It is also not emitted for in-page navigations, such as clicking anchor links or
        /// updating the <c>window.location.hash</c>. Use <c>did-navigate-in-page</c> event for this
        /// purpose.
        /// 
        /// Calling <c>event.preventDefault()</c> will prevent the navigation.
        /// </summary>
        [<Emit "$0.on('will-navigate',$1)">] abstract ``on_will-navigate``: listener: (Event -> string -> unit) -> WebContents
        [<Emit "$0.once('will-navigate',$1)">] abstract ``once_will-navigate``: listener: (Event -> string -> unit) -> WebContents
        [<Emit "$0.addListener('will-navigate',$1)">] abstract ``addListener_will-navigate``: listener: (Event -> string -> unit) -> WebContents
        [<Emit "$0.removeListener('will-navigate',$1)">] abstract ``removeListener_will-navigate``: listener: (Event -> string -> unit) -> WebContents
        /// <summary>
        /// Emitted when a <c>beforeunload</c> event handler is attempting to cancel a page
        /// unload.
        /// 
        /// Calling <c>event.preventDefault()</c> will ignore the <c>beforeunload</c> event handler
        /// and allow the page to be unloaded.
        /// </summary>
        [<Emit "$0.on('will-prevent-unload',$1)">] abstract ``on_will-prevent-unload``: listener: (Event -> unit) -> WebContents
        [<Emit "$0.once('will-prevent-unload',$1)">] abstract ``once_will-prevent-unload``: listener: (Event -> unit) -> WebContents
        [<Emit "$0.addListener('will-prevent-unload',$1)">] abstract ``addListener_will-prevent-unload``: listener: (Event -> unit) -> WebContents
        [<Emit "$0.removeListener('will-prevent-unload',$1)">] abstract ``removeListener_will-prevent-unload``: listener: (Event -> unit) -> WebContents
        /// <summary>
        /// Emitted as a server side redirect occurs during navigation.  For example a 302
        /// redirect.
        /// 
        /// This event will be emitted after <c>did-start-navigation</c> and always before the
        /// <c>did-redirect-navigation</c> event for the same navigation.
        /// 
        /// Calling <c>event.preventDefault()</c> will prevent the navigation (not just the
        /// redirect).
        /// </summary>
        [<Emit "$0.on('will-redirect',$1)">] abstract ``on_will-redirect``: listener: (Event -> string -> bool -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.once('will-redirect',$1)">] abstract ``once_will-redirect``: listener: (Event -> string -> bool -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.addListener('will-redirect',$1)">] abstract ``addListener_will-redirect``: listener: (Event -> string -> bool -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.removeListener('will-redirect',$1)">] abstract ``removeListener_will-redirect``: listener: (Event -> string -> bool -> bool -> float -> float -> unit) -> WebContents
        /// Emitted when the user is requesting to change the zoom level using the mouse
        /// wheel.
        [<Emit "$0.on('zoom-changed',$1)">] abstract ``on_zoom-changed``: listener: (Event -> WebContentsOn_zoomChanged -> unit) -> WebContents
        [<Emit "$0.once('zoom-changed',$1)">] abstract ``once_zoom-changed``: listener: (Event -> WebContentsOn_zoomChanged -> unit) -> WebContents
        [<Emit "$0.addListener('zoom-changed',$1)">] abstract ``addListener_zoom-changed``: listener: (Event -> WebContentsOn_zoomChanged -> unit) -> WebContents
        [<Emit "$0.removeListener('zoom-changed',$1)">] abstract ``removeListener_zoom-changed``: listener: (Event -> WebContentsOn_zoomChanged -> unit) -> WebContents
        /// Adds the specified path to DevTools workspace. Must be used after DevTools
        /// creation:
        abstract addWorkSpace: path: string -> unit
        /// <summary>
        /// Begin subscribing for presentation events and captured frames, the <c>callback</c>
        /// will be called with <c>callback(image, dirtyRect)</c> when there is a presentation
        /// event.
        /// 
        /// The <c>image</c> is an instance of NativeImage that stores the captured frame.
        /// 
        /// The <c>dirtyRect</c> is an object with <c>x, y, width, height</c> properties that
        /// describes which part of the page was repainted. If <c>onlyDirty</c> is set to <c>true</c>,
        /// <c>image</c> will only contain the repainted area. <c>onlyDirty</c> defaults to <c>false</c>.
        /// </summary>
        abstract beginFrameSubscription: onlyDirty: bool * callback: (NativeImage -> Rectangle -> unit) -> unit
        /// <summary>
        /// Begin subscribing for presentation events and captured frames, the <c>callback</c>
        /// will be called with <c>callback(image, dirtyRect)</c> when there is a presentation
        /// event.
        /// 
        /// The <c>image</c> is an instance of NativeImage that stores the captured frame.
        /// 
        /// The <c>dirtyRect</c> is an object with <c>x, y, width, height</c> properties that
        /// describes which part of the page was repainted. If <c>onlyDirty</c> is set to <c>true</c>,
        /// <c>image</c> will only contain the repainted area. <c>onlyDirty</c> defaults to <c>false</c>.
        /// </summary>
        abstract beginFrameSubscription: callback: (NativeImage -> Rectangle -> unit) -> unit
        /// Whether the browser can go back to previous web page.
        abstract canGoBack: unit -> bool
        /// Whether the browser can go forward to next web page.
        abstract canGoForward: unit -> bool
        /// <summary>Whether the web page can go to <c>offset</c>.</summary>
        abstract canGoToOffset: offset: float -> bool
        /// <summary>
        /// Resolves with a NativeImage
        /// 
        /// Captures a snapshot of the page within <c>rect</c>. Omitting <c>rect</c> will capture the
        /// whole visible page.
        /// </summary>
        abstract capturePage: ?rect: Rectangle -> Promise<Electron.NativeImage>
        /// Clears the navigation history.
        abstract clearHistory: unit -> unit
        /// Closes the devtools.
        abstract closeDevTools: unit -> unit
        /// <summary>Executes the editing command <c>copy</c> in web page.</summary>
        abstract copy: unit -> unit
        /// Copy the image at the given position to the clipboard.
        abstract copyImageAt: x: float * y: float -> unit
        /// <summary>Executes the editing command <c>cut</c> in web page.</summary>
        abstract cut: unit -> unit
        /// <summary>
        /// Decrease the capturer count by one. The page will be set to hidden or occluded
        /// state when its browser window is hidden or occluded and the capturer count
        /// reaches zero. If you want to decrease the hidden capturer count instead you
        /// should set <c>stayHidden</c> to true.
        /// </summary>
        abstract decrementCapturerCount: ?stayHidden: bool -> unit
        /// <summary>Executes the editing command <c>delete</c> in web page.</summary>
        abstract delete: unit -> unit
        /// <summary>Disable device emulation enabled by <c>webContents.enableDeviceEmulation</c>.</summary>
        abstract disableDeviceEmulation: unit -> unit
        /// <summary>
        /// Initiates a download of the resource at <c>url</c> without navigating. The
        /// <c>will-download</c> event of <c>session</c> will be triggered.
        /// </summary>
        abstract downloadURL: url: string -> unit
        /// Enable device emulation with the given parameters.
        abstract enableDeviceEmulation: parameters: Parameters -> unit
        /// End subscribing for frame presentation events.
        abstract endFrameSubscription: unit -> unit
        /// <summary>
        /// A promise that resolves with the result of the executed code or is rejected if
        /// the result of the code is a rejected promise.
        /// 
        /// Evaluates <c>code</c> in page.
        /// 
        /// In the browser window some HTML APIs like <c>requestFullScreen</c> can only be
        /// invoked by a gesture from the user. Setting <c>userGesture</c> to <c>true</c> will remove
        /// this limitation.
        /// 
        /// Code execution will be suspended until web page stop loading.
        /// </summary>
        abstract executeJavaScript: code: string * ?userGesture: bool -> Promise<obj option>
        /// <summary>
        /// A promise that resolves with the result of the executed code or is rejected if
        /// the result of the code is a rejected promise.
        /// 
        /// Works like <c>executeJavaScript</c> but evaluates <c>scripts</c> in an isolated context.
        /// </summary>
        abstract executeJavaScriptInIsolatedWorld: worldId: float * scripts: ResizeArray<WebSource> * ?userGesture: bool -> Promise<obj option>
        /// <summary>
        /// The request id used for the request.
        /// 
        /// Starts a request to find all matches for the <c>text</c> in the web page. The result
        /// of the request can be obtained by subscribing to <c>found-in-page</c> event.
        /// </summary>
        abstract findInPage: text: string * ?options: FindInPageOptions -> float
        /// Focuses the web page.
        abstract focus: unit -> unit
        /// Information about all Shared Workers.
        abstract getAllSharedWorkers: unit -> ResizeArray<SharedWorkerInfo>
        /// If *offscreen rendering* is enabled returns the current frame rate.
        abstract getFrameRate: unit -> float
        /// <summary>The operating system <c>pid</c> of the associated renderer process.</summary>
        abstract getOSProcessId: unit -> float
        /// Get the system printer list.
        abstract getPrinters: unit -> ResizeArray<PrinterInfo>
        /// <summary>
        /// The Chromium internal <c>pid</c> of the associated renderer. Can be compared to the
        /// <c>frameProcessId</c> passed by frame specific navigation events (e.g.
        /// <c>did-frame-navigate</c>)
        /// </summary>
        abstract getProcessId: unit -> float
        /// The title of the current web page.
        abstract getTitle: unit -> string
        /// <summary>
        /// the type of the webContent. Can be <c>backgroundPage</c>, <c>window</c>, <c>browserView</c>,
        /// <c>remote</c>, <c>webview</c> or <c>offscreen</c>.
        /// </summary>
        abstract getType: unit -> WebContentsGetTypeReturn
        /// The URL of the current web page.
        abstract getURL: unit -> string
        /// The user agent for this web page.
        abstract getUserAgent: unit -> string
        /// Returns the WebRTC IP Handling Policy.
        abstract getWebRTCIPHandlingPolicy: unit -> string
        /// the current zoom factor.
        abstract getZoomFactor: unit -> float
        /// the current zoom level.
        abstract getZoomLevel: unit -> float
        /// Makes the browser go back a web page.
        abstract goBack: unit -> unit
        /// Makes the browser go forward a web page.
        abstract goForward: unit -> unit
        /// Navigates browser to the specified absolute web page index.
        abstract goToIndex: index: float -> unit
        /// Navigates to the specified offset from the "current entry".
        abstract goToOffset: offset: float -> unit
        /// <summary>
        /// Increase the capturer count by one. The page is considered visible when its
        /// browser window is hidden and the capturer count is non-zero. If you would like
        /// the page to stay hidden, you should ensure that <c>stayHidden</c> is set to true.
        /// 
        /// This also affects the Page Visibility API.
        /// </summary>
        abstract incrementCapturerCount: ?size: Size * ?stayHidden: bool -> unit
        /// <summary>
        /// A promise that resolves with a key for the inserted CSS that can later be used
        /// to remove the CSS via <c>contents.removeInsertedCSS(key)</c>.
        /// 
        /// Injects CSS into the current web page and returns a unique key for the inserted
        /// stylesheet.
        /// </summary>
        abstract insertCSS: css: string * ?options: InsertCSSOptions -> Promise<string>
        /// <summary>Inserts <c>text</c> to the focused element.</summary>
        abstract insertText: text: string -> Promise<unit>
        /// <summary>Starts inspecting element at position (<c>x</c>, <c>y</c>).</summary>
        abstract inspectElement: x: float * y: float -> unit
        /// Opens the developer tools for the service worker context.
        abstract inspectServiceWorker: unit -> unit
        /// Opens the developer tools for the shared worker context.
        abstract inspectSharedWorker: unit -> unit
        /// Inspects the shared worker based on its ID.
        abstract inspectSharedWorkerById: workerId: string -> unit
        /// <summary>
        /// Schedules a full repaint of the window this web contents is in.
        /// 
        /// If *offscreen rendering* is enabled invalidates the frame and generates a new
        /// one through the <c>'paint'</c> event.
        /// </summary>
        abstract invalidate: unit -> unit
        /// Whether this page has been muted.
        abstract isAudioMuted: unit -> bool
        /// Whether this page is being captured. It returns true when the capturer count is
        /// large then 0.
        abstract isBeingCaptured: unit -> bool
        /// Whether the renderer process has crashed.
        abstract isCrashed: unit -> bool
        /// Whether audio is currently playing.
        abstract isCurrentlyAudible: unit -> bool
        /// Whether the web page is destroyed.
        abstract isDestroyed: unit -> bool
        /// Whether the devtools view is focused .
        abstract isDevToolsFocused: unit -> bool
        /// Whether the devtools is opened.
        abstract isDevToolsOpened: unit -> bool
        /// Whether the web page is focused.
        abstract isFocused: unit -> bool
        /// Whether web page is still loading resources.
        abstract isLoading: unit -> bool
        /// Whether the main frame (and not just iframes or frames within it) is still
        /// loading.
        abstract isLoadingMainFrame: unit -> bool
        /// Indicates whether *offscreen rendering* is enabled.
        abstract isOffscreen: unit -> bool
        /// If *offscreen rendering* is enabled returns whether it is currently painting.
        abstract isPainting: unit -> bool
        /// Whether the web page is waiting for a first-response from the main resource of
        /// the page.
        abstract isWaitingForResponse: unit -> bool
        /// <summary>
        /// the promise will resolve when the page has finished loading (see
        /// <c>did-finish-load</c>), and rejects if the page fails to load (see <c>did-fail-load</c>).
        /// 
        /// Loads the given file in the window, <c>filePath</c> should be a path to an HTML file
        /// relative to the root of your application.  For instance an app structure like
        /// this:
        /// 
        /// Would require code like this
        /// </summary>
        abstract loadFile: filePath: string * ?options: LoadFileOptions -> Promise<unit>
        /// <summary>
        /// the promise will resolve when the page has finished loading (see
        /// <c>did-finish-load</c>), and rejects if the page fails to load (see <c>did-fail-load</c>).
        /// A noop rejection handler is already attached, which avoids unhandled rejection
        /// errors.
        /// 
        /// Loads the <c>url</c> in the window. The <c>url</c> must contain the protocol prefix, e.g.
        /// the <c>http://</c> or <c>file://</c>. If the load should bypass http cache then use the
        /// <c>pragma</c> header to achieve it.
        /// </summary>
        abstract loadURL: url: string * ?options: LoadURLOptions -> Promise<unit>
        /// <summary>
        /// Opens the devtools.
        /// 
        /// When <c>contents</c> is a <c>&lt;webview&gt;</c> tag, the <c>mode</c> would be <c>detach</c> by default,
        /// explicitly passing an empty <c>mode</c> can force using last used dock state.
        /// </summary>
        abstract openDevTools: ?options: OpenDevToolsOptions -> unit
        /// <summary>Executes the editing command <c>paste</c> in web page.</summary>
        abstract paste: unit -> unit
        /// <summary>Executes the editing command <c>pasteAndMatchStyle</c> in web page.</summary>
        abstract pasteAndMatchStyle: unit -> unit
        /// <summary>
        /// Send a message to the renderer process, optionally transferring ownership of
        /// zero or more [<c>MessagePortMain</c>][] objects.
        /// 
        /// The transferred <c>MessagePortMain</c> objects will be available in the renderer
        /// process by accessing the <c>ports</c> property of the emitted event. When they arrive
        /// in the renderer, they will be native DOM <c>MessagePort</c> objects.
        /// 
        /// For example:
        /// </summary>
        abstract postMessage: channel: string * message: obj option * ?transfer: ResizeArray<MessagePortMain> -> unit
        /// <summary>
        /// When a custom <c>pageSize</c> is passed, Chromium attempts to validate platform
        /// specific minumum values for <c>width_microns</c> and <c>height_microns</c>. Width and
        /// height must both be minimum 353 microns but may be higher on some operating
        /// systems.
        /// 
        /// Prints window's web page. When <c>silent</c> is set to <c>true</c>, Electron will pick the
        /// system's default printer if <c>deviceName</c> is empty and the default settings for
        /// printing.
        /// 
        /// Use <c>page-break-before: always;</c> CSS style to force to print to a new page.
        /// 
        /// Example usage:
        /// </summary>
        abstract print: ?options: WebContentsPrintOptions * ?callback: (bool -> string -> unit) -> unit
        /// <summary>
        /// Resolves with the generated PDF data.
        /// 
        /// Prints window's web page as PDF with Chromium's preview printing custom
        /// settings.
        /// 
        /// The <c>landscape</c> will be ignored if <c>@page</c> CSS at-rule is used in the web page.
        /// 
        /// By default, an empty <c>options</c> will be regarded as:
        /// 
        /// Use <c>page-break-before: always;</c> CSS style to force to print to a new page.
        /// 
        /// An example of <c>webContents.printToPDF</c>:
        /// </summary>
        abstract printToPDF: options: PrintToPDFOptions -> Promise<Buffer>
        /// <summary>Executes the editing command <c>redo</c> in web page.</summary>
        abstract redo: unit -> unit
        /// Reloads the current web page.
        abstract reload: unit -> unit
        /// Reloads current page and ignores cache.
        abstract reloadIgnoringCache: unit -> unit
        /// <summary>
        /// Resolves if the removal was successful.
        /// 
        /// Removes the inserted CSS from the current web page. The stylesheet is identified
        /// by its key, which is returned from <c>contents.insertCSS(css)</c>.
        /// </summary>
        abstract removeInsertedCSS: key: string -> Promise<unit>
        /// Removes the specified path from DevTools workspace.
        abstract removeWorkSpace: path: string -> unit
        /// <summary>Executes the editing command <c>replace</c> in web page.</summary>
        abstract replace: text: string -> unit
        /// <summary>Executes the editing command <c>replaceMisspelling</c> in web page.</summary>
        abstract replaceMisspelling: text: string -> unit
        /// resolves if the page is saved.
        abstract savePage: fullPath: string * saveType: WebContentsSavePageSaveType -> Promise<unit>
        /// <summary>Executes the editing command <c>selectAll</c> in web page.</summary>
        abstract selectAll: unit -> unit
        /// <summary>
        /// Send an asynchronous message to the renderer process via <c>channel</c>, along with
        /// arguments. Arguments will be serialized with the Structured Clone Algorithm,
        /// just like <c>postMessage</c>, so prototype chains will not be included. Sending
        /// Functions, Promises, Symbols, WeakMaps, or WeakSets will throw an exception.
        /// 
        /// &gt; **NOTE**: Sending non-standard JavaScript types such as DOM objects or special
        /// Electron objects is deprecated, and will begin throwing an exception starting
        /// with Electron 9.
        /// 
        /// The renderer process can handle the message by listening to <c>channel</c> with the
        /// <c>ipcRenderer</c> module.
        /// 
        /// An example of sending messages from the main process to the renderer process:
        /// </summary>
        abstract send: channel: string * [<ParamArray>] args: obj option[] -> unit
        /// <summary>
        /// Sends an input <c>event</c> to the page. **Note:** The <c>BrowserWindow</c> containing the
        /// contents needs to be focused for <c>sendInputEvent()</c> to work.
        /// </summary>
        abstract sendInputEvent: inputEvent: U3<MouseInputEvent, MouseWheelInputEvent, KeyboardInputEvent> -> unit
        /// <summary>
        /// Send an asynchronous message to a specific frame in a renderer process via
        /// <c>channel</c>, along with arguments. Arguments will be serialized with the
        /// Structured Clone Algorithm, just like <c>postMessage</c>, so prototype chains will
        /// not be included. Sending Functions, Promises, Symbols, WeakMaps, or WeakSets
        /// will throw an exception.
        /// 
        /// &gt; **NOTE**: Sending non-standard JavaScript types such as DOM objects or special
        /// Electron objects is deprecated, and will begin throwing an exception starting
        /// with Electron 9.
        /// 
        /// The renderer process can handle the message by listening to <c>channel</c> with the
        /// <c>ipcRenderer</c> module.
        /// 
        /// If you want to get the <c>frameId</c> of a given renderer context you should use the
        /// <c>webFrame.routingId</c> value.  E.g.
        /// 
        /// You can also read <c>frameId</c> from all incoming IPC messages in the main process.
        /// </summary>
        abstract sendToFrame: frameId: U2<float, float * float> * channel: string * [<ParamArray>] args: obj option[] -> unit
        /// Mute the audio on the current web page.
        abstract setAudioMuted: muted: bool -> unit
        /// Controls whether or not this WebContents will throttle animations and timers
        /// when the page becomes backgrounded. This also affects the Page Visibility API.
        abstract setBackgroundThrottling: allowed: bool -> unit
        /// <summary>
        /// Uses the <c>devToolsWebContents</c> as the target <c>WebContents</c> to show devtools.
        /// 
        /// The <c>devToolsWebContents</c> must not have done any navigation, and it should not
        /// be used for other purposes after the call.
        /// 
        /// By default Electron manages the devtools by creating an internal <c>WebContents</c>
        /// with native view, which developers have very limited control of. With the
        /// <c>setDevToolsWebContents</c> method, developers can use any <c>WebContents</c> to show
        /// the devtools in it, including <c>BrowserWindow</c>, <c>BrowserView</c> and <c>&lt;webview&gt;</c>
        /// tag.
        /// 
        /// Note that closing the devtools does not destroy the <c>devToolsWebContents</c>, it is
        /// caller's responsibility to destroy <c>devToolsWebContents</c>.
        /// 
        /// An example of showing devtools in a <c>&lt;webview&gt;</c> tag:
        /// 
        /// An example of showing devtools in a <c>BrowserWindow</c>:
        /// </summary>
        abstract setDevToolsWebContents: devToolsWebContents: WebContents -> unit
        /// If *offscreen rendering* is enabled sets the frame rate to the specified number.
        /// Only values between 1 and 60 are accepted.
        abstract setFrameRate: fps: float -> unit
        /// <summary>Ignore application menu shortcuts while this web contents is focused.</summary>
        abstract setIgnoreMenuShortcuts: ignore: bool -> unit
        /// Overrides the user agent for this web page.
        abstract setUserAgent: userAgent: string -> unit
        /// Sets the maximum and minimum pinch-to-zoom level.
        /// 
        /// > **NOTE**: Visual zoom is disabled by default in Electron. To re-enable it,
        /// call:
        abstract setVisualZoomLevelLimits: minimumLevel: float * maximumLevel: float -> Promise<unit>
        /// Setting the WebRTC IP handling policy allows you to control which IPs are
        /// exposed via WebRTC. See BrowserLeaks for more details.
        abstract setWebRTCIPHandlingPolicy: policy: WebContentsSetWebRTCIPHandlingPolicyPolicy -> unit
        /// Changes the zoom factor to the specified factor. Zoom factor is zoom percent
        /// divided by 100, so 300% = 3.0.
        /// 
        /// The factor must be greater than 0.0.
        abstract setZoomFactor: factor: float -> unit
        /// <summary>
        /// Changes the zoom level to the specified level. The original size is 0 and each
        /// increment above or below represents zooming 20% larger or smaller to default
        /// limits of 300% and 50% of original size, respectively. The formula for this is
        /// <c>scale := 1.2 ^ level</c>.
        /// </summary>
        abstract setZoomLevel: level: float -> unit
        /// <summary>Shows pop-up dictionary that searches the selected word on the page.</summary>
        abstract showDefinitionForSelection: unit -> unit
        /// <summary>
        /// Sets the <c>item</c> as dragging item for current drag-drop operation, <c>file</c> is the
        /// absolute path of the file to be dragged, and <c>icon</c> is the image showing under
        /// the cursor when dragging.
        /// </summary>
        abstract startDrag: item: Item -> unit
        /// If *offscreen rendering* is enabled and not painting, start painting.
        abstract startPainting: unit -> unit
        /// Stops any pending navigation.
        abstract stop: unit -> unit
        /// <summary>Stops any <c>findInPage</c> request for the <c>webContents</c> with the provided <c>action</c>.</summary>
        abstract stopFindInPage: action: WebContentsStopFindInPageAction -> unit
        /// If *offscreen rendering* is enabled and painting, stop painting.
        abstract stopPainting: unit -> unit
        /// <summary>
        /// Indicates whether the snapshot has been created successfully.
        /// 
        /// Takes a V8 heap snapshot and saves it to <c>filePath</c>.
        /// </summary>
        abstract takeHeapSnapshot: filePath: string -> Promise<unit>
        /// Toggles the developer tools.
        abstract toggleDevTools: unit -> unit
        /// <summary>Executes the editing command <c>undo</c> in web page.</summary>
        abstract undo: unit -> unit
        /// <summary>Executes the editing command <c>unselect</c> in web page.</summary>
        abstract unselect: unit -> unit
        abstract audioMuted: bool with get, set
        abstract debugger: Debugger
        abstract devToolsWebContents: WebContents option
        abstract frameRate: float with get, set
        abstract hostWebContents: WebContents
        abstract id: float
        abstract session: Session
        abstract userAgent: string with get, set
        abstract zoomFactor: float with get, set
        abstract zoomLevel: float with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] WebContentsGetTypeReturn =
        | BackgroundPage
        | Window
        | BrowserView
        | Remote
        | Webview
        | Offscreen

    type [<StringEnum>] [<RequireQualifiedAccess>] WebContentsSavePageSaveType =
        | [<CompiledName "HTMLOnly">] HTMLOnly
        | [<CompiledName "HTMLComplete">] HTMLComplete
        | [<CompiledName "MHTML">] MHTML

    type [<StringEnum>] [<RequireQualifiedAccess>] WebContentsSetWebRTCIPHandlingPolicyPolicy =
        | Default
        | Default_public_interface_only
        | Default_public_and_private_interfaces
        | Disable_non_proxied_udp

    type [<StringEnum>] [<RequireQualifiedAccess>] WebContentsStopFindInPageAction =
        | ClearSelection
        | KeepSelection
        | ActivateSelection

    type [<AllowNullLiteral>] WebContentsStatic =
        [<EmitConstructor>] abstract Create: unit -> WebContents
        /// A WebContents instance with the given ID.
        abstract fromId: id: float -> WebContents
        /// <summary>
        /// An array of all <c>WebContents</c> instances. This will contain web contents for all
        /// windows, webviews, opened devtools, and devtools extension background pages.
        /// </summary>
        abstract getAllWebContents: unit -> ResizeArray<WebContents>
        /// <summary>The web contents that is focused in this application, otherwise returns <c>null</c>.</summary>
        abstract getFocusedWebContents: unit -> WebContents

    type [<AllowNullLiteral>] WebFrame =
        inherit NodeJS.EventEmitter
        /// Attempts to free memory that is no longer being used (like images from a
        /// previous navigation).
        /// 
        /// Note that blindly calling this method probably makes Electron slower since it
        /// will have to refill these emptied caches, you should only call it if an event in
        /// your app has occurred that makes you think your page is actually using less
        /// memory (i.e. you have navigated from a super heavy page to a mostly empty one,
        /// and intend to stay there).
        abstract clearCache: unit -> unit
        /// <summary>
        /// A promise that resolves with the result of the executed code or is rejected if
        /// execution throws or results in a rejected promise.
        /// 
        /// Evaluates <c>code</c> in page.
        /// 
        /// In the browser window some HTML APIs like <c>requestFullScreen</c> can only be
        /// invoked by a gesture from the user. Setting <c>userGesture</c> to <c>true</c> will remove
        /// this limitation.
        /// </summary>
        abstract executeJavaScript: code: string * ?userGesture: bool * ?callback: (obj option -> Error -> unit) -> Promise<obj option>
        /// <summary>
        /// A promise that resolves with the result of the executed code or is rejected if
        /// execution could not start.
        /// 
        /// Works like <c>executeJavaScript</c> but evaluates <c>scripts</c> in an isolated context.
        /// 
        /// Note that when the execution of script fails, the returned promise will not
        /// reject and the <c>result</c> would be <c>undefined</c>. This is because Chromium does not
        /// dispatch errors of isolated worlds to foreign worlds.
        /// </summary>
        abstract executeJavaScriptInIsolatedWorld: worldId: float * scripts: ResizeArray<WebSource> * ?userGesture: bool * ?callback: (obj option -> Error -> unit) -> Promise<obj option>
        /// <summary>
        /// A child of <c>webFrame</c> with the supplied <c>name</c>, <c>null</c> would be returned if
        /// there's no such frame or if the frame is not in the current renderer process.
        /// </summary>
        abstract findFrameByName: name: string -> WebFrame
        /// <summary>that has the supplied <c>routingId</c>, <c>null</c> if not found.</summary>
        abstract findFrameByRoutingId: routingId: float -> WebFrame
        /// <summary>
        /// The frame element in <c>webFrame's</c> document selected by <c>selector</c>, <c>null</c> would
        /// be returned if <c>selector</c> does not select a frame or if the frame is not in the
        /// current renderer process.
        /// </summary>
        abstract getFrameForSelector: selector: string -> WebFrame
        /// <summary>
        /// * <c>images</c> MemoryUsageDetails
        /// * <c>scripts</c> MemoryUsageDetails
        /// * <c>cssStyleSheets</c> MemoryUsageDetails
        /// * <c>xslStyleSheets</c> MemoryUsageDetails
        /// * <c>fonts</c> MemoryUsageDetails
        /// * <c>other</c> MemoryUsageDetails
        /// 
        /// Returns an object describing usage information of Blink's internal memory
        /// caches.
        /// 
        /// This will generate:
        /// </summary>
        abstract getResourceUsage: unit -> ResourceUsage
        /// The current zoom factor.
        abstract getZoomFactor: unit -> float
        /// The current zoom level.
        abstract getZoomLevel: unit -> float
        /// <summary>
        /// A key for the inserted CSS that can later be used to remove the CSS via
        /// <c>webFrame.removeInsertedCSS(key)</c>.
        /// 
        /// Injects CSS into the current web page and returns a unique key for the inserted
        /// stylesheet.
        /// </summary>
        abstract insertCSS: css: string -> string
        /// <summary>Inserts <c>text</c> to the focused element.</summary>
        abstract insertText: text: string -> unit
        /// <summary>
        /// Removes the inserted CSS from the current web page. The stylesheet is identified
        /// by its key, which is returned from <c>webFrame.insertCSS(css)</c>.
        /// </summary>
        abstract removeInsertedCSS: key: string -> unit
        /// <summary>
        /// Set the security origin, content security policy and name of the isolated world.
        /// Note: If the <c>csp</c> is specified, then the <c>securityOrigin</c> also has to be
        /// specified.
        /// </summary>
        abstract setIsolatedWorldInfo: worldId: float * info: Info -> unit
        /// <summary>
        /// Sets a provider for spell checking in input fields and text areas.
        /// 
        /// If you want to use this method you must disable the builtin spellchecker when
        /// you construct the window.
        /// 
        /// The <c>provider</c> must be an object that has a <c>spellCheck</c> method that accepts an
        /// array of individual words for spellchecking. The <c>spellCheck</c> function runs
        /// asynchronously and calls the <c>callback</c> function with an array of misspelt words
        /// when complete.
        /// 
        /// An example of using node-spellchecker as provider:
        /// </summary>
        abstract setSpellCheckProvider: language: string * provider: Provider -> unit
        /// Sets the maximum and minimum pinch-to-zoom level.
        /// 
        /// > **NOTE**: Visual zoom is disabled by default in Electron. To re-enable it,
        /// call:
        abstract setVisualZoomLevelLimits: minimumLevel: float * maximumLevel: float -> unit
        /// Changes the zoom factor to the specified factor. Zoom factor is zoom percent
        /// divided by 100, so 300% = 3.0.
        /// 
        /// The factor must be greater than 0.0.
        abstract setZoomFactor: factor: float -> unit
        /// Changes the zoom level to the specified level. The original size is 0 and each
        /// increment above or below represents zooming 20% larger or smaller to default
        /// limits of 300% and 50% of original size, respectively.
        abstract setZoomLevel: level: float -> unit
        /// <summary>
        /// A <c>WebFrame | null</c> representing the first child frame of <c>webFrame</c>, the
        /// property would be <c>null</c> if <c>webFrame</c> has no children or if first child is not
        /// in the current renderer process.
        /// </summary>
        abstract firstChild: WebFrame option
        /// <summary>
        /// A <c>WebFrame | null</c> representing next sibling frame, the property would be
        /// <c>null</c> if <c>webFrame</c> is the last frame in its parent or if the next sibling is
        /// not in the current renderer process.
        /// </summary>
        abstract nextSibling: WebFrame option
        /// <summary>
        /// A <c>WebFrame | null</c> representing the frame which opened <c>webFrame</c>, the property
        /// would be <c>null</c> if there's no opener or opener is not in the current renderer
        /// process.
        /// </summary>
        abstract opener: WebFrame option
        /// <summary>
        /// A <c>WebFrame | null</c> representing parent frame of <c>webFrame</c>, the property would
        /// be <c>null</c> if <c>webFrame</c> is top or parent is not in the current renderer process.
        /// </summary>
        abstract parent: WebFrame option
        /// <summary>
        /// An <c>Integer</c> representing the unique frame id in the current renderer process.
        /// Distinct WebFrame instances that refer to the same underlying frame will have
        /// the same <c>routingId</c>.
        /// </summary>
        abstract routingId: float
        /// <summary>
        /// A <c>WebFrame | null</c> representing top frame in frame hierarchy to which
        /// <c>webFrame</c> belongs, the property would be <c>null</c> if top frame is not in the
        /// current renderer process.
        /// </summary>
        abstract top: WebFrame option

    type [<AllowNullLiteral>] WebRequest =
        /// <summary>
        /// The <c>listener</c> will be called with <c>listener(details)</c> when a server initiated
        /// redirect is about to occur.
        /// </summary>
        abstract onBeforeRedirect: filter: Filter * listener: (OnBeforeRedirectListenerDetails -> unit) option -> unit
        /// <summary>
        /// The <c>listener</c> will be called with <c>listener(details)</c> when a server initiated
        /// redirect is about to occur.
        /// </summary>
        abstract onBeforeRedirect: listener: (OnBeforeRedirectListenerDetails -> unit) option -> unit
        /// <summary>
        /// The <c>listener</c> will be called with <c>listener(details, callback)</c> when a request
        /// is about to occur.
        /// 
        /// The <c>uploadData</c> is an array of <c>UploadData</c> objects.
        /// 
        /// The <c>callback</c> has to be called with an <c>response</c> object.
        /// 
        /// Some examples of valid <c>urls</c>:
        /// </summary>
        abstract onBeforeRequest: filter: Filter * listener: (OnBeforeRequestListenerDetails -> (Response -> unit) -> unit) option -> unit
        /// <summary>
        /// The <c>listener</c> will be called with <c>listener(details, callback)</c> when a request
        /// is about to occur.
        /// 
        /// The <c>uploadData</c> is an array of <c>UploadData</c> objects.
        /// 
        /// The <c>callback</c> has to be called with an <c>response</c> object.
        /// 
        /// Some examples of valid <c>urls</c>:
        /// </summary>
        abstract onBeforeRequest: listener: (OnBeforeRequestListenerDetails -> (Response -> unit) -> unit) option -> unit
        /// <summary>
        /// The <c>listener</c> will be called with <c>listener(details, callback)</c> before sending
        /// an HTTP request, once the request headers are available. This may occur after a
        /// TCP connection is made to the server, but before any http data is sent.
        /// 
        /// The <c>callback</c> has to be called with a <c>response</c> object.
        /// </summary>
        abstract onBeforeSendHeaders: filter: Filter * listener: (OnBeforeSendHeadersListenerDetails -> (BeforeSendResponse -> unit) -> unit) option -> unit
        /// <summary>
        /// The <c>listener</c> will be called with <c>listener(details, callback)</c> before sending
        /// an HTTP request, once the request headers are available. This may occur after a
        /// TCP connection is made to the server, but before any http data is sent.
        /// 
        /// The <c>callback</c> has to be called with a <c>response</c> object.
        /// </summary>
        abstract onBeforeSendHeaders: listener: (OnBeforeSendHeadersListenerDetails -> (BeforeSendResponse -> unit) -> unit) option -> unit
        /// <summary>
        /// The <c>listener</c> will be called with <c>listener(details)</c> when a request is
        /// completed.
        /// </summary>
        abstract onCompleted: filter: Filter * listener: (OnCompletedListenerDetails -> unit) option -> unit
        /// <summary>
        /// The <c>listener</c> will be called with <c>listener(details)</c> when a request is
        /// completed.
        /// </summary>
        abstract onCompleted: listener: (OnCompletedListenerDetails -> unit) option -> unit
        /// <summary>The <c>listener</c> will be called with <c>listener(details)</c> when an error occurs.</summary>
        abstract onErrorOccurred: filter: Filter * listener: (OnErrorOccurredListenerDetails -> unit) option -> unit
        /// <summary>The <c>listener</c> will be called with <c>listener(details)</c> when an error occurs.</summary>
        abstract onErrorOccurred: listener: (OnErrorOccurredListenerDetails -> unit) option -> unit
        /// <summary>
        /// The <c>listener</c> will be called with <c>listener(details, callback)</c> when HTTP
        /// response headers of a request have been received.
        /// 
        /// The <c>callback</c> has to be called with a <c>response</c> object.
        /// </summary>
        abstract onHeadersReceived: filter: Filter * listener: (OnHeadersReceivedListenerDetails -> (HeadersReceivedResponse -> unit) -> unit) option -> unit
        /// <summary>
        /// The <c>listener</c> will be called with <c>listener(details, callback)</c> when HTTP
        /// response headers of a request have been received.
        /// 
        /// The <c>callback</c> has to be called with a <c>response</c> object.
        /// </summary>
        abstract onHeadersReceived: listener: (OnHeadersReceivedListenerDetails -> (HeadersReceivedResponse -> unit) -> unit) option -> unit
        /// <summary>
        /// The <c>listener</c> will be called with <c>listener(details)</c> when first byte of the
        /// response body is received. For HTTP requests, this means that the status line
        /// and response headers are available.
        /// </summary>
        abstract onResponseStarted: filter: Filter * listener: (OnResponseStartedListenerDetails -> unit) option -> unit
        /// <summary>
        /// The <c>listener</c> will be called with <c>listener(details)</c> when first byte of the
        /// response body is received. For HTTP requests, this means that the status line
        /// and response headers are available.
        /// </summary>
        abstract onResponseStarted: listener: (OnResponseStartedListenerDetails -> unit) option -> unit
        /// <summary>
        /// The <c>listener</c> will be called with <c>listener(details)</c> just before a request is
        /// going to be sent to the server, modifications of previous <c>onBeforeSendHeaders</c>
        /// response are visible by the time this listener is fired.
        /// </summary>
        abstract onSendHeaders: filter: Filter * listener: (OnSendHeadersListenerDetails -> unit) option -> unit
        /// <summary>
        /// The <c>listener</c> will be called with <c>listener(details)</c> just before a request is
        /// going to be sent to the server, modifications of previous <c>onBeforeSendHeaders</c>
        /// response are visible by the time this listener is fired.
        /// </summary>
        abstract onSendHeaders: listener: (OnSendHeadersListenerDetails -> unit) option -> unit

    type [<AllowNullLiteral>] WebRequestStatic =
        [<EmitConstructor>] abstract Create: unit -> WebRequest

    type [<AllowNullLiteral>] WebSource =
        abstract code: string with get, set
        /// Default is 1.
        abstract startLine: float option with get, set
        abstract url: string option with get, set

    type [<AllowNullLiteral>] WebviewTag =
        inherit HTMLElement
        /// Fired when a load has committed. This includes navigation within the current
        /// document as well as subframe document-level loads, but does not include
        /// asynchronous resource loads.
        [<Emit "$0.addEventListener('load-commit',$1,$2)">] abstract ``addEventListener_load-commit``: listener: (LoadCommitEvent -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('load-commit',$1)">] abstract ``removeEventListener_load-commit``: listener: (LoadCommitEvent -> unit) -> WebviewTag
        /// <summary>
        /// Fired when the navigation is done, i.e. the spinner of the tab will stop
        /// spinning, and the <c>onload</c> event is dispatched.
        /// </summary>
        [<Emit "$0.addEventListener('did-finish-load',$1,$2)">] abstract ``addEventListener_did-finish-load``: listener: (Event -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('did-finish-load',$1)">] abstract ``removeEventListener_did-finish-load``: listener: (Event -> unit) -> WebviewTag
        /// <summary>
        /// This event is like <c>did-finish-load</c>, but fired when the load failed or was
        /// cancelled, e.g. <c>window.stop()</c> is invoked.
        /// </summary>
        [<Emit "$0.addEventListener('did-fail-load',$1,$2)">] abstract ``addEventListener_did-fail-load``: listener: (DidFailLoadEvent -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('did-fail-load',$1)">] abstract ``removeEventListener_did-fail-load``: listener: (DidFailLoadEvent -> unit) -> WebviewTag
        /// Fired when a frame has done navigation.
        [<Emit "$0.addEventListener('did-frame-finish-load',$1,$2)">] abstract ``addEventListener_did-frame-finish-load``: listener: (DidFrameFinishLoadEvent -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('did-frame-finish-load',$1)">] abstract ``removeEventListener_did-frame-finish-load``: listener: (DidFrameFinishLoadEvent -> unit) -> WebviewTag
        /// Corresponds to the points in time when the spinner of the tab starts spinning.
        [<Emit "$0.addEventListener('did-start-loading',$1,$2)">] abstract ``addEventListener_did-start-loading``: listener: (Event -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('did-start-loading',$1)">] abstract ``removeEventListener_did-start-loading``: listener: (Event -> unit) -> WebviewTag
        /// Corresponds to the points in time when the spinner of the tab stops spinning.
        [<Emit "$0.addEventListener('did-stop-loading',$1,$2)">] abstract ``addEventListener_did-stop-loading``: listener: (Event -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('did-stop-loading',$1)">] abstract ``removeEventListener_did-stop-loading``: listener: (Event -> unit) -> WebviewTag
        /// Fired when document in the given frame is loaded.
        [<Emit "$0.addEventListener('dom-ready',$1,$2)">] abstract ``addEventListener_dom-ready``: listener: (Event -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('dom-ready',$1)">] abstract ``removeEventListener_dom-ready``: listener: (Event -> unit) -> WebviewTag
        /// <summary>
        /// Fired when page title is set during navigation. <c>explicitSet</c> is false when
        /// title is synthesized from file url.
        /// </summary>
        [<Emit "$0.addEventListener('page-title-updated',$1,$2)">] abstract ``addEventListener_page-title-updated``: listener: (PageTitleUpdatedEvent -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('page-title-updated',$1)">] abstract ``removeEventListener_page-title-updated``: listener: (PageTitleUpdatedEvent -> unit) -> WebviewTag
        /// Fired when page receives favicon urls.
        [<Emit "$0.addEventListener('page-favicon-updated',$1,$2)">] abstract ``addEventListener_page-favicon-updated``: listener: (PageFaviconUpdatedEvent -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('page-favicon-updated',$1)">] abstract ``removeEventListener_page-favicon-updated``: listener: (PageFaviconUpdatedEvent -> unit) -> WebviewTag
        /// Fired when page enters fullscreen triggered by HTML API.
        [<Emit "$0.addEventListener('enter-html-full-screen',$1,$2)">] abstract ``addEventListener_enter-html-full-screen``: listener: (Event -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('enter-html-full-screen',$1)">] abstract ``removeEventListener_enter-html-full-screen``: listener: (Event -> unit) -> WebviewTag
        /// Fired when page leaves fullscreen triggered by HTML API.
        [<Emit "$0.addEventListener('leave-html-full-screen',$1,$2)">] abstract ``addEventListener_leave-html-full-screen``: listener: (Event -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('leave-html-full-screen',$1)">] abstract ``removeEventListener_leave-html-full-screen``: listener: (Event -> unit) -> WebviewTag
        /// Fired when the guest window logs a console message.
        /// 
        /// The following example code forwards all log messages to the embedder's console
        /// without regard for log level or other properties.
        [<Emit "$0.addEventListener('console-message',$1,$2)">] abstract ``addEventListener_console-message``: listener: (ConsoleMessageEvent -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('console-message',$1)">] abstract ``removeEventListener_console-message``: listener: (ConsoleMessageEvent -> unit) -> WebviewTag
        /// <summary>Fired when a result is available for <c>webview.findInPage</c> request.</summary>
        [<Emit "$0.addEventListener('found-in-page',$1,$2)">] abstract ``addEventListener_found-in-page``: listener: (FoundInPageEvent -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('found-in-page',$1)">] abstract ``removeEventListener_found-in-page``: listener: (FoundInPageEvent -> unit) -> WebviewTag
        /// Fired when the guest page attempts to open a new browser window.
        /// 
        /// The following example code opens the new url in system's default browser.
        [<Emit "$0.addEventListener('new-window',$1,$2)">] abstract ``addEventListener_new-window``: listener: (NewWindowEvent -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('new-window',$1)">] abstract ``removeEventListener_new-window``: listener: (NewWindowEvent -> unit) -> WebviewTag
        /// <summary>
        /// Emitted when a user or the page wants to start navigation. It can happen when
        /// the <c>window.location</c> object is changed or a user clicks a link in the page.
        /// 
        /// This event will not emit when the navigation is started programmatically with
        /// APIs like <c>&lt;webview&gt;.loadURL</c> and <c>&lt;webview&gt;.back</c>.
        /// 
        /// It is also not emitted during in-page navigation, such as clicking anchor links
        /// or updating the <c>window.location.hash</c>. Use <c>did-navigate-in-page</c> event for
        /// this purpose.
        /// 
        /// Calling <c>event.preventDefault()</c> does __NOT__ have any effect.
        /// </summary>
        [<Emit "$0.addEventListener('will-navigate',$1,$2)">] abstract ``addEventListener_will-navigate``: listener: (WillNavigateEvent -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('will-navigate',$1)">] abstract ``removeEventListener_will-navigate``: listener: (WillNavigateEvent -> unit) -> WebviewTag
        /// <summary>
        /// Emitted when a navigation is done.
        /// 
        /// This event is not emitted for in-page navigations, such as clicking anchor links
        /// or updating the <c>window.location.hash</c>. Use <c>did-navigate-in-page</c> event for
        /// this purpose.
        /// </summary>
        [<Emit "$0.addEventListener('did-navigate',$1,$2)">] abstract ``addEventListener_did-navigate``: listener: (DidNavigateEvent -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('did-navigate',$1)">] abstract ``removeEventListener_did-navigate``: listener: (DidNavigateEvent -> unit) -> WebviewTag
        /// <summary>
        /// Emitted when an in-page navigation happened.
        /// 
        /// When in-page navigation happens, the page URL changes but does not cause
        /// navigation outside of the page. Examples of this occurring are when anchor links
        /// are clicked or when the DOM <c>hashchange</c> event is triggered.
        /// </summary>
        [<Emit "$0.addEventListener('did-navigate-in-page',$1,$2)">] abstract ``addEventListener_did-navigate-in-page``: listener: (DidNavigateInPageEvent -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('did-navigate-in-page',$1)">] abstract ``removeEventListener_did-navigate-in-page``: listener: (DidNavigateInPageEvent -> unit) -> WebviewTag
        /// <summary>
        /// Fired when the guest page attempts to close itself.
        /// 
        /// The following example code navigates the <c>webview</c> to <c>about:blank</c> when the
        /// guest attempts to close itself.
        /// </summary>
        [<Emit "$0.addEventListener('close',$1,$2)">] abstract addEventListener_close: listener: (Event -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('close',$1)">] abstract removeEventListener_close: listener: (Event -> unit) -> WebviewTag
        /// <summary>
        /// Fired when the guest page has sent an asynchronous message to embedder page.
        /// 
        /// With <c>sendToHost</c> method and <c>ipc-message</c> event you can communicate between
        /// guest page and embedder page:
        /// </summary>
        [<Emit "$0.addEventListener('ipc-message',$1,$2)">] abstract ``addEventListener_ipc-message``: listener: (IpcMessageEvent -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('ipc-message',$1)">] abstract ``removeEventListener_ipc-message``: listener: (IpcMessageEvent -> unit) -> WebviewTag
        /// Fired when the renderer process is crashed.
        [<Emit "$0.addEventListener('crashed',$1,$2)">] abstract addEventListener_crashed: listener: (Event -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('crashed',$1)">] abstract removeEventListener_crashed: listener: (Event -> unit) -> WebviewTag
        /// Fired when a plugin process is crashed.
        [<Emit "$0.addEventListener('plugin-crashed',$1,$2)">] abstract ``addEventListener_plugin-crashed``: listener: (PluginCrashedEvent -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('plugin-crashed',$1)">] abstract ``removeEventListener_plugin-crashed``: listener: (PluginCrashedEvent -> unit) -> WebviewTag
        /// Fired when the WebContents is destroyed.
        [<Emit "$0.addEventListener('destroyed',$1,$2)">] abstract addEventListener_destroyed: listener: (Event -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('destroyed',$1)">] abstract removeEventListener_destroyed: listener: (Event -> unit) -> WebviewTag
        /// Emitted when media starts playing.
        [<Emit "$0.addEventListener('media-started-playing',$1,$2)">] abstract ``addEventListener_media-started-playing``: listener: (Event -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('media-started-playing',$1)">] abstract ``removeEventListener_media-started-playing``: listener: (Event -> unit) -> WebviewTag
        /// Emitted when media is paused or done playing.
        [<Emit "$0.addEventListener('media-paused',$1,$2)">] abstract ``addEventListener_media-paused``: listener: (Event -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('media-paused',$1)">] abstract ``removeEventListener_media-paused``: listener: (Event -> unit) -> WebviewTag
        /// Emitted when a page's theme color changes. This is usually due to encountering a
        /// meta tag:
        [<Emit "$0.addEventListener('did-change-theme-color',$1,$2)">] abstract ``addEventListener_did-change-theme-color``: listener: (DidChangeThemeColorEvent -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('did-change-theme-color',$1)">] abstract ``removeEventListener_did-change-theme-color``: listener: (DidChangeThemeColorEvent -> unit) -> WebviewTag
        /// Emitted when mouse moves over a link or the keyboard moves the focus to a link.
        [<Emit "$0.addEventListener('update-target-url',$1,$2)">] abstract ``addEventListener_update-target-url``: listener: (UpdateTargetUrlEvent -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('update-target-url',$1)">] abstract ``removeEventListener_update-target-url``: listener: (UpdateTargetUrlEvent -> unit) -> WebviewTag
        /// Emitted when DevTools is opened.
        [<Emit "$0.addEventListener('devtools-opened',$1,$2)">] abstract ``addEventListener_devtools-opened``: listener: (Event -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('devtools-opened',$1)">] abstract ``removeEventListener_devtools-opened``: listener: (Event -> unit) -> WebviewTag
        /// Emitted when DevTools is closed.
        [<Emit "$0.addEventListener('devtools-closed',$1,$2)">] abstract ``addEventListener_devtools-closed``: listener: (Event -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('devtools-closed',$1)">] abstract ``removeEventListener_devtools-closed``: listener: (Event -> unit) -> WebviewTag
        /// Emitted when DevTools is focused / opened.
        [<Emit "$0.addEventListener('devtools-focused',$1,$2)">] abstract ``addEventListener_devtools-focused``: listener: (Event -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('devtools-focused',$1)">] abstract ``removeEventListener_devtools-focused``: listener: (Event -> unit) -> WebviewTag
        abstract addEventListener: ``type``: KeyOf<HTMLElementEventMap> * listener: (HTMLElement -> HTMLElementEventMap -> obj option) * ?useCapture: bool -> unit
        abstract addEventListener: ``type``: string * listener: EventListenerOrEventListenerObject * ?useCapture: bool -> unit
        abstract removeEventListener: ``type``: KeyOf<HTMLElementEventMap> * listener: (HTMLElement -> HTMLElementEventMap -> obj option) * ?useCapture: bool -> unit
        abstract removeEventListener: ``type``: string * listener: EventListenerOrEventListenerObject * ?useCapture: bool -> unit
        /// Whether the guest page can go back.
        abstract canGoBack: unit -> bool
        /// Whether the guest page can go forward.
        abstract canGoForward: unit -> bool
        /// <summary>Whether the guest page can go to <c>offset</c>.</summary>
        abstract canGoToOffset: offset: float -> bool
        /// <summary>
        /// Resolves with a NativeImage
        /// 
        /// Captures a snapshot of the page within <c>rect</c>. Omitting <c>rect</c> will capture the
        /// whole visible page.
        /// </summary>
        abstract capturePage: ?rect: Rectangle -> Promise<Electron.NativeImage>
        /// Clears the navigation history.
        abstract clearHistory: unit -> unit
        /// Closes the DevTools window of guest page.
        abstract closeDevTools: unit -> unit
        /// <summary>Executes editing command <c>copy</c> in page.</summary>
        abstract copy: unit -> unit
        /// <summary>Executes editing command <c>cut</c> in page.</summary>
        abstract cut: unit -> unit
        /// <summary>Executes editing command <c>delete</c> in page.</summary>
        abstract delete: unit -> unit
        /// <summary>Initiates a download of the resource at <c>url</c> without navigating.</summary>
        abstract downloadURL: url: string -> unit
        /// <summary>
        /// A promise that resolves with the result of the executed code or is rejected if
        /// the result of the code is a rejected promise.
        /// 
        /// Evaluates <c>code</c> in page. If <c>userGesture</c> is set, it will create the user
        /// gesture context in the page. HTML APIs like <c>requestFullScreen</c>, which require
        /// user action, can take advantage of this option for automation.
        /// </summary>
        abstract executeJavaScript: code: string * ?userGesture: bool -> Promise<obj option>
        /// <summary>
        /// The request id used for the request.
        /// 
        /// Starts a request to find all matches for the <c>text</c> in the web page. The result
        /// of the request can be obtained by subscribing to <c>found-in-page</c> event.
        /// </summary>
        abstract findInPage: text: string * ?options: FindInPageOptions -> float
        /// The title of guest page.
        abstract getTitle: unit -> string
        /// The URL of guest page.
        abstract getURL: unit -> string
        /// The user agent for guest page.
        abstract getUserAgent: unit -> string
        /// <summary>The WebContents ID of this <c>webview</c>.</summary>
        abstract getWebContentsId: unit -> float
        /// the current zoom factor.
        abstract getZoomFactor: unit -> float
        /// the current zoom level.
        abstract getZoomLevel: unit -> float
        /// Makes the guest page go back.
        abstract goBack: unit -> unit
        /// Makes the guest page go forward.
        abstract goForward: unit -> unit
        /// Navigates to the specified absolute index.
        abstract goToIndex: index: float -> unit
        /// Navigates to the specified offset from the "current entry".
        abstract goToOffset: offset: float -> unit
        /// <summary>
        /// A promise that resolves with a key for the inserted CSS that can later be used
        /// to remove the CSS via <c>&lt;webview&gt;.removeInsertedCSS(key)</c>.
        /// 
        /// Injects CSS into the current web page and returns a unique key for the inserted
        /// stylesheet.
        /// </summary>
        abstract insertCSS: css: string -> Promise<string>
        /// <summary>Inserts <c>text</c> to the focused element.</summary>
        abstract insertText: text: string -> Promise<unit>
        /// <summary>Starts inspecting element at position (<c>x</c>, <c>y</c>) of guest page.</summary>
        abstract inspectElement: x: float * y: float -> unit
        /// Opens the DevTools for the service worker context present in the guest page.
        abstract inspectServiceWorker: unit -> unit
        /// Opens the DevTools for the shared worker context present in the guest page.
        abstract inspectSharedWorker: unit -> unit
        /// Whether guest page has been muted.
        abstract isAudioMuted: unit -> bool
        /// Whether the renderer process has crashed.
        abstract isCrashed: unit -> bool
        /// Whether audio is currently playing.
        abstract isCurrentlyAudible: unit -> bool
        /// Whether DevTools window of guest page is focused.
        abstract isDevToolsFocused: unit -> bool
        /// Whether guest page has a DevTools window attached.
        abstract isDevToolsOpened: unit -> bool
        /// Whether guest page is still loading resources.
        abstract isLoading: unit -> bool
        /// Whether the main frame (and not just iframes or frames within it) is still
        /// loading.
        abstract isLoadingMainFrame: unit -> bool
        /// Whether the guest page is waiting for a first-response for the main resource of
        /// the page.
        abstract isWaitingForResponse: unit -> bool
        /// <summary>
        /// The promise will resolve when the page has finished loading (see
        /// <c>did-finish-load</c>), and rejects if the page fails to load (see <c>did-fail-load</c>).
        /// 
        /// Loads the <c>url</c> in the webview, the <c>url</c> must contain the protocol prefix, e.g.
        /// the <c>http://</c> or <c>file://</c>.
        /// </summary>
        abstract loadURL: url: string * ?options: LoadURLOptions -> Promise<unit>
        /// Opens a DevTools window for guest page.
        abstract openDevTools: unit -> unit
        /// <summary>Executes editing command <c>paste</c> in page.</summary>
        abstract paste: unit -> unit
        /// <summary>Executes editing command <c>pasteAndMatchStyle</c> in page.</summary>
        abstract pasteAndMatchStyle: unit -> unit
        /// <summary>Prints <c>webview</c>'s web page. Same as <c>webContents.print([options])</c>.</summary>
        abstract print: ?options: WebviewTagPrintOptions -> Promise<unit>
        /// <summary>
        /// Resolves with the generated PDF data.
        /// 
        /// Prints <c>webview</c>'s web page as PDF, Same as <c>webContents.printToPDF(options)</c>.
        /// </summary>
        abstract printToPDF: options: PrintToPDFOptions -> Promise<Uint8Array>
        /// <summary>Executes editing command <c>redo</c> in page.</summary>
        abstract redo: unit -> unit
        /// Reloads the guest page.
        abstract reload: unit -> unit
        /// Reloads the guest page and ignores cache.
        abstract reloadIgnoringCache: unit -> unit
        /// <summary>
        /// Resolves if the removal was successful.
        /// 
        /// Removes the inserted CSS from the current web page. The stylesheet is identified
        /// by its key, which is returned from <c>&lt;webview&gt;.insertCSS(css)</c>.
        /// </summary>
        abstract removeInsertedCSS: key: string -> Promise<unit>
        /// <summary>Executes editing command <c>replace</c> in page.</summary>
        abstract replace: text: string -> unit
        /// <summary>Executes editing command <c>replaceMisspelling</c> in page.</summary>
        abstract replaceMisspelling: text: string -> unit
        /// <summary>Executes editing command <c>selectAll</c> in page.</summary>
        abstract selectAll: unit -> unit
        /// <summary>
        /// Send an asynchronous message to renderer process via <c>channel</c>, you can also
        /// send arbitrary arguments. The renderer process can handle the message by
        /// listening to the <c>channel</c> event with the <c>ipcRenderer</c> module.
        /// 
        /// See webContents.send for examples.
        /// </summary>
        abstract send: channel: string * [<ParamArray>] args: obj option[] -> Promise<unit>
        /// <summary>
        /// Sends an input <c>event</c> to the page.
        /// 
        /// See webContents.sendInputEvent for detailed description of <c>event</c> object.
        /// </summary>
        abstract sendInputEvent: ``event``: U3<MouseInputEvent, MouseWheelInputEvent, KeyboardInputEvent> -> Promise<unit>
        /// Set guest page muted.
        abstract setAudioMuted: muted: bool -> unit
        /// Overrides the user agent for the guest page.
        abstract setUserAgent: userAgent: string -> unit
        /// Sets the maximum and minimum pinch-to-zoom level.
        abstract setVisualZoomLevelLimits: minimumLevel: float * maximumLevel: float -> Promise<unit>
        /// Changes the zoom factor to the specified factor. Zoom factor is zoom percent
        /// divided by 100, so 300% = 3.0.
        abstract setZoomFactor: factor: float -> unit
        /// <summary>
        /// Changes the zoom level to the specified level. The original size is 0 and each
        /// increment above or below represents zooming 20% larger or smaller to default
        /// limits of 300% and 50% of original size, respectively. The formula for this is
        /// <c>scale := 1.2 ^ level</c>.
        /// </summary>
        abstract setZoomLevel: level: float -> unit
        /// <summary>Shows pop-up dictionary that searches the selected word on the page.</summary>
        abstract showDefinitionForSelection: unit -> unit
        /// Stops any pending navigation.
        abstract stop: unit -> unit
        /// <summary>Stops any <c>findInPage</c> request for the <c>webview</c> with the provided <c>action</c>.</summary>
        abstract stopFindInPage: action: WebviewTagStopFindInPageAction -> unit
        /// <summary>Executes editing command <c>undo</c> in page.</summary>
        abstract undo: unit -> unit
        /// <summary>Executes editing command <c>unselect</c> in page.</summary>
        abstract unselect: unit -> unit
        /// <summary>
        /// A <c>Boolean</c>. When this attribute is present the guest page will be allowed to
        /// open new windows. Popups are disabled by default.
        /// </summary>
        abstract allowpopups: bool with get, set
        /// <summary>
        /// A <c>String</c> which is a list of strings which specifies the blink features to be
        /// disabled separated by <c>,</c>. The full list of supported feature strings can be
        /// found in the RuntimeEnabledFeatures.json5 file.
        /// </summary>
        abstract disableblinkfeatures: string with get, set
        /// <summary>
        /// A <c>Boolean</c>. When this attribute is present the guest page will have web
        /// security disabled. Web security is enabled by default.
        /// </summary>
        abstract disablewebsecurity: bool with get, set
        /// <summary>
        /// A <c>String</c> which is a list of strings which specifies the blink features to be
        /// enabled separated by <c>,</c>. The full list of supported feature strings can be
        /// found in the RuntimeEnabledFeatures.json5 file.
        /// </summary>
        abstract enableblinkfeatures: string with get, set
        /// <summary>
        /// A <c>Boolean</c>. When this attribute is <c>false</c> the guest page in <c>webview</c> will not
        /// have access to the <c>remote</c> module. The remote module is available by default.
        /// </summary>
        abstract enableremotemodule: bool with get, set
        /// <summary>A <c>String</c> that sets the referrer URL for the guest page.</summary>
        abstract httpreferrer: string with get, set
        /// <summary>
        /// A <c>Boolean</c>. When this attribute is present the guest page in <c>webview</c> will
        /// have node integration and can use node APIs like <c>require</c> and <c>process</c> to
        /// access low level system resources. Node integration is disabled by default in
        /// the guest page.
        /// </summary>
        abstract nodeintegration: bool with get, set
        /// <summary>
        /// A <c>Boolean</c> for the experimental option for enabling NodeJS support in
        /// sub-frames such as iframes inside the <c>webview</c>. All your preloads will load for
        /// every iframe, you can use <c>process.isMainFrame</c> to determine if you are in the
        /// main frame or not. This option is disabled by default in the guest page.
        /// </summary>
        abstract nodeintegrationinsubframes: bool with get, set
        /// <summary>
        /// A <c>String</c> that sets the session used by the page. If <c>partition</c> starts with
        /// <c>persist:</c>, the page will use a persistent session available to all pages in the
        /// app with the same <c>partition</c>. if there is no <c>persist:</c> prefix, the page will
        /// use an in-memory session. By assigning the same <c>partition</c>, multiple pages can
        /// share the same session. If the <c>partition</c> is unset then default session of the
        /// app will be used.
        /// 
        /// This value can only be modified before the first navigation, since the session
        /// of an active renderer process cannot change. Subsequent attempts to modify the
        /// value will fail with a DOM exception.
        /// </summary>
        abstract partition: string with get, set
        /// <summary>
        /// A <c>Boolean</c>. When this attribute is present the guest page in <c>webview</c> will be
        /// able to use browser plugins. Plugins are disabled by default.
        /// </summary>
        abstract plugins: bool with get, set
        /// <summary>
        /// A <c>String</c> that specifies a script that will be loaded before other scripts run
        /// in the guest page. The protocol of script's URL must be either <c>file:</c> or
        /// <c>asar:</c>, because it will be loaded by <c>require</c> in guest page under the hood.
        /// 
        /// When the guest page doesn't have node integration this script will still have
        /// access to all Node APIs, but global objects injected by Node will be deleted
        /// after this script has finished executing.
        /// 
        /// **Note:** This option will appear as <c>preloadURL</c> (not <c>preload</c>) in the
        /// <c>webPreferences</c> specified to the <c>will-attach-webview</c> event.
        /// </summary>
        abstract preload: string with get, set
        /// <summary>
        /// A <c>String</c> representing the visible URL. Writing to this attribute initiates
        /// top-level navigation.
        /// 
        /// Assigning <c>src</c> its own value will reload the current page.
        /// 
        /// The <c>src</c> attribute can also accept data URLs, such as `data:text/plain,Hello,
        /// world!`.
        /// </summary>
        abstract src: string with get, set
        /// <summary>
        /// A <c>String</c> that sets the user agent for the guest page before the page is
        /// navigated to. Once the page is loaded, use the <c>setUserAgent</c> method to change
        /// the user agent.
        /// </summary>
        abstract useragent: string with get, set
        /// <summary>
        /// A <c>String</c> which is a comma separated list of strings which specifies the web
        /// preferences to be set on the webview. The full list of supported preference
        /// strings can be found in BrowserWindow.
        /// 
        /// The string follows the same format as the features string in <c>window.open</c>. A
        /// name by itself is given a <c>true</c> boolean value. A preference can be set to
        /// another value by including an <c>=</c>, followed by the value. Special values <c>yes</c>
        /// and <c>1</c> are interpreted as <c>true</c>, while <c>no</c> and <c>0</c> are interpreted as
        /// <c>false</c>.
        /// </summary>
        abstract webpreferences: string with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] WebviewTagStopFindInPageAction =
        | ClearSelection
        | KeepSelection
        | ActivateSelection

    type [<AllowNullLiteral>] AboutPanelOptionsOptions =
        /// The app's name.
        abstract applicationName: string option with get, set
        /// The app's version.
        abstract applicationVersion: string option with get, set
        /// Copyright information.
        abstract copyright: string option with get, set
        /// <summary>The app's build version number.</summary>
        abstract version: string option with get, set
        /// <summary>Credit information.</summary>
        abstract credits: string option with get, set
        /// <summary>List of app authors.</summary>
        abstract authors: ResizeArray<string> option with get, set
        /// <summary>The app's website.</summary>
        abstract website: string option with get, set
        /// <summary>
        /// Path to the app's icon. On Linux, will be shown as 64x64 pixels while retaining
        /// aspect ratio.
        /// </summary>
        abstract iconPath: string option with get, set

    type [<AllowNullLiteral>] AddRepresentationOptions =
        /// The scale factor to add the image representation for.
        abstract scaleFactor: float with get, set
        /// <summary>Defaults to 0. Required if a bitmap buffer is specified as <c>buffer</c>.</summary>
        abstract width: float option with get, set
        /// <summary>Defaults to 0. Required if a bitmap buffer is specified as <c>buffer</c>.</summary>
        abstract height: float option with get, set
        /// The buffer containing the raw image data.
        abstract buffer: Buffer option with get, set
        /// The data URL containing either a base 64 encoded PNG or JPEG image.
        abstract dataURL: string option with get, set

    type [<AllowNullLiteral>] AnimationSettings =
        /// Returns true if rich animations should be rendered. Looks at session type (e.g.
        /// remote desktop) and accessibility settings to give guidance for heavy
        /// animations.
        abstract shouldRenderRichAnimation: bool with get, set
        /// Determines on a per-platform basis whether scroll animations (e.g. produced by
        /// home/end key) should be enabled.
        abstract scrollAnimationsEnabledBySystem: bool with get, set
        /// Determines whether the user desires reduced motion based on platform APIs.
        abstract prefersReducedMotion: bool with get, set

    type [<AllowNullLiteral>] AppDetailsOptions =
        /// Window's App User Model ID. It has to be set, otherwise the other options will
        /// have no effect.
        abstract appId: string option with get, set
        /// Window's Relaunch Icon.
        abstract appIconPath: string option with get, set
        /// <summary>
        /// Index of the icon in <c>appIconPath</c>. Ignored when <c>appIconPath</c> is not set.
        /// Default is <c>0</c>.
        /// </summary>
        abstract appIconIndex: float option with get, set
        /// Window's Relaunch Command.
        abstract relaunchCommand: string option with get, set
        /// Window's Relaunch Display Name.
        abstract relaunchDisplayName: string option with get, set

    type [<AllowNullLiteral>] AuthenticationResponseDetails =
        abstract url: string with get, set

    type [<AllowNullLiteral>] AuthInfo =
        abstract isProxy: bool with get, set
        abstract scheme: string with get, set
        abstract host: string with get, set
        abstract port: float with get, set
        abstract realm: string with get, set

    type [<AllowNullLiteral>] AutoResizeOptions =
        /// <summary>
        /// If <c>true</c>, the view's width will grow and shrink together with the window.
        /// <c>false</c> by default.
        /// </summary>
        abstract width: bool option with get, set
        /// <summary>
        /// If <c>true</c>, the view's height will grow and shrink together with the window.
        /// <c>false</c> by default.
        /// </summary>
        abstract height: bool option with get, set
        /// <summary>
        /// If <c>true</c>, the view's x position and width will grow and shrink proportionally
        /// with the window. <c>false</c> by default.
        /// </summary>
        abstract horizontal: bool option with get, set
        /// <summary>
        /// If <c>true</c>, the view's y position and height will grow and shrink proportionally
        /// with the window. <c>false</c> by default.
        /// </summary>
        abstract vertical: bool option with get, set

    type [<AllowNullLiteral>] BeforeSendResponse =
        abstract cancel: bool option with get, set
        /// When provided, request will be made with these headers.
        abstract requestHeaders: Record<string, U2<string, ResizeArray<string>>> option with get, set

    type [<AllowNullLiteral>] BitmapOptions =
        /// Defaults to 1.0.
        abstract scaleFactor: float option with get, set

    type [<AllowNullLiteral>] BlinkMemoryInfo =
        /// Size of all allocated objects in Kilobytes.
        abstract allocated: float with get, set
        /// Size of all marked objects in Kilobytes.
        abstract marked: float with get, set
        /// Total allocated space in Kilobytes.
        abstract total: float with get, set

    type [<AllowNullLiteral>] BrowserViewConstructorOptions =
        /// See BrowserWindow.
        abstract webPreferences: WebPreferences option with get, set

    type [<AllowNullLiteral>] BrowserWindowConstructorOptions =
        /// <summary>Window's width in pixels. Default is <c>800</c>.</summary>
        abstract width: float option with get, set
        /// <summary>Window's height in pixels. Default is <c>600</c>.</summary>
        abstract height: float option with get, set
        /// (**required** if y is used) Window's left offset from screen. Default is to
        /// center the window.
        abstract x: float option with get, set
        /// (**required** if x is used) Window's top offset from screen. Default is to
        /// center the window.
        abstract y: float option with get, set
        /// <summary>
        /// The <c>width</c> and <c>height</c> would be used as web page's size, which means the
        /// actual window's size will include window frame's size and be slightly larger.
        /// Default is <c>false</c>.
        /// </summary>
        abstract useContentSize: bool option with get, set
        /// Show window in the center of the screen.
        abstract center: bool option with get, set
        /// <summary>Window's minimum width. Default is <c>0</c>.</summary>
        abstract minWidth: float option with get, set
        /// <summary>Window's minimum height. Default is <c>0</c>.</summary>
        abstract minHeight: float option with get, set
        /// Window's maximum width. Default is no limit.
        abstract maxWidth: float option with get, set
        /// Window's maximum height. Default is no limit.
        abstract maxHeight: float option with get, set
        /// <summary>Whether window is resizable. Default is <c>true</c>.</summary>
        abstract resizable: bool option with get, set
        /// <summary>Whether window is movable. This is not implemented on Linux. Default is <c>true</c>.</summary>
        abstract movable: bool option with get, set
        /// <summary>
        /// Whether window is minimizable. This is not implemented on Linux. Default is
        /// <c>true</c>.
        /// </summary>
        abstract minimizable: bool option with get, set
        /// <summary>
        /// Whether window is maximizable. This is not implemented on Linux. Default is
        /// <c>true</c>.
        /// </summary>
        abstract maximizable: bool option with get, set
        /// <summary>Whether window is closable. This is not implemented on Linux. Default is <c>true</c>.</summary>
        abstract closable: bool option with get, set
        /// <summary>
        /// Whether the window can be focused. Default is <c>true</c>. On Windows setting
        /// <c>focusable: false</c> also implies setting <c>skipTaskbar: true</c>. On Linux setting
        /// <c>focusable: false</c> makes the window stop interacting with wm, so the window will
        /// always stay on top in all workspaces.
        /// </summary>
        abstract focusable: bool option with get, set
        /// <summary>
        /// Whether the window should always stay on top of other windows. Default is
        /// <c>false</c>.
        /// </summary>
        abstract alwaysOnTop: bool option with get, set
        /// <summary>
        /// Whether the window should show in fullscreen. When explicitly set to <c>false</c> the
        /// fullscreen button will be hidden or disabled on macOS. Default is <c>false</c>.
        /// </summary>
        abstract fullscreen: bool option with get, set
        /// <summary>
        /// Whether the window can be put into fullscreen mode. On macOS, also whether the
        /// maximize/zoom button should toggle full screen mode or maximize window. Default
        /// is <c>true</c>.
        /// </summary>
        abstract fullscreenable: bool option with get, set
        /// <summary>Use pre-Lion fullscreen on macOS. Default is <c>false</c>.</summary>
        abstract simpleFullscreen: bool option with get, set
        /// <summary>Whether to show the window in taskbar. Default is <c>false</c>.</summary>
        abstract skipTaskbar: bool option with get, set
        /// <summary>Whether the window is in kiosk mode. Default is <c>false</c>.</summary>
        abstract kiosk: bool option with get, set
        /// <summary>
        /// Default window title. Default is <c>"Electron"</c>. If the HTML tag <c>&lt;title&gt;</c> is
        /// defined in the HTML file loaded by <c>loadURL()</c>, this property will be ignored.
        /// </summary>
        abstract title: string option with get, set
        /// <summary>
        /// The window icon. On Windows it is recommended to use <c>ICO</c> icons to get best
        /// visual effects, you can also leave it undefined so the executable's icon will be
        /// used.
        /// </summary>
        abstract icon: U2<NativeImage, string> option with get, set
        /// <summary>Whether window should be shown when created. Default is <c>true</c>.</summary>
        abstract show: bool option with get, set
        /// <summary>
        /// Whether the renderer should be active when <c>show</c> is <c>false</c> and it has just
        /// been created.  In order for <c>document.visibilityState</c> to work correctly on
        /// first load with <c>show: false</c> you should set this to <c>false</c>.  Setting this to
        /// <c>false</c> will cause the <c>ready-to-show</c> event to not fire.  Default is <c>true</c>.
        /// </summary>
        abstract paintWhenInitiallyHidden: bool option with get, set
        /// <summary>Specify <c>false</c> to create a Frameless Window. Default is <c>true</c>.</summary>
        abstract frame: bool option with get, set
        /// <summary>Specify parent window. Default is <c>null</c>.</summary>
        abstract parent: BrowserWindow option with get, set
        /// <summary>
        /// Whether this is a modal window. This only works when the window is a child
        /// window. Default is <c>false</c>.
        /// </summary>
        abstract modal: bool option with get, set
        /// <summary>
        /// Whether the web view accepts a single mouse-down event that simultaneously
        /// activates the window. Default is <c>false</c>.
        /// </summary>
        abstract acceptFirstMouse: bool option with get, set
        /// <summary>Whether to hide cursor when typing. Default is <c>false</c>.</summary>
        abstract disableAutoHideCursor: bool option with get, set
        /// <summary>Auto hide the menu bar unless the <c>Alt</c> key is pressed. Default is <c>false</c>.</summary>
        abstract autoHideMenuBar: bool option with get, set
        /// <summary>
        /// Enable the window to be resized larger than screen. Only relevant for macOS, as
        /// other OSes allow larger-than-screen windows by default. Default is <c>false</c>.
        /// </summary>
        abstract enableLargerThanScreen: bool option with get, set
        /// <summary>
        /// Window's background color as a hexadecimal value, like <c>#66CD00</c> or <c>#FFF</c> or
        /// <c>#80FFFFFF</c> (alpha in #AARRGGBB format is supported if <c>transparent</c> is set to
        /// <c>true</c>). Default is <c>#FFF</c> (white).
        /// </summary>
        abstract backgroundColor: string option with get, set
        /// <summary>Whether window should have a shadow. Default is <c>true</c>.</summary>
        abstract hasShadow: bool option with get, set
        /// Set the initial opacity of the window, between 0.0 (fully transparent) and 1.0
        /// (fully opaque). This is only implemented on Windows and macOS.
        abstract opacity: float option with get, set
        /// <summary>
        /// Forces using dark theme for the window, only works on some GTK desktop
        /// environments. Default is <c>false</c>.
        /// </summary>
        abstract darkTheme: bool option with get, set
        /// <summary>
        /// Makes the window transparent. Default is <c>false</c>. On Windows, does not work
        /// unless the window is frameless.
        /// </summary>
        abstract transparent: bool option with get, set
        /// The type of window, default is normal window. See more about this below.
        abstract ``type``: string option with get, set
        /// <summary>The style of window title bar. Default is <c>default</c>. Possible values are:</summary>
        abstract titleBarStyle: BrowserWindowConstructorOptionsTitleBarStyle option with get, set
        /// <summary>
        /// Set a custom position for the traffic light buttons. Can only be used with
        /// <c>titleBarStyle</c> set to <c>hidden</c>
        /// </summary>
        abstract trafficLightPosition: Point option with get, set
        /// <summary>
        /// Shows the title in the title bar in full screen mode on macOS for all
        /// <c>titleBarStyle</c> options. Default is <c>false</c>.
        /// </summary>
        abstract fullscreenWindowTitle: bool option with get, set
        /// <summary>
        /// Use <c>WS_THICKFRAME</c> style for frameless windows on Windows, which adds standard
        /// window frame. Setting it to <c>false</c> will remove window shadow and window
        /// animations. Default is <c>true</c>.
        /// </summary>
        abstract thickFrame: bool option with get, set
        /// <summary>
        /// Add a type of vibrancy effect to the window, only on macOS. Can be
        /// <c>appearance-based</c>, <c>light</c>, <c>dark</c>, <c>titlebar</c>, <c>selection</c>, <c>menu</c>, <c>popover</c>,
        /// <c>sidebar</c>, <c>medium-light</c>, <c>ultra-dark</c>, <c>header</c>, <c>sheet</c>, <c>window</c>, <c>hud</c>,
        /// <c>fullscreen-ui</c>, <c>tooltip</c>, <c>content</c>, <c>under-window</c>, or <c>under-page</c>.  Please
        /// note that using <c>frame: false</c> in combination with a vibrancy value requires
        /// that you use a non-default <c>titleBarStyle</c> as well. Also note that
        /// <c>appearance-based</c>, <c>light</c>, <c>dark</c>, <c>medium-light</c>, and <c>ultra-dark</c> have been
        /// deprecated and will be removed in an upcoming version of macOS.
        /// </summary>
        abstract vibrancy: BrowserWindowSetVibrancy option with get, set
        /// <summary>
        /// Controls the behavior on macOS when option-clicking the green stoplight button
        /// on the toolbar or by clicking the Window &gt; Zoom menu item. If <c>true</c>, the window
        /// will grow to the preferred width of the web page when zoomed, <c>false</c> will cause
        /// it to zoom to the width of the screen. This will also affect the behavior when
        /// calling <c>maximize()</c> directly. Default is <c>false</c>.
        /// </summary>
        abstract zoomToPageWidth: bool option with get, set
        /// <summary>
        /// Tab group name, allows opening the window as a native tab on macOS 10.12+.
        /// Windows with the same tabbing identifier will be grouped together. This also
        /// adds a native new tab button to your window's tab bar and allows your <c>app</c> and
        /// window to receive the <c>new-window-for-tab</c> event.
        /// </summary>
        abstract tabbingIdentifier: string option with get, set
        /// Settings of web page's features.
        abstract webPreferences: WebPreferences option with get, set

    type [<AllowNullLiteral>] CertificateTrustDialogOptions =
        /// The certificate to trust/import.
        abstract certificate: Certificate with get, set
        /// The message to display to the user.
        abstract message: string with get, set

    type [<AllowNullLiteral>] CertificateVerifyProcProcRequest =
        abstract hostname: string with get, set
        abstract certificate: Certificate with get, set
        abstract validatedCertificate: Certificate with get, set
        /// Verification result from chromium.
        abstract verificationResult: string with get, set
        /// Error code.
        abstract errorCode: float with get, set

    type [<AllowNullLiteral>] ClearStorageDataOptions =
        /// <summary>Should follow <c>window.location.origin</c>’s representation <c>scheme://host:port</c>.</summary>
        abstract origin: string option with get, set
        /// <summary>
        /// The types of storages to clear, can contain: <c>appcache</c>, <c>cookies</c>,
        /// <c>filesystem</c>, <c>indexdb</c>, <c>localstorage</c>, <c>shadercache</c>, <c>websql</c>,
        /// <c>serviceworkers</c>, <c>cachestorage</c>. If not specified, clear all storage types.
        /// </summary>
        abstract storages: ResizeArray<string> option with get, set
        /// <summary>
        /// The types of quotas to clear, can contain: <c>temporary</c>, <c>persistent</c>,
        /// <c>syncable</c>. If not specified, clear all quotas.
        /// </summary>
        abstract quotas: ResizeArray<string> option with get, set

    type [<AllowNullLiteral>] ClientRequestConstructorOptions =
        /// The HTTP request method. Defaults to the GET method.
        abstract method: string option with get, set
        /// The request URL. Must be provided in the absolute form with the protocol scheme
        /// specified as http or https.
        abstract url: string option with get, set
        /// <summary>The <c>Session</c> instance with which the request is associated.</summary>
        abstract session: Session option with get, set
        /// <summary>
        /// The name of the <c>partition</c> with which the request is associated. Defaults to
        /// the empty string. The <c>session</c> option prevails on <c>partition</c>. Thus if a
        /// <c>session</c> is explicitly specified, <c>partition</c> is ignored.
        /// </summary>
        abstract partition: string option with get, set
        /// <summary>
        /// Whether to send cookies with this request from the provided session.  This will
        /// make the <c>net</c> request's cookie behavior match a <c>fetch</c> request. Default is
        /// <c>false</c>.
        /// </summary>
        abstract useSessionCookies: bool option with get, set
        /// The protocol scheme in the form 'scheme:'. Currently supported values are
        /// 'http:' or 'https:'. Defaults to 'http:'.
        abstract protocol: string option with get, set
        /// The server host provided as a concatenation of the hostname and the port number
        /// 'hostname:port'.
        abstract host: string option with get, set
        /// The server host name.
        abstract hostname: string option with get, set
        /// The server's listening port number.
        abstract port: float option with get, set
        /// The path part of the request URL.
        abstract path: string option with get, set
        /// <summary>
        /// The redirect mode for this request. Should be one of <c>follow</c>, <c>error</c> or
        /// <c>manual</c>. Defaults to <c>follow</c>. When mode is <c>error</c>, any redirection will be
        /// aborted. When mode is <c>manual</c> the redirection will be cancelled unless
        /// <c>request.followRedirect</c> is invoked synchronously during the <c>redirect</c> event.
        /// </summary>
        abstract redirect: string option with get, set

    type [<AllowNullLiteral>] Config =
        /// The URL associated with the PAC file.
        abstract pacScript: string option with get, set
        /// Rules indicating which proxies to use.
        abstract proxyRules: string option with get, set
        /// Rules indicating which URLs should bypass the proxy settings.
        abstract proxyBypassRules: string option with get, set

    type [<AllowNullLiteral>] ConsoleMessageEvent =
        inherit Event
        abstract level: float with get, set
        abstract message: string with get, set
        abstract line: float with get, set
        abstract sourceId: string with get, set

    type [<AllowNullLiteral>] ContextMenuParams =
        /// x coordinate.
        abstract x: float with get, set
        /// y coordinate.
        abstract y: float with get, set
        /// URL of the link that encloses the node the context menu was invoked on.
        abstract linkURL: string with get, set
        /// Text associated with the link. May be an empty string if the contents of the
        /// link are an image.
        abstract linkText: string with get, set
        /// URL of the top level page that the context menu was invoked on.
        abstract pageURL: string with get, set
        /// URL of the subframe that the context menu was invoked on.
        abstract frameURL: string with get, set
        /// Source URL for the element that the context menu was invoked on. Elements with
        /// source URLs are images, audio and video.
        abstract srcURL: string with get, set
        /// <summary>
        /// Type of the node the context menu was invoked on. Can be <c>none</c>, <c>image</c>,
        /// <c>audio</c>, <c>video</c>, <c>canvas</c>, <c>file</c> or <c>plugin</c>.
        /// </summary>
        abstract mediaType: ContextMenuParamsMediaType with get, set
        /// Whether the context menu was invoked on an image which has non-empty contents.
        abstract hasImageContents: bool with get, set
        /// Whether the context is editable.
        abstract isEditable: bool with get, set
        /// Text of the selection that the context menu was invoked on.
        abstract selectionText: string with get, set
        /// Title or alt text of the selection that the context was invoked on.
        abstract titleText: string with get, set
        /// The misspelled word under the cursor, if any.
        abstract misspelledWord: string with get, set
        /// <summary>
        /// An array of suggested words to show the user to replace the <c>misspelledWord</c>.
        /// Only available if there is a misspelled word and spellchecker is enabled.
        /// </summary>
        abstract dictionarySuggestions: ResizeArray<string> with get, set
        /// The character encoding of the frame on which the menu was invoked.
        abstract frameCharset: string with get, set
        /// <summary>
        /// If the context menu was invoked on an input field, the type of that field.
        /// Possible values are <c>none</c>, <c>plainText</c>, <c>password</c>, <c>other</c>.
        /// </summary>
        abstract inputFieldType: string with get, set
        /// <summary>
        /// Input source that invoked the context menu. Can be <c>none</c>, <c>mouse</c>, <c>keyboard</c>,
        /// <c>touch</c> or <c>touchMenu</c>.
        /// </summary>
        abstract menuSourceType: ContextMenuParamsMenuSourceType with get, set
        /// The flags for the media element the context menu was invoked on.
        abstract mediaFlags: MediaFlags with get, set
        /// These flags indicate whether the renderer believes it is able to perform the
        /// corresponding action.
        abstract editFlags: EditFlags with get, set

    type [<AllowNullLiteral>] CookiesGetFilter =
        /// <summary>
        /// Retrieves cookies which are associated with <c>url</c>. Empty implies retrieving
        /// cookies of all URLs.
        /// </summary>
        abstract url: string option with get, set
        /// Filters cookies by name.
        abstract name: string option with get, set
        /// <summary>Retrieves cookies whose domains match or are subdomains of <c>domains</c>.</summary>
        abstract domain: string option with get, set
        /// <summary>Retrieves cookies whose path matches <c>path</c>.</summary>
        abstract path: string option with get, set
        /// Filters cookies by their Secure property.
        abstract secure: bool option with get, set
        /// Filters out session or persistent cookies.
        abstract session: bool option with get, set

    type [<AllowNullLiteral>] CookiesSetDetails =
        /// The URL to associate the cookie with. The promise will be rejected if the URL is
        /// invalid.
        abstract url: string with get, set
        /// The name of the cookie. Empty by default if omitted.
        abstract name: string option with get, set
        /// The value of the cookie. Empty by default if omitted.
        abstract value: string option with get, set
        /// The domain of the cookie; this will be normalized with a preceding dot so that
        /// it's also valid for subdomains. Empty by default if omitted.
        abstract domain: string option with get, set
        /// The path of the cookie. Empty by default if omitted.
        abstract path: string option with get, set
        /// Whether the cookie should be marked as Secure. Defaults to false.
        abstract secure: bool option with get, set
        /// Whether the cookie should be marked as HTTP only. Defaults to false.
        abstract httpOnly: bool option with get, set
        /// The expiration date of the cookie as the number of seconds since the UNIX epoch.
        /// If omitted then the cookie becomes a session cookie and will not be retained
        /// between sessions.
        abstract expirationDate: float option with get, set

    type [<AllowNullLiteral>] CrashReporterStartOptions =
        /// URL that crash reports will be sent to as POST.
        abstract submitURL: string with get, set
        /// <summary>Defaults to <c>app.name</c>.</summary>
        abstract productName: string option with get, set
        /// <summary>Deprecated alias for <c>{ globalExtra: { _companyName: ... } }</c>.</summary>
        [<Obsolete("")>]
        abstract companyName: string option with get, set
        /// <summary>
        /// Whether crash reports should be sent to the server. If false, crash reports will
        /// be collected and stored in the crashes directory, but not uploaded. Default is
        /// <c>true</c>.
        /// </summary>
        abstract uploadToServer: bool option with get, set
        /// <summary>
        /// If true, crashes generated in the main process will not be forwarded to the
        /// system crash handler. Default is <c>false</c>.
        /// </summary>
        abstract ignoreSystemCrashHandler: bool option with get, set
        /// <summary>If true, limit the number of crashes uploaded to 1/hour. Default is <c>false</c>.</summary>
        abstract rateLimit: bool option with get, set
        /// <summary>
        /// If true, crash reports will be compressed and uploaded with `Content-Encoding:
        /// gzip`. Not all collection servers support compressed payloads. Default is
        /// <c>false</c>.
        /// </summary>
        abstract compress: bool option with get, set
        /// <summary>
        /// Extra string key/value annotations that will be sent along with crash reports
        /// that are generated in the main process. Only string values are supported.
        /// Crashes generated in child processes will not contain these extra parameters to
        /// crash reports generated from child processes, call <c>addExtraParameter</c> from the
        /// child process.
        /// </summary>
        abstract extra: Record<string, string> option with get, set
        /// <summary>
        /// Extra string key/value annotations that will be sent along with any crash
        /// reports generated in any process. These annotations cannot be changed once the
        /// crash reporter has been started. If a key is present in both the global extra
        /// parameters and the process-specific extra parameters, then the global one will
        /// take precedence. By default, <c>productName</c> and the app version are included, as
        /// well as the Electron version.
        /// </summary>
        abstract globalExtra: Record<string, string> option with get, set

    type [<AllowNullLiteral>] CreateFromBitmapOptions =
        abstract width: float with get, set
        abstract height: float with get, set
        /// Defaults to 1.0.
        abstract scaleFactor: float option with get, set

    type [<AllowNullLiteral>] CreateFromBufferOptions =
        /// Required for bitmap buffers.
        abstract width: float option with get, set
        /// Required for bitmap buffers.
        abstract height: float option with get, set
        /// Defaults to 1.0.
        abstract scaleFactor: float option with get, set

    type [<AllowNullLiteral>] CreateInterruptedDownloadOptions =
        /// Absolute path of the download.
        abstract path: string with get, set
        /// Complete URL chain for the download.
        abstract urlChain: ResizeArray<string> with get, set
        abstract mimeType: string option with get, set
        /// Start range for the download.
        abstract offset: float with get, set
        /// Total length of the download.
        abstract length: float with get, set
        /// Last-Modified header value.
        abstract lastModified: string option with get, set
        /// ETag header value.
        abstract eTag: string option with get, set
        /// Time when download was started in number of seconds since UNIX epoch.
        abstract startTime: float option with get, set

    type [<AllowNullLiteral>] Data =
        abstract text: string option with get, set
        abstract html: string option with get, set
        abstract image: NativeImage option with get, set
        abstract rtf: string option with get, set
        /// <summary>The title of the URL at <c>text</c>.</summary>
        abstract bookmark: string option with get, set

    type [<AllowNullLiteral>] Details =
        /// The reason the render process is gone.  Possible values:
        abstract reason: DetailsReason with get, set

    type [<AllowNullLiteral>] DidChangeThemeColorEvent =
        inherit Event
        abstract themeColor: string with get, set

    type [<AllowNullLiteral>] DidFailLoadEvent =
        inherit Event
        abstract errorCode: float with get, set
        abstract errorDescription: string with get, set
        abstract validatedURL: string with get, set
        abstract isMainFrame: bool with get, set

    type [<AllowNullLiteral>] DidFrameFinishLoadEvent =
        inherit Event
        abstract isMainFrame: bool with get, set

    type [<AllowNullLiteral>] DidNavigateEvent =
        inherit Event
        abstract url: string with get, set

    type [<AllowNullLiteral>] DidNavigateInPageEvent =
        inherit Event
        abstract isMainFrame: bool with get, set
        abstract url: string with get, set

    type [<AllowNullLiteral>] DisplayBalloonOptions =
        /// <summary>Icon to use when <c>iconType</c> is <c>custom</c>.</summary>
        abstract icon: U2<NativeImage, string> option with get, set
        /// <summary>Can be <c>none</c>, <c>info</c>, <c>warning</c>, <c>error</c> or <c>custom</c>. Default is <c>custom</c>.</summary>
        abstract iconType: DisplayBalloonOptionsIconType option with get, set
        abstract title: string with get, set
        abstract content: string with get, set
        /// <summary>
        /// The large version of the icon should be used. Default is <c>true</c>. Maps to
        /// <c>NIIF_LARGE_ICON</c>.
        /// </summary>
        abstract largeIcon: bool option with get, set
        /// <summary>Do not play the associated sound. Default is <c>false</c>. Maps to <c>NIIF_NOSOUND</c>.</summary>
        abstract noSound: bool option with get, set
        /// <summary>
        /// Do not display the balloon notification if the current user is in "quiet time".
        /// Default is <c>false</c>. Maps to <c>NIIF_RESPECT_QUIET_TIME</c>.
        /// </summary>
        abstract respectQuietTime: bool option with get, set

    type [<AllowNullLiteral>] EnableNetworkEmulationOptions =
        /// Whether to emulate network outage. Defaults to false.
        abstract offline: bool option with get, set
        /// RTT in ms. Defaults to 0 which will disable latency throttling.
        abstract latency: float option with get, set
        /// Download rate in Bps. Defaults to 0 which will disable download throttling.
        abstract downloadThroughput: float option with get, set
        /// Upload rate in Bps. Defaults to 0 which will disable upload throttling.
        abstract uploadThroughput: float option with get, set

    type [<AllowNullLiteral>] FeedURLOptions =
        abstract url: string with get, set
        /// <summary>HTTP request headers.</summary>
        abstract headers: Record<string, string> option with get, set
        /// <summary>Either <c>json</c> or <c>default</c>, see the Squirrel.Mac README for more information.</summary>
        abstract serverType: string option with get, set

    type [<AllowNullLiteral>] FileIconOptions =
        abstract size: FileIconOptionsSize with get, set

    type [<AllowNullLiteral>] Filter =
        /// Array of URL patterns that will be used to filter out the requests that do not
        /// match the URL patterns.
        abstract urls: ResizeArray<string> with get, set

    type [<AllowNullLiteral>] FindInPageOptions =
        /// <summary>Whether to search forward or backward, defaults to <c>true</c>.</summary>
        abstract forward: bool option with get, set
        /// <summary>Whether the operation is first request or a follow up, defaults to <c>false</c>.</summary>
        abstract findNext: bool option with get, set
        /// <summary>Whether search should be case-sensitive, defaults to <c>false</c>.</summary>
        abstract matchCase: bool option with get, set
        /// <summary>Whether to look only at the start of words. defaults to <c>false</c>.</summary>
        abstract wordStart: bool option with get, set
        /// <summary>
        /// When combined with <c>wordStart</c>, accepts a match in the middle of a word if the
        /// match begins with an uppercase letter followed by a lowercase or non-letter.
        /// Accepts several other intra-word matches, defaults to <c>false</c>.
        /// </summary>
        abstract medialCapitalAsWordStart: bool option with get, set

    type [<AllowNullLiteral>] FocusOptions =
        /// <summary>Make the receiver the active app even if another app is currently active.</summary>
        abstract steal: bool with get, set

    type [<AllowNullLiteral>] FoundInPageEvent =
        inherit Event
        abstract result: FoundInPageResult with get, set

    type [<AllowNullLiteral>] FromPartitionOptions =
        /// Whether to enable cache.
        abstract cache: bool with get, set

    type [<AllowNullLiteral>] HeadersReceivedResponse =
        abstract cancel: bool option with get, set
        /// When provided, the server is assumed to have responded with these headers.
        abstract responseHeaders: Record<string, U2<string, ResizeArray<string>>> option with get, set
        /// <summary>
        /// Should be provided when overriding <c>responseHeaders</c> to change header status
        /// otherwise original response header's status will be used.
        /// </summary>
        abstract statusLine: string option with get, set

    type [<AllowNullLiteral>] HeapStatistics =
        abstract totalHeapSize: float with get, set
        abstract totalHeapSizeExecutable: float with get, set
        abstract totalPhysicalSize: float with get, set
        abstract totalAvailableSize: float with get, set
        abstract usedHeapSize: float with get, set
        abstract heapSizeLimit: float with get, set
        abstract mallocedMemory: float with get, set
        abstract peakMallocedMemory: float with get, set
        abstract doesZapGarbage: bool with get, set

    type [<AllowNullLiteral>] IgnoreMouseEventsOptions =
        /// <summary>
        /// If true, forwards mouse move messages to Chromium, enabling mouse related events
        /// such as <c>mouseleave</c>. Only used when <c>ignore</c> is true. If <c>ignore</c> is false,
        /// forwarding is always disabled regardless of this value.
        /// </summary>
        abstract forward: bool option with get, set

    type [<AllowNullLiteral>] ImportCertificateOptions =
        /// Path for the pkcs12 file.
        abstract certificate: string with get, set
        /// Passphrase for the certificate.
        abstract password: string with get, set

    type [<AllowNullLiteral>] Info =
        /// Security origin for the isolated world.
        abstract securityOrigin: string option with get, set
        /// Content Security Policy for the isolated world.
        abstract csp: string option with get, set
        /// Name for isolated world. Useful in devtools.
        abstract name: string option with get, set

    type [<AllowNullLiteral>] Input =
        /// <summary>Either <c>keyUp</c> or <c>keyDown</c>.</summary>
        abstract ``type``: string with get, set
        /// Equivalent to KeyboardEvent.key.
        abstract key: string with get, set
        /// Equivalent to KeyboardEvent.code.
        abstract code: string with get, set
        /// Equivalent to KeyboardEvent.repeat.
        abstract isAutoRepeat: bool with get, set
        /// Equivalent to KeyboardEvent.isComposing.
        abstract isComposing: bool with get, set
        /// Equivalent to KeyboardEvent.shiftKey.
        abstract shift: bool with get, set
        /// Equivalent to KeyboardEvent.controlKey.
        abstract control: bool with get, set
        /// Equivalent to KeyboardEvent.altKey.
        abstract alt: bool with get, set
        /// Equivalent to KeyboardEvent.metaKey.
        abstract meta: bool with get, set

    type [<AllowNullLiteral>] InsertCSSOptions =
        /// Can be either 'user' or 'author'; Specifying 'user' enables you to prevent
        /// websites from overriding the CSS you insert. Default is 'author'.
        abstract cssOrigin: string option with get, set

    type [<AllowNullLiteral>] IpcMessageEvent =
        inherit Event
        abstract channel: string with get, set
        abstract args: ResizeArray<obj option> with get, set

    type [<AllowNullLiteral>] Item =
        /// The path(s) to the file(s) being dragged.
        abstract file: U2<ResizeArray<string>, string> with get, set
        /// The image must be non-empty on macOS.
        abstract icon: U2<NativeImage, string> with get, set

    type [<AllowNullLiteral>] JumpListSettings =
        /// The minimum number of items that will be shown in the Jump List (for a more
        /// detailed description of this value see the MSDN docs).
        abstract minItems: float with get, set
        /// <summary>
        /// Array of <c>JumpListItem</c> objects that correspond to items that the user has
        /// explicitly removed from custom categories in the Jump List. These items must not
        /// be re-added to the Jump List in the **next** call to <c>app.setJumpList()</c>,
        /// Windows will not display any custom category that contains any of the removed
        /// items.
        /// </summary>
        abstract removedItems: ResizeArray<JumpListItem> with get, set

    type [<AllowNullLiteral>] LoadCommitEvent =
        inherit Event
        abstract url: string with get, set
        abstract isMainFrame: bool with get, set

    type [<AllowNullLiteral>] LoadFileOptions =
        /// <summary>Passed to <c>url.format()</c>.</summary>
        abstract query: Record<string, string> option with get, set
        /// <summary>Passed to <c>url.format()</c>.</summary>
        abstract search: string option with get, set
        /// <summary>Passed to <c>url.format()</c>.</summary>
        abstract hash: string option with get, set

    type [<AllowNullLiteral>] LoadURLOptions =
        /// An HTTP Referrer url.
        abstract httpReferrer: U2<string, Referrer> option with get, set
        /// A user agent originating the request.
        abstract userAgent: string option with get, set
        /// Extra headers separated by "\n"
        abstract extraHeaders: string option with get, set
        abstract postData: U3<ResizeArray<UploadRawData>, ResizeArray<UploadFile>, ResizeArray<UploadBlob>> option with get, set
        /// <summary>
        /// Base url (with trailing path separator) for files to be loaded by the data url.
        /// This is needed only if the specified <c>url</c> is a data url and needs to load other
        /// files.
        /// </summary>
        abstract baseURLForDataURL: string option with get, set

    type [<AllowNullLiteral>] LoginItemSettings =
        /// <summary><c>true</c> if the app is set to open at login.</summary>
        abstract openAtLogin: bool with get, set
        /// <summary>
        /// <c>true</c> if the app is set to open as hidden at login. This setting is not
        /// available on MAS builds.
        /// </summary>
        abstract openAsHidden: bool with get, set
        /// <summary>
        /// <c>true</c> if the app was opened at login automatically. This setting is not
        /// available on MAS builds.
        /// </summary>
        abstract wasOpenedAtLogin: bool with get, set
        /// <summary>
        /// <c>true</c> if the app was opened as a hidden login item. This indicates that the app
        /// should not open any windows at startup. This setting is not available on MAS
        /// builds.
        /// </summary>
        abstract wasOpenedAsHidden: bool with get, set
        /// <summary>
        /// <c>true</c> if the app was opened as a login item that should restore the state from
        /// the previous session. This indicates that the app should restore the windows
        /// that were open the last time the app was closed. This setting is not available
        /// on MAS builds.
        /// </summary>
        abstract restoreState: bool with get, set

    type [<AllowNullLiteral>] LoginItemSettingsOptions =
        /// <summary>The executable path to compare against. Defaults to <c>process.execPath</c>.</summary>
        abstract path: string option with get, set
        /// <summary>The command-line arguments to compare against. Defaults to an empty array.</summary>
        abstract args: ResizeArray<string> option with get, set

    type [<AllowNullLiteral>] MenuItemConstructorOptions =
        /// <summary>
        /// Will be called with <c>click(menuItem, browserWindow, event)</c> when the menu item
        /// is clicked.
        /// </summary>
        abstract click: (MenuItem -> BrowserWindow option -> KeyboardEvent -> unit) option with get, set
        /// <summary>
        /// Can be <c>undo</c>, <c>redo</c>, <c>cut</c>, <c>copy</c>, <c>paste</c>, <c>pasteAndMatchStyle</c>, <c>delete</c>,
        /// <c>selectAll</c>, <c>reload</c>, <c>forceReload</c>, <c>toggleDevTools</c>, <c>resetZoom</c>, <c>zoomIn</c>,
        /// <c>zoomOut</c>, <c>togglefullscreen</c>, <c>window</c>, <c>minimize</c>, <c>close</c>, <c>help</c>, <c>about</c>,
        /// <c>services</c>, <c>hide</c>, <c>hideOthers</c>, <c>unhide</c>, <c>quit</c>, <c>startSpeaking</c>,
        /// <c>stopSpeaking</c>, <c>zoom</c>, <c>front</c>, <c>appMenu</c>, <c>fileMenu</c>, <c>editMenu</c>, <c>viewMenu</c>,
        /// <c>recentDocuments</c>, <c>toggleTabBar</c>, <c>selectNextTab</c>, <c>selectPreviousTab</c>,
        /// <c>mergeAllWindows</c>, <c>clearRecentDocuments</c>, <c>moveTabToNewWindow</c> or <c>windowMenu</c>
        /// - Define the action of the menu item, when specified the <c>click</c> property will
        /// be ignored. See roles.
        /// </summary>
        abstract role: MenuItemRole option with get, set
        /// <summary>Can be <c>normal</c>, <c>separator</c>, <c>submenu</c>, <c>checkbox</c> or <c>radio</c>.</summary>
        abstract ``type``: MenuItemType option with get, set
        abstract label: string option with get, set
        abstract sublabel: string option with get, set
        /// <summary>Hover text for this menu item.</summary>
        abstract toolTip: string option with get, set
        abstract accelerator: Accelerator option with get, set
        abstract icon: U2<NativeImage, string> option with get, set
        /// If false, the menu item will be greyed out and unclickable.
        abstract enabled: bool option with get, set
        /// <summary>
        /// default is <c>true</c>, and when <c>false</c> will prevent the accelerator from triggering
        /// the item if the item is not visible`.
        /// </summary>
        abstract acceleratorWorksWhenHidden: bool option with get, set
        /// If false, the menu item will be entirely hidden.
        abstract visible: bool option with get, set
        /// <summary>Should only be specified for <c>checkbox</c> or <c>radio</c> type menu items.</summary>
        abstract ``checked``: bool option with get, set
        /// <summary>
        /// If false, the accelerator won't be registered with the system, but it will still
        /// be displayed. Defaults to true.
        /// </summary>
        abstract registerAccelerator: bool option with get, set
        /// <summary>
        /// Should be specified for <c>submenu</c> type menu items. If <c>submenu</c> is specified,
        /// the <c>type: 'submenu'</c> can be omitted. If the value is not a <c>Menu</c> then it will
        /// be automatically converted to one using <c>Menu.buildFromTemplate</c>.
        /// </summary>
        abstract submenu: U2<ResizeArray<MenuItemConstructorOptions>, Menu> option with get, set
        /// Unique within a single menu. If defined then it can be used as a reference to
        /// this item by the position attribute.
        abstract id: string option with get, set
        /// Inserts this item before the item with the specified label. If the referenced
        /// item doesn't exist the item will be inserted at the end of  the menu. Also
        /// implies that the menu item in question should be placed in the same “group” as
        /// the item.
        abstract before: ResizeArray<string> option with get, set
        /// Inserts this item after the item with the specified label. If the referenced
        /// item doesn't exist the item will be inserted at the end of the menu.
        abstract after: ResizeArray<string> option with get, set
        /// Provides a means for a single context menu to declare the placement of their
        /// containing group before the containing group of the item with the specified
        /// label.
        abstract beforeGroupContaining: ResizeArray<string> option with get, set
        /// Provides a means for a single context menu to declare the placement of their
        /// containing group after the containing group of the item with the specified
        /// label.
        abstract afterGroupContaining: ResizeArray<string> option with get, set

    type [<AllowNullLiteral>] MessageBoxOptions =
        /// <summary>
        /// Can be <c>"none"</c>, <c>"info"</c>, <c>"error"</c>, <c>"question"</c> or <c>"warning"</c>. On Windows,
        /// <c>"question"</c> displays the same icon as <c>"info"</c>, unless you set an icon using
        /// the <c>"icon"</c> option. On macOS, both <c>"warning"</c> and <c>"error"</c> display the same
        /// warning icon.
        /// </summary>
        abstract ``type``: string option with get, set
        /// Array of texts for buttons. On Windows, an empty array will result in one button
        /// labeled "OK".
        abstract buttons: ResizeArray<string> option with get, set
        /// Index of the button in the buttons array which will be selected by default when
        /// the message box opens.
        abstract defaultId: float option with get, set
        /// Title of the message box, some platforms will not show it.
        abstract title: string option with get, set
        /// Content of the message box.
        abstract message: string with get, set
        /// Extra information of the message.
        abstract detail: string option with get, set
        /// If provided, the message box will include a checkbox with the given label.
        abstract checkboxLabel: string option with get, set
        /// <summary>Initial checked state of the checkbox. <c>false</c> by default.</summary>
        abstract checkboxChecked: bool option with get, set
        abstract icon: NativeImage option with get, set
        /// <summary>
        /// The index of the button to be used to cancel the dialog, via the <c>Esc</c> key. By
        /// default this is assigned to the first button with "cancel" or "no" as the label.
        /// If no such labeled buttons exist and this option is not set, <c>0</c> will be used as
        /// the return value.
        /// </summary>
        abstract cancelId: float option with get, set
        /// <summary>
        /// On Windows Electron will try to figure out which one of the <c>buttons</c> are common
        /// buttons (like "Cancel" or "Yes"), and show the others as command links in the
        /// dialog. This can make the dialog appear in the style of modern Windows apps. If
        /// you don't like this behavior, you can set <c>noLink</c> to <c>true</c>.
        /// </summary>
        abstract noLink: bool option with get, set
        /// <summary>
        /// Normalize the keyboard access keys across platforms. Default is <c>false</c>.
        /// Enabling this assumes <c>&amp;</c> is used in the button labels for the placement of the
        /// keyboard shortcut access key and labels will be converted so they work correctly
        /// on each platform, <c>&amp;</c> characters are removed on macOS, converted to <c>_</c> on
        /// Linux, and left untouched on Windows. For example, a button label of <c>Vie&amp;w</c>
        /// will be converted to <c>Vie_w</c> on Linux and <c>View</c> on macOS and can be selected
        /// via <c>Alt-W</c> on Windows and Linux.
        /// </summary>
        abstract normalizeAccessKeys: bool option with get, set

    type [<AllowNullLiteral>] MessageBoxReturnValue =
        /// The index of the clicked button.
        abstract response: float with get, set
        /// <summary>The checked state of the checkbox if <c>checkboxLabel</c> was set. Otherwise <c>false</c>.</summary>
        abstract checkboxChecked: bool with get, set

    type [<AllowNullLiteral>] MessageBoxSyncOptions =
        /// <summary>
        /// Can be <c>"none"</c>, <c>"info"</c>, <c>"error"</c>, <c>"question"</c> or <c>"warning"</c>. On Windows,
        /// <c>"question"</c> displays the same icon as <c>"info"</c>, unless you set an icon using
        /// the <c>"icon"</c> option. On macOS, both <c>"warning"</c> and <c>"error"</c> display the same
        /// warning icon.
        /// </summary>
        abstract ``type``: string option with get, set
        /// Array of texts for buttons. On Windows, an empty array will result in one button
        /// labeled "OK".
        abstract buttons: ResizeArray<string> option with get, set
        /// Index of the button in the buttons array which will be selected by default when
        /// the message box opens.
        abstract defaultId: float option with get, set
        /// Title of the message box, some platforms will not show it.
        abstract title: string option with get, set
        /// Content of the message box.
        abstract message: string with get, set
        /// Extra information of the message.
        abstract detail: string option with get, set
        /// If provided, the message box will include a checkbox with the given label.
        abstract checkboxLabel: string option with get, set
        /// <summary>Initial checked state of the checkbox. <c>false</c> by default.</summary>
        abstract checkboxChecked: bool option with get, set
        abstract icon: U2<NativeImage, string> option with get, set
        /// <summary>
        /// The index of the button to be used to cancel the dialog, via the <c>Esc</c> key. By
        /// default this is assigned to the first button with "cancel" or "no" as the label.
        /// If no such labeled buttons exist and this option is not set, <c>0</c> will be used as
        /// the return value.
        /// </summary>
        abstract cancelId: float option with get, set
        /// <summary>
        /// On Windows Electron will try to figure out which one of the <c>buttons</c> are common
        /// buttons (like "Cancel" or "Yes"), and show the others as command links in the
        /// dialog. This can make the dialog appear in the style of modern Windows apps. If
        /// you don't like this behavior, you can set <c>noLink</c> to <c>true</c>.
        /// </summary>
        abstract noLink: bool option with get, set
        /// <summary>
        /// Normalize the keyboard access keys across platforms. Default is <c>false</c>.
        /// Enabling this assumes <c>&amp;</c> is used in the button labels for the placement of the
        /// keyboard shortcut access key and labels will be converted so they work correctly
        /// on each platform, <c>&amp;</c> characters are removed on macOS, converted to <c>_</c> on
        /// Linux, and left untouched on Windows. For example, a button label of <c>Vie&amp;w</c>
        /// will be converted to <c>Vie_w</c> on Linux and <c>View</c> on macOS and can be selected
        /// via <c>Alt-W</c> on Windows and Linux.
        /// </summary>
        abstract normalizeAccessKeys: bool option with get, set

    type [<AllowNullLiteral>] MessageDetails =
        /// The actual console message
        abstract message: string with get, set
        /// The version ID of the service worker that sent the log message
        abstract versionId: float with get, set
        /// <summary>
        /// The type of source for this message.  Can be <c>javascript</c>, <c>xml</c>, <c>network</c>,
        /// <c>console-api</c>, <c>storage</c>, <c>app-cache</c>, <c>rendering</c>, <c>security</c>, <c>deprecation</c>,
        /// <c>worker</c>, <c>violation</c>, <c>intervention</c>, <c>recommendation</c> or <c>other</c>.
        /// </summary>
        abstract source: MessageDetailsSource with get, set
        /// <summary>
        /// The log level, from 0 to 3.  In order it matches <c>verbose</c>, <c>info</c>, <c>warning</c>
        /// and <c>error</c>.
        /// </summary>
        abstract level: float with get, set
        /// The URL the message came from
        abstract sourceUrl: string with get, set
        /// The line number of the source that triggered this console message
        abstract lineNumber: float with get, set

    type [<AllowNullLiteral>] MessageEvent =
        abstract data: obj option with get, set
        abstract ports: ResizeArray<MessagePortMain> with get, set

    type [<AllowNullLiteral>] MoveToApplicationsFolderOptions =
        /// A handler for potential conflict in move failure.
        abstract conflictHandler: (MoveToApplicationsFolderOptionsConflictHandler -> bool) option with get, set

    type [<AllowNullLiteral>] NotificationConstructorOptions =
        /// A title for the notification, which will be shown at the top of the notification
        /// window when it is shown.
        abstract title: string with get, set
        /// <summary>A subtitle for the notification, which will be displayed below the title.</summary>
        abstract subtitle: string option with get, set
        /// The body text of the notification, which will be displayed below the title or
        /// subtitle.
        abstract body: string with get, set
        /// Whether or not to emit an OS notification noise when showing the notification.
        abstract silent: bool option with get, set
        /// An icon to use in the notification.
        abstract icon: U2<string, NativeImage> option with get, set
        /// <summary>Whether or not to add an inline reply option to the notification.</summary>
        abstract hasReply: bool option with get, set
        /// <summary>The timeout duration of the notification. Can be 'default' or 'never'.</summary>
        abstract timeoutType: NotificationTimeoutType option with get, set
        /// <summary>The placeholder to write in the inline reply input field.</summary>
        abstract replyPlaceholder: string option with get, set
        /// <summary>The name of the sound file to play when the notification is shown.</summary>
        abstract sound: string option with get, set
        /// <summary>The urgency level of the notification. Can be 'normal', 'critical', or 'low'.</summary>
        abstract urgency: NotificationUrgency option with get, set
        /// <summary>
        /// Actions to add to the notification. Please read the available actions and
        /// limitations in the <c>NotificationAction</c> documentation.
        /// </summary>
        abstract actions: ResizeArray<NotificationAction> option with get, set
        /// <summary>
        /// A custom title for the close button of an alert. An empty string will cause the
        /// default localized text to be used.
        /// </summary>
        abstract closeButtonText: string option with get, set

    type [<AllowNullLiteral>] OnBeforeRedirectListenerDetails =
        abstract id: float with get, set
        abstract url: string with get, set
        abstract method: string with get, set
        abstract webContentsId: float option with get, set
        abstract resourceType: string with get, set
        abstract referrer: string with get, set
        abstract timestamp: float with get, set
        abstract redirectURL: string with get, set
        abstract statusCode: float with get, set
        abstract statusLine: string with get, set
        /// The server IP address that the request was actually sent to.
        abstract ip: string option with get, set
        abstract fromCache: bool with get, set
        abstract responseHeaders: Record<string, ResizeArray<string>> option with get, set

    type [<AllowNullLiteral>] OnBeforeRequestListenerDetails =
        abstract id: float with get, set
        abstract url: string with get, set
        abstract method: string with get, set
        abstract webContentsId: float option with get, set
        abstract resourceType: string with get, set
        abstract referrer: string with get, set
        abstract timestamp: float with get, set
        abstract uploadData: ResizeArray<UploadData> with get, set

    type [<AllowNullLiteral>] OnBeforeSendHeadersListenerDetails =
        abstract id: float with get, set
        abstract url: string with get, set
        abstract method: string with get, set
        abstract webContentsId: float option with get, set
        abstract resourceType: string with get, set
        abstract referrer: string with get, set
        abstract timestamp: float with get, set
        abstract requestHeaders: Record<string, string> with get, set

    type [<AllowNullLiteral>] OnCompletedListenerDetails =
        abstract id: float with get, set
        abstract url: string with get, set
        abstract method: string with get, set
        abstract webContentsId: float option with get, set
        abstract resourceType: string with get, set
        abstract referrer: string with get, set
        abstract timestamp: float with get, set
        abstract responseHeaders: Record<string, ResizeArray<string>> option with get, set
        abstract fromCache: bool with get, set
        abstract statusCode: float with get, set
        abstract statusLine: string with get, set
        abstract error: string with get, set

    type [<AllowNullLiteral>] OnErrorOccurredListenerDetails =
        abstract id: float with get, set
        abstract url: string with get, set
        abstract method: string with get, set
        abstract webContentsId: float option with get, set
        abstract resourceType: string with get, set
        abstract referrer: string with get, set
        abstract timestamp: float with get, set
        abstract fromCache: bool with get, set
        /// The error description.
        abstract error: string with get, set

    type [<AllowNullLiteral>] OnHeadersReceivedListenerDetails =
        abstract id: float with get, set
        abstract url: string with get, set
        abstract method: string with get, set
        abstract webContentsId: float option with get, set
        abstract resourceType: string with get, set
        abstract referrer: string with get, set
        abstract timestamp: float with get, set
        abstract statusLine: string with get, set
        abstract statusCode: float with get, set
        abstract requestHeaders: Record<string, string> with get, set
        abstract responseHeaders: Record<string, ResizeArray<string>> option with get, set

    type [<AllowNullLiteral>] OnResponseStartedListenerDetails =
        abstract id: float with get, set
        abstract url: string with get, set
        abstract method: string with get, set
        abstract webContentsId: float option with get, set
        abstract resourceType: string with get, set
        abstract referrer: string with get, set
        abstract timestamp: float with get, set
        abstract responseHeaders: Record<string, ResizeArray<string>> option with get, set
        /// Indicates whether the response was fetched from disk cache.
        abstract fromCache: bool with get, set
        abstract statusCode: float with get, set
        abstract statusLine: string with get, set

    type [<AllowNullLiteral>] OnSendHeadersListenerDetails =
        abstract id: float with get, set
        abstract url: string with get, set
        abstract method: string with get, set
        abstract webContentsId: float option with get, set
        abstract resourceType: string with get, set
        abstract referrer: string with get, set
        abstract timestamp: float with get, set
        abstract requestHeaders: Record<string, string> with get, set

    type [<AllowNullLiteral>] OpenDevToolsOptions =
        /// <summary>
        /// Opens the devtools with specified dock state, can be <c>right</c>, <c>bottom</c>,
        /// <c>undocked</c>, <c>detach</c>. Defaults to last used dock state. In <c>undocked</c> mode it's
        /// possible to dock back. In <c>detach</c> mode it's not.
        /// </summary>
        abstract mode: OpenDevToolsOptionsMode with get, set
        /// <summary>
        /// Whether to bring the opened devtools window to the foreground. The default is
        /// <c>true</c>.
        /// </summary>
        abstract activate: bool option with get, set

    type [<AllowNullLiteral>] OpenDialogOptions =
        abstract title: string option with get, set
        abstract defaultPath: string option with get, set
        /// Custom label for the confirmation button, when left empty the default label will
        /// be used.
        abstract buttonLabel: string option with get, set
        abstract filters: ResizeArray<FileFilter> option with get, set
        /// Contains which features the dialog should use. The following values are
        /// supported:
        abstract properties: Array<OpenDialogOptionsPropertiesArray> option with get, set
        /// <summary>Message to display above input boxes.</summary>
        abstract message: string option with get, set
        /// <summary>Create security scoped bookmarks when packaged for the Mac App Store.</summary>
        abstract securityScopedBookmarks: bool option with get, set

    type [<AllowNullLiteral>] OpenDialogReturnValue =
        /// whether or not the dialog was canceled.
        abstract canceled: bool with get, set
        /// An array of file paths chosen by the user. If the dialog is cancelled this will
        /// be an empty array.
        abstract filePaths: ResizeArray<string> with get, set
        /// <summary>
        /// An array matching the <c>filePaths</c> array of base64 encoded strings which contains
        /// security scoped bookmark data. <c>securityScopedBookmarks</c> must be enabled for
        /// this to be populated. (For return values, see table here.)
        /// </summary>
        abstract bookmarks: ResizeArray<string> option with get, set

    type [<AllowNullLiteral>] OpenDialogSyncOptions =
        abstract title: string option with get, set
        abstract defaultPath: string option with get, set
        /// Custom label for the confirmation button, when left empty the default label will
        /// be used.
        abstract buttonLabel: string option with get, set
        abstract filters: ResizeArray<FileFilter> option with get, set
        /// Contains which features the dialog should use. The following values are
        /// supported:
        abstract properties: Array<OpenDialogOptionsPropertiesArray> option with get, set
        /// <summary>Message to display above input boxes.</summary>
        abstract message: string option with get, set
        /// <summary>Create security scoped bookmarks when packaged for the Mac App Store.</summary>
        abstract securityScopedBookmarks: bool option with get, set

    type [<AllowNullLiteral>] OpenExternalOptions =
        /// <summary><c>true</c> to bring the opened application to the foreground. The default is <c>true</c>.</summary>
        abstract activate: bool option with get, set
        /// <summary>The working directory.</summary>
        abstract workingDirectory: string option with get, set

    type [<AllowNullLiteral>] Options =
        interface end

    type [<AllowNullLiteral>] PageFaviconUpdatedEvent =
        inherit Event
        /// Array of URLs.
        abstract favicons: ResizeArray<string> with get, set

    type [<AllowNullLiteral>] PageTitleUpdatedEvent =
        inherit Event
        abstract title: string with get, set
        abstract explicitSet: bool with get, set

    type [<AllowNullLiteral>] Parameters =
        /// <summary>Specify the screen type to emulate (default: <c>desktop</c>):</summary>
        abstract screenPosition: ParametersScreenPosition with get, set
        /// Set the emulated screen size (screenPosition == mobile).
        abstract screenSize: Size with get, set
        /// Position the view on the screen (screenPosition == mobile) (default: `{ x: 0, y:
        /// 0 }`).
        abstract viewPosition: Point with get, set
        /// <summary>
        /// Set the device scale factor (if zero defaults to original device scale factor)
        /// (default: <c>0</c>).
        /// </summary>
        abstract deviceScaleFactor: float with get, set
        /// Set the emulated view size (empty means no override)
        abstract viewSize: Size with get, set
        /// <summary>
        /// Scale of emulated view inside available space (not in fit to view mode)
        /// (default: <c>1</c>).
        /// </summary>
        abstract scale: float with get, set

    type [<AllowNullLiteral>] Payment =
        /// The identifier of the purchased product.
        abstract productIdentifier: string with get, set
        /// The quantity purchased.
        abstract quantity: float with get, set

    type [<AllowNullLiteral>] PermissionCheckHandlerHandlerDetails =
        /// <summary>The security orign of the <c>media</c> check.</summary>
        abstract securityOrigin: string with get, set
        /// <summary>The type of media access being requested, can be <c>video</c>, <c>audio</c> or <c>unknown</c></summary>
        abstract mediaType: PermissionCheckHandlerHandlerDetailsMediaType with get, set
        /// The last URL the requesting frame loaded
        abstract requestingUrl: string with get, set
        /// Whether the frame making the request is the main frame
        abstract isMainFrame: bool with get, set

    type [<AllowNullLiteral>] PermissionRequestHandlerHandlerDetails =
        /// <summary>The url of the <c>openExternal</c> request.</summary>
        abstract externalURL: string option with get, set
        /// <summary>The types of media access being requested, elements can be <c>video</c> or <c>audio</c></summary>
        abstract mediaTypes: Array<PermissionRequestHandlerHandlerDetailsMediaTypesArray> option with get, set
        /// The last URL the requesting frame loaded
        abstract requestingUrl: string with get, set
        /// Whether the frame making the request is the main frame
        abstract isMainFrame: bool with get, set

    type [<AllowNullLiteral>] PluginCrashedEvent =
        inherit Event
        abstract name: string with get, set
        abstract version: string with get, set

    type [<AllowNullLiteral>] PopupOptions =
        /// Default is the focused window.
        abstract window: BrowserWindow option with get, set
        /// <summary>
        /// Default is the current mouse cursor position. Must be declared if <c>y</c> is
        /// declared.
        /// </summary>
        abstract x: float option with get, set
        /// <summary>
        /// Default is the current mouse cursor position. Must be declared if <c>x</c> is
        /// declared.
        /// </summary>
        abstract y: float option with get, set
        /// <summary>
        /// The index of the menu item to be positioned under the mouse cursor at the
        /// specified coordinates. Default is -1.
        /// </summary>
        abstract positioningItem: float option with get, set
        /// Called when menu is closed.
        abstract callback: (unit -> unit) option with get, set

    type [<AllowNullLiteral>] PreconnectOptions =
        /// URL for preconnect. Only the origin is relevant for opening the socket.
        abstract url: string with get, set
        /// number of sockets to preconnect. Must be between 1 and 6. Defaults to 1.
        abstract numSockets: float option with get, set

    type [<AllowNullLiteral>] PrintToPDFOptions =
        /// the header and footer for the PDF.
        abstract headerFooter: Record<string, string> option with get, set
        /// <summary><c>true</c> for landscape, <c>false</c> for portrait.</summary>
        abstract landscape: bool option with get, set
        /// <summary>
        /// Specifies the type of margins to use. Uses 0 for default margin, 1 for no
        /// margin, and 2 for minimum margin. and <c>width</c> in microns.
        /// </summary>
        abstract marginsType: float option with get, set
        /// The scale factor of the web page. Can range from 0 to 100.
        abstract scaleFactor: float option with get, set
        /// The page range to print.
        abstract pageRanges: Record<string, float> option with get, set
        /// <summary>
        /// Specify page size of the generated PDF. Can be <c>A3</c>, <c>A4</c>, <c>A5</c>, <c>Legal</c>,
        /// <c>Letter</c>, <c>Tabloid</c> or an Object containing <c>height</c>
        /// </summary>
        abstract pageSize: U2<string, Size> option with get, set
        /// Whether to print CSS backgrounds.
        abstract printBackground: bool option with get, set
        /// Whether to print selection only.
        abstract printSelectionOnly: bool option with get, set

    type [<AllowNullLiteral>] Privileges =
        /// Default false.
        abstract standard: bool option with get, set
        /// Default false.
        abstract secure: bool option with get, set
        /// Default false.
        abstract bypassCSP: bool option with get, set
        /// Default false.
        abstract allowServiceWorkers: bool option with get, set
        /// Default false.
        abstract supportFetchAPI: bool option with get, set
        /// Default false.
        abstract corsEnabled: bool option with get, set

    type [<AllowNullLiteral>] ProgressBarOptions =
        /// <summary>
        /// Mode for the progress bar. Can be <c>none</c>, <c>normal</c>, <c>indeterminate</c>, <c>error</c> or
        /// <c>paused</c>.
        /// </summary>
        abstract mode: ProgressBarOptionsMode with get, set

    type [<AllowNullLiteral>] Provider =
        abstract spellCheck: (ResizeArray<string> -> (ResizeArray<string> -> unit) -> unit) with get, set

    type [<AllowNullLiteral>] ReadBookmark =
        abstract title: string with get, set
        abstract url: string with get, set

    type [<AllowNullLiteral>] RedirectRequest =
        abstract url: string with get, set
        abstract method: string option with get, set
        abstract session: Session option with get, set
        abstract uploadData: ProtocolResponseUploadData option with get, set

    type [<AllowNullLiteral>] RelaunchOptions =
        abstract args: ResizeArray<string> option with get, set
        abstract execPath: string option with get, set

    type [<AllowNullLiteral>] Request =
        abstract url: string with get, set
        abstract headers: Record<string, string> with get, set
        abstract referrer: string with get, set
        abstract method: string with get, set
        abstract uploadData: ResizeArray<UploadData> with get, set

    type [<AllowNullLiteral>] ResizeOptions =
        /// Defaults to the image's width.
        abstract width: float option with get, set
        /// Defaults to the image's height.
        abstract height: float option with get, set
        /// <summary>
        /// The desired quality of the resize image. Possible values are <c>good</c>, <c>better</c>,
        /// or <c>best</c>. The default is <c>best</c>. These values express a desired quality/speed
        /// tradeoff. They are translated into an algorithm-specific method that depends on
        /// the capabilities (CPU, GPU) of the underlying platform. It is possible for all
        /// three methods to be mapped to the same algorithm on a given platform.
        /// </summary>
        abstract quality: string option with get, set

    type [<AllowNullLiteral>] ResourceUsage =
        abstract images: MemoryUsageDetails with get, set
        abstract scripts: MemoryUsageDetails with get, set
        abstract cssStyleSheets: MemoryUsageDetails with get, set
        abstract xslStyleSheets: MemoryUsageDetails with get, set
        abstract fonts: MemoryUsageDetails with get, set
        abstract other: MemoryUsageDetails with get, set

    type [<AllowNullLiteral>] Response =
        abstract cancel: bool option with get, set
        /// The original request is prevented from being sent or completed and is instead
        /// redirected to the given URL.
        abstract redirectURL: string option with get, set

    type [<AllowNullLiteral>] Result =
        abstract requestId: float with get, set
        /// Position of the active match.
        abstract activeMatchOrdinal: float with get, set
        /// Number of Matches.
        abstract matches: float with get, set
        /// Coordinates of first match region.
        abstract selectionArea: Rectangle with get, set
        abstract finalUpdate: bool with get, set

    type [<AllowNullLiteral>] SaveDialogOptions =
        abstract title: string option with get, set
        /// Absolute directory path, absolute file path, or file name to use by default.
        abstract defaultPath: string option with get, set
        /// Custom label for the confirmation button, when left empty the default label will
        /// be used.
        abstract buttonLabel: string option with get, set
        abstract filters: ResizeArray<FileFilter> option with get, set
        /// <summary>Message to display above text fields.</summary>
        abstract message: string option with get, set
        /// <summary>Custom label for the text displayed in front of the filename text field.</summary>
        abstract nameFieldLabel: string option with get, set
        /// <summary>Show the tags input box, defaults to <c>true</c>.</summary>
        abstract showsTagField: bool option with get, set
        abstract properties: Array<SaveDialogOptionsPropertiesArray> option with get, set
        /// <summary>
        /// Create a security scoped bookmark when packaged for the Mac App Store. If this
        /// option is enabled and the file doesn't already exist a blank file will be
        /// created at the chosen path.
        /// </summary>
        abstract securityScopedBookmarks: bool option with get, set

    type [<AllowNullLiteral>] SaveDialogReturnValue =
        /// whether or not the dialog was canceled.
        abstract canceled: bool with get, set
        /// <summary>If the dialog is canceled, this will be <c>undefined</c>.</summary>
        abstract filePath: string option with get, set
        /// <summary>
        /// Base64 encoded string which contains the security scoped bookmark data for the
        /// saved file. <c>securityScopedBookmarks</c> must be enabled for this to be present.
        /// (For return values, see table here.)
        /// </summary>
        abstract bookmark: string option with get, set

    type [<AllowNullLiteral>] SaveDialogSyncOptions =
        abstract title: string option with get, set
        /// Absolute directory path, absolute file path, or file name to use by default.
        abstract defaultPath: string option with get, set
        /// Custom label for the confirmation button, when left empty the default label will
        /// be used.
        abstract buttonLabel: string option with get, set
        abstract filters: ResizeArray<FileFilter> option with get, set
        /// <summary>Message to display above text fields.</summary>
        abstract message: string option with get, set
        /// <summary>Custom label for the text displayed in front of the filename text field.</summary>
        abstract nameFieldLabel: string option with get, set
        /// <summary>Show the tags input box, defaults to <c>true</c>.</summary>
        abstract showsTagField: bool option with get, set
        abstract properties: Array<SaveDialogOptionsPropertiesArray> option with get, set
        /// <summary>
        /// Create a security scoped bookmark when packaged for the Mac App Store. If this
        /// option is enabled and the file doesn't already exist a blank file will be
        /// created at the chosen path.
        /// </summary>
        abstract securityScopedBookmarks: bool option with get, set

    type [<AllowNullLiteral>] Settings =
        /// <summary>
        /// <c>true</c> to open the app at login, <c>false</c> to remove the app as a login item.
        /// Defaults to <c>false</c>.
        /// </summary>
        abstract openAtLogin: bool option with get, set
        /// <summary>
        /// <c>true</c> to open the app as hidden. Defaults to <c>false</c>. The user can edit this
        /// setting from the System Preferences so
        /// <c>app.getLoginItemSettings().wasOpenedAsHidden</c> should be checked when the app is
        /// opened to know the current value. This setting is not available on MAS builds.
        /// </summary>
        abstract openAsHidden: bool option with get, set
        /// <summary>The executable to launch at login. Defaults to <c>process.execPath</c>.</summary>
        abstract path: string option with get, set
        /// <summary>
        /// The command-line arguments to pass to the executable. Defaults to an empty
        /// array. Take care to wrap paths in quotes.
        /// </summary>
        abstract args: ResizeArray<string> option with get, set

    type [<AllowNullLiteral>] SourcesOptions =
        /// <summary>
        /// An array of Strings that lists the types of desktop sources to be captured,
        /// available types are <c>screen</c> and <c>window</c>.
        /// </summary>
        abstract types: ResizeArray<string> with get, set
        /// <summary>
        /// The size that the media source thumbnail should be scaled to. Default is <c>150</c> x
        /// <c>150</c>. Set width or height to 0 when you do not need the thumbnails. This will
        /// save the processing time required for capturing the content of each window and
        /// screen.
        /// </summary>
        abstract thumbnailSize: Size option with get, set
        /// Set to true to enable fetching window icons. The default value is false. When
        /// false the appIcon property of the sources return null. Same if a source has the
        /// type screen.
        abstract fetchWindowIcons: bool option with get, set

    type [<AllowNullLiteral>] StartLoggingOptions =
        /// <summary>
        /// What kinds of data should be captured. By default, only metadata about requests
        /// will be captured. Setting this to <c>includeSensitive</c> will include cookies and
        /// authentication data. Setting it to <c>everything</c> will include all bytes
        /// transferred on sockets. Can be <c>default</c>, <c>includeSensitive</c> or <c>everything</c>.
        /// </summary>
        abstract captureMode: StartLoggingOptionsCaptureMode option with get, set
        /// When the log grows beyond this size, logging will automatically stop. Defaults
        /// to unlimited.
        abstract maxFileSize: float option with get, set

    type [<AllowNullLiteral>] SystemMemoryInfo =
        /// The total amount of physical memory in Kilobytes available to the system.
        abstract total: float with get, set
        /// The total amount of memory not being used by applications or disk cache.
        abstract free: float with get, set
        /// <summary>The total amount of swap memory in Kilobytes available to the system.</summary>
        abstract swapTotal: float with get, set
        /// <summary>The free amount of swap memory in Kilobytes available to the system.</summary>
        abstract swapFree: float with get, set

    type [<AllowNullLiteral>] ToBitmapOptions =
        /// Defaults to 1.0.
        abstract scaleFactor: float option with get, set

    type [<AllowNullLiteral>] ToDataURLOptions =
        /// Defaults to 1.0.
        abstract scaleFactor: float option with get, set

    type [<AllowNullLiteral>] ToPNGOptions =
        /// Defaults to 1.0.
        abstract scaleFactor: float option with get, set

    type [<AllowNullLiteral>] TouchBarButtonConstructorOptions =
        /// Button text.
        abstract label: string option with get, set
        /// A short description of the button for use by screenreaders like VoiceOver.
        abstract accessibilityLabel: string option with get, set
        /// <summary>Button background color in hex format, i.e <c>#ABCDEF</c>.</summary>
        abstract backgroundColor: string option with get, set
        /// Button icon.
        abstract icon: U2<NativeImage, string> option with get, set
        /// <summary>Can be <c>left</c>, <c>right</c> or <c>overlay</c>. Defaults to <c>overlay</c>.</summary>
        abstract iconPosition: TouchBarButtonConstructorOptionsIconPosition option with get, set
        /// Function to call when the button is clicked.
        abstract click: (unit -> unit) option with get, set
        /// <summary>Whether the button is in an enabled state.  Default is <c>true</c>.</summary>
        abstract enabled: bool option with get, set

    type [<AllowNullLiteral>] TouchBarColorPickerConstructorOptions =
        /// Array of hex color strings to appear as possible colors to select.
        abstract availableColors: ResizeArray<string> option with get, set
        /// <summary>The selected hex color in the picker, i.e <c>#ABCDEF</c>.</summary>
        abstract selectedColor: string option with get, set
        /// Function to call when a color is selected.
        abstract change: (string -> unit) option with get, set

    type [<AllowNullLiteral>] TouchBarConstructorOptions =
        abstract items: Array<obj> option with get, set
        abstract escapeItem: obj option with get, set

    type [<AllowNullLiteral>] TouchBarGroupConstructorOptions =
        /// Items to display as a group.
        abstract items: TouchBar with get, set

    type [<AllowNullLiteral>] TouchBarLabelConstructorOptions =
        /// Text to display.
        abstract label: string option with get, set
        /// A short description of the button for use by screenreaders like VoiceOver.
        abstract accessibilityLabel: string option with get, set
        /// <summary>Hex color of text, i.e <c>#ABCDEF</c>.</summary>
        abstract textColor: string option with get, set

    type [<AllowNullLiteral>] TouchBarPopoverConstructorOptions =
        /// Popover button text.
        abstract label: string option with get, set
        /// Popover button icon.
        abstract icon: NativeImage option with get, set
        /// Items to display in the popover.
        abstract items: TouchBar with get, set
        /// <summary>
        /// <c>true</c> to display a close button on the left of the popover, <c>false</c> to not show
        /// it. Default is <c>true</c>.
        /// </summary>
        abstract showCloseButton: bool option with get, set

    type [<AllowNullLiteral>] TouchBarScrubberConstructorOptions =
        /// An array of items to place in this scrubber.
        abstract items: ResizeArray<ScrubberItem> with get, set
        /// Called when the user taps an item that was not the last tapped item.
        abstract select: (float -> unit) option with get, set
        /// Called when the user taps any item.
        abstract highlight: (float -> unit) option with get, set
        /// <summary>
        /// Selected item style. Can be <c>background</c>, <c>outline</c> or <c>none</c>. Defaults to
        /// <c>none</c>.
        /// </summary>
        abstract selectedStyle: TouchBarScrubberOverlayStyle option with get, set
        /// <summary>
        /// Selected overlay item style. Can be <c>background</c>, <c>outline</c> or <c>none</c>. Defaults
        /// to <c>none</c>.
        /// </summary>
        abstract overlayStyle: TouchBarScrubberOverlayStyle option with get, set
        /// <summary>Defaults to <c>false</c>.</summary>
        abstract showArrowButtons: bool option with get, set
        /// <summary>Can be <c>fixed</c> or <c>free</c>. The default is <c>free</c>.</summary>
        abstract mode: TouchBarScrubberMode option with get, set
        /// <summary>Defaults to <c>true</c>.</summary>
        abstract continuous: bool option with get, set

    type [<AllowNullLiteral>] TouchBarSegmentedControlConstructorOptions =
        /// Style of the segments:
        abstract segmentStyle: TouchBarSegmentedControlConstructorOptionsSegmentStyle option with get, set
        /// The selection mode of the control:
        abstract mode: TouchBarSegmentedControlConstructorOptionsMode option with get, set
        /// An array of segments to place in this control.
        abstract segments: ResizeArray<SegmentedControlSegment> with get, set
        /// <summary>
        /// The index of the currently selected segment, will update automatically with user
        /// interaction. When the mode is <c>multiple</c> it will be the last selected item.
        /// </summary>
        abstract selectedIndex: float option with get, set
        /// Called when the user selects a new segment.
        abstract change: (float -> bool -> unit) option with get, set

    type [<AllowNullLiteral>] TouchBarSliderConstructorOptions =
        /// Label text.
        abstract label: string option with get, set
        /// Selected value.
        abstract value: float option with get, set
        /// Minimum value.
        abstract minValue: float option with get, set
        /// Maximum value.
        abstract maxValue: float option with get, set
        /// Function to call when the slider is changed.
        abstract change: (float -> unit) option with get, set

    type [<AllowNullLiteral>] TouchBarSpacerConstructorOptions =
        /// Size of spacer, possible values are:
        abstract size: TouchBarSpacerConstructorOptionsSize option with get, set

    type [<AllowNullLiteral>] TraceBufferUsageReturnValue =
        abstract value: float with get, set
        abstract percentage: float with get, set

    type [<AllowNullLiteral>] UpdateTargetUrlEvent =
        inherit Event
        abstract url: string with get, set

    type [<AllowNullLiteral>] UploadProgress =
        /// Whether the request is currently active. If this is false no other properties
        /// will be set
        abstract active: bool with get, set
        /// <summary>
        /// Whether the upload has started. If this is false both <c>current</c> and <c>total</c> will
        /// be set to 0.
        /// </summary>
        abstract started: bool with get, set
        /// The number of bytes that have been uploaded so far
        abstract current: float with get, set
        /// The number of bytes that will be uploaded this request
        abstract total: float with get, set

    type [<AllowNullLiteral>] VisibleOnAllWorkspacesOptions =
        /// <summary>Sets whether the window should be visible above fullscreen windows</summary>
        abstract visibleOnFullScreen: bool option with get, set

    type [<AllowNullLiteral>] WebContentsPrintOptions =
        /// <summary>Don't ask user for print settings. Default is <c>false</c>.</summary>
        abstract silent: bool option with get, set
        /// <summary>Prints the background color and image of the web page. Default is <c>false</c>.</summary>
        abstract printBackground: bool option with get, set
        /// Set the printer device name to use. Must be the system-defined name and not the
        /// 'friendly' name, e.g 'Brother_QL_820NWB' and not 'Brother QL-820NWB'.
        abstract deviceName: string option with get, set
        /// <summary>
        /// Set whether the printed web page will be in color or grayscale. Default is
        /// <c>true</c>.
        /// </summary>
        abstract color: bool option with get, set
        abstract margins: Margins option with get, set
        /// <summary>Whether the web page should be printed in landscape mode. Default is <c>false</c>.</summary>
        abstract landscape: bool option with get, set
        /// The scale factor of the web page.
        abstract scaleFactor: float option with get, set
        /// The number of pages to print per page sheet.
        abstract pagesPerSheet: float option with get, set
        /// Whether the web page should be collated.
        abstract collate: bool option with get, set
        /// The number of copies of the web page to print.
        abstract copies: float option with get, set
        /// The page range to print.
        abstract pageRanges: Record<string, float> option with get, set
        /// <summary>
        /// Set the duplex mode of the printed web page. Can be <c>simplex</c>, <c>shortEdge</c>, or
        /// <c>longEdge</c>.
        /// </summary>
        abstract duplexMode: WebContentsPrintOptionsDuplexMode option with get, set
        abstract dpi: Record<string, float> option with get, set
        /// String to be printed as page header.
        abstract header: string option with get, set
        /// String to be printed as page footer.
        abstract footer: string option with get, set
        /// <summary>
        /// Specify page size of the printed document. Can be <c>A3</c>, <c>A4</c>, <c>A5</c>, <c>Legal</c>,
        /// <c>Letter</c>, <c>Tabloid</c> or an Object containing <c>height</c>.
        /// </summary>
        abstract pageSize: U2<string, Size> option with get, set

    type [<AllowNullLiteral>] WebviewTagPrintOptions =
        /// <summary>Don't ask user for print settings. Default is <c>false</c>.</summary>
        abstract silent: bool option with get, set
        /// <summary>Prints the background color and image of the web page. Default is <c>false</c>.</summary>
        abstract printBackground: bool option with get, set
        /// Set the printer device name to use. Must be the system-defined name and not the
        /// 'friendly' name, e.g 'Brother_QL_820NWB' and not 'Brother QL-820NWB'.
        abstract deviceName: string option with get, set
        /// <summary>
        /// Set whether the printed web page will be in color or grayscale. Default is
        /// <c>true</c>.
        /// </summary>
        abstract color: bool option with get, set
        abstract margins: Margins option with get, set
        /// <summary>Whether the web page should be printed in landscape mode. Default is <c>false</c>.</summary>
        abstract landscape: bool option with get, set
        /// The scale factor of the web page.
        abstract scaleFactor: float option with get, set
        /// The number of pages to print per page sheet.
        abstract pagesPerSheet: float option with get, set
        /// Whether the web page should be collated.
        abstract collate: bool option with get, set
        /// The number of copies of the web page to print.
        abstract copies: float option with get, set
        /// The page range to print.
        abstract pageRanges: Record<string, float> option with get, set
        /// <summary>
        /// Set the duplex mode of the printed web page. Can be <c>simplex</c>, <c>shortEdge</c>, or
        /// <c>longEdge</c>.
        /// </summary>
        abstract duplexMode: WebContentsPrintOptionsDuplexMode option with get, set
        abstract dpi: Record<string, float> option with get, set
        /// String to be printed as page header.
        abstract header: string option with get, set
        /// String to be printed as page footer.
        abstract footer: string option with get, set
        /// <summary>
        /// Specify page size of the printed document. Can be <c>A3</c>, <c>A4</c>, <c>A5</c>, <c>Legal</c>,
        /// <c>Letter</c>, <c>Tabloid</c> or an Object containing <c>height</c>.
        /// </summary>
        abstract pageSize: U2<string, Size> option with get, set

    type [<AllowNullLiteral>] WillNavigateEvent =
        inherit Event
        abstract url: string with get, set

    type [<AllowNullLiteral>] EditFlags =
        /// Whether the renderer believes it can undo.
        abstract canUndo: bool with get, set
        /// Whether the renderer believes it can redo.
        abstract canRedo: bool with get, set
        /// Whether the renderer believes it can cut.
        abstract canCut: bool with get, set
        /// Whether the renderer believes it can copy
        abstract canCopy: bool with get, set
        /// Whether the renderer believes it can paste.
        abstract canPaste: bool with get, set
        /// Whether the renderer believes it can delete.
        abstract canDelete: bool with get, set
        /// Whether the renderer believes it can select all.
        abstract canSelectAll: bool with get, set

    type [<AllowNullLiteral>] FoundInPageResult =
        abstract requestId: float with get, set
        /// Position of the active match.
        abstract activeMatchOrdinal: float with get, set
        /// Number of Matches.
        abstract matches: float with get, set
        /// Coordinates of first match region.
        abstract selectionArea: Rectangle with get, set
        abstract finalUpdate: bool with get, set

    type [<AllowNullLiteral>] Margins =
        /// <summary>
        /// Can be <c>default</c>, <c>none</c>, <c>printableArea</c>, or <c>custom</c>. If <c>custom</c> is chosen,
        /// you will also need to specify <c>top</c>, <c>bottom</c>, <c>left</c>, and <c>right</c>.
        /// </summary>
        abstract marginType: MarginsMarginType option with get, set
        /// The top margin of the printed web page, in pixels.
        abstract top: float option with get, set
        /// The bottom margin of the printed web page, in pixels.
        abstract bottom: float option with get, set
        /// The left margin of the printed web page, in pixels.
        abstract left: float option with get, set
        /// The right margin of the printed web page, in pixels.
        abstract right: float option with get, set

    type [<AllowNullLiteral>] MediaFlags =
        /// Whether the media element has crashed.
        abstract inError: bool with get, set
        /// Whether the media element is paused.
        abstract isPaused: bool with get, set
        /// Whether the media element is muted.
        abstract isMuted: bool with get, set
        /// Whether the media element has audio.
        abstract hasAudio: bool with get, set
        /// Whether the media element is looping.
        abstract isLooping: bool with get, set
        /// Whether the media element's controls are visible.
        abstract isControlsVisible: bool with get, set
        /// Whether the media element's controls are toggleable.
        abstract canToggleControls: bool with get, set
        /// Whether the media element can be rotated.
        abstract canRotate: bool with get, set

    type [<AllowNullLiteral>] WebPreferences =
        /// <summary>
        /// Whether to enable DevTools. If it is set to <c>false</c>, can not use
        /// <c>BrowserWindow.webContents.openDevTools()</c> to open DevTools. Default is <c>true</c>.
        /// </summary>
        abstract devTools: bool option with get, set
        /// <summary>Whether node integration is enabled. Default is <c>false</c>.</summary>
        abstract nodeIntegration: bool option with get, set
        /// <summary>
        /// Whether node integration is enabled in web workers. Default is <c>false</c>. More
        /// about this can be found in Multithreading.
        /// </summary>
        abstract nodeIntegrationInWorker: bool option with get, set
        /// <summary>
        /// Experimental option for enabling Node.js support in sub-frames such as iframes
        /// and child windows. All your preloads will load for every iframe, you can use
        /// <c>process.isMainFrame</c> to determine if you are in the main frame or not.
        /// </summary>
        abstract nodeIntegrationInSubFrames: bool option with get, set
        /// Specifies a script that will be loaded before other scripts run in the page.
        /// This script will always have access to node APIs no matter whether node
        /// integration is turned on or off. The value should be the absolute file path to
        /// the script. When node integration is turned off, the preload script can
        /// reintroduce Node global symbols back to the global scope. See example here.
        abstract preload: string option with get, set
        /// <summary>
        /// If set, this will sandbox the renderer associated with the window, making it
        /// compatible with the Chromium OS-level sandbox and disabling the Node.js engine.
        /// This is not the same as the <c>nodeIntegration</c> option and the APIs available to
        /// the preload script are more limited. Read more about the option here.
        /// </summary>
        abstract sandbox: bool option with get, set
        /// <summary>Whether to enable the <c>remote</c> module. Default is <c>true</c>.</summary>
        abstract enableRemoteModule: bool option with get, set
        /// <summary>
        /// Sets the session used by the page. Instead of passing the Session object
        /// directly, you can also choose to use the <c>partition</c> option instead, which
        /// accepts a partition string. When both <c>session</c> and <c>partition</c> are provided,
        /// <c>session</c> will be preferred. Default is the default session.
        /// </summary>
        abstract session: Session option with get, set
        /// <summary>
        /// Sets the session used by the page according to the session's partition string.
        /// If <c>partition</c> starts with <c>persist:</c>, the page will use a persistent session
        /// available to all pages in the app with the same <c>partition</c>. If there is no
        /// <c>persist:</c> prefix, the page will use an in-memory session. By assigning the same
        /// <c>partition</c>, multiple pages can share the same session. Default is the default
        /// session.
        /// </summary>
        abstract partition: string option with get, set
        /// <summary>
        /// When specified, web pages with the same <c>affinity</c> will run in the same renderer
        /// process. Note that due to reusing the renderer process, certain <c>webPreferences</c>
        /// options will also be shared between the web pages even when you specified
        /// different values for them, including but not limited to <c>preload</c>, <c>sandbox</c> and
        /// <c>nodeIntegration</c>. So it is suggested to use exact same <c>webPreferences</c> for web
        /// pages with the same <c>affinity</c>. _Deprecated_
        /// </summary>
        abstract affinity: string option with get, set
        /// <summary>The default zoom factor of the page, <c>3.0</c> represents <c>300%</c>. Default is <c>1.0</c>.</summary>
        abstract zoomFactor: float option with get, set
        /// <summary>Enables JavaScript support. Default is <c>true</c>.</summary>
        abstract javascript: bool option with get, set
        /// <summary>
        /// When <c>false</c>, it will disable the same-origin policy (usually using testing
        /// websites by people), and set <c>allowRunningInsecureContent</c> to <c>true</c> if this
        /// options has not been set by user. Default is <c>true</c>.
        /// </summary>
        abstract webSecurity: bool option with get, set
        /// <summary>
        /// Allow an https page to run JavaScript, CSS or plugins from http URLs. Default is
        /// <c>false</c>.
        /// </summary>
        abstract allowRunningInsecureContent: bool option with get, set
        /// <summary>Enables image support. Default is <c>true</c>.</summary>
        abstract images: bool option with get, set
        /// <summary>Make TextArea elements resizable. Default is <c>true</c>.</summary>
        abstract textAreasAreResizable: bool option with get, set
        /// <summary>Enables WebGL support. Default is <c>true</c>.</summary>
        abstract webgl: bool option with get, set
        /// <summary>Whether plugins should be enabled. Default is <c>false</c>.</summary>
        abstract plugins: bool option with get, set
        /// <summary>Enables Chromium's experimental features. Default is <c>false</c>.</summary>
        abstract experimentalFeatures: bool option with get, set
        /// <summary>Enables scroll bounce (rubber banding) effect on macOS. Default is <c>false</c>.</summary>
        abstract scrollBounce: bool option with get, set
        /// <summary>
        /// A list of feature strings separated by <c>,</c>, like <c>CSSVariables,KeyboardEventKey</c>
        /// to enable. The full list of supported feature strings can be found in the
        /// RuntimeEnabledFeatures.json5 file.
        /// </summary>
        abstract enableBlinkFeatures: string option with get, set
        /// <summary>
        /// A list of feature strings separated by <c>,</c>, like <c>CSSVariables,KeyboardEventKey</c>
        /// to disable. The full list of supported feature strings can be found in the
        /// RuntimeEnabledFeatures.json5 file.
        /// </summary>
        abstract disableBlinkFeatures: string option with get, set
        /// Sets the default font for the font-family.
        abstract defaultFontFamily: DefaultFontFamily option with get, set
        /// <summary>Defaults to <c>16</c>.</summary>
        abstract defaultFontSize: float option with get, set
        /// <summary>Defaults to <c>13</c>.</summary>
        abstract defaultMonospaceFontSize: float option with get, set
        /// <summary>Defaults to <c>0</c>.</summary>
        abstract minimumFontSize: float option with get, set
        /// <summary>Defaults to <c>ISO-8859-1</c>.</summary>
        abstract defaultEncoding: string option with get, set
        /// <summary>
        /// Whether to throttle animations and timers when the page becomes background. This
        /// also affects the Page Visibility API. Defaults to <c>true</c>.
        /// </summary>
        abstract backgroundThrottling: bool option with get, set
        /// <summary>
        /// Whether to enable offscreen rendering for the browser window. Defaults to
        /// <c>false</c>. See the offscreen rendering tutorial for more details.
        /// </summary>
        abstract offscreen: bool option with get, set
        /// <summary>
        /// Whether to run Electron APIs and the specified <c>preload</c> script in a separate
        /// JavaScript context. Defaults to <c>false</c>. The context that the <c>preload</c> script
        /// runs in will still have full access to the <c>document</c> and <c>window</c> globals but
        /// it will use its own set of JavaScript builtins (<c>Array</c>, <c>Object</c>, <c>JSON</c>, etc.)
        /// and will be isolated from any changes made to the global environment by the
        /// loaded page. The Electron API will only be available in the <c>preload</c> script and
        /// not the loaded page. This option should be used when loading potentially
        /// untrusted remote content to ensure the loaded content cannot tamper with the
        /// <c>preload</c> script and any Electron APIs being used. This option uses the same
        /// technique used by Chrome Content Scripts. You can access this context in the dev
        /// tools by selecting the 'Electron Isolated Context' entry in the combo box at the
        /// top of the Console tab.
        /// </summary>
        abstract contextIsolation: bool option with get, set
        /// <summary>
        /// If true, values returned from <c>webFrame.executeJavaScript</c> will be sanitized to
        /// ensure JS values can't unsafely cross between worlds when using
        /// <c>contextIsolation</c>.  The default is <c>false</c>. In Electron 12, the default will be
        /// changed to <c>true</c>. _Deprecated_
        /// </summary>
        abstract worldSafeExecuteJavaScript: bool option with get, set
        /// <summary>
        /// Whether to use native <c>window.open()</c>. Defaults to <c>false</c>. Child windows will
        /// always have node integration disabled unless <c>nodeIntegrationInSubFrames</c> is
        /// true. **Note:** This option is currently experimental.
        /// </summary>
        abstract nativeWindowOpen: bool option with get, set
        /// <summary>
        /// Whether to enable the <c>&lt;webview&gt;</c> tag. Defaults to <c>false</c>. **Note:** The
        /// <c>preload</c> script configured for the <c>&lt;webview&gt;</c> will have node integration
        /// enabled when it is executed so you should ensure remote/untrusted content is not
        /// able to create a <c>&lt;webview&gt;</c> tag with a possibly malicious <c>preload</c> script. You
        /// can use the <c>will-attach-webview</c> event on webContents to strip away the
        /// <c>preload</c> script and to validate or alter the <c>&lt;webview&gt;</c>'s initial settings.
        /// </summary>
        abstract webviewTag: bool option with get, set
        /// <summary>
        /// A list of strings that will be appended to <c>process.argv</c> in the renderer
        /// process of this app.  Useful for passing small bits of data down to renderer
        /// process preload scripts.
        /// </summary>
        abstract additionalArguments: ResizeArray<string> option with get, set
        /// <summary>
        /// Whether to enable browser style consecutive dialog protection. Default is
        /// <c>false</c>.
        /// </summary>
        abstract safeDialogs: bool option with get, set
        /// The message to display when consecutive dialog protection is triggered. If not
        /// defined the default message would be used, note that currently the default
        /// message is in English and not localized.
        abstract safeDialogsMessage: string option with get, set
        /// <summary>
        /// Whether to disable dialogs completely. Overrides <c>safeDialogs</c>. Default is
        /// <c>false</c>.
        /// </summary>
        abstract disableDialogs: bool option with get, set
        /// <summary>
        /// Whether dragging and dropping a file or link onto the page causes a navigation.
        /// Default is <c>false</c>.
        /// </summary>
        abstract navigateOnDragDrop: bool option with get, set
        /// <summary>
        /// Autoplay policy to apply to content in the window, can be
        /// <c>no-user-gesture-required</c>, <c>user-gesture-required</c>,
        /// <c>document-user-activation-required</c>. Defaults to <c>no-user-gesture-required</c>.
        /// </summary>
        abstract autoplayPolicy: WebPreferencesAutoplayPolicy option with get, set
        /// <summary>
        /// Whether to prevent the window from resizing when entering HTML Fullscreen.
        /// Default is <c>false</c>.
        /// </summary>
        abstract disableHtmlFullscreenWindowResize: bool option with get, set
        /// An alternative title string provided only to accessibility tools such as screen
        /// readers. This string is not directly visible to users.
        abstract accessibleTitle: string option with get, set
        /// <summary>Whether to enable the builtin spellchecker. Default is <c>true</c>.</summary>
        abstract spellcheck: bool option with get, set
        /// <summary>Whether to enable the WebSQL api. Default is <c>true</c>.</summary>
        abstract enableWebSQL: bool option with get, set
        /// Enforces the v8 code caching policy used by blink. Accepted values are
        abstract v8CacheOptions: WebPreferencesV8CacheOptions option with get, set

    type [<AllowNullLiteral>] DefaultFontFamily =
        /// <summary>Defaults to <c>Times New Roman</c>.</summary>
        abstract standard: string option with get, set
        /// <summary>Defaults to <c>Times New Roman</c>.</summary>
        abstract serif: string option with get, set
        /// <summary>Defaults to <c>Arial</c>.</summary>
        abstract sansSerif: string option with get, set
        /// <summary>Defaults to <c>Courier New</c>.</summary>
        abstract monospace: string option with get, set
        /// <summary>Defaults to <c>Script</c>.</summary>
        abstract cursive: string option with get, set
        /// <summary>Defaults to <c>Impact</c>.</summary>
        abstract fantasy: string option with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] BrowserWindowSetVibrancy =
        | [<CompiledName "appearance-based">] AppearanceBased
        | Light
        | Dark
        | Titlebar
        | Selection
        | Menu
        | Popover
        | Sidebar
        | [<CompiledName "medium-light">] MediumLight
        | [<CompiledName "ultra-dark">] UltraDark
        | Header
        | Sheet
        | Window
        | Hud
        | [<CompiledName "fullscreen-ui">] FullscreenUi
        | Tooltip
        | Content
        | [<CompiledName "under-window">] UnderWindow
        | [<CompiledName "under-page">] UnderPage

    type [<StringEnum>] [<RequireQualifiedAccess>] DisplayAccelerometerSupport =
        | Available
        | Unavailable
        | Unknown

    type [<StringEnum>] [<RequireQualifiedAccess>] DownloadItemOn_done =
        | Completed
        | Cancelled
        | Interrupted

    type [<StringEnum>] [<RequireQualifiedAccess>] DownloadItemOn_updated =
        | Progressing
        | Interrupted

    type [<StringEnum>] [<RequireQualifiedAccess>] InputEventModifiersArray =
        | Shift
        | Control
        | Ctrl
        | Alt
        | Meta
        | Command
        | Cmd
        | IsKeypad
        | IsAutoRepeat
        | LeftButtonDown
        | MiddleButtonDown
        | RightButtonDown
        | CapsLock
        | NumLock
        | Left
        | Right

    type [<StringEnum>] [<RequireQualifiedAccess>] JumpListCategoryType =
        | Tasks
        | Frequent
        | Recent
        | Custom

    type [<StringEnum>] [<RequireQualifiedAccess>] JumpListItemType =
        | Task
        | Separator
        | File

    type [<StringEnum>] [<RequireQualifiedAccess>] KeyboardInputEventType =
        | KeyDown
        | KeyUp
        | Char

    type [<StringEnum>] [<RequireQualifiedAccess>] MenuItemRole =
        | Undo
        | Redo
        | Cut
        | Copy
        | Paste
        | PasteAndMatchStyle
        | Delete
        | SelectAll
        | Reload
        | ForceReload
        | ToggleDevTools
        | ResetZoom
        | ZoomIn
        | ZoomOut
        | Togglefullscreen
        | Window
        | Minimize
        | Close
        | Help
        | About
        | Services
        | Hide
        | HideOthers
        | Unhide
        | Quit
        | StartSpeaking
        | StopSpeaking
        | Zoom
        | Front
        | AppMenu
        | FileMenu
        | EditMenu
        | ViewMenu
        | RecentDocuments
        | ToggleTabBar
        | SelectNextTab
        | SelectPreviousTab
        | MergeAllWindows
        | ClearRecentDocuments
        | MoveTabToNewWindow
        | WindowMenu

    type [<StringEnum>] [<RequireQualifiedAccess>] MenuItemType =
        | Normal
        | Separator
        | Submenu
        | Checkbox
        | Radio

    type [<StringEnum>] [<RequireQualifiedAccess>] MouseInputEventButton =
        | Left
        | Middle
        | Right

    type [<StringEnum>] [<RequireQualifiedAccess>] MouseInputEventType =
        | MouseDown
        | MouseUp
        | MouseEnter
        | MouseLeave
        | ContextMenu
        | MouseWheel
        | MouseMove

    type [<StringEnum>] [<RequireQualifiedAccess>] NativeThemeThemeSource =
        | System
        | Light
        | Dark

    type [<StringEnum>] [<RequireQualifiedAccess>] NewWindowEventDisposition =
        | Default
        | [<CompiledName "foreground-tab">] ForegroundTab
        | [<CompiledName "background-tab">] BackgroundTab
        | [<CompiledName "new-window">] NewWindow
        | [<CompiledName "save-to-disk">] SaveToDisk
        | Other

    type [<StringEnum>] [<RequireQualifiedAccess>] NotificationTimeoutType =
        | Default
        | Never

    type [<StringEnum>] [<RequireQualifiedAccess>] NotificationUrgency =
        | Normal
        | Critical
        | Low

    type [<StringEnum>] [<RequireQualifiedAccess>] ProcessMetricIntegrityLevel =
        | Untrusted
        | Low
        | Medium
        | High
        | Unknown

    type [<StringEnum>] [<RequireQualifiedAccess>] ProcessMetricType =
        | [<CompiledName "Browser">] Browser
        | [<CompiledName "Tab">] Tab
        | [<CompiledName "Utility">] Utility
        | [<CompiledName "Zygote">] Zygote
        | [<CompiledName "Sandbox helper">] ``Sandbox helper``
        | [<CompiledName "GPU">] GPU
        | [<CompiledName "Pepper Plugin">] ``Pepper Plugin``
        | [<CompiledName "Pepper Plugin Broker">] ``Pepper Plugin Broker``
        | [<CompiledName "Unknown">] Unknown

    type [<StringEnum>] [<RequireQualifiedAccess>] ReferrerPolicy =
        | Default
        | [<CompiledName "unsafe-url">] UnsafeUrl
        | [<CompiledName "no-referrer-when-downgrade">] NoReferrerWhenDowngrade
        | [<CompiledName "no-referrer">] NoReferrer
        | Origin
        | [<CompiledName "strict-origin-when-cross-origin">] StrictOriginWhenCrossOrigin
        | [<CompiledName "same-origin">] SameOrigin
        | [<CompiledName "strict-origin">] StrictOrigin

    type [<StringEnum>] [<RequireQualifiedAccess>] RemovePasswordScheme =
        | Basic
        | Digest
        | Ntlm
        | Negotiate

    type [<StringEnum>] [<RequireQualifiedAccess>] SystemPreferencesSetAppLevelAppearance =
        | Dark
        | Light

    type [<StringEnum>] [<RequireQualifiedAccess>] SystemPreferencesAppLevelAppearance =
        | Dark
        | Light
        | Unknown

    type [<StringEnum>] [<RequireQualifiedAccess>] TouchBarScrubberMode =
        | Fixed
        | Free

    type [<StringEnum>] [<RequireQualifiedAccess>] TouchBarScrubberOverlayStyle =
        | Background
        | Outline
        | None

    type [<StringEnum>] [<RequireQualifiedAccess>] TraceConfigRecording_mode =
        | [<CompiledName "record-until-full">] RecordUntilFull
        | [<CompiledName "record-continuously">] RecordContinuously
        | [<CompiledName "record-as-much-as-possible">] RecordAsMuchAsPossible
        | [<CompiledName "trace-to-console">] TraceToConsole

    type [<StringEnum>] [<RequireQualifiedAccess>] TransactionTransactionState =
        | Purchasing
        | Purchased
        | Failed
        | Restored
        | Deferred

    type [<StringEnum>] [<RequireQualifiedAccess>] WebContentsOn_zoomChanged =
        | In
        | Out

    type [<StringEnum>] [<RequireQualifiedAccess>] BrowserWindowConstructorOptionsTitleBarStyle =
        | Default
        | Hidden
        | HiddenInset
        | CustomButtonsOnHover

    type [<StringEnum>] [<RequireQualifiedAccess>] ContextMenuParamsMediaType =
        | None
        | Image
        | Audio
        | Video
        | Canvas
        | File
        | Plugin

    type [<StringEnum>] [<RequireQualifiedAccess>] ContextMenuParamsMenuSourceType =
        | None
        | Mouse
        | Keyboard
        | Touch
        | TouchMenu

    type [<StringEnum>] [<RequireQualifiedAccess>] DetailsReason =
        | [<CompiledName "clean-exit">] CleanExit
        | [<CompiledName "abnormal-exit">] AbnormalExit
        | Killed
        | Crashed
        | Oom
        | [<CompiledName "launch-failed">] LaunchFailed
        | [<CompiledName "integrity-failure">] IntegrityFailure

    type [<StringEnum>] [<RequireQualifiedAccess>] DisplayBalloonOptionsIconType =
        | None
        | Info
        | Warning
        | Error
        | Custom

    type [<StringEnum>] [<RequireQualifiedAccess>] FileIconOptionsSize =
        | Small
        | Normal
        | Large

    type [<StringEnum>] [<RequireQualifiedAccess>] MessageDetailsSource =
        | Javascript
        | Xml
        | Network
        | [<CompiledName "console-api">] ConsoleApi
        | Storage
        | [<CompiledName "app-cache">] AppCache
        | Rendering
        | Security
        | Deprecation
        | Worker
        | Violation
        | Intervention
        | Recommendation
        | Other

    type [<StringEnum>] [<RequireQualifiedAccess>] MoveToApplicationsFolderOptionsConflictHandler =
        | Exists
        | ExistsAndRunning

    type [<StringEnum>] [<RequireQualifiedAccess>] OpenDevToolsOptionsMode =
        | Right
        | Bottom
        | Undocked
        | Detach

    type [<StringEnum>] [<RequireQualifiedAccess>] OpenDialogOptionsPropertiesArray =
        | OpenFile
        | OpenDirectory
        | MultiSelections
        | ShowHiddenFiles
        | CreateDirectory
        | PromptToCreate
        | NoResolveAliases
        | TreatPackageAsDirectory
        | DontAddToRecent

    type [<StringEnum>] [<RequireQualifiedAccess>] ParametersScreenPosition =
        | Desktop
        | Mobile

    type [<StringEnum>] [<RequireQualifiedAccess>] PermissionCheckHandlerHandlerDetailsMediaType =
        | Video
        | Audio
        | Unknown

    type [<StringEnum>] [<RequireQualifiedAccess>] PermissionRequestHandlerHandlerDetailsMediaTypesArray =
        | Video
        | Audio

    type [<StringEnum>] [<RequireQualifiedAccess>] ProgressBarOptionsMode =
        | None
        | Normal
        | Indeterminate
        | Error
        | Paused

    type [<StringEnum>] [<RequireQualifiedAccess>] SaveDialogOptionsPropertiesArray =
        | ShowHiddenFiles
        | CreateDirectory
        | TreatPackageAsDirectory
        | ShowOverwriteConfirmation
        | DontAddToRecent

    type [<StringEnum>] [<RequireQualifiedAccess>] StartLoggingOptionsCaptureMode =
        | Default
        | IncludeSensitive
        | Everything

    type [<StringEnum>] [<RequireQualifiedAccess>] TouchBarButtonConstructorOptionsIconPosition =
        | Left
        | Right
        | Overlay

    type [<StringEnum>] [<RequireQualifiedAccess>] TouchBarSegmentedControlConstructorOptionsSegmentStyle =
        | Automatic
        | Rounded
        | [<CompiledName "textured-rounded">] TexturedRounded
        | [<CompiledName "round-rect">] RoundRect
        | [<CompiledName "textured-square">] TexturedSquare
        | Capsule
        | [<CompiledName "small-square">] SmallSquare
        | Separated

    type [<StringEnum>] [<RequireQualifiedAccess>] TouchBarSegmentedControlConstructorOptionsMode =
        | Single
        | Multiple
        | Buttons

    type [<StringEnum>] [<RequireQualifiedAccess>] TouchBarSpacerConstructorOptionsSize =
        | Small
        | Large
        | Flexible

    type [<StringEnum>] [<RequireQualifiedAccess>] WebContentsPrintOptionsDuplexMode =
        | Simplex
        | ShortEdge
        | LongEdge

    type [<StringEnum>] [<RequireQualifiedAccess>] MarginsMarginType =
        | Default
        | None
        | PrintableArea
        | Custom

    type [<StringEnum>] [<RequireQualifiedAccess>] WebPreferencesAutoplayPolicy =
        | [<CompiledName "no-user-gesture-required">] NoUserGestureRequired
        | [<CompiledName "user-gesture-required">] UserGestureRequired
        | [<CompiledName "document-user-activation-required">] DocumentUserActivationRequired

    type [<StringEnum>] [<RequireQualifiedAccess>] WebPreferencesV8CacheOptions =
        | None
        | Code
        | BypassHeatCheck
        | BypassHeatCheckAndEagerCompile

type [<AllowNullLiteral>] NodeRequireFunction =
    [<Emit "$0.Invoke('electron')">] abstract Invoke_electron: unit -> obj

type [<AllowNullLiteral>] File =
    /// The real path to the file on the users filesystem
    abstract path: string with get, set

type [<AllowNullLiteral>] Document =
    [<Emit "$0.createElement('webview')">] abstract createElement_webview: unit -> Electron.WebviewTag

module NodeJS =

    type [<AllowNullLiteral>] Process =
        inherit NodeJS.EventEmitter
        /// Emitted when Electron has loaded its internal initialization script and is
        /// beginning to load the web page or the main script.
        /// 
        /// It can be used by the preload script to add removed Node global symbols back to
        /// the global scope when node integration is turned off:
        [<Emit "$0.on('loaded',$1)">] abstract on_loaded: listener: Function -> Process
        [<Emit "$0.once('loaded',$1)">] abstract once_loaded: listener: Function -> Process
        [<Emit "$0.addListener('loaded',$1)">] abstract addListener_loaded: listener: Function -> Process
        [<Emit "$0.removeListener('loaded',$1)">] abstract removeListener_loaded: listener: Function -> Process
        /// Causes the main thread of the current process crash.
        abstract crash: unit -> unit
        /// <summary>
        /// * <c>allocated</c> Integer - Size of all allocated objects in Kilobytes.
        /// * <c>marked</c> Integer - Size of all marked objects in Kilobytes.
        /// * <c>total</c> Integer - Total allocated space in Kilobytes.
        /// 
        /// Returns an object with Blink memory information. It can be useful for debugging
        /// rendering / DOM related memory issues. Note that all values are reported in
        /// Kilobytes.
        /// </summary>
        abstract getBlinkMemoryInfo: unit -> Electron.BlinkMemoryInfo
        abstract getCPUUsage: unit -> Electron.CPUUsage
        /// <summary>
        /// The number of milliseconds since epoch, or <c>null</c> if the information is
        /// unavailable
        /// 
        /// Indicates the creation time of the application. The time is represented as
        /// number of milliseconds since epoch. It returns null if it is unable to get the
        /// process creation time.
        /// </summary>
        abstract getCreationTime: unit -> float option
        /// <summary>
        /// * <c>totalHeapSize</c> Integer
        /// * <c>totalHeapSizeExecutable</c> Integer
        /// * <c>totalPhysicalSize</c> Integer
        /// * <c>totalAvailableSize</c> Integer
        /// * <c>usedHeapSize</c> Integer
        /// * <c>heapSizeLimit</c> Integer
        /// * <c>mallocedMemory</c> Integer
        /// * <c>peakMallocedMemory</c> Integer
        /// * <c>doesZapGarbage</c> Boolean
        /// 
        /// Returns an object with V8 heap statistics. Note that all statistics are reported
        /// in Kilobytes.
        /// </summary>
        abstract getHeapStatistics: unit -> Electron.HeapStatistics
        abstract getIOCounters: unit -> Electron.IOCounters
        /// <summary>
        /// Resolves with a ProcessMemoryInfo
        /// 
        /// Returns an object giving memory usage statistics about the current process. Note
        /// that all statistics are reported in Kilobytes. This api should be called after
        /// app ready.
        /// 
        /// Chromium does not provide <c>residentSet</c> value for macOS. This is because macOS
        /// performs in-memory compression of pages that haven't been recently used. As a
        /// result the resident set size value is not what one would expect. <c>private</c>
        /// memory is more representative of the actual pre-compression memory usage of the
        /// process on macOS.
        /// </summary>
        abstract getProcessMemoryInfo: unit -> Promise<Electron.ProcessMemoryInfo>
        /// <summary>
        /// * <c>total</c> Integer - The total amount of physical memory in Kilobytes available
        /// to the system.
        /// * <c>free</c> Integer - The total amount of memory not being used by applications or
        /// disk cache.
        /// * <c>swapTotal</c> Integer _Windows_ _Linux_ - The total amount of swap memory in
        /// Kilobytes available to the system.
        /// * <c>swapFree</c> Integer _Windows_ _Linux_ - The free amount of swap memory in
        /// Kilobytes available to the system.
        /// 
        /// Returns an object giving memory usage statistics about the entire system. Note
        /// that all statistics are reported in Kilobytes.
        /// </summary>
        abstract getSystemMemoryInfo: unit -> Electron.SystemMemoryInfo
        /// <summary>
        /// The version of the host operating system.
        /// 
        /// Example:
        /// 
        /// **Note:** It returns the actual operating system version instead of kernel
        /// version on macOS unlike <c>os.release()</c>.
        /// </summary>
        abstract getSystemVersion: unit -> string
        /// Causes the main thread of the current process hang.
        abstract hang: unit -> unit
        /// <summary>
        /// Sets the file descriptor soft limit to <c>maxDescriptors</c> or the OS hard limit,
        /// whichever is lower for the current process.
        /// </summary>
        abstract setFdLimit: maxDescriptors: float -> unit
        /// <summary>
        /// Indicates whether the snapshot has been created successfully.
        /// 
        /// Takes a V8 heap snapshot and saves it to <c>filePath</c>.
        /// </summary>
        abstract takeHeapSnapshot: filePath: string -> bool
        /// <summary>A <c>String</c> representing Chrome's version string.</summary>
        abstract chrome: string
        /// <summary>
        /// A <c>Boolean</c>. When app is started by being passed as parameter to the default
        /// app, this property is <c>true</c> in the main process, otherwise it is <c>undefined</c>.
        /// </summary>
        abstract defaultApp: bool
        /// <summary>A <c>String</c> representing Electron's version string.</summary>
        abstract electron: string
        /// <summary>
        /// A <c>Boolean</c>, <c>true</c> when the current renderer context is the "main" renderer
        /// frame. If you want the ID of the current frame you should use
        /// <c>webFrame.routingId</c>.
        /// </summary>
        abstract isMainFrame: bool
        /// <summary>
        /// A <c>Boolean</c>. For Mac App Store build, this property is <c>true</c>, for other builds
        /// it is <c>undefined</c>.
        /// </summary>
        abstract mas: bool
        /// <summary>
        /// A <c>Boolean</c> that controls ASAR support inside your application. Setting this to
        /// <c>true</c> will disable the support for <c>asar</c> archives in Node's built-in modules.
        /// </summary>
        abstract noAsar: bool with get, set
        /// <summary>
        /// A <c>Boolean</c> that controls whether or not deprecation warnings are printed to
        /// <c>stderr</c>. Setting this to <c>true</c> will silence deprecation warnings. This
        /// property is used instead of the <c>--no-deprecation</c> command line flag.
        /// </summary>
        abstract noDeprecation: bool with get, set
        /// <summary>A <c>String</c> representing the path to the resources directory.</summary>
        abstract resourcesPath: string
        /// <summary>
        /// A <c>Boolean</c>. When the renderer process is sandboxed, this property is <c>true</c>,
        /// otherwise it is <c>undefined</c>.
        /// </summary>
        abstract sandboxed: bool
        /// <summary>
        /// A <c>Boolean</c> that controls whether or not deprecation warnings will be thrown as
        /// exceptions. Setting this to <c>true</c> will throw errors for deprecations. This
        /// property is used instead of the <c>--throw-deprecation</c> command line flag.
        /// </summary>
        abstract throwDeprecation: bool with get, set
        /// <summary>
        /// A <c>Boolean</c> that controls whether or not deprecations printed to <c>stderr</c>
        /// include their stack trace. Setting this to <c>true</c> will print stack traces for
        /// deprecations. This property is instead of the <c>--trace-deprecation</c> command line
        /// flag.
        /// </summary>
        abstract traceDeprecation: bool with get, set
        /// <summary>
        /// A <c>Boolean</c> that controls whether or not process warnings printed to <c>stderr</c>
        /// include their stack trace. Setting this to <c>true</c> will print stack traces for
        /// process warnings (including deprecations). This property is instead of the
        /// <c>--trace-warnings</c> command line flag.
        /// </summary>
        abstract traceProcessWarnings: bool with get, set
        /// <summary>
        /// A <c>String</c> representing the current process's type, can be <c>"browser"</c> (i.e.
        /// main process), <c>"renderer"</c>, or <c>"worker"</c> (i.e. web worker).
        /// </summary>
        abstract ``type``: string
        /// <summary>
        /// A <c>Boolean</c>. If the app is running as a Windows Store app (appx), this property
        /// is <c>true</c>, for otherwise it is <c>undefined</c>.
        /// </summary>
        abstract windowsStore: bool

    type [<AllowNullLiteral>] ProcessVersions =
        abstract electron: string
        abstract chrome: string
