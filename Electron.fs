// ts2fable 0.0.0
module rec Electron
open System
open Fable.Core
open Fable.Core.JS
open Browser.Types

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
        abstract NativeImage: NativeImageStatic
        abstract Notification: NotificationStatic
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
        [<Emit "new $0($1...)">] abstract Create: unit -> Accelerator

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
        /// Emitted when Chrome's accessibility support changes. This event fires when
        /// assistive technologies, such as screen readers, are enabled or disabled. See
        /// https://www.chromium.org/developers/design-documents/accessibility for more
        /// details.
        [<Emit "$0.on('accessibility-support-changed',$1)">] abstract ``on_accessibility-support-changed``: listener: (Event -> bool -> unit) -> App
        [<Emit "$0.once('accessibility-support-changed',$1)">] abstract ``once_accessibility-support-changed``: listener: (Event -> bool -> unit) -> App
        [<Emit "$0.addListener('accessibility-support-changed',$1)">] abstract ``addListener_accessibility-support-changed``: listener: (Event -> bool -> unit) -> App
        [<Emit "$0.removeListener('accessibility-support-changed',$1)">] abstract ``removeListener_accessibility-support-changed``: listener: (Event -> bool -> unit) -> App
        /// Emitted when the application is activated. Various actions can trigger this
        /// event, such as launching the application for the first time, attempting to
        /// re-launch the application when it's already running, or clicking on the
        /// application's dock or taskbar icon.
        [<Emit "$0.on('activate',$1)">] abstract on_activate: listener: (Event -> bool -> unit) -> App
        [<Emit "$0.once('activate',$1)">] abstract once_activate: listener: (Event -> bool -> unit) -> App
        [<Emit "$0.addListener('activate',$1)">] abstract addListener_activate: listener: (Event -> bool -> unit) -> App
        [<Emit "$0.removeListener('activate',$1)">] abstract removeListener_activate: listener: (Event -> bool -> unit) -> App
        /// Emitted during Handoff after an activity from this device was successfully
        /// resumed on another one.
        [<Emit "$0.on('activity-was-continued',$1)">] abstract ``on_activity-was-continued``: listener: (Event -> string -> obj -> unit) -> App
        [<Emit "$0.once('activity-was-continued',$1)">] abstract ``once_activity-was-continued``: listener: (Event -> string -> obj -> unit) -> App
        [<Emit "$0.addListener('activity-was-continued',$1)">] abstract ``addListener_activity-was-continued``: listener: (Event -> string -> obj -> unit) -> App
        [<Emit "$0.removeListener('activity-was-continued',$1)">] abstract ``removeListener_activity-was-continued``: listener: (Event -> string -> obj -> unit) -> App
        /// Emitted before the application starts closing its windows. Calling
        /// `event.preventDefault()` will prevent the default behavior, which is terminating
        /// the application.
        /// 
        /// **Note:** If application quit was initiated by `autoUpdater.quitAndInstall()`,
        /// then `before-quit` is emitted *after* emitting `close` event on all windows and
        /// closing them.
        /// 
        /// **Note:** On Windows, this event will not be emitted if the app is closed due to
        /// a shutdown/restart of the system or a user logout.
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
        /// Emitted when failed to verify the `certificate` for `url`, to trust the
        /// certificate you should prevent the default behavior with
        /// `event.preventDefault()` and call `callback(true)`.
        [<Emit "$0.on('certificate-error',$1)">] abstract ``on_certificate-error``: listener: (Event -> WebContents -> string -> string -> Certificate -> (bool -> unit) -> unit) -> App
        [<Emit "$0.once('certificate-error',$1)">] abstract ``once_certificate-error``: listener: (Event -> WebContents -> string -> string -> Certificate -> (bool -> unit) -> unit) -> App
        [<Emit "$0.addListener('certificate-error',$1)">] abstract ``addListener_certificate-error``: listener: (Event -> WebContents -> string -> string -> Certificate -> (bool -> unit) -> unit) -> App
        [<Emit "$0.removeListener('certificate-error',$1)">] abstract ``removeListener_certificate-error``: listener: (Event -> WebContents -> string -> string -> Certificate -> (bool -> unit) -> unit) -> App
        /// Emitted during Handoff when an activity from a different device wants to be
        /// resumed. You should call `event.preventDefault()` if you want to handle this
        /// event.
        /// 
        /// A user activity can be continued only in an app that has the same developer Team
        /// ID as the activity's source app and that supports the activity's type. Supported
        /// activity types are specified in the app's `Info.plist` under the
        /// `NSUserActivityTypes` key.
        [<Emit "$0.on('continue-activity',$1)">] abstract ``on_continue-activity``: listener: (Event -> string -> obj -> unit) -> App
        [<Emit "$0.once('continue-activity',$1)">] abstract ``once_continue-activity``: listener: (Event -> string -> obj -> unit) -> App
        [<Emit "$0.addListener('continue-activity',$1)">] abstract ``addListener_continue-activity``: listener: (Event -> string -> obj -> unit) -> App
        [<Emit "$0.removeListener('continue-activity',$1)">] abstract ``removeListener_continue-activity``: listener: (Event -> string -> obj -> unit) -> App
        /// Emitted during Handoff when an activity from a different device fails to be
        /// resumed.
        [<Emit "$0.on('continue-activity-error',$1)">] abstract ``on_continue-activity-error``: listener: (Event -> string -> string -> unit) -> App
        [<Emit "$0.once('continue-activity-error',$1)">] abstract ``once_continue-activity-error``: listener: (Event -> string -> string -> unit) -> App
        [<Emit "$0.addListener('continue-activity-error',$1)">] abstract ``addListener_continue-activity-error``: listener: (Event -> string -> string -> unit) -> App
        [<Emit "$0.removeListener('continue-activity-error',$1)">] abstract ``removeListener_continue-activity-error``: listener: (Event -> string -> string -> unit) -> App
        /// Emitted when `desktopCapturer.getSources()` is called in the renderer process of
        /// `webContents`. Calling `event.preventDefault()` will make it return empty
        /// sources.
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
        /// Emitted when `webContents` wants to do basic auth.
        /// 
        /// The default behavior is to cancel all authentications. To override this you
        /// should prevent the default behavior with `event.preventDefault()` and call
        /// `callback(username, password)` with the credentials.
        /// 
        /// If `callback` is called without a username or password, the authentication
        /// request will be cancelled and the authentication error will be returned to the
        /// page.
        [<Emit "$0.on('login',$1)">] abstract on_login: listener: (Event -> WebContents -> AuthenticationResponseDetails -> AuthInfo -> (string -> string -> unit) -> unit) -> App
        [<Emit "$0.once('login',$1)">] abstract once_login: listener: (Event -> WebContents -> AuthenticationResponseDetails -> AuthInfo -> (string -> string -> unit) -> unit) -> App
        [<Emit "$0.addListener('login',$1)">] abstract addListener_login: listener: (Event -> WebContents -> AuthenticationResponseDetails -> AuthInfo -> (string -> string -> unit) -> unit) -> App
        [<Emit "$0.removeListener('login',$1)">] abstract removeListener_login: listener: (Event -> WebContents -> AuthenticationResponseDetails -> AuthInfo -> (string -> string -> unit) -> unit) -> App
        /// Emitted when the user clicks the native macOS new tab button. The new tab button
        /// is only visible if the current `BrowserWindow` has a `tabbingIdentifier`
        [<Emit "$0.on('new-window-for-tab',$1)">] abstract ``on_new-window-for-tab``: listener: (Event -> unit) -> App
        [<Emit "$0.once('new-window-for-tab',$1)">] abstract ``once_new-window-for-tab``: listener: (Event -> unit) -> App
        [<Emit "$0.addListener('new-window-for-tab',$1)">] abstract ``addListener_new-window-for-tab``: listener: (Event -> unit) -> App
        [<Emit "$0.removeListener('new-window-for-tab',$1)">] abstract ``removeListener_new-window-for-tab``: listener: (Event -> unit) -> App
        /// Emitted when the user wants to open a file with the application. The `open-file`
        /// event is usually emitted when the application is already open and the OS wants
        /// to reuse the application to open the file. `open-file` is also emitted when a
        /// file is dropped onto the dock and the application is not yet running. Make sure
        /// to listen for the `open-file` event very early in your application startup to
        /// handle this case (even before the `ready` event is emitted).
        /// 
        /// You should call `event.preventDefault()` if you want to handle this event.
        /// 
        /// On Windows, you have to parse `process.argv` (in the main process) to get the
        /// filepath.
        [<Emit "$0.on('open-file',$1)">] abstract ``on_open-file``: listener: (Event -> string -> unit) -> App
        [<Emit "$0.once('open-file',$1)">] abstract ``once_open-file``: listener: (Event -> string -> unit) -> App
        [<Emit "$0.addListener('open-file',$1)">] abstract ``addListener_open-file``: listener: (Event -> string -> unit) -> App
        [<Emit "$0.removeListener('open-file',$1)">] abstract ``removeListener_open-file``: listener: (Event -> string -> unit) -> App
        /// Emitted when the user wants to open a URL with the application. Your
        /// application's `Info.plist` file must define the URL scheme within the
        /// `CFBundleURLTypes` key, and set `NSPrincipalClass` to `AtomApplication`.
        /// 
        /// You should call `event.preventDefault()` if you want to handle this event.
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
        /// Emitted when Electron has finished initializing. On macOS, `launchInfo` holds
        /// the `userInfo` of the `NSUserNotification` that was used to open the
        /// application, if it was launched from Notification Center. You can call
        /// `app.isReady()` to check if this event has already fired.
        [<Emit "$0.on('ready',$1)">] abstract on_ready: listener: (obj -> unit) -> App
        [<Emit "$0.once('ready',$1)">] abstract once_ready: listener: (obj -> unit) -> App
        [<Emit "$0.addListener('ready',$1)">] abstract addListener_ready: listener: (obj -> unit) -> App
        [<Emit "$0.removeListener('ready',$1)">] abstract removeListener_ready: listener: (obj -> unit) -> App
        /// Emitted when `remote.getBuiltin()` is called in the renderer process of
        /// `webContents`. Calling `event.preventDefault()` will prevent the module from
        /// being returned. Custom value can be returned by setting `event.returnValue`.
        [<Emit "$0.on('remote-get-builtin',$1)">] abstract ``on_remote-get-builtin``: listener: (Event -> WebContents -> string -> unit) -> App
        [<Emit "$0.once('remote-get-builtin',$1)">] abstract ``once_remote-get-builtin``: listener: (Event -> WebContents -> string -> unit) -> App
        [<Emit "$0.addListener('remote-get-builtin',$1)">] abstract ``addListener_remote-get-builtin``: listener: (Event -> WebContents -> string -> unit) -> App
        [<Emit "$0.removeListener('remote-get-builtin',$1)">] abstract ``removeListener_remote-get-builtin``: listener: (Event -> WebContents -> string -> unit) -> App
        /// Emitted when `remote.getCurrentWebContents()` is called in the renderer process
        /// of `webContents`. Calling `event.preventDefault()` will prevent the object from
        /// being returned. Custom value can be returned by setting `event.returnValue`.
        [<Emit "$0.on('remote-get-current-web-contents',$1)">] abstract ``on_remote-get-current-web-contents``: listener: (Event -> WebContents -> unit) -> App
        [<Emit "$0.once('remote-get-current-web-contents',$1)">] abstract ``once_remote-get-current-web-contents``: listener: (Event -> WebContents -> unit) -> App
        [<Emit "$0.addListener('remote-get-current-web-contents',$1)">] abstract ``addListener_remote-get-current-web-contents``: listener: (Event -> WebContents -> unit) -> App
        [<Emit "$0.removeListener('remote-get-current-web-contents',$1)">] abstract ``removeListener_remote-get-current-web-contents``: listener: (Event -> WebContents -> unit) -> App
        /// Emitted when `remote.getCurrentWindow()` is called in the renderer process of
        /// `webContents`. Calling `event.preventDefault()` will prevent the object from
        /// being returned. Custom value can be returned by setting `event.returnValue`.
        [<Emit "$0.on('remote-get-current-window',$1)">] abstract ``on_remote-get-current-window``: listener: (Event -> WebContents -> unit) -> App
        [<Emit "$0.once('remote-get-current-window',$1)">] abstract ``once_remote-get-current-window``: listener: (Event -> WebContents -> unit) -> App
        [<Emit "$0.addListener('remote-get-current-window',$1)">] abstract ``addListener_remote-get-current-window``: listener: (Event -> WebContents -> unit) -> App
        [<Emit "$0.removeListener('remote-get-current-window',$1)">] abstract ``removeListener_remote-get-current-window``: listener: (Event -> WebContents -> unit) -> App
        /// Emitted when `remote.getGlobal()` is called in the renderer process of
        /// `webContents`. Calling `event.preventDefault()` will prevent the global from
        /// being returned. Custom value can be returned by setting `event.returnValue`.
        [<Emit "$0.on('remote-get-global',$1)">] abstract ``on_remote-get-global``: listener: (Event -> WebContents -> string -> unit) -> App
        [<Emit "$0.once('remote-get-global',$1)">] abstract ``once_remote-get-global``: listener: (Event -> WebContents -> string -> unit) -> App
        [<Emit "$0.addListener('remote-get-global',$1)">] abstract ``addListener_remote-get-global``: listener: (Event -> WebContents -> string -> unit) -> App
        [<Emit "$0.removeListener('remote-get-global',$1)">] abstract ``removeListener_remote-get-global``: listener: (Event -> WebContents -> string -> unit) -> App
        /// Emitted when `<webview>.getWebContents()` is called in the renderer process of
        /// `webContents`. Calling `event.preventDefault()` will prevent the object from
        /// being returned. Custom value can be returned by setting `event.returnValue`.
        [<Emit "$0.on('remote-get-guest-web-contents',$1)">] abstract ``on_remote-get-guest-web-contents``: listener: (Event -> WebContents -> WebContents -> unit) -> App
        [<Emit "$0.once('remote-get-guest-web-contents',$1)">] abstract ``once_remote-get-guest-web-contents``: listener: (Event -> WebContents -> WebContents -> unit) -> App
        [<Emit "$0.addListener('remote-get-guest-web-contents',$1)">] abstract ``addListener_remote-get-guest-web-contents``: listener: (Event -> WebContents -> WebContents -> unit) -> App
        [<Emit "$0.removeListener('remote-get-guest-web-contents',$1)">] abstract ``removeListener_remote-get-guest-web-contents``: listener: (Event -> WebContents -> WebContents -> unit) -> App
        /// Emitted when `remote.require()` is called in the renderer process of
        /// `webContents`. Calling `event.preventDefault()` will prevent the module from
        /// being returned. Custom value can be returned by setting `event.returnValue`.
        [<Emit "$0.on('remote-require',$1)">] abstract ``on_remote-require``: listener: (Event -> WebContents -> string -> unit) -> App
        [<Emit "$0.once('remote-require',$1)">] abstract ``once_remote-require``: listener: (Event -> WebContents -> string -> unit) -> App
        [<Emit "$0.addListener('remote-require',$1)">] abstract ``addListener_remote-require``: listener: (Event -> WebContents -> string -> unit) -> App
        [<Emit "$0.removeListener('remote-require',$1)">] abstract ``removeListener_remote-require``: listener: (Event -> WebContents -> string -> unit) -> App
        /// Emitted when the renderer process of `webContents` crashes or is killed.
        [<Emit "$0.on('renderer-process-crashed',$1)">] abstract ``on_renderer-process-crashed``: listener: (Event -> WebContents -> bool -> unit) -> App
        [<Emit "$0.once('renderer-process-crashed',$1)">] abstract ``once_renderer-process-crashed``: listener: (Event -> WebContents -> bool -> unit) -> App
        [<Emit "$0.addListener('renderer-process-crashed',$1)">] abstract ``addListener_renderer-process-crashed``: listener: (Event -> WebContents -> bool -> unit) -> App
        [<Emit "$0.removeListener('renderer-process-crashed',$1)">] abstract ``removeListener_renderer-process-crashed``: listener: (Event -> WebContents -> bool -> unit) -> App
        /// This event will be emitted inside the primary instance of your application when
        /// a second instance has been executed and calls `app.requestSingleInstanceLock()`.
        /// 
        /// `argv` is an Array of the second instance's command line arguments, and
        /// `workingDirectory` is its current working directory. Usually applications
        /// respond to this by making their primary window focused and non-minimized.
        /// 
        /// This event is guaranteed to be emitted after the `ready` event of `app` gets
        /// emitted.
        /// 
        /// **Note:** Extra command line arguments might be added by Chromium, such as
        /// `--original-process-start-time`.
        [<Emit "$0.on('second-instance',$1)">] abstract ``on_second-instance``: listener: (Event -> ResizeArray<string> -> string -> unit) -> App
        [<Emit "$0.once('second-instance',$1)">] abstract ``once_second-instance``: listener: (Event -> ResizeArray<string> -> string -> unit) -> App
        [<Emit "$0.addListener('second-instance',$1)">] abstract ``addListener_second-instance``: listener: (Event -> ResizeArray<string> -> string -> unit) -> App
        [<Emit "$0.removeListener('second-instance',$1)">] abstract ``removeListener_second-instance``: listener: (Event -> ResizeArray<string> -> string -> unit) -> App
        /// Emitted when a client certificate is requested.
        /// 
        /// The `url` corresponds to the navigation entry requesting the client certificate
        /// and `callback` can be called with an entry filtered from the list. Using
        /// `event.preventDefault()` prevents the application from using the first
        /// certificate from the store.
        [<Emit "$0.on('select-client-certificate',$1)">] abstract ``on_select-client-certificate``: listener: (Event -> WebContents -> string -> ResizeArray<Certificate> -> (Certificate -> unit) -> unit) -> App
        [<Emit "$0.once('select-client-certificate',$1)">] abstract ``once_select-client-certificate``: listener: (Event -> WebContents -> string -> ResizeArray<Certificate> -> (Certificate -> unit) -> unit) -> App
        [<Emit "$0.addListener('select-client-certificate',$1)">] abstract ``addListener_select-client-certificate``: listener: (Event -> WebContents -> string -> ResizeArray<Certificate> -> (Certificate -> unit) -> unit) -> App
        [<Emit "$0.removeListener('select-client-certificate',$1)">] abstract ``removeListener_select-client-certificate``: listener: (Event -> WebContents -> string -> ResizeArray<Certificate> -> (Certificate -> unit) -> unit) -> App
        /// Emitted when Electron has created a new `session`.
        [<Emit "$0.on('session-created',$1)">] abstract ``on_session-created``: listener: (Session -> unit) -> App
        [<Emit "$0.once('session-created',$1)">] abstract ``once_session-created``: listener: (Session -> unit) -> App
        [<Emit "$0.addListener('session-created',$1)">] abstract ``addListener_session-created``: listener: (Session -> unit) -> App
        [<Emit "$0.removeListener('session-created',$1)">] abstract ``removeListener_session-created``: listener: (Session -> unit) -> App
        /// Emitted when Handoff is about to be resumed on another device. If you need to
        /// update the state to be transferred, you should call `event.preventDefault()`
        /// immediately, construct a new `userInfo` dictionary and call
        /// `app.updateCurrentActiviy()` in a timely manner. Otherwise, the operation will
        /// fail and `continue-activity-error` will be called.
        [<Emit "$0.on('update-activity-state',$1)">] abstract ``on_update-activity-state``: listener: (Event -> string -> obj -> unit) -> App
        [<Emit "$0.once('update-activity-state',$1)">] abstract ``once_update-activity-state``: listener: (Event -> string -> obj -> unit) -> App
        [<Emit "$0.addListener('update-activity-state',$1)">] abstract ``addListener_update-activity-state``: listener: (Event -> string -> obj -> unit) -> App
        [<Emit "$0.removeListener('update-activity-state',$1)">] abstract ``removeListener_update-activity-state``: listener: (Event -> string -> obj -> unit) -> App
        /// Emitted when a new webContents is created.
        [<Emit "$0.on('web-contents-created',$1)">] abstract ``on_web-contents-created``: listener: (Event -> WebContents -> unit) -> App
        [<Emit "$0.once('web-contents-created',$1)">] abstract ``once_web-contents-created``: listener: (Event -> WebContents -> unit) -> App
        [<Emit "$0.addListener('web-contents-created',$1)">] abstract ``addListener_web-contents-created``: listener: (Event -> WebContents -> unit) -> App
        [<Emit "$0.removeListener('web-contents-created',$1)">] abstract ``removeListener_web-contents-created``: listener: (Event -> WebContents -> unit) -> App
        /// Emitted during Handoff before an activity from a different device wants to be
        /// resumed. You should call `event.preventDefault()` if you want to handle this
        /// event.
        [<Emit "$0.on('will-continue-activity',$1)">] abstract ``on_will-continue-activity``: listener: (Event -> string -> unit) -> App
        [<Emit "$0.once('will-continue-activity',$1)">] abstract ``once_will-continue-activity``: listener: (Event -> string -> unit) -> App
        [<Emit "$0.addListener('will-continue-activity',$1)">] abstract ``addListener_will-continue-activity``: listener: (Event -> string -> unit) -> App
        [<Emit "$0.removeListener('will-continue-activity',$1)">] abstract ``removeListener_will-continue-activity``: listener: (Event -> string -> unit) -> App
        /// Emitted when the application has finished basic startup. On Windows and Linux,
        /// the `will-finish-launching` event is the same as the `ready` event; on macOS,
        /// this event represents the `applicationWillFinishLaunching` notification of
        /// `NSApplication`. You would usually set up listeners for the `open-file` and
        /// `open-url` events here, and start the crash reporter and auto updater.
        /// 
        /// In most cases, you should do everything in the `ready` event handler.
        [<Emit "$0.on('will-finish-launching',$1)">] abstract ``on_will-finish-launching``: listener: Function -> App
        [<Emit "$0.once('will-finish-launching',$1)">] abstract ``once_will-finish-launching``: listener: Function -> App
        [<Emit "$0.addListener('will-finish-launching',$1)">] abstract ``addListener_will-finish-launching``: listener: Function -> App
        [<Emit "$0.removeListener('will-finish-launching',$1)">] abstract ``removeListener_will-finish-launching``: listener: Function -> App
        /// Emitted when all windows have been closed and the application will quit. Calling
        /// `event.preventDefault()` will prevent the default behaviour, which is
        /// terminating the application.
        /// 
        /// See the description of the `window-all-closed` event for the differences between
        /// the `will-quit` and `window-all-closed` events.
        /// 
        /// **Note:** On Windows, this event will not be emitted if the app is closed due to
        /// a shutdown/restart of the system or a user logout.
        [<Emit "$0.on('will-quit',$1)">] abstract ``on_will-quit``: listener: (Event -> unit) -> App
        [<Emit "$0.once('will-quit',$1)">] abstract ``once_will-quit``: listener: (Event -> unit) -> App
        [<Emit "$0.addListener('will-quit',$1)">] abstract ``addListener_will-quit``: listener: (Event -> unit) -> App
        [<Emit "$0.removeListener('will-quit',$1)">] abstract ``removeListener_will-quit``: listener: (Event -> unit) -> App
        /// Emitted when all windows have been closed.
        /// 
        /// If you do not subscribe to this event and all windows are closed, the default
        /// behavior is to quit the app; however, if you subscribe, you control whether the
        /// app quits or not. If the user pressed `Cmd + Q`, or the developer called
        /// `app.quit()`, Electron will first try to close all the windows and then emit the
        /// `will-quit` event, and in this case the `window-all-closed` event would not be
        /// emitted.
        [<Emit "$0.on('window-all-closed',$1)">] abstract ``on_window-all-closed``: listener: Function -> App
        [<Emit "$0.once('window-all-closed',$1)">] abstract ``once_window-all-closed``: listener: Function -> App
        [<Emit "$0.addListener('window-all-closed',$1)">] abstract ``addListener_window-all-closed``: listener: Function -> App
        [<Emit "$0.removeListener('window-all-closed',$1)">] abstract ``removeListener_window-all-closed``: listener: Function -> App
        /// Adds `path` to the recent documents list.
        /// 
        /// This list is managed by the OS. On Windows, you can visit the list from the task
        /// bar, and on macOS, you can visit it from dock menu.
        abstract addRecentDocument: path: string -> unit
        /// Clears the recent documents list.
        abstract clearRecentDocuments: unit -> unit
        /// By default, Chromium disables 3D APIs (e.g. WebGL) until restart on a per domain
        /// basis if the GPU processes crashes too frequently. This function disables that
        /// behaviour.
        /// 
        /// This method can only be called before app is ready.
        abstract disableDomainBlockingFor3DAPIs: unit -> unit
        /// Disables hardware acceleration for current app.
        /// 
        /// This method can only be called before app is ready.
        abstract disableHardwareAcceleration: unit -> unit
        /// Enables full sandbox mode on the app.
        /// 
        /// This method can only be called before app is ready.
        abstract enableSandbox: unit -> unit
        /// Exits immediately with `exitCode`. `exitCode` defaults to 0.
        /// 
        /// All windows will be closed immediately without asking the user, and the
        /// `before-quit` and `will-quit` events will not be emitted.
        abstract exit: ?exitCode: float -> unit
        /// On Linux, focuses on the first visible window. On macOS, makes the application
        /// the active app. On Windows, focuses on the application's first window.
        abstract focus: unit -> unit
        /// Array of `ProcessMetric` objects that correspond to memory and CPU usage
        /// statistics of all the processes associated with the app.
        abstract getAppMetrics: unit -> ResizeArray<ProcessMetric>
        /// The current application directory.
        abstract getAppPath: unit -> string
        /// The current value displayed in the counter badge.
        /// 
        /// *Deprecated**
        abstract getBadgeCount: unit -> float
        /// The type of the currently running activity.
        abstract getCurrentActivityType: unit -> string
        /// fulfilled with the app's icon, which is a NativeImage.
        /// 
        /// Fetches a path's associated icon.
        /// 
        /// On _Windows_, there a 2 kinds of icons:
        /// 
        /// * Icons associated with certain file extensions, like `.mp3`, `.png`, etc.
        /// * Icons inside the file itself, like `.exe`, `.dll`, `.ico`.
        /// 
        /// On _Linux_ and _macOS_, icons depend on the application associated with file
        /// mime type.
        abstract getFileIcon: path: string * ?options: FileIconOptions -> Promise<Electron.NativeImage>
        /// The Graphics Feature Status from `chrome://gpu/`.
        /// 
        /// **Note:** This information is only usable after the `gpu-info-update` event is
        /// emitted.
        abstract getGPUFeatureStatus: unit -> GPUFeatureStatus
        /// For `infoType` equal to `complete`: Promise is fulfilled with `Object`
        /// containing all the GPU Information as in chromium's GPUInfo object. This
        /// includes the version and driver information that's shown on `chrome://gpu` page.
        /// 
        /// For `infoType` equal to `basic`: Promise is fulfilled with `Object` containing
        /// fewer attributes than when requested with `complete`. Here's an example of basic
        /// response:
        /// 
        /// Using `basic` should be preferred if only basic information like `vendorId` or
        /// `driverId` is needed.
        abstract getGPUInfo: infoType: AppGetGPUInfoInfoType -> Promise<obj>
        /// * `minItems` Integer - The minimum number of items that will be shown in the
        /// Jump List (for a more detailed description of this value see the MSDN docs).
        /// * `removedItems` JumpListItem[] - Array of `JumpListItem` objects that
        /// correspond to items that the user has explicitly removed from custom categories
        /// in the Jump List. These items must not be re-added to the Jump List in the
        /// **next** call to `app.setJumpList()`, Windows will not display any custom
        /// category that contains any of the removed items.
        abstract getJumpListSettings: unit -> JumpListSettings
        /// The current application locale. Possible return values are documented here.
        /// 
        /// To set the locale, you'll want to use a command line switch at app startup,
        /// which may be found here.
        /// 
        /// **Note:** When distributing your packaged app, you have to also ship the
        /// `locales` folder.
        /// 
        /// **Note:** On Windows, you have to call it after the `ready` events gets emitted.
        abstract getLocale: unit -> string
        /// User operating system's locale two-letter ISO 3166 country code. The value is
        /// taken from native OS APIs.
        /// 
        /// *Note:** When unable to detect locale country code, it returns empty string.
        abstract getLocaleCountryCode: unit -> string
        /// If you provided `path` and `args` options to `app.setLoginItemSettings`, then
        /// you need to pass the same arguments here for `openAtLogin` to be set correctly.
        /// 
        /// 
        /// * `openAtLogin` Boolean - `true` if the app is set to open at login.
        /// * `openAsHidden` Boolean _macOS_ - `true` if the app is set to open as hidden at
        /// login. This setting is not available on MAS builds.
        /// * `wasOpenedAtLogin` Boolean _macOS_ - `true` if the app was opened at login
        /// automatically. This setting is not available on MAS builds.
        /// * `wasOpenedAsHidden` Boolean _macOS_ - `true` if the app was opened as a hidden
        /// login item. This indicates that the app should not open any windows at startup.
        /// This setting is not available on MAS builds.
        /// * `restoreState` Boolean _macOS_ - `true` if the app was opened as a login item
        /// that should restore the state from the previous session. This indicates that the
        /// app should restore the windows that were open the last time the app was closed.
        /// This setting is not available on MAS builds.
        abstract getLoginItemSettings: ?options: LoginItemSettingsOptions -> LoginItemSettings
        /// The current application's name, which is the name in the application's
        /// `package.json` file.
        /// 
        /// Usually the `name` field of `package.json` is a short lowercase name, according
        /// to the npm modules spec. You should usually also specify a `productName` field,
        /// which is your application's full capitalized name, and which will be preferred
        /// over `name` by Electron.
        /// 
        /// *Deprecated**
        abstract getName: unit -> string
        /// A path to a special directory or file associated with `name`. On failure, an
        /// `Error` is thrown.
        /// 
        /// If `app.getPath('logs')` is called without called `app.setAppLogsPath()` being
        /// called first, a default log directory will be created equivalent to calling
        /// `app.setAppLogsPath()` without a `path` parameter.
        abstract getPath: name: AppGetPathName -> string
        /// The version of the loaded application. If no version is found in the
        /// application's `package.json` file, the version of the current bundle or
        /// executable is returned.
        abstract getVersion: unit -> string
        /// This method returns whether or not this instance of your app is currently
        /// holding the single instance lock.  You can request the lock with
        /// `app.requestSingleInstanceLock()` and release with
        /// `app.releaseSingleInstanceLock()`
        abstract hasSingleInstanceLock: unit -> bool
        /// Hides all application windows without minimizing them.
        abstract hide: unit -> unit
        /// Imports the certificate in pkcs12 format into the platform certificate store.
        /// `callback` is called with the `result` of import operation, a value of `0`
        /// indicates success while any other value indicates failure according to Chromium
        /// net_error_list.
        abstract importCertificate: options: ImportCertificateOptions * callback: (float -> unit) -> unit
        /// Invalidates the current Handoff user activity.
        abstract invalidateCurrentActivity: unit -> unit
        /// `true` if Chrome's accessibility support is enabled, `false` otherwise. This API
        /// will return `true` if the use of assistive technologies, such as screen readers,
        /// has been detected. See
        /// https://www.chromium.org/developers/design-documents/accessibility for more
        /// details.
        /// 
        /// *Deprecated**
        abstract isAccessibilitySupportEnabled: unit -> bool
        /// Whether the current executable is the default handler for a protocol (aka URI
        /// scheme).
        /// 
        /// **Note:** On macOS, you can use this method to check if the app has been
        /// registered as the default protocol handler for a protocol. You can also verify
        /// this by checking `~/Library/Preferences/com.apple.LaunchServices.plist` on the
        /// macOS machine. Please refer to Apple's documentation for details.
        /// 
        /// The API uses the Windows Registry and `LSCopyDefaultHandlerForURLScheme`
        /// internally.
        abstract isDefaultProtocolClient: protocol: string * ?path: string * ?args: ResizeArray<string> -> bool
        /// whether or not the current OS version allows for native emoji pickers.
        abstract isEmojiPanelSupported: unit -> bool
        /// Whether the application is currently running from the systems Application
        /// folder. Use in combination with `app.moveToApplicationsFolder()`
        abstract isInApplicationsFolder: unit -> bool
        /// `true` if Electron has finished initializing, `false` otherwise.
        abstract isReady: unit -> bool
        /// Whether the current desktop environment is Unity launcher.
        abstract isUnityRunning: unit -> bool
        /// Whether the move was successful. Please note that if the move is successful,
        /// your application will quit and relaunch.
        /// 
        /// No confirmation dialog will be presented by default. If you wish to allow the
        /// user to confirm the operation, you may do so using the `dialog` API.
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
        /// conflict is resolved with default behavior.  i.e. returning `false` will ensure
        /// no further action is taken, returning `true` will result in the default behavior
        /// and the method continuing.
        /// 
        /// For example:
        /// 
        /// Would mean that if an app already exists in the user directory, if the user
        /// chooses to 'Continue Move' then the function would continue with its default
        /// behavior and the existing app will be trashed and the active app moved into its
        /// place.
        abstract moveToApplicationsFolder: ?options: MoveToApplicationsFolderOptions -> bool
        /// Try to close all windows. The `before-quit` event will be emitted first. If all
        /// windows are successfully closed, the `will-quit` event will be emitted and by
        /// default the application will terminate.
        /// 
        /// This method guarantees that all `beforeunload` and `unload` event handlers are
        /// correctly executed. It is possible that a window cancels the quitting by
        /// returning `false` in the `beforeunload` event handler.
        abstract quit: unit -> unit
        /// Relaunches the app when current instance exits.
        /// 
        /// By default, the new instance will use the same working directory and command
        /// line arguments with current instance. When `args` is specified, the `args` will
        /// be passed as command line arguments instead. When `execPath` is specified, the
        /// `execPath` will be executed for relaunch instead of current app.
        /// 
        /// Note that this method does not quit the app when executed, you have to call
        /// `app.quit` or `app.exit` after calling `app.relaunch` to make the app restart.
        /// 
        /// When `app.relaunch` is called for multiple times, multiple instances will be
        /// started after current instance exited.
        /// 
        /// An example of restarting current instance immediately and adding a new command
        /// line argument to the new instance:
        abstract relaunch: ?options: RelaunchOptions -> unit
        /// Releases all locks that were created by `requestSingleInstanceLock`. This will
        /// allow multiple instances of the application to once again run side by side.
        abstract releaseSingleInstanceLock: unit -> unit
        /// Whether the call succeeded.
        /// 
        /// This method checks if the current executable as the default handler for a
        /// protocol (aka URI scheme). If so, it will remove the app as the default handler.
        abstract removeAsDefaultProtocolClient: protocol: string * ?path: string * ?args: ResizeArray<string> -> bool
        /// The return value of this method indicates whether or not this instance of your
        /// application successfully obtained the lock.  If it failed to obtain the lock,
        /// you can assume that another instance of your application is already running with
        /// the lock and exit immediately.
        /// 
        /// I.e. This method returns `true` if your process is the primary instance of your
        /// application and your app should continue loading.  It returns `false` if your
        /// process should immediately quit as it has sent its parameters to another
        /// instance that has already acquired the lock.
        /// 
        /// On macOS, the system enforces single instance automatically when users try to
        /// open a second instance of your app in Finder, and the `open-file` and `open-url`
        /// events will be emitted for that. However when users start your app in command
        /// line, the system's single instance mechanism will be bypassed, and you have to
        /// use this method to ensure single instance.
        /// 
        /// An example of activating the window of primary instance when a second instance
        /// starts:
        abstract requestSingleInstanceLock: unit -> bool
        /// Marks the current Handoff user activity as inactive without invalidating it.
        abstract resignCurrentActivity: unit -> unit
        /// Set the about panel options. This will override the values defined in the app's
        /// `.plist` file on MacOS. See the Apple docs for more details. On Linux, values
        /// must be set in order to be shown; there are no defaults.
        /// 
        /// If you do not set `credits` but still wish to surface them in your app, AppKit
        /// will look for a file named "Credits.html", "Credits.rtf", and "Credits.rtfd", in
        /// that order, in the bundle returned by the NSBundle class method main. The first
        /// file found is used, and if none is found, the info area is left blank. See Apple
        /// documentation for more information.
        abstract setAboutPanelOptions: options: AboutPanelOptionsOptions -> unit
        /// Manually enables Chrome's accessibility support, allowing to expose
        /// accessibility switch to users in application settings. See Chromium's
        /// accessibility docs for more details. Disabled by default.
        /// 
        /// This API must be called after the `ready` event is emitted.
        /// 
        /// **Note:** Rendering accessibility tree can significantly affect the performance
        /// of your app. It should not be enabled by default.
        /// 
        /// *Deprecated**
        abstract setAccessibilitySupportEnabled: enabled: bool -> unit
        /// Sets or creates a directory your app's logs which can then be manipulated with
        /// `app.getPath()` or `app.setPath(pathName, newPath)`.
        /// 
        /// Calling `app.setAppLogsPath()` without a `path` parameter will result in this
        /// directory being set to `~/Library/Logs/YourAppName` on _macOS_, and inside the
        /// `userData` directory on _Linux_ and _Windows_.
        abstract setAppLogsPath: ?path: string -> unit
        /// Changes the Application User Model ID to `id`.
        abstract setAppUserModelId: id: string -> unit
        /// Whether the call succeeded.
        /// 
        /// Sets the current executable as the default handler for a protocol (aka URI
        /// scheme). It allows you to integrate your app deeper into the operating system.
        /// Once registered, all links with `your-protocol://` will be opened with the
        /// current executable. The whole link, including protocol, will be passed to your
        /// application as a parameter.
        /// 
        /// **Note:** On macOS, you can only register protocols that have been added to your
        /// app's `info.plist`, which cannot be modified at runtime. However, you can change
        /// the file during build time via Electron Forge, Electron Packager, or by editing
        /// `info.plist` with a text editor. Please refer to Apple's documentation for
        /// details.
        /// 
        /// **Note:** In a Windows Store environment (when packaged as an `appx`) this API
        /// will return `true` for all calls but the registry key it sets won't be
        /// accessible by other applications.  In order to register your Windows Store
        /// application as a default protocol handler you must declare the protocol in your
        /// manifest.
        /// 
        /// The API uses the Windows Registry and `LSSetDefaultHandlerForURLScheme`
        /// internally.
        abstract setAsDefaultProtocolClient: protocol: string * ?path: string * ?args: ResizeArray<string> -> bool
        /// Whether the call succeeded.
        /// 
        /// Sets the counter badge for current app. Setting the count to `0` will hide the
        /// badge.
        /// 
        /// On macOS, it shows on the dock icon. On Linux, it only works for Unity launcher.
        /// 
        /// **Note:** Unity launcher requires the existence of a `.desktop` file to work,
        /// for more information please read Desktop Environment Integration.
        /// 
        /// *Deprecated**
        abstract setBadgeCount: count: float -> bool
        /// Sets or removes a custom Jump List for the application, and returns one of the
        /// following strings:
        /// 
        /// * `ok` - Nothing went wrong.
        /// * `error` - One or more errors occurred, enable runtime logging to figure out
        /// the likely cause.
        /// * `invalidSeparatorError` - An attempt was made to add a separator to a custom
        /// category in the Jump List. Separators are only allowed in the standard `Tasks`
        /// category.
        /// * `fileTypeRegistrationError` - An attempt was made to add a file link to the
        /// Jump List for a file type the app isn't registered to handle.
        /// * `customCategoryAccessDeniedError` - Custom categories can't be added to the
        /// Jump List due to user privacy or group policy settings.
        /// 
        /// If `categories` is `null` the previously set custom Jump List (if any) will be
        /// replaced by the standard Jump List for the app (managed by Windows).
        /// 
        /// **Note:** If a `JumpListCategory` object has neither the `type` nor the `name`
        /// property set then its `type` is assumed to be `tasks`. If the `name` property is
        /// set but the `type` property is omitted then the `type` is assumed to be
        /// `custom`.
        /// 
        /// **Note:** Users can remove items from custom categories, and Windows will not
        /// allow a removed item to be added back into a custom category until **after** the
        /// next successful call to `app.setJumpList(categories)`. Any attempt to re-add a
        /// removed item to a custom category earlier than that will result in the entire
        /// custom category being omitted from the Jump List. The list of removed items can
        /// be obtained using `app.getJumpListSettings()`.
        /// 
        /// Here's a very simple example of creating a custom Jump List:
        abstract setJumpList: categories: U2<ResizeArray<JumpListCategory>, obj> -> unit
        /// Set the app's login item settings.
        /// 
        /// To work with Electron's `autoUpdater` on Windows, which uses Squirrel, you'll
        /// want to set the launch path to Update.exe, and pass arguments that specify your
        /// application name. For example:
        abstract setLoginItemSettings: settings: Settings -> unit
        /// Overrides the current application's name.
        /// 
        /// *Deprecated**
        abstract setName: name: string -> unit
        /// Overrides the `path` to a special directory or file associated with `name`. If
        /// the path specifies a directory that does not exist, an `Error` is thrown. In
        /// that case, the directory should be created with `fs.mkdirSync` or similar.
        /// 
        /// You can only override paths of a `name` defined in `app.getPath`.
        /// 
        /// By default, web pages' cookies and caches will be stored under the `userData`
        /// directory. If you want to change this location, you have to override the
        /// `userData` path before the `ready` event of the `app` module is emitted.
        abstract setPath: name: string * path: string -> unit
        /// Creates an `NSUserActivity` and sets it as the current activity. The activity is
        /// eligible for Handoff to another device afterward.
        abstract setUserActivity: ``type``: string * userInfo: obj option * ?webpageURL: string -> unit
        /// Adds `tasks` to the Tasks category of the Jump List on Windows.
        /// 
        /// `tasks` is an array of `Task` objects.
        /// 
        /// Whether the call succeeded.
        /// 
        /// **Note:** If you'd like to customize the Jump List even more use
        /// `app.setJumpList(categories)` instead.
        abstract setUserTasks: tasks: ResizeArray<Task> -> bool
        /// Shows application windows after they were hidden. Does not automatically focus
        /// them.
        abstract show: unit -> unit
        /// Show the app's about panel options. These options can be overridden with
        /// `app.setAboutPanelOptions(options)`.
        abstract showAboutPanel: unit -> unit
        /// Show the platform's native emoji picker.
        abstract showEmojiPanel: unit -> unit
        /// This function **must** be called once you have finished accessing the security
        /// scoped file. If you do not remember to stop accessing the bookmark, kernel
        /// resources will be leaked and your app will lose its ability to reach outside the
        /// sandbox completely, until your app is restarted.
        /// 
        /// Start accessing a security scoped resource. With this method Electron
        /// applications that are packaged for the Mac App Store may reach outside their
        /// sandbox to access files chosen by the user. See Apple's documentation for a
        /// description of how this system works.
        abstract startAccessingSecurityScopedResource: bookmarkData: string -> Function
        /// Updates the current activity if its type matches `type`, merging the entries
        /// from `userInfo` into its current `userInfo` dictionary.
        abstract updateCurrentActivity: ``type``: string * userInfo: obj option -> unit
        /// fulfilled when Electron is initialized. May be used as a convenient alternative
        /// to checking `app.isReady()` and subscribing to the `ready` event if the app is
        /// not ready yet.
        abstract whenReady: unit -> Promise<unit>
        /// A `Boolean` property that's `true` if Chrome's accessibility support is enabled,
        /// `false` otherwise. This property will be `true` if the use of assistive
        /// technologies, such as screen readers, has been detected. Setting this property
        /// to `true` manually enables Chrome's accessibility support, allowing developers
        /// to expose accessibility switch to users in application settings.
        /// 
        /// See Chromium's accessibility docs for more details. Disabled by default.
        /// 
        /// This API must be called after the `ready` event is emitted.
        /// 
        /// **Note:** Rendering accessibility tree can significantly affect the performance
        /// of your app. It should not be enabled by default.
        abstract accessibilitySupportEnabled: bool with get, set
        /// A `Boolean` which when `true` disables the overrides that Electron has in place
        /// to ensure renderer processes are restarted on every navigation.  The current
        /// default value for this property is `false`.
        /// 
        /// The intention is for these overrides to become disabled by default and then at
        /// some point in the future this property will be removed.  This property impacts
        /// which native modules you can use in the renderer process.  For more information
        /// on the direction Electron is going with renderer process restarts and usage of
        /// native modules in the renderer process please check out this Tracking Issue.
        abstract allowRendererProcessReuse: bool with get, set
        /// A `Menu | null` property that returns `Menu` if one has been set and `null`
        /// otherwise. Users can pass a Menu to set this property.
        abstract applicationMenu: U2<Menu, obj> with get, set
        /// An `Integer` property that returns the badge count for current app. Setting the
        /// count to `0` will hide the badge.
        /// 
        /// On macOS, setting this with any nonzero integer shows on the dock icon. On
        /// Linux, this property only works for Unity launcher.
        /// 
        /// **Note:** Unity launcher requires the existence of a `.desktop` file to work,
        /// for more information please read Desktop Environment Integration.
        abstract badgeCount: float with get, set
        /// A `CommandLine` object that allows you to read and manipulate the command line
        /// arguments that Chromium uses.
        abstract commandLine: CommandLine
        /// A `Dock` object that allows you to perform actions on your app icon in the
        /// user's dock on macOS.
        abstract dock: Dock
        /// A `Boolean` property that returns  `true` if the app is packaged, `false`
        /// otherwise. For many apps, this property can be used to distinguish development
        /// and production environments.
        abstract isPackaged: bool
        /// A `String` property that indicates the current application's name, which is the
        /// name in the application's `package.json` file.
        /// 
        /// Usually the `name` field of `package.json` is a short lowercase name, according
        /// to the npm modules spec. You should usually also specify a `productName` field,
        /// which is your application's full capitalized name, and which will be preferred
        /// over `name` by Electron.
        abstract name: string with get, set
        /// A `String` which is the user agent string Electron will use as a global
        /// fallback.
        /// 
        /// This is the user agent that will be used when no user agent is set at the
        /// `webContents` or `session` level.  It is useful for ensuring that your entire
        /// app has the same user agent.  Set to a custom value as early as possible in your
        /// app's initialization to ensure that your overridden value is used.
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

    type [<AllowNullLiteral>] AutoUpdater =
        inherit NodeJS.EventEmitter
        /// This event is emitted after a user calls `quitAndInstall()`.
        /// 
        /// When this API is called, the `before-quit` event is not emitted before all
        /// windows are closed. As a result you should listen to this event if you wish to
        /// perform actions before the windows are closed while a process is quitting, as
        /// well as listening to `before-quit`.
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
        /// Emitted when an update has been downloaded.
        /// 
        /// On Windows only `releaseName` is available.
        /// 
        /// **Note:** It is not strictly necessary to handle this event. A successfully
        /// downloaded update will still be applied the next time the application starts.
        [<Emit "$0.on('update-downloaded',$1)">] abstract ``on_update-downloaded``: listener: (Event -> string -> string -> DateTime -> string -> unit) -> AutoUpdater
        [<Emit "$0.once('update-downloaded',$1)">] abstract ``once_update-downloaded``: listener: (Event -> string -> string -> DateTime -> string -> unit) -> AutoUpdater
        [<Emit "$0.addListener('update-downloaded',$1)">] abstract ``addListener_update-downloaded``: listener: (Event -> string -> string -> DateTime -> string -> unit) -> AutoUpdater
        [<Emit "$0.removeListener('update-downloaded',$1)">] abstract ``removeListener_update-downloaded``: listener: (Event -> string -> string -> DateTime -> string -> unit) -> AutoUpdater
        /// Emitted when there is no available update.
        [<Emit "$0.on('update-not-available',$1)">] abstract ``on_update-not-available``: listener: Function -> AutoUpdater
        [<Emit "$0.once('update-not-available',$1)">] abstract ``once_update-not-available``: listener: Function -> AutoUpdater
        [<Emit "$0.addListener('update-not-available',$1)">] abstract ``addListener_update-not-available``: listener: Function -> AutoUpdater
        [<Emit "$0.removeListener('update-not-available',$1)">] abstract ``removeListener_update-not-available``: listener: Function -> AutoUpdater
        /// Asks the server whether there is an update. You must call `setFeedURL` before
        /// using this API.
        abstract checkForUpdates: unit -> unit
        /// The current update feed URL.
        abstract getFeedURL: unit -> string
        /// Restarts the app and installs the update after it has been downloaded. It should
        /// only be called after `update-downloaded` has been emitted.
        /// 
        /// Under the hood calling `autoUpdater.quitAndInstall()` will close all application
        /// windows first, and automatically call `app.quit()` after all windows have been
        /// closed.
        /// 
        /// **Note:** It is not strictly necessary to call this function to apply an update,
        /// as a successfully downloaded update will always be applied the next time the
        /// application starts.
        abstract quitAndInstall: unit -> unit
        /// Sets the `url` and initialize the auto updater.
        abstract setFeedURL: options: FeedURLOptions -> unit

    type [<AllowNullLiteral>] BluetoothDevice =
        abstract deviceId: string with get, set
        abstract deviceName: string with get, set

    type [<AllowNullLiteral>] BrowserView =
        /// Force closing the view, the `unload` and `beforeunload` events won't be emitted
        /// for the web page. After you're done with a view, call this function in order to
        /// free memory and other resources as soon as possible.
        abstract destroy: unit -> unit
        /// The `bounds` of this BrowserView instance as `Object`.
        abstract getBounds: unit -> Rectangle
        /// Whether the view is destroyed.
        abstract isDestroyed: unit -> bool
        abstract setAutoResize: options: AutoResizeOptions -> unit
        abstract setBackgroundColor: color: string -> unit
        /// Resizes and moves the view to the supplied bounds relative to the window.
        abstract setBounds: bounds: Rectangle -> unit
        abstract id: float with get, set
        abstract webContents: WebContents with get, set

    type [<AllowNullLiteral>] BrowserViewStatic =
        /// BrowserView
        [<Emit "new $0($1...)">] abstract Create: ?options: BrowserViewConstructorOptions -> BrowserView
        /// The view with the given `id`.
        abstract fromId: id: float -> BrowserView
        /// The BrowserView that owns the given `webContents` or `null` if the contents are
        /// not owned by a BrowserView.
        abstract fromWebContents: webContents: WebContents -> U2<BrowserView, obj>
        /// An array of all opened BrowserViews.
        abstract getAllViews: unit -> ResizeArray<BrowserView>

    type [<AllowNullLiteral>] BrowserWindow =
        inherit NodeJS.EventEmitter
        /// Emitted when the window is set or unset to show always on top of other windows.
        [<Emit "$0.on('always-on-top-changed',$1)">] abstract ``on_always-on-top-changed``: listener: (Event -> bool -> unit) -> BrowserWindow
        [<Emit "$0.once('always-on-top-changed',$1)">] abstract ``once_always-on-top-changed``: listener: (Event -> bool -> unit) -> BrowserWindow
        [<Emit "$0.addListener('always-on-top-changed',$1)">] abstract ``addListener_always-on-top-changed``: listener: (Event -> bool -> unit) -> BrowserWindow
        [<Emit "$0.removeListener('always-on-top-changed',$1)">] abstract ``removeListener_always-on-top-changed``: listener: (Event -> bool -> unit) -> BrowserWindow
        /// Emitted when an App Command is invoked. These are typically related to keyboard
        /// media keys or browser commands, as well as the "Back" button built into some
        /// mice on Windows.
        /// 
        /// Commands are lowercased, underscores are replaced with hyphens, and the
        /// `APPCOMMAND_` prefix is stripped off. e.g. `APPCOMMAND_BROWSER_BACKWARD` is
        /// emitted as `browser-backward`.
        /// 
        /// The following app commands are explicitly supported on Linux:
        /// 
        /// `browser-backward`
        /// `browser-forward`
        [<Emit "$0.on('app-command',$1)">] abstract ``on_app-command``: listener: (Event -> string -> unit) -> BrowserWindow
        [<Emit "$0.once('app-command',$1)">] abstract ``once_app-command``: listener: (Event -> string -> unit) -> BrowserWindow
        [<Emit "$0.addListener('app-command',$1)">] abstract ``addListener_app-command``: listener: (Event -> string -> unit) -> BrowserWindow
        [<Emit "$0.removeListener('app-command',$1)">] abstract ``removeListener_app-command``: listener: (Event -> string -> unit) -> BrowserWindow
        /// Emitted when the window loses focus.
        [<Emit "$0.on('blur',$1)">] abstract on_blur: listener: Function -> BrowserWindow
        [<Emit "$0.once('blur',$1)">] abstract once_blur: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('blur',$1)">] abstract addListener_blur: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('blur',$1)">] abstract removeListener_blur: listener: Function -> BrowserWindow
        /// Emitted when the window is going to be closed. It's emitted before the
        /// `beforeunload` and `unload` event of the DOM. Calling `event.preventDefault()`
        /// will cancel the close.
        /// 
        /// Usually you would want to use the `beforeunload` handler to decide whether the
        /// window should be closed, which will also be called when the window is reloaded.
        /// In Electron, returning any value other than `undefined` would cancel the close.
        /// For example:
        /// 
        /// _**Note**: There is a subtle difference between the behaviors of
        /// `window.onbeforeunload = handler` and `window.addEventListener('beforeunload',
        /// handler)`. It is recommended to always set the `event.returnValue` explicitly,
        /// instead of only returning a value, as the former works more consistently within
        /// Electron._
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
        /// Emitted when the window is being moved to a new position.
        /// 
        /// __Note__: On macOS this event is an alias of `moved`.
        [<Emit "$0.on('move',$1)">] abstract on_move: listener: Function -> BrowserWindow
        [<Emit "$0.once('move',$1)">] abstract once_move: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('move',$1)">] abstract addListener_move: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('move',$1)">] abstract removeListener_move: listener: Function -> BrowserWindow
        /// Emitted once when the window is moved to a new position.
        [<Emit "$0.on('moved',$1)">] abstract on_moved: listener: Function -> BrowserWindow
        [<Emit "$0.once('moved',$1)">] abstract once_moved: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('moved',$1)">] abstract addListener_moved: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('moved',$1)">] abstract removeListener_moved: listener: Function -> BrowserWindow
        /// Emitted when the native new tab button is clicked.
        [<Emit "$0.on('new-window-for-tab',$1)">] abstract ``on_new-window-for-tab``: listener: Function -> BrowserWindow
        [<Emit "$0.once('new-window-for-tab',$1)">] abstract ``once_new-window-for-tab``: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('new-window-for-tab',$1)">] abstract ``addListener_new-window-for-tab``: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('new-window-for-tab',$1)">] abstract ``removeListener_new-window-for-tab``: listener: Function -> BrowserWindow
        /// Emitted when the document changed its title, calling `event.preventDefault()`
        /// will prevent the native window's title from changing. `explicitSet` is false
        /// when title is synthesized from file URL.
        [<Emit "$0.on('page-title-updated',$1)">] abstract ``on_page-title-updated``: listener: (Event -> string -> bool -> unit) -> BrowserWindow
        [<Emit "$0.once('page-title-updated',$1)">] abstract ``once_page-title-updated``: listener: (Event -> string -> bool -> unit) -> BrowserWindow
        [<Emit "$0.addListener('page-title-updated',$1)">] abstract ``addListener_page-title-updated``: listener: (Event -> string -> bool -> unit) -> BrowserWindow
        [<Emit "$0.removeListener('page-title-updated',$1)">] abstract ``removeListener_page-title-updated``: listener: (Event -> string -> bool -> unit) -> BrowserWindow
        /// Emitted when the web page has been rendered (while not being shown) and window
        /// can be displayed without a visual flash.
        /// 
        /// Please note that using this event implies that the renderer will be considered
        /// "visible" and paint even though `show` is false.  This event will never fire if
        /// you use `paintWhenInitiallyHidden: false`
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
        /// Emitted on trackpad rotation gesture. Continually emitted until rotation gesture
        /// is ended. The `rotation` value on each emission is the angle in degrees rotated
        /// since the last emission. The last emitted event upon a rotation gesture will
        /// always be of value `0`. Counter-clockwise rotation values are positive, while
        /// clockwise ones are negative.
        [<Emit "$0.on('rotate-gesture',$1)">] abstract ``on_rotate-gesture``: listener: (Event -> float -> unit) -> BrowserWindow
        [<Emit "$0.once('rotate-gesture',$1)">] abstract ``once_rotate-gesture``: listener: (Event -> float -> unit) -> BrowserWindow
        [<Emit "$0.addListener('rotate-gesture',$1)">] abstract ``addListener_rotate-gesture``: listener: (Event -> float -> unit) -> BrowserWindow
        [<Emit "$0.removeListener('rotate-gesture',$1)">] abstract ``removeListener_rotate-gesture``: listener: (Event -> float -> unit) -> BrowserWindow
        /// Emitted when scroll wheel event phase has begun.
        [<Emit "$0.on('scroll-touch-begin',$1)">] abstract ``on_scroll-touch-begin``: listener: Function -> BrowserWindow
        [<Emit "$0.once('scroll-touch-begin',$1)">] abstract ``once_scroll-touch-begin``: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('scroll-touch-begin',$1)">] abstract ``addListener_scroll-touch-begin``: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('scroll-touch-begin',$1)">] abstract ``removeListener_scroll-touch-begin``: listener: Function -> BrowserWindow
        /// Emitted when scroll wheel event phase filed upon reaching the edge of element.
        [<Emit "$0.on('scroll-touch-edge',$1)">] abstract ``on_scroll-touch-edge``: listener: Function -> BrowserWindow
        [<Emit "$0.once('scroll-touch-edge',$1)">] abstract ``once_scroll-touch-edge``: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('scroll-touch-edge',$1)">] abstract ``addListener_scroll-touch-edge``: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('scroll-touch-edge',$1)">] abstract ``removeListener_scroll-touch-edge``: listener: Function -> BrowserWindow
        /// Emitted when scroll wheel event phase has ended.
        [<Emit "$0.on('scroll-touch-end',$1)">] abstract ``on_scroll-touch-end``: listener: Function -> BrowserWindow
        [<Emit "$0.once('scroll-touch-end',$1)">] abstract ``once_scroll-touch-end``: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('scroll-touch-end',$1)">] abstract ``addListener_scroll-touch-end``: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('scroll-touch-end',$1)">] abstract ``removeListener_scroll-touch-end``: listener: Function -> BrowserWindow
        /// Emitted when window session is going to end due to force shutdown or machine
        /// restart or session log off.
        [<Emit "$0.on('session-end',$1)">] abstract ``on_session-end``: listener: Function -> BrowserWindow
        [<Emit "$0.once('session-end',$1)">] abstract ``once_session-end``: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('session-end',$1)">] abstract ``addListener_session-end``: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('session-end',$1)">] abstract ``removeListener_session-end``: listener: Function -> BrowserWindow
        /// Emitted when the window opens a sheet.
        [<Emit "$0.on('sheet-begin',$1)">] abstract ``on_sheet-begin``: listener: Function -> BrowserWindow
        [<Emit "$0.once('sheet-begin',$1)">] abstract ``once_sheet-begin``: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('sheet-begin',$1)">] abstract ``addListener_sheet-begin``: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('sheet-begin',$1)">] abstract ``removeListener_sheet-begin``: listener: Function -> BrowserWindow
        /// Emitted when the window has closed a sheet.
        [<Emit "$0.on('sheet-end',$1)">] abstract ``on_sheet-end``: listener: Function -> BrowserWindow
        [<Emit "$0.once('sheet-end',$1)">] abstract ``once_sheet-end``: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('sheet-end',$1)">] abstract ``addListener_sheet-end``: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('sheet-end',$1)">] abstract ``removeListener_sheet-end``: listener: Function -> BrowserWindow
        /// Emitted when the window is shown.
        [<Emit "$0.on('show',$1)">] abstract on_show: listener: Function -> BrowserWindow
        [<Emit "$0.once('show',$1)">] abstract once_show: listener: Function -> BrowserWindow
        [<Emit "$0.addListener('show',$1)">] abstract addListener_show: listener: Function -> BrowserWindow
        [<Emit "$0.removeListener('show',$1)">] abstract removeListener_show: listener: Function -> BrowserWindow
        /// Emitted on 3-finger swipe. Possible directions are `up`, `right`, `down`,
        /// `left`.
        /// 
        /// The method underlying this event is built to handle older macOS-style trackpad
        /// swiping, where the content on the screen doesn't move with the swipe. Most macOS
        /// trackpads are not configured to allow this kind of swiping anymore, so in order
        /// for it to emit properly the 'Swipe between pages' preference in `System
        /// Preferences > Trackpad > More Gestures` must be set to 'Swipe with two or three
        /// fingers'.
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
        /// Emitted before the window is moved. Calling `event.preventDefault()` will
        /// prevent the window from being moved.
        /// 
        /// Note that this is only emitted when the window is being resized manually.
        /// Resizing the window with `setBounds`/`setSize` will not emit this event.
        [<Emit "$0.on('will-move',$1)">] abstract ``on_will-move``: listener: (Event -> Rectangle -> unit) -> BrowserWindow
        [<Emit "$0.once('will-move',$1)">] abstract ``once_will-move``: listener: (Event -> Rectangle -> unit) -> BrowserWindow
        [<Emit "$0.addListener('will-move',$1)">] abstract ``addListener_will-move``: listener: (Event -> Rectangle -> unit) -> BrowserWindow
        [<Emit "$0.removeListener('will-move',$1)">] abstract ``removeListener_will-move``: listener: (Event -> Rectangle -> unit) -> BrowserWindow
        /// Emitted before the window is resized. Calling `event.preventDefault()` will
        /// prevent the window from being resized.
        /// 
        /// Note that this is only emitted when the window is being resized manually.
        /// Resizing the window with `setBounds`/`setSize` will not emit this event.
        [<Emit "$0.on('will-resize',$1)">] abstract ``on_will-resize``: listener: (Event -> Rectangle -> unit) -> BrowserWindow
        [<Emit "$0.once('will-resize',$1)">] abstract ``once_will-resize``: listener: (Event -> Rectangle -> unit) -> BrowserWindow
        [<Emit "$0.addListener('will-resize',$1)">] abstract ``addListener_will-resize``: listener: (Event -> Rectangle -> unit) -> BrowserWindow
        [<Emit "$0.removeListener('will-resize',$1)">] abstract ``removeListener_will-resize``: listener: (Event -> Rectangle -> unit) -> BrowserWindow
        /// Replacement API for setBrowserView supporting work with multi browser views.
        abstract addBrowserView: browserView: BrowserView -> unit
        /// Adds a window as a tab on this window, after the tab for the window instance.
        abstract addTabbedWindow: browserWindow: BrowserWindow -> unit
        /// Removes focus from the window.
        abstract blur: unit -> unit
        abstract blurWebView: unit -> unit
        /// Resolves with a NativeImage
        /// 
        /// Captures a snapshot of the page within `rect`. Omitting `rect` will capture the
        /// whole visible page.
        abstract capturePage: ?rect: Rectangle -> Promise<Electron.NativeImage>
        /// Moves window to the center of the screen.
        abstract center: unit -> unit
        /// Try to close the window. This has the same effect as a user manually clicking
        /// the close button of the window. The web page may cancel the close though. See
        /// the close event.
        abstract close: unit -> unit
        /// Closes the currently open Quick Look panel.
        abstract closeFilePreview: unit -> unit
        /// Force closing the window, the `unload` and `beforeunload` event won't be emitted
        /// for the web page, and `close` event will also not be emitted for this window,
        /// but it guarantees the `closed` event will be emitted.
        abstract destroy: unit -> unit
        /// Starts or stops flashing the window to attract user's attention.
        abstract flashFrame: flag: bool -> unit
        /// Focuses on the window.
        abstract focus: unit -> unit
        abstract focusOnWebView: unit -> unit
        /// The `bounds` of the window as `Object`.
        abstract getBounds: unit -> Rectangle
        /// an BrowserView what is attached. Returns `null` if none is attached. Throw error
        /// if multiple BrowserViews is attached.
        abstract getBrowserView: unit -> U2<BrowserView, obj>
        /// an array of all BrowserViews that have been attached with `addBrowserView` or
        /// `setBrowserView`.
        /// 
        /// **Note:** The BrowserView API is currently experimental and may change or be
        /// removed in future Electron releases.
        abstract getBrowserViews: unit -> ResizeArray<BrowserView>
        /// All child windows.
        abstract getChildWindows: unit -> ResizeArray<BrowserWindow>
        /// The `bounds` of the window's client area as `Object`.
        abstract getContentBounds: unit -> Rectangle
        /// Contains the window's client area's width and height.
        abstract getContentSize: unit -> ResizeArray<float>
        /// Contains the window's maximum width and height.
        abstract getMaximumSize: unit -> ResizeArray<float>
        /// Contains the window's minimum width and height.
        abstract getMinimumSize: unit -> ResizeArray<float>
        /// The platform-specific handle of the window.
        /// 
        /// The native type of the handle is `HWND` on Windows, `NSView*` on macOS, and
        /// `Window` (`unsigned long`) on Linux.
        abstract getNativeWindowHandle: unit -> Buffer
        /// Contains the window bounds of the normal state
        /// 
        /// **Note:** whatever the current state of the window : maximized, minimized or in
        /// fullscreen, this function always returns the position and size of the window in
        /// normal state. In normal state, getBounds and getNormalBounds returns the same
        /// `Rectangle`.
        abstract getNormalBounds: unit -> Rectangle
        /// between 0.0 (fully transparent) and 1.0 (fully opaque). On Linux, always returns
        /// 1.
        abstract getOpacity: unit -> float
        /// The parent window.
        abstract getParentWindow: unit -> BrowserWindow
        /// Contains the window's current position.
        abstract getPosition: unit -> ResizeArray<float>
        /// The pathname of the file the window represents.
        abstract getRepresentedFilename: unit -> string
        /// Contains the window's width and height.
        abstract getSize: unit -> ResizeArray<float>
        /// The title of the native window.
        /// 
        /// **Note:** The title of the web page can be different from the title of the
        /// native window.
        abstract getTitle: unit -> string
        /// Whether the window has a shadow.
        abstract hasShadow: unit -> bool
        /// Hides the window.
        abstract hide: unit -> unit
        /// Hooks a windows message. The `callback` is called when the message is received
        /// in the WndProc.
        abstract hookWindowMessage: message: float * callback: (unit -> unit) -> unit
        /// Whether the window is always on top of other windows.
        abstract isAlwaysOnTop: unit -> bool
        /// Whether the window can be manually closed by user.
        /// 
        /// On Linux always returns `true`.
        /// 
        /// *Deprecated**
        abstract isClosable: unit -> bool
        /// Whether the window is destroyed.
        abstract isDestroyed: unit -> bool
        /// Whether the window's document has been edited.
        abstract isDocumentEdited: unit -> bool
        /// Returns Boolean - whether the window is enabled.
        abstract isEnabled: unit -> unit
        /// Whether the window is focused.
        abstract isFocused: unit -> bool
        /// Whether the window is in fullscreen mode.
        abstract isFullScreen: unit -> bool
        /// Whether the maximize/zoom window button toggles fullscreen mode or maximizes the
        /// window.
        /// 
        /// *Deprecated**
        abstract isFullScreenable: unit -> bool
        /// Whether the window is in kiosk mode.
        abstract isKiosk: unit -> bool
        /// Whether the window can be manually maximized by user.
        /// 
        /// On Linux always returns `true`.
        /// 
        /// *Deprecated**
        abstract isMaximizable: unit -> bool
        /// Whether the window is maximized.
        abstract isMaximized: unit -> bool
        /// Whether menu bar automatically hides itself.
        /// 
        /// *Deprecated**
        abstract isMenuBarAutoHide: unit -> bool
        /// Whether the menu bar is visible.
        abstract isMenuBarVisible: unit -> bool
        /// Whether the window can be manually minimized by user
        /// 
        /// On Linux always returns `true`.
        /// 
        /// *Deprecated**
        abstract isMinimizable: unit -> bool
        /// Whether the window is minimized.
        abstract isMinimized: unit -> bool
        /// Whether current window is a modal window.
        abstract isModal: unit -> bool
        /// Whether the window can be moved by user.
        /// 
        /// On Linux always returns `true`.
        /// 
        /// *Deprecated**
        abstract isMovable: unit -> bool
        /// Whether the window is in normal state (not maximized, not minimized, not in
        /// fullscreen mode).
        abstract isNormal: unit -> bool
        /// Whether the window can be manually resized by user.
        /// 
        /// *Deprecated**
        abstract isResizable: unit -> bool
        /// Whether the window is in simple (pre-Lion) fullscreen mode.
        abstract isSimpleFullScreen: unit -> bool
        /// Whether the window is visible to the user.
        abstract isVisible: unit -> bool
        /// Whether the window is visible on all workspaces.
        /// 
        /// *Note:** This API always returns false on Windows.
        abstract isVisibleOnAllWorkspaces: unit -> bool
        /// `true` or `false` depending on whether the message is hooked.
        abstract isWindowMessageHooked: message: float -> bool
        /// the promise will resolve when the page has finished loading (see
        /// `did-finish-load`), and rejects if the page fails to load (see `did-fail-load`).
        /// 
        /// Same as `webContents.loadFile`, `filePath` should be a path to an HTML file
        /// relative to the root of your application.  See the `webContents` docs for more
        /// information.
        abstract loadFile: filePath: string * ?options: LoadFileOptions -> Promise<unit>
        /// the promise will resolve when the page has finished loading (see
        /// `did-finish-load`), and rejects if the page fails to load (see `did-fail-load`).
        /// 
        /// Same as `webContents.loadURL(url[, options])`.
        /// 
        /// The `url` can be a remote address (e.g. `http://`) or a path to a local HTML
        /// file using the `file://` protocol.
        /// 
        /// To ensure that file URLs are properly formatted, it is recommended to use Node's
        /// `url.format` method:
        /// 
        /// You can load a URL using a `POST` request with URL-encoded data by doing the
        /// following:
        abstract loadURL: url: string * ?options: LoadURLOptions -> Promise<unit>
        /// Maximizes the window. This will also show (but not focus) the window if it isn't
        /// being displayed already.
        abstract maximize: unit -> unit
        /// Merges all windows into one window with multiple tabs when native tabs are
        /// enabled and there is more than one open window.
        abstract mergeAllWindows: unit -> unit
        /// Minimizes the window. On some platforms the minimized window will be shown in
        /// the Dock.
        abstract minimize: unit -> unit
        /// Moves the current tab into a new window if native tabs are enabled and there is
        /// more than one tab in the current window.
        abstract moveTabToNewWindow: unit -> unit
        /// Moves window to top(z-order) regardless of focus
        abstract moveTop: unit -> unit
        /// Uses Quick Look to preview a file at a given path.
        abstract previewFile: path: string * ?displayName: string -> unit
        /// Same as `webContents.reload`.
        abstract reload: unit -> unit
        abstract removeBrowserView: browserView: BrowserView -> unit
        /// Remove the window's menu bar.
        abstract removeMenu: unit -> unit
        /// Restores the window from minimized state to its previous state.
        abstract restore: unit -> unit
        /// Selects the next tab when native tabs are enabled and there are other tabs in
        /// the window.
        abstract selectNextTab: unit -> unit
        /// Selects the previous tab when native tabs are enabled and there are other tabs
        /// in the window.
        abstract selectPreviousTab: unit -> unit
        /// Sets whether the window should show always on top of other windows. After
        /// setting this, the window is still a normal window, not a toolbox window which
        /// can not be focused on.
        abstract setAlwaysOnTop: flag: bool * ?level: BrowserWindowSetAlwaysOnTopLevel * ?relativeLevel: float -> unit
        /// Sets the properties for the window's taskbar button.
        /// 
        /// **Note:** `relaunchCommand` and `relaunchDisplayName` must always be set
        /// together. If one of those properties is not set, then neither will be used.
        abstract setAppDetails: options: AppDetailsOptions -> unit
        /// This will make a window maintain an aspect ratio. The extra size allows a
        /// developer to have space, specified in pixels, not included within the aspect
        /// ratio calculations. This API already takes into account the difference between a
        /// window's size and its content size.
        /// 
        /// Consider a normal window with an HD video player and associated controls.
        /// Perhaps there are 15 pixels of controls on the left edge, 25 pixels of controls
        /// on the right edge and 50 pixels of controls below the player. In order to
        /// maintain a 16:9 aspect ratio (standard aspect ratio for HD @1920x1080) within
        /// the player itself we would call this function with arguments of 16/9 and [ 40,
        /// 50 ]. The second argument doesn't care where the extra width and height are
        /// within the content view--only that they exist. Sum any extra width and height
        /// areas you have within the overall content view.
        /// 
        /// Calling this function with a value of `0` will remove any previously set aspect
        /// ratios.
        abstract setAspectRatio: aspectRatio: float * ?extraSize: Size -> unit
        /// Controls whether to hide cursor when typing.
        abstract setAutoHideCursor: autoHide: bool -> unit
        /// Sets whether the window menu bar should hide itself automatically. Once set the
        /// menu bar will only show when users press the single `Alt` key.
        /// 
        /// If the menu bar is already visible, calling `setAutoHideMenuBar(true)` won't
        /// hide it immediately.
        /// 
        /// *Deprecated**
        abstract setAutoHideMenuBar: hide: bool -> unit
        /// Sets the background color of the window. See Setting `backgroundColor`.
        abstract setBackgroundColor: backgroundColor: string -> unit
        /// Resizes and moves the window to the supplied bounds. Any properties that are not
        /// supplied will default to their current values.
        abstract setBounds: bounds: obj * ?animate: bool -> unit
        abstract setBrowserView: browserView: U2<BrowserView, obj> -> unit
        /// Sets whether the window can be manually closed by user. On Linux does nothing.
        /// 
        /// *Deprecated**
        abstract setClosable: closable: bool -> unit
        /// Resizes and moves the window's client area (e.g. the web page) to the supplied
        /// bounds.
        abstract setContentBounds: bounds: Rectangle * ?animate: bool -> unit
        /// Prevents the window contents from being captured by other apps.
        /// 
        /// On macOS it sets the NSWindow's sharingType to NSWindowSharingNone. On Windows
        /// it calls SetWindowDisplayAffinity with `WDA_MONITOR`.
        abstract setContentProtection: enable: bool -> unit
        /// Resizes the window's client area (e.g. the web page) to `width` and `height`.
        abstract setContentSize: width: float * height: float * ?animate: bool -> unit
        /// Specifies whether the window’s document has been edited, and the icon in title
        /// bar will become gray when set to `true`.
        abstract setDocumentEdited: edited: bool -> unit
        /// Disable or enable the window.
        abstract setEnabled: enable: bool -> unit
        /// Changes whether the window can be focused.
        /// 
        /// On macOS it does not remove the focus from the window.
        abstract setFocusable: focusable: bool -> unit
        /// Sets whether the window should be in fullscreen mode.
        abstract setFullScreen: flag: bool -> unit
        /// Sets whether the maximize/zoom window button toggles fullscreen mode or
        /// maximizes the window.
        /// 
        /// *Deprecated**
        abstract setFullScreenable: fullscreenable: bool -> unit
        /// Sets whether the window should have a shadow.
        abstract setHasShadow: hasShadow: bool -> unit
        /// Changes window icon.
        abstract setIcon: icon: U2<NativeImage, string> -> unit
        /// Makes the window ignore all mouse events.
        /// 
        /// All mouse events happened in this window will be passed to the window below this
        /// window, but if this window has focus, it will still receive keyboard events.
        abstract setIgnoreMouseEvents: ignore: bool * ?options: IgnoreMouseEventsOptions -> unit
        /// Enters or leaves the kiosk mode.
        abstract setKiosk: flag: bool -> unit
        /// Sets whether the window can be manually maximized by user. On Linux does
        /// nothing.
        /// 
        /// *Deprecated**
        abstract setMaximizable: maximizable: bool -> unit
        /// Sets the maximum size of window to `width` and `height`.
        abstract setMaximumSize: width: float * height: float -> unit
        /// Sets the `menu` as the window's menu bar.
        abstract setMenu: menu: U2<Menu, obj> -> unit
        /// Sets whether the menu bar should be visible. If the menu bar is auto-hide, users
        /// can still bring up the menu bar by pressing the single `Alt` key.
        abstract setMenuBarVisibility: visible: bool -> unit
        /// Sets whether the window can be manually minimized by user. On Linux does
        /// nothing.
        /// 
        /// *Deprecated**
        abstract setMinimizable: minimizable: bool -> unit
        /// Sets the minimum size of window to `width` and `height`.
        abstract setMinimumSize: width: float * height: float -> unit
        /// Sets whether the window can be moved by user. On Linux does nothing.
        /// 
        /// *Deprecated**
        abstract setMovable: movable: bool -> unit
        /// Sets the opacity of the window. On Linux, does nothing. Out of bound number
        /// values are clamped to the [0, 1] range.
        abstract setOpacity: opacity: float -> unit
        /// Sets a 16 x 16 pixel overlay onto the current taskbar icon, usually used to
        /// convey some sort of application status or to passively notify the user.
        abstract setOverlayIcon: overlay: U2<NativeImage, obj> * description: string -> unit
        /// Sets `parent` as current window's parent window, passing `null` will turn
        /// current window into a top-level window.
        abstract setParentWindow: parent: U2<BrowserWindow, obj> -> unit
        /// Moves window to `x` and `y`.
        abstract setPosition: x: float * y: float * ?animate: bool -> unit
        /// Sets progress value in progress bar. Valid range is [0, 1.0].
        /// 
        /// Remove progress bar when progress < 0; Change to indeterminate mode when
        /// progress > 1.
        /// 
        /// On Linux platform, only supports Unity desktop environment, you need to specify
        /// the `*.desktop` file name to `desktopName` field in `package.json`. By default,
        /// it will assume `{app.name}.desktop`.
        /// 
        /// On Windows, a mode can be passed. Accepted values are `none`, `normal`,
        /// `indeterminate`, `error`, and `paused`. If you call `setProgressBar` without a
        /// mode set (but with a value within the valid range), `normal` will be assumed.
        abstract setProgressBar: progress: float * ?options: ProgressBarOptions -> unit
        /// Sets the pathname of the file the window represents, and the icon of the file
        /// will show in window's title bar.
        abstract setRepresentedFilename: filename: string -> unit
        /// Sets whether the window can be manually resized by user.
        /// 
        /// *Deprecated**
        abstract setResizable: resizable: bool -> unit
        /// Setting a window shape determines the area within the window where the system
        /// permits drawing and user interaction. Outside of the given region, no pixels
        /// will be drawn and no mouse events will be registered. Mouse events outside of
        /// the region will not be received by that window, but will fall through to
        /// whatever is behind the window.
        abstract setShape: rects: ResizeArray<Rectangle> -> unit
        /// Changes the attachment point for sheets on macOS. By default, sheets are
        /// attached just below the window frame, but you may want to display them beneath a
        /// HTML-rendered toolbar. For example:
        abstract setSheetOffset: offsetY: float * ?offsetX: float -> unit
        /// Enters or leaves simple fullscreen mode.
        /// 
        /// Simple fullscreen mode emulates the native fullscreen behavior found in versions
        /// of Mac OS X prior to Lion (10.7).
        abstract setSimpleFullScreen: flag: bool -> unit
        /// Resizes the window to `width` and `height`. If `width` or `height` are below any
        /// set minimum size constraints the window will snap to its minimum size.
        abstract setSize: width: float * height: float * ?animate: bool -> unit
        /// Makes the window not show in the taskbar.
        abstract setSkipTaskbar: skip: bool -> unit
        /// Whether the buttons were added successfully
        /// 
        /// Add a thumbnail toolbar with a specified set of buttons to the thumbnail image
        /// of a window in a taskbar button layout. Returns a `Boolean` object indicates
        /// whether the thumbnail has been added successfully.
        /// 
        /// The number of buttons in thumbnail toolbar should be no greater than 7 due to
        /// the limited room. Once you setup the thumbnail toolbar, the toolbar cannot be
        /// removed due to the platform's limitation. But you can call the API with an empty
        /// array to clean the buttons.
        /// 
        /// The `buttons` is an array of `Button` objects:
        /// 
        /// * `Button` Object
        ///    * `icon` NativeImage - The icon showing in thumbnail toolbar.
        ///    * `click` Function
        ///    * `tooltip` String (optional) - The text of the button's tooltip.
        ///    * `flags` String[] (optional) - Control specific states and behaviors of the
        /// button. By default, it is `['enabled']`.
        /// 
        /// The `flags` is an array that can include following `String`s:
        /// 
        /// * `enabled` - The button is active and available to the user.
        /// * `disabled` - The button is disabled. It is present, but has a visual state
        /// indicating it will not respond to user action.
        /// * `dismissonclick` - When the button is clicked, the thumbnail window closes
        /// immediately.
        /// * `nobackground` - Do not draw a button border, use only the image.
        /// * `hidden` - The button is not shown to the user.
        /// * `noninteractive` - The button is enabled but not interactive; no pressed
        /// button state is drawn. This value is intended for instances where the button is
        /// used in a notification.
        abstract setThumbarButtons: buttons: ResizeArray<ThumbarButton> -> bool
        /// Sets the region of the window to show as the thumbnail image displayed when
        /// hovering over the window in the taskbar. You can reset the thumbnail to be the
        /// entire window by specifying an empty region: `{ x: 0, y: 0, width: 0, height: 0
        /// }`.
        abstract setThumbnailClip: region: Rectangle -> unit
        /// Sets the toolTip that is displayed when hovering over the window thumbnail in
        /// the taskbar.
        abstract setThumbnailToolTip: toolTip: string -> unit
        /// Changes the title of native window to `title`.
        abstract setTitle: title: string -> unit
        /// Sets the touchBar layout for the current window. Specifying `null` or
        /// `undefined` clears the touch bar. This method only has an effect if the machine
        /// has a touch bar and is running on macOS 10.12.1+.
        /// 
        /// **Note:** The TouchBar API is currently experimental and may change or be
        /// removed in future Electron releases.
        abstract setTouchBar: touchBar: U2<TouchBar, obj> -> unit
        /// Adds a vibrancy effect to the browser window. Passing `null` or an empty string
        /// will remove the vibrancy effect on the window.
        /// 
        /// Note that `appearance-based`, `light`, `dark`, `medium-light`, and `ultra-dark`
        /// have been deprecated and will be removed in an upcoming version of macOS.
        abstract setVibrancy: ``type``: U2<BrowserWindowSetVibrancy, obj> -> unit
        /// Sets whether the window should be visible on all workspaces.
        /// 
        /// *Note:** This API does nothing on Windows.
        abstract setVisibleOnAllWorkspaces: visible: bool * ?options: VisibleOnAllWorkspacesOptions -> unit
        /// Sets whether the window traffic light buttons should be visible.
        /// 
        /// This cannot be called when `titleBarStyle` is set to `customButtonsOnHover`.
        abstract setWindowButtonVisibility: visible: bool -> unit
        /// Shows and gives focus to the window.
        abstract show: unit -> unit
        /// Same as `webContents.showDefinitionForSelection()`.
        abstract showDefinitionForSelection: unit -> unit
        /// Shows the window but doesn't focus on it.
        abstract showInactive: unit -> unit
        /// Toggles the visibility of the tab bar if native tabs are enabled and there is
        /// only one tab in the current window.
        abstract toggleTabBar: unit -> unit
        /// Unhooks all of the window messages.
        abstract unhookAllWindowMessages: unit -> unit
        /// Unhook the window message.
        abstract unhookWindowMessage: message: float -> unit
        /// Unmaximizes the window.
        abstract unmaximize: unit -> unit
        abstract autoHideMenuBar: bool with get, set
        abstract closable: bool with get, set
        abstract excludedFromShownWindowsMenu: bool with get, set
        abstract fullScreenable: bool with get, set
        abstract id: float
        abstract maximizable: bool with get, set
        abstract minimizable: bool with get, set
        abstract movable: bool with get, set
        abstract resizable: bool with get, set
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
        [<Emit "new $0($1...)">] abstract Create: ?options: BrowserWindowConstructorOptions -> BrowserWindow
        /// Adds DevTools extension located at `path`, and returns extension's name.
        /// 
        /// The extension will be remembered so you only need to call this API once, this
        /// API is not for programming use. If you try to add an extension that has already
        /// been loaded, this method will not return and instead log a warning to the
        /// console.
        /// 
        /// The method will also not return if the extension's manifest is missing or
        /// incomplete.
        /// 
        /// **Note:** This API cannot be called before the `ready` event of the `app` module
        /// is emitted.
        abstract addDevToolsExtension: path: string -> unit
        /// Adds Chrome extension located at `path`, and returns extension's name.
        /// 
        /// The method will also not return if the extension's manifest is missing or
        /// incomplete.
        /// 
        /// **Note:** This API cannot be called before the `ready` event of the `app` module
        /// is emitted.
        abstract addExtension: path: string -> unit
        /// The window that owns the given `browserView`. If the given view is not attached
        /// to any window, returns `null`.
        abstract fromBrowserView: browserView: BrowserView -> U2<BrowserWindow, obj>
        /// The window with the given `id`.
        abstract fromId: id: float -> BrowserWindow
        /// The window that owns the given `webContents`.
        abstract fromWebContents: webContents: WebContents -> BrowserWindow
        /// An array of all opened browser windows.
        abstract getAllWindows: unit -> ResizeArray<BrowserWindow>
        /// The keys are the extension names and each value is an Object containing `name`
        /// and `version` properties.
        /// 
        /// To check if a DevTools extension is installed you can run the following:
        /// 
        /// **Note:** This API cannot be called before the `ready` event of the `app` module
        /// is emitted.
        abstract getDevToolsExtensions: unit -> Record<string, ExtensionInfo>
        /// The keys are the extension names and each value is an Object containing `name`
        /// and `version` properties.
        /// 
        /// **Note:** This API cannot be called before the `ready` event of the `app` module
        /// is emitted.
        abstract getExtensions: unit -> Record<string, ExtensionInfo>
        /// The window that is focused in this application, otherwise returns `null`.
        abstract getFocusedWindow: unit -> U2<BrowserWindow, obj>
        /// Remove a DevTools extension by name.
        /// 
        /// **Note:** This API cannot be called before the `ready` event of the `app` module
        /// is emitted.
        abstract removeDevToolsExtension: name: string -> unit
        /// Remove a Chrome extension by name.
        /// 
        /// **Note:** This API cannot be called before the `ready` event of the `app` module
        /// is emitted.
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
        /// Sends a message to the child window with the specified origin or `*` for no
        /// origin preference.
        /// 
        /// In addition to these methods, the child window implements `window.opener` object
        /// with no properties and a single method.
        abstract postMessage: message: obj option * targetOrigin: string -> unit
        /// Invokes the print dialog on the child window.
        abstract print: unit -> unit
        abstract closed: bool with get, set

    type [<AllowNullLiteral>] BrowserWindowProxyStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> BrowserWindowProxy

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
        /// Emitted when the `request` is aborted. The `abort` event will not be fired if
        /// the `request` is already closed.
        [<Emit "$0.on('abort',$1)">] abstract on_abort: listener: Function -> ClientRequest
        [<Emit "$0.once('abort',$1)">] abstract once_abort: listener: Function -> ClientRequest
        [<Emit "$0.addListener('abort',$1)">] abstract addListener_abort: listener: Function -> ClientRequest
        [<Emit "$0.removeListener('abort',$1)">] abstract removeListener_abort: listener: Function -> ClientRequest
        /// Emitted as the last event in the HTTP request-response transaction. The `close`
        /// event indicates that no more events will be emitted on either the `request` or
        /// `response` objects.
        [<Emit "$0.on('close',$1)">] abstract on_close: listener: Function -> ClientRequest
        [<Emit "$0.once('close',$1)">] abstract once_close: listener: Function -> ClientRequest
        [<Emit "$0.addListener('close',$1)">] abstract addListener_close: listener: Function -> ClientRequest
        [<Emit "$0.removeListener('close',$1)">] abstract removeListener_close: listener: Function -> ClientRequest
        /// Emitted when the `net` module fails to issue a network request. Typically when
        /// the `request` object emits an `error` event, a `close` event will subsequently
        /// follow and no response object will be provided.
        [<Emit "$0.on('error',$1)">] abstract on_error: listener: (Error -> unit) -> ClientRequest
        [<Emit "$0.once('error',$1)">] abstract once_error: listener: (Error -> unit) -> ClientRequest
        [<Emit "$0.addListener('error',$1)">] abstract addListener_error: listener: (Error -> unit) -> ClientRequest
        [<Emit "$0.removeListener('error',$1)">] abstract removeListener_error: listener: (Error -> unit) -> ClientRequest
        /// Emitted just after the last chunk of the `request`'s data has been written into
        /// the `request` object.
        [<Emit "$0.on('finish',$1)">] abstract on_finish: listener: Function -> ClientRequest
        [<Emit "$0.once('finish',$1)">] abstract once_finish: listener: Function -> ClientRequest
        [<Emit "$0.addListener('finish',$1)">] abstract addListener_finish: listener: Function -> ClientRequest
        [<Emit "$0.removeListener('finish',$1)">] abstract removeListener_finish: listener: Function -> ClientRequest
        /// Emitted when an authenticating proxy is asking for user credentials.
        /// 
        /// The `callback` function is expected to be called back with user credentials:
        /// 
        /// * `username` String
        /// * `password` String
        /// 
        /// Providing empty credentials will cancel the request and report an authentication
        /// error on the response object:
        [<Emit "$0.on('login',$1)">] abstract on_login: listener: (AuthInfo -> (string -> string -> unit) -> unit) -> ClientRequest
        [<Emit "$0.once('login',$1)">] abstract once_login: listener: (AuthInfo -> (string -> string -> unit) -> unit) -> ClientRequest
        [<Emit "$0.addListener('login',$1)">] abstract addListener_login: listener: (AuthInfo -> (string -> string -> unit) -> unit) -> ClientRequest
        [<Emit "$0.removeListener('login',$1)">] abstract removeListener_login: listener: (AuthInfo -> (string -> string -> unit) -> unit) -> ClientRequest
        /// Emitted when the server returns a redirect response (e.g. 301 Moved
        /// Permanently). Calling `request.followRedirect` will continue with the
        /// redirection.  If this event is handled, `request.followRedirect` must be called
        /// **synchronously**, otherwise the request will be cancelled.
        [<Emit "$0.on('redirect',$1)">] abstract on_redirect: listener: (float -> string -> string -> Record<string, ResizeArray<string>> -> unit) -> ClientRequest
        [<Emit "$0.once('redirect',$1)">] abstract once_redirect: listener: (float -> string -> string -> Record<string, ResizeArray<string>> -> unit) -> ClientRequest
        [<Emit "$0.addListener('redirect',$1)">] abstract addListener_redirect: listener: (float -> string -> string -> Record<string, ResizeArray<string>> -> unit) -> ClientRequest
        [<Emit "$0.removeListener('redirect',$1)">] abstract removeListener_redirect: listener: (float -> string -> string -> Record<string, ResizeArray<string>> -> unit) -> ClientRequest
        [<Emit "$0.on('response',$1)">] abstract on_response: listener: (IncomingMessage -> unit) -> ClientRequest
        [<Emit "$0.once('response',$1)">] abstract once_response: listener: (IncomingMessage -> unit) -> ClientRequest
        [<Emit "$0.addListener('response',$1)">] abstract addListener_response: listener: (IncomingMessage -> unit) -> ClientRequest
        [<Emit "$0.removeListener('response',$1)">] abstract removeListener_response: listener: (IncomingMessage -> unit) -> ClientRequest
        /// Cancels an ongoing HTTP transaction. If the request has already emitted the
        /// `close` event, the abort operation will have no effect. Otherwise an ongoing
        /// event will emit `abort` and `close` events. Additionally, if there is an ongoing
        /// response object,it will emit the `aborted` event.
        abstract abort: unit -> unit
        /// Sends the last chunk of the request data. Subsequent write or end operations
        /// will not be allowed. The `finish` event is emitted just after the end operation.
        abstract ``end``: ?chunk: U2<string, Buffer> * ?encoding: string * ?callback: (unit -> unit) -> unit
        /// Continues any pending redirection. Can only be called during a `'redirect'`
        /// event.
        abstract followRedirect: unit -> unit
        /// The value of a previously set extra header name.
        abstract getHeader: name: string -> string
        /// * `active` Boolean - Whether the request is currently active. If this is false
        /// no other properties will be set
        /// * `started` Boolean - Whether the upload has started. If this is false both
        /// `current` and `total` will be set to 0.
        /// * `current` Integer - The number of bytes that have been uploaded so far
        /// * `total` Integer - The number of bytes that will be uploaded this request
        /// 
        /// You can use this method in conjunction with `POST` requests to get the progress
        /// of a file upload or other data transfer.
        abstract getUploadProgress: unit -> UploadProgress
        /// Removes a previously set extra header name. This method can be called only
        /// before first write. Trying to call it after the first write will throw an error.
        abstract removeHeader: name: string -> unit
        /// Adds an extra HTTP header. The header name will be issued as-is without
        /// lowercasing. It can be called only before first write. Calling this method after
        /// the first write will throw an error. If the passed value is not a `String`, its
        /// `toString()` method will be called to obtain the final value.
        abstract setHeader: name: string * value: string -> unit
        /// `callback` is essentially a dummy function introduced in the purpose of keeping
        /// similarity with the Node.js API. It is called asynchronously in the next tick
        /// after `chunk` content have been delivered to the Chromium networking layer.
        /// Contrary to the Node.js implementation, it is not guaranteed that `chunk`
        /// content have been flushed on the wire before `callback` is called.
        /// 
        /// Adds a chunk of data to the request body. The first write operation may cause
        /// the request headers to be issued on the wire. After the first write operation,
        /// it is not allowed to add or remove a custom header.
        abstract write: chunk: U2<string, Buffer> * ?encoding: string * ?callback: (unit -> unit) -> unit
        abstract chunkedEncoding: bool with get, set

    type [<AllowNullLiteral>] ClientRequestStatic =
        /// ClientRequest
        [<Emit "new $0($1...)">] abstract Create: options: U2<ClientRequestConstructorOptions, string> -> ClientRequest

    type [<AllowNullLiteral>] Clipboard =
        /// An array of supported formats for the clipboard `type`.
        abstract availableFormats: ?``type``: ClipboardAvailableFormatsType -> ResizeArray<string>
        /// Clears the clipboard content.
        abstract clear: ?``type``: ClipboardClearType -> unit
        /// Whether the clipboard supports the specified `format`.
        abstract has: format: string * ?``type``: ClipboardHasType -> bool
        /// Reads `format` type from the clipboard.
        abstract read: format: string -> string
        /// * `title` String
        /// * `url` String
        /// 
        /// Returns an Object containing `title` and `url` keys representing the bookmark in
        /// the clipboard. The `title` and `url` values will be empty strings when the
        /// bookmark is unavailable.
        abstract readBookmark: unit -> ReadBookmark
        /// Reads `format` type from the clipboard.
        abstract readBuffer: format: string -> Buffer
        /// The text on the find pasteboard, which is the pasteboard that holds information
        /// about the current state of the active application’s find panel.
        /// 
        /// This method uses synchronous IPC when called from the renderer process. The
        /// cached value is reread from the find pasteboard whenever the application is
        /// activated.
        abstract readFindText: unit -> string
        /// The content in the clipboard as markup.
        abstract readHTML: ?``type``: ClipboardReadHTMLType -> string
        /// The image content in the clipboard.
        abstract readImage: ?``type``: ClipboardReadImageType -> NativeImage
        /// The content in the clipboard as RTF.
        abstract readRTF: ?``type``: ClipboardReadRTFType -> string
        /// The content in the clipboard as plain text.
        abstract readText: ?``type``: ClipboardReadTextType -> string
        /// Writes `data` to the clipboard.
        abstract write: data: Data * ?``type``: ClipboardWriteType -> unit
        /// Writes the `title` and `url` into the clipboard as a bookmark.
        /// 
        /// **Note:** Most apps on Windows don't support pasting bookmarks into them so you
        /// can use `clipboard.write` to write both a bookmark and fallback text to the
        /// clipboard.
        abstract writeBookmark: title: string * url: string * ?``type``: ClipboardWriteBookmarkType -> unit
        /// Writes the `buffer` into the clipboard as `format`.
        abstract writeBuffer: format: string * buffer: Buffer * ?``type``: ClipboardWriteBufferType -> unit
        /// Writes the `text` into the find pasteboard (the pasteboard that holds
        /// information about the current state of the active application’s find panel) as
        /// plain text. This method uses synchronous IPC when called from the renderer
        /// process.
        abstract writeFindText: text: string -> unit
        /// Writes `markup` to the clipboard.
        abstract writeHTML: markup: string * ?``type``: ClipboardWriteHTMLType -> unit
        /// Writes `image` to the clipboard.
        abstract writeImage: image: NativeImage * ?``type``: ClipboardWriteImageType -> unit
        /// Writes the `text` into the clipboard in RTF.
        abstract writeRTF: text: string * ?``type``: ClipboardWriteRTFType -> unit
        /// Writes the `text` into the clipboard as plain text.
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
        /// Append an argument to Chromium's command line. The argument will be quoted
        /// correctly. Switches will precede arguments regardless of appending order.
        /// 
        /// If you're appending an argument like `--switch=value`, consider using
        /// `appendSwitch('switch', 'value')` instead.
        /// 
        /// **Note:** This will not affect `process.argv`. The intended usage of this
        /// function is to control Chromium's behavior.
        abstract appendArgument: value: string -> unit
        /// Append a switch (with optional `value`) to Chromium's command line.
        /// 
        /// **Note:** This will not affect `process.argv`. The intended usage of this
        /// function is to control Chromium's behavior.
        abstract appendSwitch: the_switch: string * ?value: string -> unit
        /// The command-line switch value.
        /// 
        /// **Note:** When the switch is not present or has no value, it returns empty
        /// string.
        abstract getSwitchValue: the_switch: string -> string
        /// Whether the command-line switch is present.
        abstract hasSwitch: the_switch: string -> bool

    type [<AllowNullLiteral>] CommandLineStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> CommandLine

    type [<AllowNullLiteral>] ContentTracing =
        /// resolves with an array of category groups once all child processes have
        /// acknowledged the `getCategories` request
        /// 
        /// Get a set of category groups. The category groups can change as new code paths
        /// are reached. See also the list of built-in tracing categories.
        abstract getCategories: unit -> Promise<ResizeArray<string>>
        /// Resolves with an object containing the `value` and `percentage` of trace buffer
        /// maximum usage
        /// 
        /// * `value` Number
        /// * `percentage` Number
        /// 
        /// Get the maximum usage across processes of trace buffer as a percentage of the
        /// full state.
        abstract getTraceBufferUsage: unit -> Promise<Electron.TraceBufferUsageReturnValue>
        /// resolved once all child processes have acknowledged the `startRecording`
        /// request.
        /// 
        /// Start recording on all processes.
        /// 
        /// Recording begins immediately locally and asynchronously on child processes as
        /// soon as they receive the EnableRecording request.
        /// 
        /// If a recording is already running, the promise will be immediately resolved, as
        /// only one trace operation can be in progress at a time.
        abstract startRecording: options: U2<TraceConfig, TraceCategoriesAndOptions> -> Promise<unit>
        /// resolves with a path to a file that contains the traced data once all child
        /// processes have acknowledged the `stopRecording` request
        /// 
        /// Stop recording on all processes.
        /// 
        /// Child processes typically cache trace data and only rarely flush and send trace
        /// data back to the main process. This helps to minimize the runtime overhead of
        /// tracing since sending trace data over IPC can be an expensive operation. So, to
        /// end tracing, Chromium asynchronously asks all child processes to flush any
        /// pending trace data.
        /// 
        /// Trace data will be written into `resultFilePath`. If `resultFilePath` is empty
        /// or not provided, trace data will be written to a temporary file, and the path
        /// will be returned in the promise.
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
        /// Whether the cookie is a host-only cookie; this will only be `true` if no domain
        /// was passed.
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
        /// A promise which resolves an array of cookie objects.
        /// 
        /// Sends a request to get all cookies matching `filter`, and resolves a promise
        /// with the response.
        abstract get: filter: CookiesGetFilter -> Promise<ResizeArray<Electron.Cookie>>
        /// A promise which resolves when the cookie has been removed
        /// 
        /// Removes the cookies matching `url` and `name`
        abstract remove: url: string * name: string -> Promise<unit>
        /// A promise which resolves when the cookie has been set
        /// 
        /// Sets a cookie with `details`.
        abstract set: details: CookiesSetDetails -> Promise<unit>

    type [<AllowNullLiteral>] CookiesStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Cookies

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
        /// Set an extra parameter to be sent with the crash report. The values specified
        /// here will be sent in addition to any values set via the `extra` option when
        /// `start` was called. This API is only available on macOS and windows, if you need
        /// to add/update extra parameters on Linux after your first call to `start` you can
        /// call `start` again with the updated `extra` options.
        abstract addExtraParameter: key: string * value: string -> unit
        /// Returns the date and ID of the last crash report. Only crash reports that have
        /// been uploaded will be returned; even if a crash report is present on disk it
        /// will not be returned until it is uploaded. In the case that there are no
        /// uploaded reports, `null` is returned.
        abstract getLastCrashReport: unit -> CrashReport
        /// See all of the current parameters being passed to the crash reporter.
        abstract getParameters: unit -> unit
        /// Returns all uploaded crash reports. Each report contains the date and uploaded
        /// ID.
        abstract getUploadedReports: unit -> ResizeArray<CrashReport>
        /// Whether reports should be submitted to the server. Set through the `start`
        /// method or `setUploadToServer`.
        /// 
        /// *Note:** This API can only be called from the main process.
        abstract getUploadToServer: unit -> bool
        /// Remove a extra parameter from the current set of parameters so that it will not
        /// be sent with the crash report.
        abstract removeExtraParameter: key: string -> unit
        /// This would normally be controlled by user preferences. This has no effect if
        /// called before `start` is called.
        /// 
        /// *Note:** This API can only be called from the main process.
        abstract setUploadToServer: uploadToServer: bool -> unit
        /// You are required to call this method before using any other `crashReporter` APIs
        /// and in each process (main/renderer) from which you want to collect crash
        /// reports. You can pass different options to `crashReporter.start` when calling
        /// from different processes.
        /// 
        /// **Note** Child processes created via the `child_process` module will not have
        /// access to the Electron modules. Therefore, to collect crash reports from them,
        /// use `process.crashReporter.start` instead. Pass the same options as above along
        /// with an additional one called `crashesDirectory` that should point to a
        /// directory to store the crash reports temporarily. You can test this out by
        /// calling `process.crash()` to crash the child process.
        /// 
        /// **Note:** If you need send additional/updated `extra` parameters after your
        /// first call `start` you can call `addExtraParameter` on macOS or call `start`
        /// again with the new/updated `extra` parameters on Linux and Windows.
        /// 
        /// **Note:** On macOS and windows, Electron uses a new `crashpad` client for crash
        /// collection and reporting. If you want to enable crash reporting, initializing
        /// `crashpad` from the main process using `crashReporter.start` is required
        /// regardless of which process you want to collect crashes from. Once initialized
        /// this way, the crashpad handler collects crashes from all processes. You still
        /// have to call `crashReporter.start` from the renderer or child process, otherwise
        /// crashes from them will get reported without `companyName`, `productName` or any
        /// of the `extra` information.
        abstract start: options: CrashReporterStartOptions -> unit

    type [<AllowNullLiteral>] CustomScheme =
        abstract privileges: Privileges option with get, set
        /// Custom schemes to be registered with options.
        abstract scheme: string with get, set

    type [<AllowNullLiteral>] Debugger =
        inherit NodeJS.EventEmitter
        /// Emitted when the debugging session is terminated. This happens either when
        /// `webContents` is closed or devtools is invoked for the attached `webContents`.
        [<Emit "$0.on('detach',$1)">] abstract on_detach: listener: (Event -> string -> unit) -> Debugger
        [<Emit "$0.once('detach',$1)">] abstract once_detach: listener: (Event -> string -> unit) -> Debugger
        [<Emit "$0.addListener('detach',$1)">] abstract addListener_detach: listener: (Event -> string -> unit) -> Debugger
        [<Emit "$0.removeListener('detach',$1)">] abstract removeListener_detach: listener: (Event -> string -> unit) -> Debugger
        /// Emitted whenever the debugging target issues an instrumentation event.
        [<Emit "$0.on('message',$1)">] abstract on_message: listener: (Event -> string -> obj -> unit) -> Debugger
        [<Emit "$0.once('message',$1)">] abstract once_message: listener: (Event -> string -> obj -> unit) -> Debugger
        [<Emit "$0.addListener('message',$1)">] abstract addListener_message: listener: (Event -> string -> obj -> unit) -> Debugger
        [<Emit "$0.removeListener('message',$1)">] abstract removeListener_message: listener: (Event -> string -> obj -> unit) -> Debugger
        /// Attaches the debugger to the `webContents`.
        abstract attach: ?protocolVersion: string -> unit
        /// Detaches the debugger from the `webContents`.
        abstract detach: unit -> unit
        /// Whether a debugger is attached to the `webContents`.
        abstract isAttached: unit -> bool
        /// A promise that resolves with the response defined by the 'returns' attribute of
        /// the command description in the remote debugging protocol or is rejected
        /// indicating the failure of the command.
        /// 
        /// Send given command to the debugging target.
        abstract sendCommand: ``method``: string * ?commandParams: obj -> Promise<obj option>

    type [<AllowNullLiteral>] DebuggerStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Debugger

    type [<AllowNullLiteral>] DesktopCapturer =
        /// Resolves with an array of `DesktopCapturerSource` objects, each
        /// `DesktopCapturerSource` represents a screen or an individual window that can be
        /// captured.
        abstract getSources: options: SourcesOptions -> Promise<ResizeArray<Electron.DesktopCapturerSource>>

    type [<AllowNullLiteral>] DesktopCapturerSource =
        /// An icon image of the application that owns the window or null if the source has
        /// a type screen. The size of the icon is not known in advance and depends on what
        /// the the application provides.
        abstract appIcon: NativeImage with get, set
        /// A unique identifier that will correspond to the `id` of the matching Display
        /// returned by the Screen API. On some platforms, this is equivalent to the `XX`
        /// portion of the `id` field above and on others it will differ. It will be an
        /// empty string if not available.
        abstract display_id: string with get, set
        /// The identifier of a window or screen that can be used as a `chromeMediaSourceId`
        /// constraint when calling [`navigator.webkitGetUserMedia`]. The format of the
        /// identifier will be `window:XX` or `screen:XX`, where `XX` is a random generated
        /// number.
        abstract id: string with get, set
        /// A screen source will be named either `Entire Screen` or `Screen <index>`, while
        /// the name of a window source will match the window title.
        abstract name: string with get, set
        /// A thumbnail image. **Note:** There is no guarantee that the size of the
        /// thumbnail is the same as the `thumbnailSize` specified in the `options` passed
        /// to `desktopCapturer.getSources`. The actual size depends on the scale of the
        /// screen or window.
        abstract thumbnail: NativeImage with get, set

    type [<AllowNullLiteral>] Dialog =
        /// resolves when the certificate trust dialog is shown.
        /// 
        /// On macOS, this displays a modal dialog that shows a message and certificate
        /// information, and gives the user the option of trusting/importing the
        /// certificate. If you provide a `browserWindow` argument the dialog will be
        /// attached to the parent window, making it modal.
        /// 
        /// On Windows the options are more limited, due to the Win32 APIs used:
        /// 
        /// * The `message` argument is not used, as the OS provides its own confirmation
        /// dialog.
        /// * The `browserWindow` argument is ignored since it is not possible to make this
        /// confirmation dialog modal.
        abstract showCertificateTrustDialog: browserWindow: BrowserWindow * options: CertificateTrustDialogOptions -> Promise<unit>
        /// resolves when the certificate trust dialog is shown.
        /// 
        /// On macOS, this displays a modal dialog that shows a message and certificate
        /// information, and gives the user the option of trusting/importing the
        /// certificate. If you provide a `browserWindow` argument the dialog will be
        /// attached to the parent window, making it modal.
        /// 
        /// On Windows the options are more limited, due to the Win32 APIs used:
        /// 
        /// * The `message` argument is not used, as the OS provides its own confirmation
        /// dialog.
        /// * The `browserWindow` argument is ignored since it is not possible to make this
        /// confirmation dialog modal.
        abstract showCertificateTrustDialog: options: CertificateTrustDialogOptions -> Promise<unit>
        /// Displays a modal dialog that shows an error message.
        /// 
        /// This API can be called safely before the `ready` event the `app` module emits,
        /// it is usually used to report errors in early stage of startup. If called before
        /// the app `ready`event on Linux, the message will be emitted to stderr, and no GUI
        /// dialog will appear.
        abstract showErrorBox: title: string * content: string -> unit
        /// resolves with a promise containing the following properties:
        /// 
        /// * `response` Number - The index of the clicked button.
        /// * `checkboxChecked` Boolean - The checked state of the checkbox if
        /// `checkboxLabel` was set. Otherwise `false`.
        /// 
        /// Shows a message box, it will block the process until the message box is closed.
        /// 
        /// The `browserWindow` argument allows the dialog to attach itself to a parent
        /// window, making it modal.
        abstract showMessageBox: browserWindow: BrowserWindow * options: MessageBoxOptions -> Promise<Electron.MessageBoxReturnValue>
        /// resolves with a promise containing the following properties:
        /// 
        /// * `response` Number - The index of the clicked button.
        /// * `checkboxChecked` Boolean - The checked state of the checkbox if
        /// `checkboxLabel` was set. Otherwise `false`.
        /// 
        /// Shows a message box, it will block the process until the message box is closed.
        /// 
        /// The `browserWindow` argument allows the dialog to attach itself to a parent
        /// window, making it modal.
        abstract showMessageBox: options: MessageBoxOptions -> Promise<Electron.MessageBoxReturnValue>
        /// the index of the clicked button.
        /// 
        /// Shows a message box, it will block the process until the message box is closed.
        /// It returns the index of the clicked button.
        /// 
        /// The `browserWindow` argument allows the dialog to attach itself to a parent
        /// window, making it modal. If the `browserWindow` is not shown, the dialog will
        /// not be attached to it. In that case it will be displayed as an independent
        /// window.
        abstract showMessageBoxSync: browserWindow: BrowserWindow * options: MessageBoxSyncOptions -> float
        /// the index of the clicked button.
        /// 
        /// Shows a message box, it will block the process until the message box is closed.
        /// It returns the index of the clicked button.
        /// 
        /// The `browserWindow` argument allows the dialog to attach itself to a parent
        /// window, making it modal. If the `browserWindow` is not shown, the dialog will
        /// not be attached to it. In that case it will be displayed as an independent
        /// window.
        abstract showMessageBoxSync: options: MessageBoxSyncOptions -> float
        /// Resolve with an object containing the following:
        /// 
        /// * `canceled` Boolean - whether or not the dialog was canceled.
        /// * `filePaths` String[] - An array of file paths chosen by the user. If the
        /// dialog is cancelled this will be an empty array.
        /// * `bookmarks` String[] (optional) _macOS_ _mas_ - An array matching the
        /// `filePaths` array of base64 encoded strings which contains security scoped
        /// bookmark data. `securityScopedBookmarks` must be enabled for this to be
        /// populated. (For return values, see table here.)
        /// 
        /// The `browserWindow` argument allows the dialog to attach itself to a parent
        /// window, making it modal.
        /// 
        /// The `filters` specifies an array of file types that can be displayed or selected
        /// when you want to limit the user to a specific type. For example:
        /// 
        /// The `extensions` array should contain extensions without wildcards or dots (e.g.
        /// `'png'` is good but `'.png'` and `'*.png'` are bad). To show all files, use the
        /// `'*'` wildcard (no other wildcard is supported).
        /// 
        /// **Note:** On Windows and Linux an open dialog can not be both a file selector
        /// and a directory selector, so if you set `properties` to `['openFile',
        /// 'openDirectory']` on these platforms, a directory selector will be shown.
        abstract showOpenDialog: browserWindow: BrowserWindow * options: OpenDialogOptions -> Promise<Electron.OpenDialogReturnValue>
        /// Resolve with an object containing the following:
        /// 
        /// * `canceled` Boolean - whether or not the dialog was canceled.
        /// * `filePaths` String[] - An array of file paths chosen by the user. If the
        /// dialog is cancelled this will be an empty array.
        /// * `bookmarks` String[] (optional) _macOS_ _mas_ - An array matching the
        /// `filePaths` array of base64 encoded strings which contains security scoped
        /// bookmark data. `securityScopedBookmarks` must be enabled for this to be
        /// populated. (For return values, see table here.)
        /// 
        /// The `browserWindow` argument allows the dialog to attach itself to a parent
        /// window, making it modal.
        /// 
        /// The `filters` specifies an array of file types that can be displayed or selected
        /// when you want to limit the user to a specific type. For example:
        /// 
        /// The `extensions` array should contain extensions without wildcards or dots (e.g.
        /// `'png'` is good but `'.png'` and `'*.png'` are bad). To show all files, use the
        /// `'*'` wildcard (no other wildcard is supported).
        /// 
        /// **Note:** On Windows and Linux an open dialog can not be both a file selector
        /// and a directory selector, so if you set `properties` to `['openFile',
        /// 'openDirectory']` on these platforms, a directory selector will be shown.
        abstract showOpenDialog: options: OpenDialogOptions -> Promise<Electron.OpenDialogReturnValue>
        /// the file paths chosen by the user; if the dialog is cancelled it returns
        /// `undefined`.
        /// 
        /// The `browserWindow` argument allows the dialog to attach itself to a parent
        /// window, making it modal.
        /// 
        /// The `filters` specifies an array of file types that can be displayed or selected
        /// when you want to limit the user to a specific type. For example:
        /// 
        /// The `extensions` array should contain extensions without wildcards or dots (e.g.
        /// `'png'` is good but `'.png'` and `'*.png'` are bad). To show all files, use the
        /// `'*'` wildcard (no other wildcard is supported).
        /// 
        /// **Note:** On Windows and Linux an open dialog can not be both a file selector
        /// and a directory selector, so if you set `properties` to `['openFile',
        /// 'openDirectory']` on these platforms, a directory selector will be shown.
        abstract showOpenDialogSync: options: OpenDialogSyncOptions -> U2<ResizeArray<string>, obj>
        /// the file paths chosen by the user; if the dialog is cancelled it returns
        /// `undefined`.
        /// 
        /// The `browserWindow` argument allows the dialog to attach itself to a parent
        /// window, making it modal.
        /// 
        /// The `filters` specifies an array of file types that can be displayed or selected
        /// when you want to limit the user to a specific type. For example:
        /// 
        /// The `extensions` array should contain extensions without wildcards or dots (e.g.
        /// `'png'` is good but `'.png'` and `'*.png'` are bad). To show all files, use the
        /// `'*'` wildcard (no other wildcard is supported).
        /// 
        /// **Note:** On Windows and Linux an open dialog can not be both a file selector
        /// and a directory selector, so if you set `properties` to `['openFile',
        /// 'openDirectory']` on these platforms, a directory selector will be shown.
        abstract showOpenDialogSync: browserWindow: BrowserWindow * options: OpenDialogSyncOptions -> U2<ResizeArray<string>, obj>
        /// Resolve with an object containing the following:
        /// 
        /// * `canceled` Boolean - whether or not the dialog was canceled.
        /// * `filePath` String (optional) - If the dialog is canceled, this will be
        /// `undefined`.
        /// * `bookmark` String (optional) _macOS_ _mas_ - Base64 encoded string which
        /// contains the security scoped bookmark data for the saved file.
        /// `securityScopedBookmarks` must be enabled for this to be present. (For return
        /// values, see table here.)
        /// 
        /// The `browserWindow` argument allows the dialog to attach itself to a parent
        /// window, making it modal.
        /// 
        /// The `filters` specifies an array of file types that can be displayed, see
        /// `dialog.showOpenDialog` for an example.
        /// 
        /// **Note:** On macOS, using the asynchronous version is recommended to avoid
        /// issues when expanding and collapsing the dialog.
        abstract showSaveDialog: options: SaveDialogOptions -> Promise<Electron.SaveDialogReturnValue>
        /// Resolve with an object containing the following:
        /// 
        /// * `canceled` Boolean - whether or not the dialog was canceled.
        /// * `filePath` String (optional) - If the dialog is canceled, this will be
        /// `undefined`.
        /// * `bookmark` String (optional) _macOS_ _mas_ - Base64 encoded string which
        /// contains the security scoped bookmark data for the saved file.
        /// `securityScopedBookmarks` must be enabled for this to be present. (For return
        /// values, see table here.)
        /// 
        /// The `browserWindow` argument allows the dialog to attach itself to a parent
        /// window, making it modal.
        /// 
        /// The `filters` specifies an array of file types that can be displayed, see
        /// `dialog.showOpenDialog` for an example.
        /// 
        /// **Note:** On macOS, using the asynchronous version is recommended to avoid
        /// issues when expanding and collapsing the dialog.
        abstract showSaveDialog: browserWindow: BrowserWindow * options: SaveDialogOptions -> Promise<Electron.SaveDialogReturnValue>
        /// the path of the file chosen by the user; if the dialog is cancelled it returns
        /// `undefined`.
        /// 
        /// The `browserWindow` argument allows the dialog to attach itself to a parent
        /// window, making it modal.
        /// 
        /// The `filters` specifies an array of file types that can be displayed, see
        /// `dialog.showOpenDialog` for an example.
        abstract showSaveDialogSync: options: SaveDialogSyncOptions -> U2<string, obj>
        /// the path of the file chosen by the user; if the dialog is cancelled it returns
        /// `undefined`.
        /// 
        /// The `browserWindow` argument allows the dialog to attach itself to a parent
        /// window, making it modal.
        /// 
        /// The `filters` specifies an array of file types that can be displayed, see
        /// `dialog.showOpenDialog` for an example.
        abstract showSaveDialogSync: browserWindow: BrowserWindow * options: SaveDialogSyncOptions -> U2<string, obj>

    type [<AllowNullLiteral>] Display =
        /// Can be `available`, `unavailable`, `unknown`.
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
        /// `true` for an internal display and `false` for an external display
        abstract ``internal``: bool with get, set
        /// Whether or not the display is a monochrome display.
        abstract monochrome: bool with get, set
        /// Can be 0, 90, 180, 270, represents screen rotation in clock-wise degrees.
        abstract rotation: float with get, set
        /// Output device's pixel scale factor.
        abstract scaleFactor: float with get, set
        abstract size: Size with get, set
        /// Can be `available`, `unavailable`, `unknown`.
        abstract touchSupport: DisplayAccelerometerSupport with get, set
        abstract workArea: Rectangle with get, set
        abstract workAreaSize: Size with get, set

    type [<AllowNullLiteral>] Dock =
        /// an ID representing the request.
        /// 
        /// When `critical` is passed, the dock icon will bounce until either the
        /// application becomes active or the request is canceled.
        /// 
        /// When `informational` is passed, the dock icon will bounce for one second.
        /// However, the request remains active until either the application becomes active
        /// or the request is canceled.
        /// 
        /// **Nota Bene:** This method can only be used while the app is not focused; when
        /// the app is focused it will return -1.
        abstract bounce: ?``type``: DockBounceType -> float
        /// Cancel the bounce of `id`.
        abstract cancelBounce: id: float -> unit
        /// Bounces the Downloads stack if the filePath is inside the Downloads folder.
        abstract downloadFinished: filePath: string -> unit
        /// The badge string of the dock.
        abstract getBadge: unit -> string
        /// The application's [dock menu][dock-menu].
        abstract getMenu: unit -> U2<Menu, obj>
        /// Hides the dock icon.
        abstract hide: unit -> unit
        /// Whether the dock icon is visible.
        abstract isVisible: unit -> bool
        /// Sets the string to be displayed in the dock’s badging area.
        abstract setBadge: text: string -> unit
        /// Sets the `image` associated with this dock icon.
        abstract setIcon: image: U2<NativeImage, string> -> unit
        /// Sets the application's [dock menu][dock-menu].
        abstract setMenu: menu: Menu -> unit
        /// Resolves when the dock icon is shown.
        abstract show: unit -> Promise<unit>

    type [<StringEnum>] [<RequireQualifiedAccess>] DockBounceType =
        | Critical
        | Informational

    type [<AllowNullLiteral>] DockStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Dock

    type [<AllowNullLiteral>] DownloadItem =
        inherit NodeJS.EventEmitter
        /// Emitted when the download is in a terminal state. This includes a completed
        /// download, a cancelled download (via `downloadItem.cancel()`), and interrupted
        /// download that can't be resumed.
        /// 
        /// The `state` can be one of following:
        /// 
        /// * `completed` - The download completed successfully.
        /// * `cancelled` - The download has been cancelled.
        /// * `interrupted` - The download has interrupted and can not resume.
        [<Emit "$0.on('done',$1)">] abstract on_done: listener: (Event -> DownloadItemOn_done -> unit) -> DownloadItem
        [<Emit "$0.once('done',$1)">] abstract once_done: listener: (Event -> DownloadItemOn_done -> unit) -> DownloadItem
        [<Emit "$0.addListener('done',$1)">] abstract addListener_done: listener: (Event -> DownloadItemOn_done -> unit) -> DownloadItem
        [<Emit "$0.removeListener('done',$1)">] abstract removeListener_done: listener: (Event -> DownloadItemOn_done -> unit) -> DownloadItem
        /// Emitted when the download has been updated and is not done.
        /// 
        /// The `state` can be one of following:
        /// 
        /// * `progressing` - The download is in-progress.
        /// * `interrupted` - The download has interrupted and can be resumed.
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
        /// Returns the object previously set by
        /// `downloadItem.setSaveDialogOptions(options)`.
        abstract getSaveDialogOptions: unit -> SaveDialogOptions
        /// The save path of the download item. This will be either the path set via
        /// `downloadItem.setSavePath(path)` or the path selected from the shown save
        /// dialog.
        /// 
        /// *Deprecated: use the `savePath` property instead.**
        abstract getSavePath: unit -> string
        /// Number of seconds since the UNIX epoch when the download was started.
        abstract getStartTime: unit -> float
        /// The current state. Can be `progressing`, `completed`, `cancelled` or
        /// `interrupted`.
        /// 
        /// **Note:** The following methods are useful specifically to resume a `cancelled`
        /// item when session is restarted.
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
        /// Resumes the download that has been paused.
        /// 
        /// **Note:** To enable resumable downloads the server you are downloading from must
        /// support range requests and provide both `Last-Modified` and `ETag` header
        /// values. Otherwise `resume()` will dismiss previously received bytes and restart
        /// the download from the beginning.
        abstract resume: unit -> unit
        /// This API allows the user to set custom options for the save dialog that opens
        /// for the download item by default. The API is only available in session's
        /// `will-download` callback function.
        abstract setSaveDialogOptions: options: SaveDialogOptions -> unit
        /// The API is only available in session's `will-download` callback function. If
        /// user doesn't set the save path via the API, Electron will use the original
        /// routine to determine the save path; this usually prompts a save dialog.
        /// 
        /// *Deprecated: use the `savePath` property instead.**
        abstract setSavePath: path: string -> unit
        abstract savePath: string with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] DownloadItemGetStateReturn =
        | Progressing
        | Completed
        | Cancelled
        | Interrupted

    type [<AllowNullLiteral>] DownloadItemStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> DownloadItem

    type [<AllowNullLiteral>] Event =
        inherit GlobalEvent
        abstract preventDefault: (unit -> unit) with get, set

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
        /// Whether this application has registered `accelerator`.
        /// 
        /// When the accelerator is already taken by other applications, this call will
        /// still return `false`. This behavior is intended by operating systems, since they
        /// don't want applications to fight for global shortcuts.
        abstract isRegistered: accelerator: Accelerator -> bool
        /// Whether or not the shortcut was registered successfully.
        /// 
        /// Registers a global shortcut of `accelerator`. The `callback` is called when the
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
        abstract register: accelerator: Accelerator * callback: (unit -> unit) -> bool
        /// Registers a global shortcut of all `accelerator` items in `accelerators`. The
        /// `callback` is called when any of the registered shortcuts are pressed by the
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
        abstract registerAll: accelerators: ResizeArray<string> * callback: (unit -> unit) -> unit
        /// Unregisters the global shortcut of `accelerator`.
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
        /// Resolves with an array of `Product` objects.
        /// 
        /// Retrieves the product descriptions.
        abstract getProducts: productIDs: ResizeArray<string> -> Promise<ResizeArray<Electron.Product>>
        /// the path to the receipt.
        abstract getReceiptURL: unit -> string
        /// Returns `true` if the product is valid and added to the payment queue.
        /// 
        /// You should listen for the `transactions-updated` event as soon as possible and
        /// certainly before you call `purchaseProduct`.
        abstract purchaseProduct: productID: string * ?quantity: float -> Promise<bool>

    type [<AllowNullLiteral>] IncomingMessage =
        inherit NodeJS.EventEmitter
        /// Emitted when a request has been canceled during an ongoing HTTP transaction.
        [<Emit "$0.on('aborted',$1)">] abstract on_aborted: listener: Function -> IncomingMessage
        [<Emit "$0.once('aborted',$1)">] abstract once_aborted: listener: Function -> IncomingMessage
        [<Emit "$0.addListener('aborted',$1)">] abstract addListener_aborted: listener: Function -> IncomingMessage
        [<Emit "$0.removeListener('aborted',$1)">] abstract removeListener_aborted: listener: Function -> IncomingMessage
        /// The `data` event is the usual method of transferring response data into
        /// applicative code.
        [<Emit "$0.on('data',$1)">] abstract on_data: listener: (Buffer -> unit) -> IncomingMessage
        [<Emit "$0.once('data',$1)">] abstract once_data: listener: (Buffer -> unit) -> IncomingMessage
        [<Emit "$0.addListener('data',$1)">] abstract addListener_data: listener: (Buffer -> unit) -> IncomingMessage
        [<Emit "$0.removeListener('data',$1)">] abstract removeListener_data: listener: (Buffer -> unit) -> IncomingMessage
        /// Indicates that response body has ended.
        [<Emit "$0.on('end',$1)">] abstract on_end: listener: Function -> IncomingMessage
        [<Emit "$0.once('end',$1)">] abstract once_end: listener: Function -> IncomingMessage
        [<Emit "$0.addListener('end',$1)">] abstract addListener_end: listener: Function -> IncomingMessage
        [<Emit "$0.removeListener('end',$1)">] abstract removeListener_end: listener: Function -> IncomingMessage
        /// Returns:
        /// 
        /// `error` Error - Typically holds an error string identifying failure root cause.
        /// 
        /// Emitted when an error was encountered while streaming response data events. For
        /// instance, if the server closes the underlying while the response is still
        /// streaming, an `error` event will be emitted on the response object and a `close`
        /// event will subsequently follow on the request object.
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
        [<Emit "new $0($1...)">] abstract Create: unit -> IncomingMessage

    type [<AllowNullLiteral>] InputEvent =
        /// An array of modifiers of the event, can be `shift`, `control`, `alt`, `meta`,
        /// `isKeypad`, `isAutoRepeat`, `leftButtonDown`, `middleButtonDown`,
        /// `rightButtonDown`, `capsLock`, `numLock`, `left`, `right`.
        abstract modifiers: Array<InputEventModifiersArray> with get, set

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
        /// Adds a handler for an `invoke`able IPC. This handler will be called whenever a
        /// renderer calls `ipcRenderer.invoke(channel, ...args)`.
        /// 
        /// If `listener` returns a Promise, the eventual result of the promise will be
        /// returned as a reply to the remote caller. Otherwise, the return value of the
        /// listener will be used as the value of the reply.
        /// 
        /// The `event` that is passed as the first argument to the handler is the same as
        /// that passed to a regular event listener. It includes information about which
        /// WebContents is the source of the invoke request.
        abstract handle: channel: string * listener: (IpcMainInvokeEvent -> ResizeArray<obj option> -> U2<Promise<unit>, obj option>) -> unit
        /// Handles a single `invoke`able IPC message, then removes the listener. See
        /// `ipcMain.handle(channel, listener)`.
        abstract handleOnce: channel: string * listener: (IpcMainInvokeEvent -> ResizeArray<obj option> -> U2<Promise<unit>, obj option>) -> unit
        /// Listens to `channel`, when a new message arrives `listener` would be called with
        /// `listener(event, args...)`.
        abstract on: channel: string * listener: (IpcMainEvent -> ResizeArray<obj option> -> unit) -> IpcMain
        /// Adds a one time `listener` function for the event. This `listener` is invoked
        /// only the next time a message is sent to `channel`, after which it is removed.
        abstract once: channel: string * listener: (IpcMainEvent -> ResizeArray<obj option> -> unit) -> IpcMain
        /// Removes listeners of the specified `channel`.
        abstract removeAllListeners: ?channel: string -> IpcMain
        /// Removes any handler for `channel`, if present.
        abstract removeHandler: channel: string -> unit
        /// Removes the specified `listener` from the listener array for the specified
        /// `channel`.
        abstract removeListener: channel: string * listener: (ResizeArray<obj option> -> unit) -> IpcMain

    type [<AllowNullLiteral>] IpcMainEvent =
        inherit Event
        /// The ID of the renderer frame that sent this message
        abstract frameId: float with get, set
        /// A function that will send an IPC message to the renderer frame that sent the
        /// original message that you are currently handling.  You should use this method to
        /// "reply" to the sent message in order to guarantee the reply will go to the
        /// correct process and frame.
        abstract reply: Function with get, set
        /// Set this to the value to be returned in a synchronous message
        abstract returnValue: obj option with get, set
        /// Returns the `webContents` that sent the message
        abstract sender: WebContents with get, set

    type [<AllowNullLiteral>] IpcMainInvokeEvent =
        inherit Event
        /// The ID of the renderer frame that sent this message
        abstract frameId: float with get, set
        /// Returns the `webContents` that sent the message
        abstract sender: WebContents with get, set

    type [<AllowNullLiteral>] IpcRenderer =
        inherit NodeJS.EventEmitter
        /// Resolves with the response from the main process.
        /// 
        /// Send a message to the main process asynchronously via `channel` and expect an
        /// asynchronous result. Arguments will be serialized as JSON internally and hence
        /// no functions or prototype chain will be included.
        /// 
        /// The main process should listen for `channel` with `ipcMain.handle()`.
        /// 
        /// For example:
        abstract invoke: channel: string * [<ParamArray>] args: ResizeArray<obj option> -> Promise<obj option>
        /// Listens to `channel`, when a new message arrives `listener` would be called with
        /// `listener(event, args...)`.
        abstract on: channel: string * listener: (IpcRendererEvent -> ResizeArray<obj option> -> unit) -> IpcRenderer
        /// Adds a one time `listener` function for the event. This `listener` is invoked
        /// only the next time a message is sent to `channel`, after which it is removed.
        abstract once: channel: string * listener: (IpcRendererEvent -> ResizeArray<obj option> -> unit) -> IpcRenderer
        /// Removes all listeners, or those of the specified `channel`.
        abstract removeAllListeners: channel: string -> IpcRenderer
        /// Removes the specified `listener` from the listener array for the specified
        /// `channel`.
        abstract removeListener: channel: string * listener: (ResizeArray<obj option> -> unit) -> IpcRenderer
        /// Send a message to the main process asynchronously via `channel`, you can also
        /// send arbitrary arguments. Arguments will be serialized as JSON internally and
        /// hence no functions or prototype chain will be included.
        /// 
        /// The main process handles it by listening for `channel` with the `ipcMain`
        /// module.
        abstract send: channel: string * [<ParamArray>] args: ResizeArray<obj option> -> unit
        /// The value sent back by the `ipcMain` handler.
        /// 
        /// Send a message to the main process synchronously via `channel`, you can also
        /// send arbitrary arguments. Arguments will be serialized in JSON internally and
        /// hence no functions or prototype chain will be included.
        /// 
        /// The main process handles it by listening for `channel` with `ipcMain` module,
        /// and replies by setting `event.returnValue`.
        /// 
        /// **Note:** Sending a synchronous message will block the whole renderer process,
        /// unless you know what you are doing you should never use it.
        abstract sendSync: channel: string * [<ParamArray>] args: ResizeArray<obj option> -> obj option
        /// Sends a message to a window with `webContentsId` via `channel`.
        abstract sendTo: webContentsId: float * channel: string * [<ParamArray>] args: ResizeArray<obj option> -> unit
        /// Like `ipcRenderer.send` but the event will be sent to the `<webview>` element in
        /// the host page instead of the main process.
        abstract sendToHost: channel: string * [<ParamArray>] args: ResizeArray<obj option> -> unit

    type [<AllowNullLiteral>] IpcRendererEvent =
        inherit Event
        /// The `IpcRenderer` instance that emitted the event originally
        abstract sender: IpcRenderer with get, set
        /// The `webContents.id` that sent the message, you can call
        /// `event.sender.sendTo(event.senderId, ...)` to reply to the message, see
        /// ipcRenderer.sendTo for more information. This only applies to messages sent from
        /// a different renderer. Messages sent directly from the main process set
        /// `event.senderId` to `0`.
        abstract senderId: float with get, set

    type [<AllowNullLiteral>] JumpListCategory =
        /// Array of `JumpListItem` objects if `type` is `tasks` or `custom`, otherwise it
        /// should be omitted.
        abstract items: ResizeArray<JumpListItem> option with get, set
        /// Must be set if `type` is `custom`, otherwise it should be omitted.
        abstract name: string option with get, set
        /// One of the following:
        abstract ``type``: JumpListCategoryType option with get, set

    type [<AllowNullLiteral>] JumpListItem =
        /// The command line arguments when `program` is executed. Should only be set if
        /// `type` is `task`.
        abstract args: string option with get, set
        /// Description of the task (displayed in a tooltip). Should only be set if `type`
        /// is `task`.
        abstract description: string option with get, set
        /// The index of the icon in the resource file. If a resource file contains multiple
        /// icons this value can be used to specify the zero-based index of the icon that
        /// should be displayed for this task. If a resource file contains only one icon,
        /// this property should be set to zero.
        abstract iconIndex: float option with get, set
        /// The absolute path to an icon to be displayed in a Jump List, which can be an
        /// arbitrary resource file that contains an icon (e.g. `.ico`, `.exe`, `.dll`). You
        /// can usually specify `process.execPath` to show the program icon.
        abstract iconPath: string option with get, set
        /// Path of the file to open, should only be set if `type` is `file`.
        abstract path: string option with get, set
        /// Path of the program to execute, usually you should specify `process.execPath`
        /// which opens the current program. Should only be set if `type` is `task`.
        abstract program: string option with get, set
        /// The text to be displayed for the item in the Jump List. Should only be set if
        /// `type` is `task`.
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
        /// The type of the event, can be `keyDown`, `keyUp` or `char`.
        abstract ``type``: KeyboardInputEventType with get, set

    type [<AllowNullLiteral>] MemoryInfo =
        /// The maximum amount of memory that has ever been pinned to actual physical RAM.
        abstract peakWorkingSetSize: float with get, set
        /// The amount of memory not shared by other processes, such as JS heap or HTML
        /// content.
        abstract privateBytes: float option with get, set
        /// The amount of memory currently pinned to actual physical RAM.
        abstract workingSetSize: float with get, set

    type [<AllowNullLiteral>] MemoryUsageDetails =
        abstract count: float with get, set
        abstract liveSize: float with get, set
        abstract size: float with get, set

    type [<AllowNullLiteral>] Menu =
        /// Emitted when a popup is closed either manually or with `menu.closePopup()`.
        [<Emit "$0.on('menu-will-close',$1)">] abstract ``on_menu-will-close``: listener: (Event -> unit) -> Menu
        [<Emit "$0.once('menu-will-close',$1)">] abstract ``once_menu-will-close``: listener: (Event -> unit) -> Menu
        [<Emit "$0.addListener('menu-will-close',$1)">] abstract ``addListener_menu-will-close``: listener: (Event -> unit) -> Menu
        [<Emit "$0.removeListener('menu-will-close',$1)">] abstract ``removeListener_menu-will-close``: listener: (Event -> unit) -> Menu
        /// Emitted when `menu.popup()` is called.
        [<Emit "$0.on('menu-will-show',$1)">] abstract ``on_menu-will-show``: listener: (Event -> unit) -> Menu
        [<Emit "$0.once('menu-will-show',$1)">] abstract ``once_menu-will-show``: listener: (Event -> unit) -> Menu
        [<Emit "$0.addListener('menu-will-show',$1)">] abstract ``addListener_menu-will-show``: listener: (Event -> unit) -> Menu
        [<Emit "$0.removeListener('menu-will-show',$1)">] abstract ``removeListener_menu-will-show``: listener: (Event -> unit) -> Menu
        /// Appends the `menuItem` to the menu.
        abstract append: menuItem: MenuItem -> unit
        /// Closes the context menu in the `browserWindow`.
        abstract closePopup: ?browserWindow: BrowserWindow -> unit
        /// the item with the specified `id`
        abstract getMenuItemById: id: string -> MenuItem
        /// Inserts the `menuItem` to the `pos` position of the menu.
        abstract insert: pos: float * menuItem: MenuItem -> unit
        /// Pops up this menu as a context menu in the `BrowserWindow`.
        abstract popup: ?options: PopupOptions -> unit
        abstract items: ResizeArray<MenuItem> with get, set

    type [<AllowNullLiteral>] MenuStatic =
        /// Menu
        [<Emit "new $0($1...)">] abstract Create: unit -> Menu
        /// Generally, the `template` is an array of `options` for constructing a MenuItem.
        /// The usage can be referenced above.
        /// 
        /// You can also attach other fields to the element of the `template` and they will
        /// become properties of the constructed menu items.
        abstract buildFromTemplate: template: Array<U2<MenuItemConstructorOptions, MenuItem>> -> Menu
        /// The application menu, if set, or `null`, if not set.
        /// 
        /// **Note:** The returned `Menu` instance doesn't support dynamic addition or
        /// removal of menu items. Instance properties can still be dynamically modified.
        abstract getApplicationMenu: unit -> U2<Menu, obj>
        /// Sends the `action` to the first responder of application. This is used for
        /// emulating default macOS menu behaviors. Usually you would use the `role`
        /// property of a `MenuItem`.
        /// 
        /// See the macOS Cocoa Event Handling Guide for more information on macOS' native
        /// actions.
        abstract sendActionToFirstResponder: action: string -> unit
        /// Sets `menu` as the application menu on macOS. On Windows and Linux, the `menu`
        /// will be set as each window's top menu.
        /// 
        /// Also on Windows and Linux, you can use a `&` in the top-level item name to
        /// indicate which letter should get a generated accelerator. For example, using
        /// `&File` for the file menu would result in a generated `Alt-F` accelerator that
        /// opens the associated menu. The indicated character in the button label gets an
        /// underline. The `&` character is not displayed on the button label.
        /// 
        /// Passing `null` will suppress the default menu. On Windows and Linux, this has
        /// the additional effect of removing the menu bar from the window.
        /// 
        /// **Note:** The default menu will be created automatically if the app does not set
        /// one. It contains standard items such as `File`, `Edit`, `View`, `Window` and
        /// `Help`.
        abstract setApplicationMenu: menu: U2<Menu, obj> -> unit

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
        [<Emit "new $0($1...)">] abstract Create: options: MenuItemConstructorOptions -> MenuItem

    type [<AllowNullLiteral>] MimeTypedBuffer =
        /// The actual Buffer content.
        abstract data: Buffer with get, set
        /// The mimeType of the Buffer that you are sending.
        abstract mimeType: string with get, set

    type [<AllowNullLiteral>] MouseInputEvent =
        inherit InputEvent
        /// The button pressed, can be `left`, `middle`, `right`.
        abstract button: MouseInputEventButton option with get, set
        abstract clickCount: float option with get, set
        abstract globalX: float option with get, set
        abstract globalY: float option with get, set
        abstract movementX: float option with get, set
        abstract movementY: float option with get, set
        /// The type of the event, can be `mouseDown`, `mouseUp`, `mouseEnter`,
        /// `mouseLeave`, `contextMenu`, `mouseWheel` or `mouseMove`.
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
        /// The type of the event, can be `mouseWheel`.
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
        /// A Buffer that contains the image's raw bitmap pixel data.
        /// 
        /// The difference between `getBitmap()` and `toBitmap()` is, `getBitmap()` does not
        /// copy the bitmap data, so you have to use the returned Buffer immediately in
        /// current event loop tick, otherwise the data might be changed or destroyed.
        abstract getBitmap: ?options: BitmapOptions -> Buffer
        /// A Buffer that stores C pointer to underlying native handle of the image. On
        /// macOS, a pointer to `NSImage` instance would be returned.
        /// 
        /// Notice that the returned pointer is a weak pointer to the underlying native
        /// image instead of a copy, so you _must_ ensure that the associated `nativeImage`
        /// instance is kept around.
        abstract getNativeHandle: unit -> Buffer
        abstract getSize: unit -> Size
        /// Whether the image is empty.
        abstract isEmpty: unit -> bool
        /// Whether the image is a template image.
        /// 
        /// *Deprecated**
        abstract isTemplateImage: unit -> bool
        /// The resized image.
        /// 
        /// If only the `height` or the `width` are specified then the current aspect ratio
        /// will be preserved in the resized image.
        abstract resize: options: ResizeOptions -> NativeImage
        /// Marks the image as a template image.
        /// 
        /// *Deprecated**
        abstract setTemplateImage: option: bool -> unit
        /// A Buffer that contains a copy of the image's raw bitmap pixel data.
        abstract toBitmap: ?options: ToBitmapOptions -> Buffer
        /// The data URL of the image.
        abstract toDataURL: ?options: ToDataURLOptions -> string
        /// A Buffer that contains the image's `JPEG` encoded data.
        abstract toJPEG: quality: float -> Buffer
        /// A Buffer that contains the image's `PNG` encoded data.
        abstract toPNG: ?options: ToPNGOptions -> Buffer
        abstract isMacTemplateImage: bool with get, set

    type [<AllowNullLiteral>] NativeImageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> NativeImage
        /// Creates an empty `NativeImage` instance.
        abstract createEmpty: unit -> NativeImage
        /// Creates a new `NativeImage` instance from `buffer` that contains the raw bitmap
        /// pixel data returned by `toBitmap()`. The specific format is platform-dependent.
        abstract createFromBitmap: buffer: Buffer * options: CreateFromBitmapOptions -> NativeImage
        /// Creates a new `NativeImage` instance from `buffer`. Tries to decode as PNG or
        /// JPEG first.
        abstract createFromBuffer: buffer: Buffer * ?options: CreateFromBufferOptions -> NativeImage
        /// Creates a new `NativeImage` instance from `dataURL`.
        abstract createFromDataURL: dataURL: string -> NativeImage
        /// Creates a new `NativeImage` instance from the NSImage that maps to the given
        /// image name. See `System Icons` for a list of possible values.
        /// 
        /// The `hslShift` is applied to the image with the following rules
        /// 
        /// * `hsl_shift[0]` (hue): The absolute hue value for the image - 0 and 1 map to 0
        /// and 360 on the hue color wheel (red).
        /// * `hsl_shift[1]` (saturation): A saturation shift for the image, with the
        /// following key values: 0 = remove all color. 0.5 = leave unchanged. 1 = fully
        /// saturate the image.
        /// * `hsl_shift[2]` (lightness): A lightness shift for the image, with the
        /// following key values: 0 = remove all lightness (make all pixels black). 0.5 =
        /// leave unchanged. 1 = full lightness (make all pixels white).
        /// 
        /// This means that `[-1, 0, 1]` will make the image completely white and `[-1, 1,
        /// 0]` will make the image completely black.
        /// 
        /// In some cases, the `NSImageName` doesn't match its string representation; one
        /// example of this is `NSFolderImageName`, whose string representation would
        /// actually be `NSFolder`. Therefore, you'll need to determine the correct string
        /// representation for your image before passing it in. This can be done with the
        /// following:
        /// 
        /// `echo -e '#import <Cocoa/Cocoa.h>\nint main() { NSLog(@"%@", SYSTEM_IMAGE_NAME);
        /// }' | clang -otest -x objective-c -framework Cocoa - && ./test`
        /// 
        /// where `SYSTEM_IMAGE_NAME` should be replaced with any value from this list.
        abstract createFromNamedImage: imageName: string * ?hslShift: ResizeArray<float> -> NativeImage
        /// Creates a new `NativeImage` instance from a file located at `path`. This method
        /// returns an empty image if the `path` does not exist, cannot be read, or is not a
        /// valid image.
        abstract createFromPath: path: string -> NativeImage

    type [<AllowNullLiteral>] NativeTheme =
        inherit NodeJS.EventEmitter
        /// Emitted when something in the underlying NativeTheme has changed. This normally
        /// means that either the value of `shouldUseDarkColors`,
        /// `shouldUseHighContrastColors` or `shouldUseInvertedColorScheme` has changed. You
        /// will have to check them to determine which one has changed.
        [<Emit "$0.on('updated',$1)">] abstract on_updated: listener: Function -> NativeTheme
        [<Emit "$0.once('updated',$1)">] abstract once_updated: listener: Function -> NativeTheme
        [<Emit "$0.addListener('updated',$1)">] abstract addListener_updated: listener: Function -> NativeTheme
        [<Emit "$0.removeListener('updated',$1)">] abstract removeListener_updated: listener: Function -> NativeTheme
        /// A `Boolean` for if the OS / Chromium currently has a dark mode enabled or is
        /// being instructed to show a dark-style UI.  If you want to modify this value you
        /// should use `themeSource` below.
        abstract shouldUseDarkColors: bool
        /// A `Boolean` for if the OS / Chromium currently has high-contrast mode enabled or
        /// is being instructed to show a high-constrast UI.
        abstract shouldUseHighContrastColors: bool
        /// A `Boolean` for if the OS / Chromium currently has an inverted color scheme or
        /// is being instructed to use an inverted color scheme.
        abstract shouldUseInvertedColorScheme: bool
        /// A `String` property that can be `system`, `light` or `dark`.  It is used to
        /// override and supercede the value that Chromium has chosen to use internally.
        /// 
        /// Setting this property to `system` will remove the override and everything will
        /// be reset to the OS default.  By default `themeSource` is `system`.
        /// 
        /// Settings this property to `dark` will have the following effects:
        /// 
        /// * `nativeTheme.shouldUseDarkColors` will be `true` when accessed
        /// * Any UI Electron renders on Linux and Windows including context menus,
        /// devtools, etc. will use the dark UI.
        /// * Any UI the OS renders on macOS including menus, window frames, etc. will use
        /// the dark UI.
        /// * The `prefers-color-scheme` CSS query will match `dark` mode.
        /// * The `updated` event will be emitted
        /// 
        /// Settings this property to `light` will have the following effects:
        /// 
        /// * `nativeTheme.shouldUseDarkColors` will be `false` when accessed
        /// * Any UI Electron renders on Linux and Windows including context menus,
        /// devtools, etc. will use the light UI.
        /// * Any UI the OS renders on macOS including menus, window frames, etc. will use
        /// the light UI.
        /// * The `prefers-color-scheme` CSS query will match `light` mode.
        /// * The `updated` event will be emitted
        /// 
        /// The usage of this property should align with a classic "dark mode" state machine
        /// in your application where the user has three options.
        /// 
        /// * `Follow OS` --> `themeSource = 'system'`
        /// * `Dark Mode` --> `themeSource = 'dark'`
        /// * `Light Mode` --> `themeSource = 'light'`
        /// 
        /// Your application should then always use `shouldUseDarkColors` to determine what
        /// CSS to apply.
        abstract themeSource: NativeThemeThemeSource with get, set

    type [<AllowNullLiteral>] Net =
        /// Creates a `ClientRequest` instance using the provided `options` which are
        /// directly forwarded to the `ClientRequest` constructor. The `net.request` method
        /// would be used to issue both secure and insecure HTTP requests according to the
        /// specified protocol scheme in the `options` object.
        abstract request: options: U2<ClientRequestConstructorOptions, string> -> ClientRequest

    type [<AllowNullLiteral>] NetLog =
        /// resolves when the net log has begun recording.
        /// 
        /// Starts recording network events to `path`.
        abstract startLogging: path: string * ?options: StartLoggingOptions -> Promise<unit>
        /// resolves with a file path to which network logs were recorded.
        /// 
        /// Stops recording network events. If not called, net logging will automatically
        /// end when app quits.
        abstract stopLogging: unit -> Promise<string>
        /// A `Boolean` property that indicates whether network logs are recorded.
        abstract currentlyLogging: bool
        /// A `String` property that returns the path to the current log file.
        abstract currentlyLoggingPath: string

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
        /// Emitted when the user clicks the "Reply" button on a notification with
        /// `hasReply: true`.
        [<Emit "$0.on('reply',$1)">] abstract on_reply: listener: (Event -> string -> unit) -> Notification
        [<Emit "$0.once('reply',$1)">] abstract once_reply: listener: (Event -> string -> unit) -> Notification
        [<Emit "$0.addListener('reply',$1)">] abstract addListener_reply: listener: (Event -> string -> unit) -> Notification
        [<Emit "$0.removeListener('reply',$1)">] abstract removeListener_reply: listener: (Event -> string -> unit) -> Notification
        /// Emitted when the notification is shown to the user, note this could be fired
        /// multiple times as a notification can be shown multiple times through the
        /// `show()` method.
        [<Emit "$0.on('show',$1)">] abstract on_show: listener: (Event -> unit) -> Notification
        [<Emit "$0.once('show',$1)">] abstract once_show: listener: (Event -> unit) -> Notification
        [<Emit "$0.addListener('show',$1)">] abstract addListener_show: listener: (Event -> unit) -> Notification
        [<Emit "$0.removeListener('show',$1)">] abstract removeListener_show: listener: (Event -> unit) -> Notification
        /// Dismisses the notification.
        abstract close: unit -> unit
        /// Immediately shows the notification to the user, please note this means unlike
        /// the HTML5 Notification implementation, instantiating a `new Notification` does
        /// not immediately show it to the user, you need to call this method before the OS
        /// will display it.
        /// 
        /// If the notification has been shown before, this method will dismiss the
        /// previously shown notification and create a new one with identical properties.
        abstract show: unit -> unit
        abstract actions: ResizeArray<NotificationAction> with get, set
        abstract body: string with get, set
        abstract closeButtonText: string with get, set
        abstract hasReply: bool with get, set
        abstract replyPlaceholder: string with get, set
        abstract silent: bool with get, set
        abstract sound: string with get, set
        abstract subtitle: string with get, set
        abstract title: string with get, set

    type [<AllowNullLiteral>] NotificationStatic =
        /// Notification
        [<Emit "new $0($1...)">] abstract Create: ?options: NotificationConstructorOptions -> Notification
        /// Whether or not desktop notifications are supported on the current system
        abstract isSupported: unit -> bool

    type [<AllowNullLiteral>] NotificationAction =
        /// The label for the given action.
        abstract text: string option with get, set
        /// The type of action, can be `button`.
        abstract ``type``: string with get, set

    type [<AllowNullLiteral>] Point =
        abstract x: float with get, set
        abstract y: float with get, set

    type [<AllowNullLiteral>] PowerMonitor =
        inherit NodeJS.EventEmitter
        /// Emitted when the system is about to lock the screen.
        [<Emit "$0.on('lock-screen',$1)">] abstract ``on_lock-screen``: listener: Function -> PowerMonitor
        [<Emit "$0.once('lock-screen',$1)">] abstract ``once_lock-screen``: listener: Function -> PowerMonitor
        [<Emit "$0.addListener('lock-screen',$1)">] abstract ``addListener_lock-screen``: listener: Function -> PowerMonitor
        [<Emit "$0.removeListener('lock-screen',$1)">] abstract ``removeListener_lock-screen``: listener: Function -> PowerMonitor
        /// Emitted when the system changes to AC power.
        [<Emit "$0.on('on-ac',$1)">] abstract ``on_on-ac``: listener: Function -> PowerMonitor
        [<Emit "$0.once('on-ac',$1)">] abstract ``once_on-ac``: listener: Function -> PowerMonitor
        [<Emit "$0.addListener('on-ac',$1)">] abstract ``addListener_on-ac``: listener: Function -> PowerMonitor
        [<Emit "$0.removeListener('on-ac',$1)">] abstract ``removeListener_on-ac``: listener: Function -> PowerMonitor
        /// Emitted when system changes to battery power.
        [<Emit "$0.on('on-battery',$1)">] abstract ``on_on-battery``: listener: Function -> PowerMonitor
        [<Emit "$0.once('on-battery',$1)">] abstract ``once_on-battery``: listener: Function -> PowerMonitor
        [<Emit "$0.addListener('on-battery',$1)">] abstract ``addListener_on-battery``: listener: Function -> PowerMonitor
        [<Emit "$0.removeListener('on-battery',$1)">] abstract ``removeListener_on-battery``: listener: Function -> PowerMonitor
        /// Emitted when system is resuming.
        [<Emit "$0.on('resume',$1)">] abstract on_resume: listener: Function -> PowerMonitor
        [<Emit "$0.once('resume',$1)">] abstract once_resume: listener: Function -> PowerMonitor
        [<Emit "$0.addListener('resume',$1)">] abstract addListener_resume: listener: Function -> PowerMonitor
        [<Emit "$0.removeListener('resume',$1)">] abstract removeListener_resume: listener: Function -> PowerMonitor
        /// Emitted when the system is about to reboot or shut down. If the event handler
        /// invokes `e.preventDefault()`, Electron will attempt to delay system shutdown in
        /// order for the app to exit cleanly. If `e.preventDefault()` is called, the app
        /// should exit as soon as possible by calling something like `app.quit()`.
        [<Emit "$0.on('shutdown',$1)">] abstract on_shutdown: listener: Function -> PowerMonitor
        [<Emit "$0.once('shutdown',$1)">] abstract once_shutdown: listener: Function -> PowerMonitor
        [<Emit "$0.addListener('shutdown',$1)">] abstract addListener_shutdown: listener: Function -> PowerMonitor
        [<Emit "$0.removeListener('shutdown',$1)">] abstract removeListener_shutdown: listener: Function -> PowerMonitor
        /// Emitted when the system is suspending.
        [<Emit "$0.on('suspend',$1)">] abstract on_suspend: listener: Function -> PowerMonitor
        [<Emit "$0.once('suspend',$1)">] abstract once_suspend: listener: Function -> PowerMonitor
        [<Emit "$0.addListener('suspend',$1)">] abstract addListener_suspend: listener: Function -> PowerMonitor
        [<Emit "$0.removeListener('suspend',$1)">] abstract removeListener_suspend: listener: Function -> PowerMonitor
        /// Emitted as soon as the systems screen is unlocked.
        [<Emit "$0.on('unlock-screen',$1)">] abstract ``on_unlock-screen``: listener: Function -> PowerMonitor
        [<Emit "$0.once('unlock-screen',$1)">] abstract ``once_unlock-screen``: listener: Function -> PowerMonitor
        [<Emit "$0.addListener('unlock-screen',$1)">] abstract ``addListener_unlock-screen``: listener: Function -> PowerMonitor
        [<Emit "$0.removeListener('unlock-screen',$1)">] abstract ``removeListener_unlock-screen``: listener: Function -> PowerMonitor
        /// The system's current state. Can be `active`, `idle`, `locked` or `unknown`.
        /// 
        /// Calculate the system idle state. `idleThreshold` is the amount of time (in
        /// seconds) before considered idle.  `locked` is available on supported systems
        /// only.
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
        /// Whether the corresponding `powerSaveBlocker` has started.
        abstract isStarted: id: float -> bool
        /// The blocker ID that is assigned to this power blocker.
        /// 
        /// Starts preventing the system from entering lower-power mode. Returns an integer
        /// identifying the power save blocker.
        /// 
        /// **Note:** `prevent-display-sleep` has higher precedence over
        /// `prevent-app-suspension`. Only the highest precedence type takes effect. In
        /// other words, `prevent-display-sleep` always takes precedence over
        /// `prevent-app-suspension`.
        /// 
        /// For example, an API calling A requests for `prevent-app-suspension`, and another
        /// calling B requests for `prevent-display-sleep`. `prevent-display-sleep` will be
        /// used until B stops its request. After that, `prevent-app-suspension` is used.
        abstract start: ``type``: PowerSaveBlockerStartType -> float
        /// Stops the specified power save blocker.
        abstract stop: id: float -> unit

    type [<StringEnum>] [<RequireQualifiedAccess>] PowerSaveBlockerStartType =
        | [<CompiledName "prevent-app-suspension">] PreventAppSuspension
        | [<CompiledName "prevent-display-sleep">] PreventDisplaySleep

    type [<AllowNullLiteral>] PrinterInfo =
        abstract description: string with get, set
        abstract isDefault: bool with get, set
        abstract name: string with get, set
        abstract status: float with get, set

    type [<AllowNullLiteral>] ProcessMemoryInfo =
        /// The amount of memory not shared by other processes, such as JS heap or HTML
        /// content in Kilobytes.
        abstract ``private``: float with get, set
        /// The amount of memory currently pinned to actual physical RAM in Kilobytes.
        abstract residentSet: float with get, set
        /// The amount of memory shared between processes, typically memory consumed by the
        /// Electron code itself in Kilobytes.
        abstract shared: float with get, set

    type [<AllowNullLiteral>] ProcessMetric =
        /// CPU usage of the process.
        abstract cpu: CPUUsage with get, set
        /// Creation time for this process. The time is represented as number of
        /// milliseconds since epoch. Since the `pid` can be reused after a process dies, it
        /// is useful to use both the `pid` and the `creationTime` to uniquely identify a
        /// process.
        abstract creationTime: float with get, set
        /// One of the following values:
        abstract integrityLevel: ProcessMetricIntegrityLevel option with get, set
        /// Memory information for the process.
        abstract memory: MemoryInfo with get, set
        /// Process id of the process.
        abstract pid: float with get, set
        /// Whether the process is sandboxed on OS level.
        abstract sandboxed: bool option with get, set
        /// Process type. One of the following values:
        abstract ``type``: ProcessMetricType with get, set

    type [<AllowNullLiteral>] Product =
        /// The total size of the content, in bytes.
        abstract contentLengths: ResizeArray<float> with get, set
        /// A string that identifies the version of the content.
        abstract contentVersion: string with get, set
        /// The locale formatted price of the product.
        abstract formattedPrice: string with get, set
        /// A Boolean value that indicates whether the App Store has downloadable content
        /// for this product. `true` if at least one file has been associated with the
        /// product.
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
        /// Intercepts `scheme` protocol and uses `handler` as the protocol's new handler
        /// which sends a `Buffer` as a response.
        abstract interceptBufferProtocol: scheme: string * handler: (Request -> (Buffer -> unit) -> unit) * ?completion: (Error -> unit) -> unit
        /// Intercepts `scheme` protocol and uses `handler` as the protocol's new handler
        /// which sends a file as a response.
        abstract interceptFileProtocol: scheme: string * handler: (Request -> (string -> unit) -> unit) * ?completion: (Error -> unit) -> unit
        /// Intercepts `scheme` protocol and uses `handler` as the protocol's new handler
        /// which sends a new HTTP request as a response.
        abstract interceptHttpProtocol: scheme: string * handler: (Request -> (RedirectRequest -> unit) -> unit) * ?completion: (Error -> unit) -> unit
        /// Same as `protocol.registerStreamProtocol`, except that it replaces an existing
        /// protocol handler.
        abstract interceptStreamProtocol: scheme: string * handler: (Request -> (U2<NodeJS.ReadableStream, StreamProtocolResponse> -> unit) -> unit) * ?completion: (Error -> unit) -> unit
        /// Intercepts `scheme` protocol and uses `handler` as the protocol's new handler
        /// which sends a `String` as a response.
        abstract interceptStringProtocol: scheme: string * handler: (Request -> (U2<string, StringProtocolResponse> -> unit) -> unit) * ?completion: (Error -> unit) -> unit
        /// fulfilled with a boolean that indicates whether there is already a handler for
        /// `scheme`.
        abstract isProtocolHandled: scheme: string -> Promise<bool>
        /// Registers a protocol of `scheme` that will send a `Buffer` as a response.
        /// 
        /// The usage is the same with `registerFileProtocol`, except that the `callback`
        /// should be called with either a `Buffer` object or an object that has the `data`,
        /// `mimeType`, and `charset` properties.
        /// 
        /// Example:
        abstract registerBufferProtocol: scheme: string * handler: (Request -> (U2<Buffer, MimeTypedBuffer> -> unit) -> unit) * ?completion: (Error -> unit) -> unit
        /// Registers a protocol of `scheme` that will send the file as a response. The
        /// `handler` will be called with `handler(request, callback)` when a `request` is
        /// going to be created with `scheme`. `completion` will be called with
        /// `completion(null)` when `scheme` is successfully registered or
        /// `completion(error)` when failed.
        /// 
        /// To handle the `request`, the `callback` should be called with either the file's
        /// path or an object that has a `path` property, e.g. `callback(filePath)` or
        /// `callback({ path: filePath })`. The object may also have a `headers` property
        /// which gives a map of headers to values for the response headers, e.g.
        /// `callback({ path: filePath, headers: {"Content-Security-Policy": "default-src
        /// 'none'"]})`.
        /// 
        /// When `callback` is called with nothing, a number, or an object that has an
        /// `error` property, the `request` will fail with the `error` number you specified.
        /// For the available error numbers you can use, please see the net error list.
        /// 
        /// By default the `scheme` is treated like `http:`, which is parsed differently
        /// than protocols that follow the "generic URI syntax" like `file:`.
        abstract registerFileProtocol: scheme: string * handler: (Request -> (U2<string, FilePathWithHeaders> -> unit) -> unit) * ?completion: (Error -> unit) -> unit
        /// Registers a protocol of `scheme` that will send an HTTP request as a response.
        /// 
        /// The usage is the same with `registerFileProtocol`, except that the `callback`
        /// should be called with a `redirectRequest` object that has the `url`, `method`,
        /// `referrer`, `uploadData` and `session` properties.
        /// 
        /// By default the HTTP request will reuse the current session. If you want the
        /// request to have a different session you should set `session` to `null`.
        /// 
        /// For POST requests the `uploadData` object must be provided.
        abstract registerHttpProtocol: scheme: string * handler: (Request -> (RedirectRequest -> unit) -> unit) * ?completion: (Error -> unit) -> unit
        /// **Note:** This method can only be used before the `ready` event of the `app`
        /// module gets emitted and can be called only once.
        /// 
        /// Registers the `scheme` as standard, secure, bypasses content security policy for
        /// resources, allows registering ServiceWorker and supports fetch API.
        /// 
        /// Specify a privilege with the value of `true` to enable the capability. An
        /// example of registering a privileged scheme, with bypassing Content Security
        /// Policy:
        /// 
        /// A standard scheme adheres to what RFC 3986 calls generic URI syntax. For example
        /// `http` and `https` are standard schemes, while `file` is not.
        /// 
        /// Registering a scheme as standard, will allow relative and absolute resources to
        /// be resolved correctly when served. Otherwise the scheme will behave like the
        /// `file` protocol, but without the ability to resolve relative URLs.
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
        /// register a custom protocol to replace the `http` protocol, you have to register
        /// it as a standard scheme.
        /// 
        /// `protocol.registerSchemesAsPrivileged` can be used to replicate the
        /// functionality of the previous `protocol.registerStandardSchemes`,
        /// `webFrame.registerURLSchemeAs*` and `protocol.registerServiceWorkerSchemes`
        /// functions that existed prior to Electron 5.0.0, for example:
        /// 
        /// *before (<= v4.x)**
        /// 
        /// *after (>= v5.x)**
        abstract registerSchemesAsPrivileged: customSchemes: ResizeArray<CustomScheme> -> unit
        /// Registers a protocol of `scheme` that will send a `Readable` as a response.
        /// 
        /// The usage is similar to the other `register{Any}Protocol`, except that the
        /// `callback` should be called with either a `Readable` object or an object that
        /// has the `data`, `statusCode`, and `headers` properties.
        /// 
        /// Example:
        /// 
        /// It is possible to pass any object that implements the readable stream API (emits
        /// `data`/`end`/`error` events). For example, here's how a file could be returned:
        abstract registerStreamProtocol: scheme: string * handler: (Request -> (U2<NodeJS.ReadableStream, StreamProtocolResponse> -> unit) -> unit) * ?completion: (Error -> unit) -> unit
        /// Registers a protocol of `scheme` that will send a `String` as a response.
        /// 
        /// The usage is the same with `registerFileProtocol`, except that the `callback`
        /// should be called with either a `String` or an object that has the `data`,
        /// `mimeType`, and `charset` properties.
        abstract registerStringProtocol: scheme: string * handler: (Request -> (U2<string, StringProtocolResponse> -> unit) -> unit) * ?completion: (Error -> unit) -> unit
        /// Remove the interceptor installed for `scheme` and restore its original handler.
        abstract uninterceptProtocol: scheme: string * ?completion: (Error -> unit) -> unit
        /// Unregisters the custom protocol of `scheme`.
        abstract unregisterProtocol: scheme: string * ?completion: (Error -> unit) -> unit

    type [<AllowNullLiteral>] ProtocolRequest =
        abstract ``method``: string with get, set
        abstract referrer: string with get, set
        abstract uploadData: ResizeArray<UploadData> option with get, set
        abstract url: string with get, set

    type [<AllowNullLiteral>] ProtocolResponse =
        /// The charset of response body, default is `"utf-8"`.
        abstract charset: string option with get, set
        /// The response body. When returning stream as response, this is a Node.js readable
        /// stream representing the response body. When returning `Buffer` as response, this
        /// is a `Buffer`. When returning `String` as response, this is a `String`. This is
        /// ignored for other types of responses.
        abstract data: U3<Buffer, string, NodeJS.ReadableStream> option with get, set
        /// When assigned, the `request` will fail with the `error` number . For the
        /// available error numbers you can use, please see the net error list.
        abstract error: float option with get, set
        /// An object containing the response headers. The keys must be String, and values
        /// must be either String or Array of String.
        abstract headers: Record<string, U2<string, ResizeArray<string>>> option with get, set
        /// The HTTP `method`. This is only used for file and URL responses.
        abstract ``method``: string option with get, set
        /// The MIME type of response body, default is `"text/html"`. Setting `mimeType`
        /// would implicitly set the `content-type` header in response, but if
        /// `content-type` is already set in `headers`, the `mimeType` would be ignored.
        abstract mimeType: string option with get, set
        /// Path to the file which would be sent as response body. This is only used for
        /// file responses.
        abstract path: string option with get, set
        /// The `referrer` URL. This is only used for file and URL responses.
        abstract referrer: string option with get, set
        /// The session used for requesting URL, by default the HTTP request will reuse the
        /// current session. Setting `session` to `null` would use a random independent
        /// session. This is only used for URL responses.
        abstract session: Session option with get, set
        /// The HTTP response code, default is 200.
        abstract statusCode: float option with get, set
        /// The data used as upload data. This is only used for URL responses when `method`
        /// is `"POST"`.
        abstract uploadData: ProtocolResponseUploadData option with get, set
        /// Download the `url` and pipe the result as response body. This is only used for
        /// URL responses.
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
        /// Can be `default`, `unsafe-url`, `no-referrer-when-downgrade`, `no-referrer`,
        /// `origin`, `strict-origin-when-cross-origin`, `same-origin` or `strict-origin`.
        /// See the Referrer-Policy spec for more details on the meaning of these values.
        abstract policy: ReferrerPolicy with get, set
        /// HTTP Referrer URL.
        abstract url: string with get, set

    type [<AllowNullLiteral>] Remote =
        inherit MainInterface
        /// The web contents of this web page.
        abstract getCurrentWebContents: unit -> WebContents
        /// The window to which this web page belongs.
        /// 
        /// **Note:** Do not use `removeAllListeners` on `BrowserWindow`. Use of this can
        /// remove all `blur` listeners, disable click events on touch bar buttons, and
        /// other unintended consequences.
        abstract getCurrentWindow: unit -> BrowserWindow
        /// The global variable of `name` (e.g. `global[name]`) in the main process.
        abstract getGlobal: name: string -> obj option
        /// The object returned by `require(module)` in the main process. Modules specified
        /// by their relative path will resolve relative to the entrypoint of the main
        /// process.
        /// 
        /// e.g.
        abstract require: ``module``: string -> obj option
        /// A `NodeJS.Process` object.  The `process` object in the main process. This is
        /// the same as `remote.getGlobal('process')` but is cached.
        abstract ``process``: NodeJS.Process

    type [<AllowNullLiteral>] RemoveClientCertificate =
        /// Origin of the server whose associated client certificate must be removed from
        /// the cache.
        abstract origin: string with get, set
        /// `clientCertificate`.
        abstract ``type``: string with get, set

    type [<AllowNullLiteral>] RemovePassword =
        /// When provided, the authentication info related to the origin will only be
        /// removed otherwise the entire cache will be cleared.
        abstract origin: string option with get, set
        /// Credentials of the authentication. Must be provided if removing by `origin`.
        abstract password: string option with get, set
        /// Realm of the authentication. Must be provided if removing by `origin`.
        abstract realm: string option with get, set
        /// Scheme of the authentication. Can be `basic`, `digest`, `ntlm`, `negotiate`.
        /// Must be provided if removing by `origin`.
        abstract scheme: RemovePasswordScheme option with get, set
        /// `password`.
        abstract ``type``: string with get, set
        /// Credentials of the authentication. Must be provided if removing by `origin`.
        abstract username: string option with get, set

    type [<AllowNullLiteral>] Screen =
        inherit NodeJS.EventEmitter
        /// Emitted when `newDisplay` has been added.
        [<Emit "$0.on('display-added',$1)">] abstract ``on_display-added``: listener: (Event -> Display -> unit) -> Screen
        [<Emit "$0.once('display-added',$1)">] abstract ``once_display-added``: listener: (Event -> Display -> unit) -> Screen
        [<Emit "$0.addListener('display-added',$1)">] abstract ``addListener_display-added``: listener: (Event -> Display -> unit) -> Screen
        [<Emit "$0.removeListener('display-added',$1)">] abstract ``removeListener_display-added``: listener: (Event -> Display -> unit) -> Screen
        /// Emitted when one or more metrics change in a `display`. The `changedMetrics` is
        /// an array of strings that describe the changes. Possible changes are `bounds`,
        /// `workArea`, `scaleFactor` and `rotation`.
        [<Emit "$0.on('display-metrics-changed',$1)">] abstract ``on_display-metrics-changed``: listener: (Event -> Display -> ResizeArray<string> -> unit) -> Screen
        [<Emit "$0.once('display-metrics-changed',$1)">] abstract ``once_display-metrics-changed``: listener: (Event -> Display -> ResizeArray<string> -> unit) -> Screen
        [<Emit "$0.addListener('display-metrics-changed',$1)">] abstract ``addListener_display-metrics-changed``: listener: (Event -> Display -> ResizeArray<string> -> unit) -> Screen
        [<Emit "$0.removeListener('display-metrics-changed',$1)">] abstract ``removeListener_display-metrics-changed``: listener: (Event -> Display -> ResizeArray<string> -> unit) -> Screen
        /// Emitted when `oldDisplay` has been removed.
        [<Emit "$0.on('display-removed',$1)">] abstract ``on_display-removed``: listener: (Event -> Display -> unit) -> Screen
        [<Emit "$0.once('display-removed',$1)">] abstract ``once_display-removed``: listener: (Event -> Display -> unit) -> Screen
        [<Emit "$0.addListener('display-removed',$1)">] abstract ``addListener_display-removed``: listener: (Event -> Display -> unit) -> Screen
        [<Emit "$0.removeListener('display-removed',$1)">] abstract ``removeListener_display-removed``: listener: (Event -> Display -> unit) -> Screen
        /// Converts a screen DIP point to a screen physical point. The DPI scale is
        /// performed relative to the display containing the DIP point.
        abstract dipToScreenPoint: point: Point -> Point
        /// Converts a screen DIP rect to a screen physical rect. The DPI scale is performed
        /// relative to the display nearest to `window`. If `window` is null, scaling will
        /// be performed to the display nearest to `rect`.
        abstract dipToScreenRect: window: U2<BrowserWindow, obj> * rect: Rectangle -> Rectangle
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
        /// Converts a screen physical point to a screen DIP point. The DPI scale is
        /// performed relative to the display containing the physical point.
        abstract screenToDipPoint: point: Point -> Point
        /// Converts a screen physical rect to a screen DIP rect. The DPI scale is performed
        /// relative to the display nearest to `window`. If `window` is null, scaling will
        /// be performed to the display nearest to `rect`.
        abstract screenToDipRect: window: U2<BrowserWindow, obj> * rect: Rectangle -> Rectangle

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

    type [<AllowNullLiteral>] Session =
        inherit NodeJS.EventEmitter
        /// Emitted when a render process requests preconnection to a URL, generally due to
        /// a resource hint.
        [<Emit "$0.on('preconnect',$1)">] abstract on_preconnect: listener: (Event -> string -> bool -> unit) -> Session
        [<Emit "$0.once('preconnect',$1)">] abstract once_preconnect: listener: (Event -> string -> bool -> unit) -> Session
        [<Emit "$0.addListener('preconnect',$1)">] abstract addListener_preconnect: listener: (Event -> string -> bool -> unit) -> Session
        [<Emit "$0.removeListener('preconnect',$1)">] abstract removeListener_preconnect: listener: (Event -> string -> bool -> unit) -> Session
        /// Emitted when Electron is about to download `item` in `webContents`.
        /// 
        /// Calling `event.preventDefault()` will cancel the download and `item` will not be
        /// available from next tick of the process.
        [<Emit "$0.on('will-download',$1)">] abstract ``on_will-download``: listener: (Event -> DownloadItem -> WebContents -> unit) -> Session
        [<Emit "$0.once('will-download',$1)">] abstract ``once_will-download``: listener: (Event -> DownloadItem -> WebContents -> unit) -> Session
        [<Emit "$0.addListener('will-download',$1)">] abstract ``addListener_will-download``: listener: (Event -> DownloadItem -> WebContents -> unit) -> Session
        [<Emit "$0.removeListener('will-download',$1)">] abstract ``removeListener_will-download``: listener: (Event -> DownloadItem -> WebContents -> unit) -> Session
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
        /// Allows resuming `cancelled` or `interrupted` downloads from previous `Session`.
        /// The API will generate a DownloadItem that can be accessed with the will-download
        /// event. The DownloadItem will not have any `WebContents` associated with it and
        /// the initial state will be `interrupted`. The download will start only when the
        /// `resume` API is called on the DownloadItem.
        abstract createInterruptedDownload: options: CreateInterruptedDownloadOptions -> unit
        /// Disables any network emulation already active for the `session`. Resets to the
        /// original network configuration.
        abstract disableNetworkEmulation: unit -> unit
        /// Emulates network with the given configuration for the `session`.
        abstract enableNetworkEmulation: options: EnableNetworkEmulationOptions -> unit
        /// Writes any unwritten DOMStorage data to disk.
        abstract flushStorageData: unit -> unit
        /// resolves with blob data.
        abstract getBlobData: identifier: string -> Promise<Buffer>
        /// the session's current cache size, in bytes.
        abstract getCacheSize: unit -> Promise<float>
        /// an array of paths to preload scripts that have been registered.
        abstract getPreloads: unit -> ResizeArray<string>
        /// The user agent for this session.
        abstract getUserAgent: unit -> string
        /// Preconnects the given number of sockets to an origin.
        abstract preconnect: options: PreconnectOptions -> unit
        /// Resolves with the proxy information for `url`.
        abstract resolveProxy: url: string -> Promise<string>
        /// Sets the certificate verify proc for `session`, the `proc` will be called with
        /// `proc(request, callback)` whenever a server certificate verification is
        /// requested. Calling `callback(0)` accepts the certificate, calling `callback(-2)`
        /// rejects it.
        /// 
        /// Calling `setCertificateVerifyProc(null)` will revert back to default certificate
        /// verify proc.
        abstract setCertificateVerifyProc: proc: (ProcRequest -> (float -> unit) -> unit) -> unit
        /// Sets download saving directory. By default, the download directory will be the
        /// `Downloads` under the respective app folder.
        abstract setDownloadPath: path: string -> unit
        /// Sets the handler which can be used to respond to permission checks for the
        /// `session`. Returning `true` will allow the permission and `false` will reject
        /// it. To clear the handler, call `setPermissionCheckHandler(null)`.
        abstract setPermissionCheckHandler: handler: U2<(WebContents -> string -> string -> Details -> bool), obj> -> unit
        /// Sets the handler which can be used to respond to permission requests for the
        /// `session`. Calling `callback(true)` will allow the permission and
        /// `callback(false)` will reject it. To clear the handler, call
        /// `setPermissionRequestHandler(null)`.
        abstract setPermissionRequestHandler: handler: U2<(WebContents -> string -> (bool -> unit) -> PermissionRequestHandlerHandlerDetails -> unit), obj> -> unit
        /// Adds scripts that will be executed on ALL web contents that are associated with
        /// this session just before normal `preload` scripts run.
        abstract setPreloads: preloads: ResizeArray<string> -> unit
        /// Resolves when the proxy setting process is complete.
        /// 
        /// Sets the proxy settings.
        /// 
        /// When `pacScript` and `proxyRules` are provided together, the `proxyRules` option
        /// is ignored and `pacScript` configuration is applied.
        /// 
        /// The `proxyRules` has to follow the rules below:
        /// 
        /// For example:
        /// 
        /// * `http=foopy:80;ftp=foopy2` - Use HTTP proxy `foopy:80` for `http://` URLs, and
        /// HTTP proxy `foopy2:80` for `ftp://` URLs.
        /// * `foopy:80` - Use HTTP proxy `foopy:80` for all URLs.
        /// * `foopy:80,bar,direct://` - Use HTTP proxy `foopy:80` for all URLs, failing
        /// over to `bar` if `foopy:80` is unavailable, and after that using no proxy.
        /// * `socks4://foopy` - Use SOCKS v4 proxy `foopy:1080` for all URLs.
        /// * `http=foopy,socks5://bar.com` - Use HTTP proxy `foopy` for http URLs, and fail
        /// over to the SOCKS5 proxy `bar.com` if `foopy` is unavailable.
        /// * `http=foopy,direct://` - Use HTTP proxy `foopy` for http URLs, and use no
        /// proxy if `foopy` is unavailable.
        /// * `http=foopy;socks=foopy2` - Use HTTP proxy `foopy` for http URLs, and use
        /// `socks4://foopy2` for all other URLs.
        /// 
        /// The `proxyBypassRules` is a comma separated list of rules described below:
        /// 
        /// * `[ URL_SCHEME "://" ] HOSTNAME_PATTERN [ ":" <port> ]`
        /// 
        /// Match all hostnames that match the pattern HOSTNAME_PATTERN.
        /// 
        /// Examples: "foobar.com", "*foobar.com", "*.foobar.com", "*foobar.com:99",
        /// "https://x.*.y.com:99"
        /// * `"." HOSTNAME_SUFFIX_PATTERN [ ":" PORT ]`
        /// 
        /// Match a particular domain suffix.
        /// 
        /// Examples: ".google.com", ".com", "http://.google.com"
        /// * `[ SCHEME "://" ] IP_LITERAL [ ":" PORT ]`
        /// 
        /// Match URLs which are IP address literals.
        /// 
        /// Examples: "127.0.1", "[0:0::1]", "[::1]", "http://[::1]:99"
        /// * `IP_LITERAL "/" PREFIX_LENGTH_IN_BITS`
        /// 
        /// Match any URL that is to an IP literal that falls between the given range. IP
        /// range is specified using CIDR notation.
        /// 
        /// Examples: "192.168.1.1/16", "fefe:13::abc/33".
        /// * `<local>`
        /// 
        /// Match local addresses. The meaning of `<local>` is whether the host matches one
        /// of: "127.0.0.1", "::1", "localhost".
        abstract setProxy: config: Config -> Promise<unit>
        /// Overrides the `userAgent` and `acceptLanguages` for this session.
        /// 
        /// The `acceptLanguages` must a comma separated ordered list of language codes, for
        /// example `"en-US,fr,de,ko,zh-CN,ja"`.
        /// 
        /// This doesn't affect existing `WebContents`, and each `WebContents` can use
        /// `webContents.setUserAgent` to override the session-wide user agent.
        abstract setUserAgent: userAgent: string * ?acceptLanguages: string -> unit
        abstract cookies: Cookies
        abstract netLog: NetLog
        abstract protocol: Protocol
        abstract webRequest: WebRequest

    type [<AllowNullLiteral>] SessionStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Session
        /// A session instance from `partition` string. When there is an existing `Session`
        /// with the same `partition`, it will be returned; otherwise a new `Session`
        /// instance will be created with `options`.
        /// 
        /// If `partition` starts with `persist:`, the page will use a persistent session
        /// available to all pages in the app with the same `partition`. if there is no
        /// `persist:` prefix, the page will use an in-memory session. If the `partition` is
        /// empty then default session of the app will be returned.
        /// 
        /// To create a `Session` with `options`, you have to ensure the `Session` with the
        /// `partition` has never been used before. There is no way to change the `options`
        /// of an existing `Session` object.
        abstract fromPartition: partition: string * ?options: FromPartitionOptions -> Session
        /// A `Session` object, the default session object of the app.
        abstract defaultSession: Session with get, set

    type [<AllowNullLiteral>] Shell =
        /// Play the beep sound.
        abstract beep: unit -> unit
        /// Whether the item was successfully moved to the trash.
        /// 
        /// Move the given file to trash and returns a boolean status for the operation.
        abstract moveItemToTrash: fullPath: string -> bool
        /// Open the given external protocol URL in the desktop's default manner. (For
        /// example, mailto: URLs in the user's default mail agent).
        abstract openExternal: url: string * ?options: OpenExternalOptions -> Promise<unit>
        /// Whether the item was successfully opened.
        /// 
        /// Open the given file in the desktop's default manner.
        abstract openItem: fullPath: string -> bool
        /// Resolves the shortcut link at `shortcutPath`.
        /// 
        /// An exception will be thrown when any error happens.
        abstract readShortcutLink: shortcutPath: string -> ShortcutDetails
        /// Show the given file in a file manager. If possible, select the file.
        abstract showItemInFolder: fullPath: string -> unit
        /// Whether the shortcut was created successfully.
        /// 
        /// Creates or updates a shortcut link at `shortcutPath`.
        abstract writeShortcutLink: shortcutPath: string * operation: ShellWriteShortcutLinkOperation * options: ShortcutDetails -> bool
        /// Whether the shortcut was created successfully.
        /// 
        /// Creates or updates a shortcut link at `shortcutPath`.
        abstract writeShortcutLink: shortcutPath: string * options: ShortcutDetails -> bool

    type [<StringEnum>] [<RequireQualifiedAccess>] ShellWriteShortcutLinkOperation =
        | Create
        | Update
        | Replace

    type [<AllowNullLiteral>] ShortcutDetails =
        /// The Application User Model ID. Default is empty.
        abstract appUserModelId: string option with get, set
        /// The arguments to be applied to `target` when launching from this shortcut.
        /// Default is empty.
        abstract args: string option with get, set
        /// The working directory. Default is empty.
        abstract cwd: string option with get, set
        /// The description of the shortcut. Default is empty.
        abstract description: string option with get, set
        /// The path to the icon, can be a DLL or EXE. `icon` and `iconIndex` have to be set
        /// together. Default is empty, which uses the target's icon.
        abstract icon: string option with get, set
        /// The resource ID of icon when `icon` is a DLL or EXE. Default is 0.
        abstract iconIndex: float option with get, set
        /// The target to launch from this shortcut.
        abstract target: string with get, set

    type [<AllowNullLiteral>] Size =
        abstract height: float with get, set
        abstract width: float with get, set

    type [<AllowNullLiteral>] StreamProtocolResponse =
        /// A Node.js readable stream representing the response body.
        abstract data: U2<NodeJS.ReadableStream, obj> with get, set
        /// An object containing the response headers.
        abstract headers: Record<string, U2<string, ResizeArray<string>>> option with get, set
        /// The HTTP response code.
        abstract statusCode: float option with get, set

    type [<AllowNullLiteral>] StringProtocolResponse =
        /// Charset of the response.
        abstract charset: string option with get, set
        /// A string representing the response body.
        abstract data: U2<string, obj> with get, set
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
        /// **Deprecated:** Should use the new `updated` event on the `nativeTheme` module.
        [<Emit "$0.on('high-contrast-color-scheme-changed',$1)">] abstract ``on_high-contrast-color-scheme-changed``: listener: (Event -> bool -> unit) -> SystemPreferences
        [<Emit "$0.once('high-contrast-color-scheme-changed',$1)">] abstract ``once_high-contrast-color-scheme-changed``: listener: (Event -> bool -> unit) -> SystemPreferences
        [<Emit "$0.addListener('high-contrast-color-scheme-changed',$1)">] abstract ``addListener_high-contrast-color-scheme-changed``: listener: (Event -> bool -> unit) -> SystemPreferences
        [<Emit "$0.removeListener('high-contrast-color-scheme-changed',$1)">] abstract ``removeListener_high-contrast-color-scheme-changed``: listener: (Event -> bool -> unit) -> SystemPreferences
        /// **Deprecated:** Should use the new `updated` event on the `nativeTheme` module.
        [<Emit "$0.on('inverted-color-scheme-changed',$1)">] abstract ``on_inverted-color-scheme-changed``: listener: (Event -> bool -> unit) -> SystemPreferences
        [<Emit "$0.once('inverted-color-scheme-changed',$1)">] abstract ``once_inverted-color-scheme-changed``: listener: (Event -> bool -> unit) -> SystemPreferences
        [<Emit "$0.addListener('inverted-color-scheme-changed',$1)">] abstract ``addListener_inverted-color-scheme-changed``: listener: (Event -> bool -> unit) -> SystemPreferences
        [<Emit "$0.removeListener('inverted-color-scheme-changed',$1)">] abstract ``removeListener_inverted-color-scheme-changed``: listener: (Event -> bool -> unit) -> SystemPreferences
        /// A promise that resolves with `true` if consent was granted and `false` if it was
        /// denied. If an invalid `mediaType` is passed, the promise will be rejected. If an
        /// access request was denied and later is changed through the System Preferences
        /// pane, a restart of the app will be required for the new permissions to take
        /// effect. If access has already been requested and denied, it _must_ be changed
        /// through the preference pane; an alert will not pop up and the promise will
        /// resolve with the existing access status.
        /// 
        /// **Important:** In order to properly leverage this API, you must set the
        /// `NSMicrophoneUsageDescription` and `NSCameraUsageDescription` strings in your
        /// app's `Info.plist` file. The values for these keys will be used to populate the
        /// permission dialogs so that the user will be properly informed as to the purpose
        /// of the permission request. See Electron Application Distribution for more
        /// information about how to set these in the context of Electron.
        /// 
        /// This user consent was not required until macOS 10.14 Mojave, so this method will
        /// always return `true` if your system is running 10.13 High Sierra or lower.
        abstract askForMediaAccess: mediaType: SystemPreferencesAskForMediaAccessMediaType -> Promise<bool>
        /// whether or not this device has the ability to use Touch ID.
        /// 
        /// **NOTE:** This API will return `false` on macOS systems older than Sierra
        /// 10.12.2.
        abstract canPromptTouchID: unit -> bool
        /// The users current system wide accent color preference in RGBA hexadecimal form.
        /// 
        /// This API is only available on macOS 10.14 Mojave or newer.
        abstract getAccentColor: unit -> string
        /// * `shouldRenderRichAnimation` Boolean - Returns true if rich animations should
        /// be rendered. Looks at session type (e.g. remote desktop) and accessibility
        /// settings to give guidance for heavy animations.
        /// * `scrollAnimationsEnabledBySystem` Boolean - Determines on a per-platform basis
        /// whether scroll animations (e.g. produced by home/end key) should be enabled.
        /// * `prefersReducedMotion` Boolean - Determines whether the user desires reduced
        /// motion based on platform APIs.
        /// 
        /// Returns an object with system animation settings.
        abstract getAnimationSettings: unit -> AnimationSettings
        /// | `null` - Can be `dark`, `light` or `unknown`.
        /// 
        /// Gets the macOS appearance setting that you have declared you want for your
        /// application, maps to NSApplication.appearance. You can use the
        /// `setAppLevelAppearance` API to set this value.
        /// 
        /// *Deprecated**
        abstract getAppLevelAppearance: unit -> SystemPreferencesGetAppLevelAppearanceReturn
        /// The system color setting in RGB hexadecimal form (`#ABCDEF`). See the Windows
        /// docs and the MacOS docs for more details.
        abstract getColor: color: SystemPreferencesGetColorColor -> string
        /// Can be `dark`, `light` or `unknown`.
        /// 
        /// Gets the macOS appearance setting that is currently applied to your application,
        /// maps to NSApplication.effectiveAppearance
        /// 
        /// Please note that until Electron is built targeting the 10.14 SDK, your
        /// application's `effectiveAppearance` will default to 'light' and won't inherit
        /// the OS preference. In the interim in order for your application to inherit the
        /// OS preference you must set the `NSRequiresAquaSystemAppearance` key in your apps
        /// `Info.plist` to `false`.  If you are using `electron-packager` or
        /// `electron-forge` just set the `enableDarwinDarkMode` packager option to `true`.
        /// See the Electron Packager API for more details.
        /// 
        /// *Deprecated**
        abstract getEffectiveAppearance: unit -> SystemPreferencesGetEffectiveAppearanceReturn
        /// Can be `not-determined`, `granted`, `denied`, `restricted` or `unknown`.
        /// 
        /// This user consent was not required until macOS 10.14 Mojave, so this method will
        /// always return `granted` if your system is running 10.13 High Sierra or lower.
        abstract getMediaAccessStatus: mediaType: string -> SystemPreferencesGetMediaAccessStatusReturn
        /// The standard system color formatted as `#RRGGBBAA`.
        /// 
        /// Returns one of several standard system colors that automatically adapt to
        /// vibrancy and changes in accessibility settings like 'Increase contrast' and
        /// 'Reduce transparency'. See Apple Documentation for  more details.
        abstract getSystemColor: color: SystemPreferencesGetSystemColorColor -> string
        /// The value of `key` in `NSUserDefaults`.
        /// 
        /// Some popular `key` and `type`s are:
        /// 
        /// * `AppleInterfaceStyle`: `string`
        /// * `AppleAquaColorVariant`: `integer`
        /// * `AppleHighlightColor`: `string`
        /// * `AppleShowScrollBars`: `string`
        /// * `NSNavRecentPlaces`: `array`
        /// * `NSPreferredWebServices`: `dictionary`
        /// * `NSUserDictionaryReplacementItems`: `array`
        abstract getUserDefault: key: string * ``type``: SystemPreferencesGetUserDefaultType -> obj option
        /// `true` if DWM composition (Aero Glass) is enabled, and `false` otherwise.
        /// 
        /// An example of using it to determine if you should create a transparent window or
        /// not (transparent windows won't work correctly when DWM composition is disabled):
        abstract isAeroGlassEnabled: unit -> bool
        /// Whether the system is in Dark Mode.
        /// 
        /// **Note:** On macOS 10.15 Catalina in order for this API to return the correct
        /// value when in the "automatic" dark mode setting you must either have
        /// `NSRequiresAquaSystemAppearance=false` in your `Info.plist` or be on Electron
        /// `>=7.0.0`.  See the dark mode guide for more information.
        /// 
        /// *Deprecated:** Should use the new `nativeTheme.shouldUseDarkColors` API.
        abstract isDarkMode: unit -> bool
        /// `true` if a high contrast theme is active, `false` otherwise.
        /// 
        /// **Depreacted:** Should use the new `nativeTheme.shouldUseHighContrastColors`
        /// API.
        abstract isHighContrastColorScheme: unit -> bool
        /// `true` if an inverted color scheme (a high contrast color scheme with light text
        /// and dark backgrounds) is active, `false` otherwise.
        /// 
        /// **Deprecated:** Should use the new `nativeTheme.shouldUseInvertedColorScheme`
        /// API.
        abstract isInvertedColorScheme: unit -> bool
        /// Whether the Swipe between pages setting is on.
        abstract isSwipeTrackingFromScrollEventsEnabled: unit -> bool
        /// `true` if the current process is a trusted accessibility client and `false` if
        /// it is not.
        abstract isTrustedAccessibilityClient: prompt: bool -> bool
        /// Posts `event` as native notifications of macOS. The `userInfo` is an Object that
        /// contains the user information dictionary sent along with the notification.
        abstract postLocalNotification: ``event``: string * userInfo: Record<string, obj option> -> unit
        /// Posts `event` as native notifications of macOS. The `userInfo` is an Object that
        /// contains the user information dictionary sent along with the notification.
        abstract postNotification: ``event``: string * userInfo: Record<string, obj option> * ?deliverImmediately: bool -> unit
        /// Posts `event` as native notifications of macOS. The `userInfo` is an Object that
        /// contains the user information dictionary sent along with the notification.
        abstract postWorkspaceNotification: ``event``: string * userInfo: Record<string, obj option> -> unit
        /// resolves if the user has successfully authenticated with Touch ID.
        /// 
        /// This API itself will not protect your user data; rather, it is a mechanism to
        /// allow you to do so. Native apps will need to set Access Control Constants like
        /// `kSecAccessControlUserPresence` on the their keychain entry so that reading it
        /// would auto-prompt for Touch ID biometric consent. This could be done with
        /// `node-keytar`, such that one would store an encryption key with `node-keytar`
        /// and only fetch it if `promptTouchID()` resolves.
        /// 
        /// **NOTE:** This API will return a rejected Promise on macOS systems older than
        /// Sierra 10.12.2.
        abstract promptTouchID: reason: string -> Promise<unit>
        /// Add the specified defaults to your application's `NSUserDefaults`.
        abstract registerDefaults: defaults: Record<string, U3<string, bool, float>> -> unit
        /// Removes the `key` in `NSUserDefaults`. This can be used to restore the default
        /// or global value of a `key` previously set with `setUserDefault`.
        abstract removeUserDefault: key: string -> unit
        /// Sets the appearance setting for your application, this should override the
        /// system default and override the value of `getEffectiveAppearance`.
        /// 
        /// *Deprecated**
        abstract setAppLevelAppearance: appearance: U2<SystemPreferencesSetAppLevelAppearance, obj> -> unit
        /// Set the value of `key` in `NSUserDefaults`.
        /// 
        /// Note that `type` should match actual type of `value`. An exception is thrown if
        /// they don't.
        /// 
        /// Some popular `key` and `type`s are:
        /// 
        /// `ApplePressAndHoldEnabled`: `boolean`
        abstract setUserDefault: key: string * ``type``: string * value: string -> unit
        /// The ID of this subscription
        /// 
        /// Same as `subscribeNotification`, but uses `NSNotificationCenter` for local
        /// defaults. This is necessary for events such as
        /// `NSUserDefaultsDidChangeNotification`.
        abstract subscribeLocalNotification: ``event``: string * callback: (string -> Record<string, obj> -> string -> unit) -> float
        /// The ID of this subscription
        /// 
        /// Subscribes to native notifications of macOS, `callback` will be called with
        /// `callback(event, userInfo)` when the corresponding `event` happens. The
        /// `userInfo` is an Object that contains the user information dictionary sent along
        /// with the notification. The `object` is the sender of the notification, and only
        /// supports `NSString` values for now.
        /// 
        /// The `id` of the subscriber is returned, which can be used to unsubscribe the
        /// `event`.
        /// 
        /// Under the hood this API subscribes to `NSDistributedNotificationCenter`, example
        /// values of `event` are:
        /// 
        /// * `AppleInterfaceThemeChangedNotification`
        /// * `AppleAquaColorVariantChanged`
        /// * `AppleColorPreferencesChangedNotification`
        /// * `AppleShowScrollBarsSettingChanged`
        abstract subscribeNotification: ``event``: string * callback: (string -> Record<string, obj> -> string -> unit) -> float
        /// Same as `subscribeNotification`, but uses
        /// `NSWorkspace.sharedWorkspace.notificationCenter`. This is necessary for events
        /// such as `NSWorkspaceDidActivateApplicationNotification`.
        abstract subscribeWorkspaceNotification: ``event``: string * callback: (string -> Record<string, obj> -> string -> unit) -> unit
        /// Same as `unsubscribeNotification`, but removes the subscriber from
        /// `NSNotificationCenter`.
        abstract unsubscribeLocalNotification: id: float -> unit
        /// Removes the subscriber with `id`.
        abstract unsubscribeNotification: id: float -> unit
        /// Same as `unsubscribeNotification`, but removes the subscriber from
        /// `NSWorkspace.sharedWorkspace.notificationCenter`.
        abstract unsubscribeWorkspaceNotification: id: float -> unit
        /// A `String` property that can be `dark`, `light` or `unknown`. It determines the
        /// macOS appearance setting for your application. This maps to values in:
        /// NSApplication.appearance. Setting this will override the system default as well
        /// as the value of `getEffectiveAppearance`.
        /// 
        /// Possible values that can be set are `dark` and `light`, and possible return
        /// values are `dark`, `light`, and `unknown`.
        /// 
        /// This property is only available on macOS 10.14 Mojave or newer.
        abstract appLevelAppearance: SystemPreferencesAppLevelAppearance with get, set
        /// A `String` property that can be `dark`, `light` or `unknown`.
        /// 
        /// Returns the macOS appearance setting that is currently applied to your
        /// application, maps to NSApplication.effectiveAppearance
        /// 
        /// Please note that until Electron is built targeting the 10.14 SDK, your
        /// application's `effectiveAppearance` will default to 'light' and won't inherit
        /// the OS preference. In the interim in order for your application to inherit the
        /// OS preference you must set the `NSRequiresAquaSystemAppearance` key in your apps
        /// `Info.plist` to `false`.  If you are using `electron-packager` or
        /// `electron-forge` just set the `enableDarwinDarkMode` packager option to `true`.
        /// See the Electron Packager API for more details.
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
        | [<CompiledName "selected-menu-item">] SelectedMenuItem
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
        /// The command line arguments when `program` is executed.
        abstract arguments: string with get, set
        /// Description of this task.
        abstract description: string with get, set
        /// The icon index in the icon file. If an icon file consists of two or more icons,
        /// set this value to identify the icon. If an icon file consists of one icon, this
        /// value is 0.
        abstract iconIndex: float with get, set
        /// The absolute path to an icon to be displayed in a JumpList, which can be an
        /// arbitrary resource file that contains an icon. You can usually specify
        /// `process.execPath` to show the icon of the program.
        abstract iconPath: string with get, set
        /// Path of the program to execute, usually you should specify `process.execPath`
        /// which opens the current program.
        abstract program: string with get, set
        /// The string to be displayed in a JumpList.
        abstract title: string with get, set
        /// The working directory. Default is empty.
        abstract workingDirectory: string option with get, set

    type [<AllowNullLiteral>] ThumbarButton =
        abstract click: Function with get, set
        /// Control specific states and behaviors of the button. By default, it is
        /// `['enabled']`.
        abstract flags: ResizeArray<string> option with get, set
        /// The icon showing in thumbnail toolbar.
        abstract icon: NativeImage with get, set
        /// The text of the button's tooltip.
        abstract tooltip: string option with get, set

    type [<AllowNullLiteral>] TouchBar =
        abstract escapeItem: obj with get, set

    type [<AllowNullLiteral>] TouchBarStatic =
        /// TouchBar
        [<Emit "new $0($1...)">] abstract Create: options: TouchBarConstructorOptions -> TouchBar
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
        abstract backgroundColor: string with get, set
        abstract icon: NativeImage with get, set
        abstract label: string with get, set

    type [<AllowNullLiteral>] TouchBarButtonStatic =
        /// TouchBarButton
        [<Emit "new $0($1...)">] abstract Create: options: TouchBarButtonConstructorOptions -> TouchBarButton

    type [<AllowNullLiteral>] TouchBarColorPicker =
        inherit NodeJS.EventEmitter
        abstract availableColors: ResizeArray<string> with get, set
        abstract selectedColor: string with get, set

    type [<AllowNullLiteral>] TouchBarColorPickerStatic =
        /// TouchBarColorPicker
        [<Emit "new $0($1...)">] abstract Create: options: TouchBarColorPickerConstructorOptions -> TouchBarColorPicker

    type [<AllowNullLiteral>] TouchBarGroup =
        inherit NodeJS.EventEmitter

    type [<AllowNullLiteral>] TouchBarGroupStatic =
        /// TouchBarGroup
        [<Emit "new $0($1...)">] abstract Create: options: TouchBarGroupConstructorOptions -> TouchBarGroup

    type [<AllowNullLiteral>] TouchBarLabel =
        inherit NodeJS.EventEmitter
        abstract label: string with get, set
        abstract textColor: string with get, set

    type [<AllowNullLiteral>] TouchBarLabelStatic =
        /// TouchBarLabel
        [<Emit "new $0($1...)">] abstract Create: options: TouchBarLabelConstructorOptions -> TouchBarLabel

    type [<AllowNullLiteral>] TouchBarPopover =
        inherit NodeJS.EventEmitter
        abstract icon: NativeImage with get, set
        abstract label: string with get, set

    type [<AllowNullLiteral>] TouchBarPopoverStatic =
        /// TouchBarPopover
        [<Emit "new $0($1...)">] abstract Create: options: TouchBarPopoverConstructorOptions -> TouchBarPopover

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
        [<Emit "new $0($1...)">] abstract Create: options: TouchBarScrubberConstructorOptions -> TouchBarScrubber

    type [<AllowNullLiteral>] TouchBarSegmentedControl =
        inherit NodeJS.EventEmitter
        abstract segments: ResizeArray<SegmentedControlSegment> with get, set
        abstract segmentStyle: string with get, set
        abstract selectedIndex: float with get, set

    type [<AllowNullLiteral>] TouchBarSegmentedControlStatic =
        /// TouchBarSegmentedControl
        [<Emit "new $0($1...)">] abstract Create: options: TouchBarSegmentedControlConstructorOptions -> TouchBarSegmentedControl

    type [<AllowNullLiteral>] TouchBarSlider =
        inherit NodeJS.EventEmitter
        abstract label: string with get, set
        abstract maxValue: float with get, set
        abstract minValue: float with get, set
        abstract value: float with get, set

    type [<AllowNullLiteral>] TouchBarSliderStatic =
        /// TouchBarSlider
        [<Emit "new $0($1...)">] abstract Create: options: TouchBarSliderConstructorOptions -> TouchBarSlider

    type [<AllowNullLiteral>] TouchBarSpacer =
        inherit NodeJS.EventEmitter

    type [<AllowNullLiteral>] TouchBarSpacerStatic =
        /// TouchBarSpacer
        [<Emit "new $0($1...)">] abstract Create: options: TouchBarSpacerConstructorOptions -> TouchBarSpacer

    type [<AllowNullLiteral>] TraceCategoriesAndOptions =
        /// A filter to control what category groups should be traced. A filter can have an
        /// optional '-' prefix to exclude category groups that contain a matching category.
        /// Having both included and excluded category patterns in the same list is not
        /// supported. Examples: `test_MyTest*`, `test_MyTest*,test_OtherStuff`,
        /// `-excluded_category1,-excluded_category2`.
        abstract categoryFilter: string with get, set
        /// Controls what kind of tracing is enabled, it is a comma-delimited sequence of
        /// the following strings: `record-until-full`, `record-continuously`,
        /// `trace-to-console`, `enable-sampling`, `enable-systrace`, e.g.
        /// `'record-until-full,enable-sampling'`. The first 3 options are trace recording
        /// modes and hence mutually exclusive. If more than one trace recording modes
        /// appear in the `traceOptions` string, the last one takes precedence. If none of
        /// the trace recording modes are specified, recording mode is `record-until-full`.
        /// The trace option will first be reset to the default option (`record_mode` set to
        /// `record-until-full`, `enable_sampling` and `enable_systrace` set to `false`)
        /// before options parsed from `traceOptions` are applied on it.
        abstract traceOptions: string with get, set

    type [<AllowNullLiteral>] TraceConfig =
        /// if true, filter event data according to a whitelist of events that have been
        /// manually vetted to not include any PII. See the implementation in Chromium for
        /// specifics.
        abstract enable_argument_filter: bool option with get, set
        /// a list of tracing categories to exclude. Can include glob-like patterns using
        /// `*` at the end of the category name. See tracing categories for the list of
        /// categories.
        abstract excluded_categories: ResizeArray<string> option with get, set
        /// a list of histogram names to report with the trace.
        abstract histogram_names: ResizeArray<string> option with get, set
        /// a list of tracing categories to include. Can include glob-like patterns using
        /// `*` at the end of the category name. See tracing categories for the list of
        /// categories.
        abstract included_categories: ResizeArray<string> option with get, set
        /// a list of process IDs to include in the trace. If not specified, trace all
        /// processes.
        abstract included_process_ids: ResizeArray<float> option with get, set
        /// if the `disabled-by-default-memory-infra` category is enabled, this contains
        /// optional additional configuration for data collection. See the Chromium
        /// memory-infra docs for more information.
        abstract memory_dump_config: Record<string, obj option> option with get, set
        /// Can be `record-until-full`, `record-continuously`, `record-as-much-as-possible`
        /// or `trace-to-console`. Defaults to `record-until-full`.
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
        /// The transaction state, can be `purchasing`, `purchased`, `failed`, `restored` or
        /// `deferred`.
        abstract transactionState: TransactionTransactionState with get, set

    type [<AllowNullLiteral>] Tray =
        inherit NodeJS.EventEmitter
        /// Emitted when the tray balloon is clicked.
        [<Emit "$0.on('balloon-click',$1)">] abstract ``on_balloon-click``: listener: Function -> Tray
        [<Emit "$0.once('balloon-click',$1)">] abstract ``once_balloon-click``: listener: Function -> Tray
        [<Emit "$0.addListener('balloon-click',$1)">] abstract ``addListener_balloon-click``: listener: Function -> Tray
        [<Emit "$0.removeListener('balloon-click',$1)">] abstract ``removeListener_balloon-click``: listener: Function -> Tray
        /// Emitted when the tray balloon is closed because of timeout or user manually
        /// closes it.
        [<Emit "$0.on('balloon-closed',$1)">] abstract ``on_balloon-closed``: listener: Function -> Tray
        [<Emit "$0.once('balloon-closed',$1)">] abstract ``once_balloon-closed``: listener: Function -> Tray
        [<Emit "$0.addListener('balloon-closed',$1)">] abstract ``addListener_balloon-closed``: listener: Function -> Tray
        [<Emit "$0.removeListener('balloon-closed',$1)">] abstract ``removeListener_balloon-closed``: listener: Function -> Tray
        /// Emitted when the tray balloon shows.
        [<Emit "$0.on('balloon-show',$1)">] abstract ``on_balloon-show``: listener: Function -> Tray
        [<Emit "$0.once('balloon-show',$1)">] abstract ``once_balloon-show``: listener: Function -> Tray
        [<Emit "$0.addListener('balloon-show',$1)">] abstract ``addListener_balloon-show``: listener: Function -> Tray
        [<Emit "$0.removeListener('balloon-show',$1)">] abstract ``removeListener_balloon-show``: listener: Function -> Tray
        /// Emitted when the tray icon is clicked.
        [<Emit "$0.on('click',$1)">] abstract on_click: listener: (KeyboardEvent -> Rectangle -> Point -> unit) -> Tray
        [<Emit "$0.once('click',$1)">] abstract once_click: listener: (KeyboardEvent -> Rectangle -> Point -> unit) -> Tray
        [<Emit "$0.addListener('click',$1)">] abstract addListener_click: listener: (KeyboardEvent -> Rectangle -> Point -> unit) -> Tray
        [<Emit "$0.removeListener('click',$1)">] abstract removeListener_click: listener: (KeyboardEvent -> Rectangle -> Point -> unit) -> Tray
        /// Emitted when the tray icon is double clicked.
        [<Emit "$0.on('double-click',$1)">] abstract ``on_double-click``: listener: (KeyboardEvent -> Rectangle -> unit) -> Tray
        [<Emit "$0.once('double-click',$1)">] abstract ``once_double-click``: listener: (KeyboardEvent -> Rectangle -> unit) -> Tray
        [<Emit "$0.addListener('double-click',$1)">] abstract ``addListener_double-click``: listener: (KeyboardEvent -> Rectangle -> unit) -> Tray
        [<Emit "$0.removeListener('double-click',$1)">] abstract ``removeListener_double-click``: listener: (KeyboardEvent -> Rectangle -> unit) -> Tray
        /// Emitted when a drag operation ends on the tray or ends at another location.
        [<Emit "$0.on('drag-end',$1)">] abstract ``on_drag-end``: listener: Function -> Tray
        [<Emit "$0.once('drag-end',$1)">] abstract ``once_drag-end``: listener: Function -> Tray
        [<Emit "$0.addListener('drag-end',$1)">] abstract ``addListener_drag-end``: listener: Function -> Tray
        [<Emit "$0.removeListener('drag-end',$1)">] abstract ``removeListener_drag-end``: listener: Function -> Tray
        /// Emitted when a drag operation enters the tray icon.
        [<Emit "$0.on('drag-enter',$1)">] abstract ``on_drag-enter``: listener: Function -> Tray
        [<Emit "$0.once('drag-enter',$1)">] abstract ``once_drag-enter``: listener: Function -> Tray
        [<Emit "$0.addListener('drag-enter',$1)">] abstract ``addListener_drag-enter``: listener: Function -> Tray
        [<Emit "$0.removeListener('drag-enter',$1)">] abstract ``removeListener_drag-enter``: listener: Function -> Tray
        /// Emitted when a drag operation exits the tray icon.
        [<Emit "$0.on('drag-leave',$1)">] abstract ``on_drag-leave``: listener: Function -> Tray
        [<Emit "$0.once('drag-leave',$1)">] abstract ``once_drag-leave``: listener: Function -> Tray
        [<Emit "$0.addListener('drag-leave',$1)">] abstract ``addListener_drag-leave``: listener: Function -> Tray
        [<Emit "$0.removeListener('drag-leave',$1)">] abstract ``removeListener_drag-leave``: listener: Function -> Tray
        /// Emitted when any dragged items are dropped on the tray icon.
        [<Emit "$0.on('drop',$1)">] abstract on_drop: listener: Function -> Tray
        [<Emit "$0.once('drop',$1)">] abstract once_drop: listener: Function -> Tray
        [<Emit "$0.addListener('drop',$1)">] abstract addListener_drop: listener: Function -> Tray
        [<Emit "$0.removeListener('drop',$1)">] abstract removeListener_drop: listener: Function -> Tray
        /// Emitted when dragged files are dropped in the tray icon.
        [<Emit "$0.on('drop-files',$1)">] abstract ``on_drop-files``: listener: (Event -> ResizeArray<string> -> unit) -> Tray
        [<Emit "$0.once('drop-files',$1)">] abstract ``once_drop-files``: listener: (Event -> ResizeArray<string> -> unit) -> Tray
        [<Emit "$0.addListener('drop-files',$1)">] abstract ``addListener_drop-files``: listener: (Event -> ResizeArray<string> -> unit) -> Tray
        [<Emit "$0.removeListener('drop-files',$1)">] abstract ``removeListener_drop-files``: listener: (Event -> ResizeArray<string> -> unit) -> Tray
        /// Emitted when dragged text is dropped in the tray icon.
        [<Emit "$0.on('drop-text',$1)">] abstract ``on_drop-text``: listener: (Event -> string -> unit) -> Tray
        [<Emit "$0.once('drop-text',$1)">] abstract ``once_drop-text``: listener: (Event -> string -> unit) -> Tray
        [<Emit "$0.addListener('drop-text',$1)">] abstract ``addListener_drop-text``: listener: (Event -> string -> unit) -> Tray
        [<Emit "$0.removeListener('drop-text',$1)">] abstract ``removeListener_drop-text``: listener: (Event -> string -> unit) -> Tray
        /// Emitted when the mouse enters the tray icon.
        [<Emit "$0.on('mouse-enter',$1)">] abstract ``on_mouse-enter``: listener: (KeyboardEvent -> Point -> unit) -> Tray
        [<Emit "$0.once('mouse-enter',$1)">] abstract ``once_mouse-enter``: listener: (KeyboardEvent -> Point -> unit) -> Tray
        [<Emit "$0.addListener('mouse-enter',$1)">] abstract ``addListener_mouse-enter``: listener: (KeyboardEvent -> Point -> unit) -> Tray
        [<Emit "$0.removeListener('mouse-enter',$1)">] abstract ``removeListener_mouse-enter``: listener: (KeyboardEvent -> Point -> unit) -> Tray
        /// Emitted when the mouse exits the tray icon.
        [<Emit "$0.on('mouse-leave',$1)">] abstract ``on_mouse-leave``: listener: (KeyboardEvent -> Point -> unit) -> Tray
        [<Emit "$0.once('mouse-leave',$1)">] abstract ``once_mouse-leave``: listener: (KeyboardEvent -> Point -> unit) -> Tray
        [<Emit "$0.addListener('mouse-leave',$1)">] abstract ``addListener_mouse-leave``: listener: (KeyboardEvent -> Point -> unit) -> Tray
        [<Emit "$0.removeListener('mouse-leave',$1)">] abstract ``removeListener_mouse-leave``: listener: (KeyboardEvent -> Point -> unit) -> Tray
        /// Emitted when the mouse moves in the tray icon.
        [<Emit "$0.on('mouse-move',$1)">] abstract ``on_mouse-move``: listener: (KeyboardEvent -> Point -> unit) -> Tray
        [<Emit "$0.once('mouse-move',$1)">] abstract ``once_mouse-move``: listener: (KeyboardEvent -> Point -> unit) -> Tray
        [<Emit "$0.addListener('mouse-move',$1)">] abstract ``addListener_mouse-move``: listener: (KeyboardEvent -> Point -> unit) -> Tray
        [<Emit "$0.removeListener('mouse-move',$1)">] abstract ``removeListener_mouse-move``: listener: (KeyboardEvent -> Point -> unit) -> Tray
        /// Emitted when the tray icon is right clicked.
        [<Emit "$0.on('right-click',$1)">] abstract ``on_right-click``: listener: (KeyboardEvent -> Rectangle -> unit) -> Tray
        [<Emit "$0.once('right-click',$1)">] abstract ``once_right-click``: listener: (KeyboardEvent -> Rectangle -> unit) -> Tray
        [<Emit "$0.addListener('right-click',$1)">] abstract ``addListener_right-click``: listener: (KeyboardEvent -> Rectangle -> unit) -> Tray
        [<Emit "$0.removeListener('right-click',$1)">] abstract ``removeListener_right-click``: listener: (KeyboardEvent -> Rectangle -> unit) -> Tray
        /// Destroys the tray icon immediately.
        abstract destroy: unit -> unit
        /// Displays a tray balloon.
        abstract displayBalloon: options: DisplayBalloonOptions -> unit
        /// The `bounds` of this tray icon as `Object`.
        abstract getBounds: unit -> Rectangle
        /// Whether double click events will be ignored.
        abstract getIgnoreDoubleClickEvents: unit -> bool
        /// the title displayed next to the tray icon in the status bar
        abstract getTitle: unit -> string
        /// Whether the tray icon is destroyed.
        abstract isDestroyed: unit -> bool
        /// Pops up the context menu of the tray icon. When `menu` is passed, the `menu`
        /// will be shown instead of the tray icon's context menu.
        /// 
        /// The `position` is only available on Windows, and it is (0, 0) by default.
        abstract popUpContextMenu: ?menu: Menu * ?position: Point -> unit
        /// Sets the context menu for this icon.
        abstract setContextMenu: menu: U2<Menu, obj> -> unit
        /// Sets the option to ignore double click events. Ignoring these events allows you
        /// to detect every individual click of the tray icon.
        /// 
        /// This value is set to false by default.
        abstract setIgnoreDoubleClickEvents: ignore: bool -> unit
        /// Sets the `image` associated with this tray icon.
        abstract setImage: image: U2<NativeImage, string> -> unit
        /// Sets the `image` associated with this tray icon when pressed on macOS.
        abstract setPressedImage: image: U2<NativeImage, string> -> unit
        /// Sets the title displayed next to the tray icon in the status bar (Support ANSI
        /// colors).
        abstract setTitle: title: string -> unit
        /// Sets the hover text for this tray icon.
        abstract setToolTip: toolTip: string -> unit

    type [<AllowNullLiteral>] TrayStatic =
        /// Tray
        [<Emit "new $0($1...)">] abstract Create: image: U2<NativeImage, string> -> Tray

    type [<AllowNullLiteral>] UploadBlob =
        /// UUID of blob data to upload.
        abstract blobUUID: string with get, set
        /// `blob`.
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
        /// Number of bytes to read from `offset`. Defaults to `0`.
        abstract length: float with get, set
        /// Last Modification time in number of seconds since the UNIX epoch.
        abstract modificationTime: float with get, set
        /// Defaults to `0`.
        abstract offset: float with get, set
        /// `file`.
        abstract ``type``: string with get, set

    type [<AllowNullLiteral>] UploadRawData =
        /// Data to be uploaded.
        abstract bytes: Buffer with get, set
        /// `rawData`.
        abstract ``type``: string with get, set

    type [<AllowNullLiteral>] WebContents =
        inherit NodeJS.EventEmitter
        /// Emitted before dispatching the `keydown` and `keyup` events in the page. Calling
        /// `event.preventDefault` will prevent the page `keydown`/`keyup` events and the
        /// menu shortcuts.
        /// 
        /// To only prevent the menu shortcuts, use `setIgnoreMenuShortcuts`:
        [<Emit "$0.on('before-input-event',$1)">] abstract ``on_before-input-event``: listener: (Event -> Input -> unit) -> WebContents
        [<Emit "$0.once('before-input-event',$1)">] abstract ``once_before-input-event``: listener: (Event -> Input -> unit) -> WebContents
        [<Emit "$0.addListener('before-input-event',$1)">] abstract ``addListener_before-input-event``: listener: (Event -> Input -> unit) -> WebContents
        [<Emit "$0.removeListener('before-input-event',$1)">] abstract ``removeListener_before-input-event``: listener: (Event -> Input -> unit) -> WebContents
        /// Emitted when failed to verify the `certificate` for `url`.
        /// 
        /// The usage is the same with the `certificate-error` event of `app`.
        [<Emit "$0.on('certificate-error',$1)">] abstract ``on_certificate-error``: listener: (Event -> string -> string -> Certificate -> (bool -> unit) -> unit) -> WebContents
        [<Emit "$0.once('certificate-error',$1)">] abstract ``once_certificate-error``: listener: (Event -> string -> string -> Certificate -> (bool -> unit) -> unit) -> WebContents
        [<Emit "$0.addListener('certificate-error',$1)">] abstract ``addListener_certificate-error``: listener: (Event -> string -> string -> Certificate -> (bool -> unit) -> unit) -> WebContents
        [<Emit "$0.removeListener('certificate-error',$1)">] abstract ``removeListener_certificate-error``: listener: (Event -> string -> string -> Certificate -> (bool -> unit) -> unit) -> WebContents
        /// Emitted when the associated window logs a console message. Will not be emitted
        /// for windows with *offscreen rendering* enabled.
        [<Emit "$0.on('console-message',$1)">] abstract ``on_console-message``: listener: (Event -> float -> string -> float -> string -> unit) -> WebContents
        [<Emit "$0.once('console-message',$1)">] abstract ``once_console-message``: listener: (Event -> float -> string -> float -> string -> unit) -> WebContents
        [<Emit "$0.addListener('console-message',$1)">] abstract ``addListener_console-message``: listener: (Event -> float -> string -> float -> string -> unit) -> WebContents
        [<Emit "$0.removeListener('console-message',$1)">] abstract ``removeListener_console-message``: listener: (Event -> float -> string -> float -> string -> unit) -> WebContents
        /// Emitted when there is a new context menu that needs to be handled.
        [<Emit "$0.on('context-menu',$1)">] abstract ``on_context-menu``: listener: (Event -> ContextMenuParams -> unit) -> WebContents
        [<Emit "$0.once('context-menu',$1)">] abstract ``once_context-menu``: listener: (Event -> ContextMenuParams -> unit) -> WebContents
        [<Emit "$0.addListener('context-menu',$1)">] abstract ``addListener_context-menu``: listener: (Event -> ContextMenuParams -> unit) -> WebContents
        [<Emit "$0.removeListener('context-menu',$1)">] abstract ``removeListener_context-menu``: listener: (Event -> ContextMenuParams -> unit) -> WebContents
        /// Emitted when the renderer process crashes or is killed.
        [<Emit "$0.on('crashed',$1)">] abstract on_crashed: listener: (Event -> bool -> unit) -> WebContents
        [<Emit "$0.once('crashed',$1)">] abstract once_crashed: listener: (Event -> bool -> unit) -> WebContents
        [<Emit "$0.addListener('crashed',$1)">] abstract addListener_crashed: listener: (Event -> bool -> unit) -> WebContents
        [<Emit "$0.removeListener('crashed',$1)">] abstract removeListener_crashed: listener: (Event -> bool -> unit) -> WebContents
        /// Emitted when the cursor's type changes. The `type` parameter can be `default`,
        /// `crosshair`, `pointer`, `text`, `wait`, `help`, `e-resize`, `n-resize`,
        /// `ne-resize`, `nw-resize`, `s-resize`, `se-resize`, `sw-resize`, `w-resize`,
        /// `ns-resize`, `ew-resize`, `nesw-resize`, `nwse-resize`, `col-resize`,
        /// `row-resize`, `m-panning`, `e-panning`, `n-panning`, `ne-panning`, `nw-panning`,
        /// `s-panning`, `se-panning`, `sw-panning`, `w-panning`, `move`, `vertical-text`,
        /// `cell`, `context-menu`, `alias`, `progress`, `nodrop`, `copy`, `none`,
        /// `not-allowed`, `zoom-in`, `zoom-out`, `grab`, `grabbing` or `custom`.
        /// 
        /// If the `type` parameter is `custom`, the `image` parameter will hold the custom
        /// cursor image in a `NativeImage`, and `scale`, `size` and `hotspot` will hold
        /// additional information about the custom cursor.
        [<Emit "$0.on('cursor-changed',$1)">] abstract ``on_cursor-changed``: listener: (Event -> string -> NativeImage -> float -> Size -> Point -> unit) -> WebContents
        [<Emit "$0.once('cursor-changed',$1)">] abstract ``once_cursor-changed``: listener: (Event -> string -> NativeImage -> float -> Size -> Point -> unit) -> WebContents
        [<Emit "$0.addListener('cursor-changed',$1)">] abstract ``addListener_cursor-changed``: listener: (Event -> string -> NativeImage -> float -> Size -> Point -> unit) -> WebContents
        [<Emit "$0.removeListener('cursor-changed',$1)">] abstract ``removeListener_cursor-changed``: listener: (Event -> string -> NativeImage -> float -> Size -> Point -> unit) -> WebContents
        /// Emitted when `desktopCapturer.getSources()` is called in the renderer process.
        /// Calling `event.preventDefault()` will make it return empty sources.
        [<Emit "$0.on('desktop-capturer-get-sources',$1)">] abstract ``on_desktop-capturer-get-sources``: listener: (Event -> unit) -> WebContents
        [<Emit "$0.once('desktop-capturer-get-sources',$1)">] abstract ``once_desktop-capturer-get-sources``: listener: (Event -> unit) -> WebContents
        [<Emit "$0.addListener('desktop-capturer-get-sources',$1)">] abstract ``addListener_desktop-capturer-get-sources``: listener: (Event -> unit) -> WebContents
        [<Emit "$0.removeListener('desktop-capturer-get-sources',$1)">] abstract ``removeListener_desktop-capturer-get-sources``: listener: (Event -> unit) -> WebContents
        /// Emitted when `webContents` is destroyed.
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
        /// Emitted when a `<webview>` has been attached to this web contents.
        [<Emit "$0.on('did-attach-webview',$1)">] abstract ``on_did-attach-webview``: listener: (Event -> WebContents -> unit) -> WebContents
        [<Emit "$0.once('did-attach-webview',$1)">] abstract ``once_did-attach-webview``: listener: (Event -> WebContents -> unit) -> WebContents
        [<Emit "$0.addListener('did-attach-webview',$1)">] abstract ``addListener_did-attach-webview``: listener: (Event -> WebContents -> unit) -> WebContents
        [<Emit "$0.removeListener('did-attach-webview',$1)">] abstract ``removeListener_did-attach-webview``: listener: (Event -> WebContents -> unit) -> WebContents
        /// Emitted when a page's theme color changes. This is usually due to encountering a
        /// meta tag:
        [<Emit "$0.on('did-change-theme-color',$1)">] abstract ``on_did-change-theme-color``: listener: (Event -> U2<string, obj> -> unit) -> WebContents
        [<Emit "$0.once('did-change-theme-color',$1)">] abstract ``once_did-change-theme-color``: listener: (Event -> U2<string, obj> -> unit) -> WebContents
        [<Emit "$0.addListener('did-change-theme-color',$1)">] abstract ``addListener_did-change-theme-color``: listener: (Event -> U2<string, obj> -> unit) -> WebContents
        [<Emit "$0.removeListener('did-change-theme-color',$1)">] abstract ``removeListener_did-change-theme-color``: listener: (Event -> U2<string, obj> -> unit) -> WebContents
        /// This event is like `did-finish-load` but emitted when the load failed. The full
        /// list of error codes and their meaning is available here.
        [<Emit "$0.on('did-fail-load',$1)">] abstract ``on_did-fail-load``: listener: (Event -> float -> string -> string -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.once('did-fail-load',$1)">] abstract ``once_did-fail-load``: listener: (Event -> float -> string -> string -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.addListener('did-fail-load',$1)">] abstract ``addListener_did-fail-load``: listener: (Event -> float -> string -> string -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.removeListener('did-fail-load',$1)">] abstract ``removeListener_did-fail-load``: listener: (Event -> float -> string -> string -> bool -> float -> float -> unit) -> WebContents
        /// This event is like `did-fail-load` but emitted when the load was cancelled (e.g.
        /// `window.stop()` was invoked).
        [<Emit "$0.on('did-fail-provisional-load',$1)">] abstract ``on_did-fail-provisional-load``: listener: (Event -> float -> string -> string -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.once('did-fail-provisional-load',$1)">] abstract ``once_did-fail-provisional-load``: listener: (Event -> float -> string -> string -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.addListener('did-fail-provisional-load',$1)">] abstract ``addListener_did-fail-provisional-load``: listener: (Event -> float -> string -> string -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.removeListener('did-fail-provisional-load',$1)">] abstract ``removeListener_did-fail-provisional-load``: listener: (Event -> float -> string -> string -> bool -> float -> float -> unit) -> WebContents
        /// Emitted when the navigation is done, i.e. the spinner of the tab has stopped
        /// spinning, and the `onload` event was dispatched.
        [<Emit "$0.on('did-finish-load',$1)">] abstract ``on_did-finish-load``: listener: Function -> WebContents
        [<Emit "$0.once('did-finish-load',$1)">] abstract ``once_did-finish-load``: listener: Function -> WebContents
        [<Emit "$0.addListener('did-finish-load',$1)">] abstract ``addListener_did-finish-load``: listener: Function -> WebContents
        [<Emit "$0.removeListener('did-finish-load',$1)">] abstract ``removeListener_did-finish-load``: listener: Function -> WebContents
        /// Emitted when a frame has done navigation.
        [<Emit "$0.on('did-frame-finish-load',$1)">] abstract ``on_did-frame-finish-load``: listener: (Event -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.once('did-frame-finish-load',$1)">] abstract ``once_did-frame-finish-load``: listener: (Event -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.addListener('did-frame-finish-load',$1)">] abstract ``addListener_did-frame-finish-load``: listener: (Event -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.removeListener('did-frame-finish-load',$1)">] abstract ``removeListener_did-frame-finish-load``: listener: (Event -> bool -> float -> float -> unit) -> WebContents
        /// Emitted when any frame navigation is done.
        /// 
        /// This event is not emitted for in-page navigations, such as clicking anchor links
        /// or updating the `window.location.hash`. Use `did-navigate-in-page` event for
        /// this purpose.
        [<Emit "$0.on('did-frame-navigate',$1)">] abstract ``on_did-frame-navigate``: listener: (Event -> string -> float -> string -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.once('did-frame-navigate',$1)">] abstract ``once_did-frame-navigate``: listener: (Event -> string -> float -> string -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.addListener('did-frame-navigate',$1)">] abstract ``addListener_did-frame-navigate``: listener: (Event -> string -> float -> string -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.removeListener('did-frame-navigate',$1)">] abstract ``removeListener_did-frame-navigate``: listener: (Event -> string -> float -> string -> bool -> float -> float -> unit) -> WebContents
        /// Emitted when a main frame navigation is done.
        /// 
        /// This event is not emitted for in-page navigations, such as clicking anchor links
        /// or updating the `window.location.hash`. Use `did-navigate-in-page` event for
        /// this purpose.
        [<Emit "$0.on('did-navigate',$1)">] abstract ``on_did-navigate``: listener: (Event -> string -> float -> string -> unit) -> WebContents
        [<Emit "$0.once('did-navigate',$1)">] abstract ``once_did-navigate``: listener: (Event -> string -> float -> string -> unit) -> WebContents
        [<Emit "$0.addListener('did-navigate',$1)">] abstract ``addListener_did-navigate``: listener: (Event -> string -> float -> string -> unit) -> WebContents
        [<Emit "$0.removeListener('did-navigate',$1)">] abstract ``removeListener_did-navigate``: listener: (Event -> string -> float -> string -> unit) -> WebContents
        /// Emitted when an in-page navigation happened in any frame.
        /// 
        /// When in-page navigation happens, the page URL changes but does not cause
        /// navigation outside of the page. Examples of this occurring are when anchor links
        /// are clicked or when the DOM `hashchange` event is triggered.
        [<Emit "$0.on('did-navigate-in-page',$1)">] abstract ``on_did-navigate-in-page``: listener: (Event -> string -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.once('did-navigate-in-page',$1)">] abstract ``once_did-navigate-in-page``: listener: (Event -> string -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.addListener('did-navigate-in-page',$1)">] abstract ``addListener_did-navigate-in-page``: listener: (Event -> string -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.removeListener('did-navigate-in-page',$1)">] abstract ``removeListener_did-navigate-in-page``: listener: (Event -> string -> bool -> float -> float -> unit) -> WebContents
        /// Emitted after a server side redirect occurs during navigation.  For example a
        /// 302 redirect.
        /// 
        /// This event can not be prevented, if you want to prevent redirects you should
        /// checkout out the `will-redirect` event above.
        [<Emit "$0.on('did-redirect-navigation',$1)">] abstract ``on_did-redirect-navigation``: listener: (Event -> string -> bool -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.once('did-redirect-navigation',$1)">] abstract ``once_did-redirect-navigation``: listener: (Event -> string -> bool -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.addListener('did-redirect-navigation',$1)">] abstract ``addListener_did-redirect-navigation``: listener: (Event -> string -> bool -> bool -> float -> float -> unit) -> WebContents
        [<Emit "$0.removeListener('did-redirect-navigation',$1)">] abstract ``removeListener_did-redirect-navigation``: listener: (Event -> string -> bool -> bool -> float -> float -> unit) -> WebContents
        /// Corresponds to the points in time when the spinner of the tab started spinning.
        [<Emit "$0.on('did-start-loading',$1)">] abstract ``on_did-start-loading``: listener: Function -> WebContents
        [<Emit "$0.once('did-start-loading',$1)">] abstract ``once_did-start-loading``: listener: Function -> WebContents
        [<Emit "$0.addListener('did-start-loading',$1)">] abstract ``addListener_did-start-loading``: listener: Function -> WebContents
        [<Emit "$0.removeListener('did-start-loading',$1)">] abstract ``removeListener_did-start-loading``: listener: Function -> WebContents
        /// Emitted when any frame (including main) starts navigating. `isInplace` will be
        /// `true` for in-page navigations.
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
        /// Emitted when a result is available for [`webContents.findInPage`] request.
        [<Emit "$0.on('found-in-page',$1)">] abstract ``on_found-in-page``: listener: (Event -> Result -> unit) -> WebContents
        [<Emit "$0.once('found-in-page',$1)">] abstract ``once_found-in-page``: listener: (Event -> Result -> unit) -> WebContents
        [<Emit "$0.addListener('found-in-page',$1)">] abstract ``addListener_found-in-page``: listener: (Event -> Result -> unit) -> WebContents
        [<Emit "$0.removeListener('found-in-page',$1)">] abstract ``removeListener_found-in-page``: listener: (Event -> Result -> unit) -> WebContents
        /// Emitted when the renderer process sends an asynchronous message via
        /// `ipcRenderer.send()`.
        [<Emit "$0.on('ipc-message',$1)">] abstract ``on_ipc-message``: listener: (Event -> string -> ResizeArray<obj option> -> unit) -> WebContents
        [<Emit "$0.once('ipc-message',$1)">] abstract ``once_ipc-message``: listener: (Event -> string -> ResizeArray<obj option> -> unit) -> WebContents
        [<Emit "$0.addListener('ipc-message',$1)">] abstract ``addListener_ipc-message``: listener: (Event -> string -> ResizeArray<obj option> -> unit) -> WebContents
        [<Emit "$0.removeListener('ipc-message',$1)">] abstract ``removeListener_ipc-message``: listener: (Event -> string -> ResizeArray<obj option> -> unit) -> WebContents
        /// Emitted when the renderer process sends a synchronous message via
        /// `ipcRenderer.sendSync()`.
        [<Emit "$0.on('ipc-message-sync',$1)">] abstract ``on_ipc-message-sync``: listener: (Event -> string -> ResizeArray<obj option> -> unit) -> WebContents
        [<Emit "$0.once('ipc-message-sync',$1)">] abstract ``once_ipc-message-sync``: listener: (Event -> string -> ResizeArray<obj option> -> unit) -> WebContents
        [<Emit "$0.addListener('ipc-message-sync',$1)">] abstract ``addListener_ipc-message-sync``: listener: (Event -> string -> ResizeArray<obj option> -> unit) -> WebContents
        [<Emit "$0.removeListener('ipc-message-sync',$1)">] abstract ``removeListener_ipc-message-sync``: listener: (Event -> string -> ResizeArray<obj option> -> unit) -> WebContents
        /// Emitted when the window leaves a full-screen state triggered by HTML API.
        [<Emit "$0.on('leave-html-full-screen',$1)">] abstract ``on_leave-html-full-screen``: listener: Function -> WebContents
        [<Emit "$0.once('leave-html-full-screen',$1)">] abstract ``once_leave-html-full-screen``: listener: Function -> WebContents
        [<Emit "$0.addListener('leave-html-full-screen',$1)">] abstract ``addListener_leave-html-full-screen``: listener: Function -> WebContents
        [<Emit "$0.removeListener('leave-html-full-screen',$1)">] abstract ``removeListener_leave-html-full-screen``: listener: Function -> WebContents
        /// Emitted when `webContents` wants to do basic auth.
        /// 
        /// The usage is the same with the `login` event of `app`.
        [<Emit "$0.on('login',$1)">] abstract on_login: listener: (Event -> AuthenticationResponseDetails -> AuthInfo -> (string -> string -> unit) -> unit) -> WebContents
        [<Emit "$0.once('login',$1)">] abstract once_login: listener: (Event -> AuthenticationResponseDetails -> AuthInfo -> (string -> string -> unit) -> unit) -> WebContents
        [<Emit "$0.addListener('login',$1)">] abstract addListener_login: listener: (Event -> AuthenticationResponseDetails -> AuthInfo -> (string -> string -> unit) -> unit) -> WebContents
        [<Emit "$0.removeListener('login',$1)">] abstract removeListener_login: listener: (Event -> AuthenticationResponseDetails -> AuthInfo -> (string -> string -> unit) -> unit) -> WebContents
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
        /// Emitted when the page requests to open a new window for a `url`. It could be
        /// requested by `window.open` or an external link like `<a target='_blank'>`.
        /// 
        /// By default a new `BrowserWindow` will be created for the `url`.
        /// 
        /// Calling `event.preventDefault()` will prevent Electron from automatically
        /// creating a new `BrowserWindow`. If you call `event.preventDefault()` and
        /// manually create a new `BrowserWindow` then you must set `event.newGuest` to
        /// reference the new `BrowserWindow` instance, failing to do so may result in
        /// unexpected behavior. For example:
        [<Emit "$0.on('new-window',$1)">] abstract ``on_new-window``: listener: (Event -> string -> string -> WebContentsOn_newWindow -> BrowserWindowConstructorOptions -> ResizeArray<string> -> Referrer -> unit) -> WebContents
        [<Emit "$0.once('new-window',$1)">] abstract ``once_new-window``: listener: (Event -> string -> string -> WebContentsOn_newWindow -> BrowserWindowConstructorOptions -> ResizeArray<string> -> Referrer -> unit) -> WebContents
        [<Emit "$0.addListener('new-window',$1)">] abstract ``addListener_new-window``: listener: (Event -> string -> string -> WebContentsOn_newWindow -> BrowserWindowConstructorOptions -> ResizeArray<string> -> Referrer -> unit) -> WebContents
        [<Emit "$0.removeListener('new-window',$1)">] abstract ``removeListener_new-window``: listener: (Event -> string -> string -> WebContentsOn_newWindow -> BrowserWindowConstructorOptions -> ResizeArray<string> -> Referrer -> unit) -> WebContents
        /// Emitted when page receives favicon urls.
        [<Emit "$0.on('page-favicon-updated',$1)">] abstract ``on_page-favicon-updated``: listener: (Event -> ResizeArray<string> -> unit) -> WebContents
        [<Emit "$0.once('page-favicon-updated',$1)">] abstract ``once_page-favicon-updated``: listener: (Event -> ResizeArray<string> -> unit) -> WebContents
        [<Emit "$0.addListener('page-favicon-updated',$1)">] abstract ``addListener_page-favicon-updated``: listener: (Event -> ResizeArray<string> -> unit) -> WebContents
        [<Emit "$0.removeListener('page-favicon-updated',$1)">] abstract ``removeListener_page-favicon-updated``: listener: (Event -> ResizeArray<string> -> unit) -> WebContents
        /// Fired when page title is set during navigation. `explicitSet` is false when
        /// title is synthesized from file url.
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
        /// Emitted when the preload script `preloadPath` throws an unhandled exception
        /// `error`.
        [<Emit "$0.on('preload-error',$1)">] abstract ``on_preload-error``: listener: (Event -> string -> Error -> unit) -> WebContents
        [<Emit "$0.once('preload-error',$1)">] abstract ``once_preload-error``: listener: (Event -> string -> Error -> unit) -> WebContents
        [<Emit "$0.addListener('preload-error',$1)">] abstract ``addListener_preload-error``: listener: (Event -> string -> Error -> unit) -> WebContents
        [<Emit "$0.removeListener('preload-error',$1)">] abstract ``removeListener_preload-error``: listener: (Event -> string -> Error -> unit) -> WebContents
        /// Emitted when `remote.getBuiltin()` is called in the renderer process. Calling
        /// `event.preventDefault()` will prevent the module from being returned. Custom
        /// value can be returned by setting `event.returnValue`.
        [<Emit "$0.on('remote-get-builtin',$1)">] abstract ``on_remote-get-builtin``: listener: (IpcMainEvent -> string -> unit) -> WebContents
        [<Emit "$0.once('remote-get-builtin',$1)">] abstract ``once_remote-get-builtin``: listener: (IpcMainEvent -> string -> unit) -> WebContents
        [<Emit "$0.addListener('remote-get-builtin',$1)">] abstract ``addListener_remote-get-builtin``: listener: (IpcMainEvent -> string -> unit) -> WebContents
        [<Emit "$0.removeListener('remote-get-builtin',$1)">] abstract ``removeListener_remote-get-builtin``: listener: (IpcMainEvent -> string -> unit) -> WebContents
        /// Emitted when `remote.getCurrentWebContents()` is called in the renderer process.
        /// Calling `event.preventDefault()` will prevent the object from being returned.
        /// Custom value can be returned by setting `event.returnValue`.
        [<Emit "$0.on('remote-get-current-web-contents',$1)">] abstract ``on_remote-get-current-web-contents``: listener: (IpcMainEvent -> unit) -> WebContents
        [<Emit "$0.once('remote-get-current-web-contents',$1)">] abstract ``once_remote-get-current-web-contents``: listener: (IpcMainEvent -> unit) -> WebContents
        [<Emit "$0.addListener('remote-get-current-web-contents',$1)">] abstract ``addListener_remote-get-current-web-contents``: listener: (IpcMainEvent -> unit) -> WebContents
        [<Emit "$0.removeListener('remote-get-current-web-contents',$1)">] abstract ``removeListener_remote-get-current-web-contents``: listener: (IpcMainEvent -> unit) -> WebContents
        /// Emitted when `remote.getCurrentWindow()` is called in the renderer process.
        /// Calling `event.preventDefault()` will prevent the object from being returned.
        /// Custom value can be returned by setting `event.returnValue`.
        [<Emit "$0.on('remote-get-current-window',$1)">] abstract ``on_remote-get-current-window``: listener: (IpcMainEvent -> unit) -> WebContents
        [<Emit "$0.once('remote-get-current-window',$1)">] abstract ``once_remote-get-current-window``: listener: (IpcMainEvent -> unit) -> WebContents
        [<Emit "$0.addListener('remote-get-current-window',$1)">] abstract ``addListener_remote-get-current-window``: listener: (IpcMainEvent -> unit) -> WebContents
        [<Emit "$0.removeListener('remote-get-current-window',$1)">] abstract ``removeListener_remote-get-current-window``: listener: (IpcMainEvent -> unit) -> WebContents
        /// Emitted when `remote.getGlobal()` is called in the renderer process. Calling
        /// `event.preventDefault()` will prevent the global from being returned. Custom
        /// value can be returned by setting `event.returnValue`.
        [<Emit "$0.on('remote-get-global',$1)">] abstract ``on_remote-get-global``: listener: (IpcMainEvent -> string -> unit) -> WebContents
        [<Emit "$0.once('remote-get-global',$1)">] abstract ``once_remote-get-global``: listener: (IpcMainEvent -> string -> unit) -> WebContents
        [<Emit "$0.addListener('remote-get-global',$1)">] abstract ``addListener_remote-get-global``: listener: (IpcMainEvent -> string -> unit) -> WebContents
        [<Emit "$0.removeListener('remote-get-global',$1)">] abstract ``removeListener_remote-get-global``: listener: (IpcMainEvent -> string -> unit) -> WebContents
        /// Emitted when `<webview>.getWebContents()` is called in the renderer process.
        /// Calling `event.preventDefault()` will prevent the object from being returned.
        /// Custom value can be returned by setting `event.returnValue`.
        [<Emit "$0.on('remote-get-guest-web-contents',$1)">] abstract ``on_remote-get-guest-web-contents``: listener: (IpcMainEvent -> WebContents -> unit) -> WebContents
        [<Emit "$0.once('remote-get-guest-web-contents',$1)">] abstract ``once_remote-get-guest-web-contents``: listener: (IpcMainEvent -> WebContents -> unit) -> WebContents
        [<Emit "$0.addListener('remote-get-guest-web-contents',$1)">] abstract ``addListener_remote-get-guest-web-contents``: listener: (IpcMainEvent -> WebContents -> unit) -> WebContents
        [<Emit "$0.removeListener('remote-get-guest-web-contents',$1)">] abstract ``removeListener_remote-get-guest-web-contents``: listener: (IpcMainEvent -> WebContents -> unit) -> WebContents
        /// Emitted when `remote.require()` is called in the renderer process. Calling
        /// `event.preventDefault()` will prevent the module from being returned. Custom
        /// value can be returned by setting `event.returnValue`.
        [<Emit "$0.on('remote-require',$1)">] abstract ``on_remote-require``: listener: (IpcMainEvent -> string -> unit) -> WebContents
        [<Emit "$0.once('remote-require',$1)">] abstract ``once_remote-require``: listener: (IpcMainEvent -> string -> unit) -> WebContents
        [<Emit "$0.addListener('remote-require',$1)">] abstract ``addListener_remote-require``: listener: (IpcMainEvent -> string -> unit) -> WebContents
        [<Emit "$0.removeListener('remote-require',$1)">] abstract ``removeListener_remote-require``: listener: (IpcMainEvent -> string -> unit) -> WebContents
        /// Emitted when the unresponsive web page becomes responsive again.
        [<Emit "$0.on('responsive',$1)">] abstract on_responsive: listener: Function -> WebContents
        [<Emit "$0.once('responsive',$1)">] abstract once_responsive: listener: Function -> WebContents
        [<Emit "$0.addListener('responsive',$1)">] abstract addListener_responsive: listener: Function -> WebContents
        [<Emit "$0.removeListener('responsive',$1)">] abstract removeListener_responsive: listener: Function -> WebContents
        /// Emitted when bluetooth device needs to be selected on call to
        /// `navigator.bluetooth.requestDevice`. To use `navigator.bluetooth` api
        /// `webBluetooth` should be enabled. If `event.preventDefault` is not called, first
        /// available device will be selected. `callback` should be called with `deviceId`
        /// to be selected, passing empty string to `callback` will cancel the request.
        [<Emit "$0.on('select-bluetooth-device',$1)">] abstract ``on_select-bluetooth-device``: listener: (Event -> ResizeArray<BluetoothDevice> -> (string -> unit) -> unit) -> WebContents
        [<Emit "$0.once('select-bluetooth-device',$1)">] abstract ``once_select-bluetooth-device``: listener: (Event -> ResizeArray<BluetoothDevice> -> (string -> unit) -> unit) -> WebContents
        [<Emit "$0.addListener('select-bluetooth-device',$1)">] abstract ``addListener_select-bluetooth-device``: listener: (Event -> ResizeArray<BluetoothDevice> -> (string -> unit) -> unit) -> WebContents
        [<Emit "$0.removeListener('select-bluetooth-device',$1)">] abstract ``removeListener_select-bluetooth-device``: listener: (Event -> ResizeArray<BluetoothDevice> -> (string -> unit) -> unit) -> WebContents
        /// Emitted when a client certificate is requested.
        /// 
        /// The usage is the same with the `select-client-certificate` event of `app`.
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
        /// Emitted when a `<webview>`'s web contents is being attached to this web
        /// contents. Calling `event.preventDefault()` will destroy the guest page.
        /// 
        /// This event can be used to configure `webPreferences` for the `webContents` of a
        /// `<webview>` before it's loaded, and provides the ability to set settings that
        /// can't be set via `<webview>` attributes.
        /// 
        /// **Note:** The specified `preload` script option will be appear as `preloadURL`
        /// (not `preload`) in the `webPreferences` object emitted with this event.
        [<Emit "$0.on('will-attach-webview',$1)">] abstract ``on_will-attach-webview``: listener: (Event -> WebPreferences -> Record<string, string> -> unit) -> WebContents
        [<Emit "$0.once('will-attach-webview',$1)">] abstract ``once_will-attach-webview``: listener: (Event -> WebPreferences -> Record<string, string> -> unit) -> WebContents
        [<Emit "$0.addListener('will-attach-webview',$1)">] abstract ``addListener_will-attach-webview``: listener: (Event -> WebPreferences -> Record<string, string> -> unit) -> WebContents
        [<Emit "$0.removeListener('will-attach-webview',$1)">] abstract ``removeListener_will-attach-webview``: listener: (Event -> WebPreferences -> Record<string, string> -> unit) -> WebContents
        /// Emitted when a user or the page wants to start navigation. It can happen when
        /// the `window.location` object is changed or a user clicks a link in the page.
        /// 
        /// This event will not emit when the navigation is started programmatically with
        /// APIs like `webContents.loadURL` and `webContents.back`.
        /// 
        /// It is also not emitted for in-page navigations, such as clicking anchor links or
        /// updating the `window.location.hash`. Use `did-navigate-in-page` event for this
        /// purpose.
        /// 
        /// Calling `event.preventDefault()` will prevent the navigation.
        [<Emit "$0.on('will-navigate',$1)">] abstract ``on_will-navigate``: listener: (Event -> string -> unit) -> WebContents
        [<Emit "$0.once('will-navigate',$1)">] abstract ``once_will-navigate``: listener: (Event -> string -> unit) -> WebContents
        [<Emit "$0.addListener('will-navigate',$1)">] abstract ``addListener_will-navigate``: listener: (Event -> string -> unit) -> WebContents
        [<Emit "$0.removeListener('will-navigate',$1)">] abstract ``removeListener_will-navigate``: listener: (Event -> string -> unit) -> WebContents
        /// Emitted when a `beforeunload` event handler is attempting to cancel a page
        /// unload.
        /// 
        /// Calling `event.preventDefault()` will ignore the `beforeunload` event handler
        /// and allow the page to be unloaded.
        [<Emit "$0.on('will-prevent-unload',$1)">] abstract ``on_will-prevent-unload``: listener: (Event -> unit) -> WebContents
        [<Emit "$0.once('will-prevent-unload',$1)">] abstract ``once_will-prevent-unload``: listener: (Event -> unit) -> WebContents
        [<Emit "$0.addListener('will-prevent-unload',$1)">] abstract ``addListener_will-prevent-unload``: listener: (Event -> unit) -> WebContents
        [<Emit "$0.removeListener('will-prevent-unload',$1)">] abstract ``removeListener_will-prevent-unload``: listener: (Event -> unit) -> WebContents
        /// Emitted as a server side redirect occurs during navigation.  For example a 302
        /// redirect.
        /// 
        /// This event will be emitted after `did-start-navigation` and always before the
        /// `did-redirect-navigation` event for the same navigation.
        /// 
        /// Calling `event.preventDefault()` will prevent the navigation (not just the
        /// redirect).
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
        /// Begin subscribing for presentation events and captured frames, the `callback`
        /// will be called with `callback(image, dirtyRect)` when there is a presentation
        /// event.
        /// 
        /// The `image` is an instance of NativeImage that stores the captured frame.
        /// 
        /// The `dirtyRect` is an object with `x, y, width, height` properties that
        /// describes which part of the page was repainted. If `onlyDirty` is set to `true`,
        /// `image` will only contain the repainted area. `onlyDirty` defaults to `false`.
        abstract beginFrameSubscription: callback: (NativeImage -> Rectangle -> unit) -> unit
        /// Begin subscribing for presentation events and captured frames, the `callback`
        /// will be called with `callback(image, dirtyRect)` when there is a presentation
        /// event.
        /// 
        /// The `image` is an instance of NativeImage that stores the captured frame.
        /// 
        /// The `dirtyRect` is an object with `x, y, width, height` properties that
        /// describes which part of the page was repainted. If `onlyDirty` is set to `true`,
        /// `image` will only contain the repainted area. `onlyDirty` defaults to `false`.
        abstract beginFrameSubscription: onlyDirty: bool * callback: (NativeImage -> Rectangle -> unit) -> unit
        /// Whether the browser can go back to previous web page.
        abstract canGoBack: unit -> bool
        /// Whether the browser can go forward to next web page.
        abstract canGoForward: unit -> bool
        /// Whether the web page can go to `offset`.
        abstract canGoToOffset: offset: float -> bool
        /// Resolves with a NativeImage
        /// 
        /// Captures a snapshot of the page within `rect`. Omitting `rect` will capture the
        /// whole visible page.
        abstract capturePage: ?rect: Rectangle -> Promise<Electron.NativeImage>
        /// Clears the navigation history.
        abstract clearHistory: unit -> unit
        /// Closes the devtools.
        abstract closeDevTools: unit -> unit
        /// Executes the editing command `copy` in web page.
        abstract copy: unit -> unit
        /// Copy the image at the given position to the clipboard.
        abstract copyImageAt: x: float * y: float -> unit
        /// Executes the editing command `cut` in web page.
        abstract cut: unit -> unit
        /// Decrease the capturer count by one. The page will be set to hidden or occluded
        /// state when its browser window is hidden or occluded and the capturer count
        /// reaches zero.
        abstract decrementCapturerCount: unit -> unit
        /// Executes the editing command `delete` in web page.
        abstract delete: unit -> unit
        /// Disable device emulation enabled by `webContents.enableDeviceEmulation`.
        abstract disableDeviceEmulation: unit -> unit
        /// Initiates a download of the resource at `url` without navigating. The
        /// `will-download` event of `session` will be triggered.
        abstract downloadURL: url: string -> unit
        /// Enable device emulation with the given parameters.
        abstract enableDeviceEmulation: parameters: Parameters -> unit
        /// End subscribing for frame presentation events.
        abstract endFrameSubscription: unit -> unit
        /// A promise that resolves with the result of the executed code or is rejected if
        /// the result of the code is a rejected promise.
        /// 
        /// Evaluates `code` in page.
        /// 
        /// In the browser window some HTML APIs like `requestFullScreen` can only be
        /// invoked by a gesture from the user. Setting `userGesture` to `true` will remove
        /// this limitation.
        /// 
        /// Code execution will be suspended until web page stop loading.
        abstract executeJavaScript: code: string * ?userGesture: bool -> Promise<obj option>
        /// The request id used for the request.
        /// 
        /// Starts a request to find all matches for the `text` in the web page. The result
        /// of the request can be obtained by subscribing to `found-in-page` event.
        abstract findInPage: text: string * ?options: FindInPageOptions -> float
        /// Focuses the web page.
        abstract focus: unit -> unit
        /// If *offscreen rendering* is enabled returns the current frame rate.
        /// 
        /// *Deprecated**
        abstract getFrameRate: unit -> float
        /// The operating system `pid` of the associated renderer process.
        abstract getOSProcessId: unit -> float
        /// Get the system printer list.
        abstract getPrinters: unit -> ResizeArray<PrinterInfo>
        /// The Chromium internal `pid` of the associated renderer. Can be compared to the
        /// `frameProcessId` passed by frame specific navigation events (e.g.
        /// `did-frame-navigate`)
        abstract getProcessId: unit -> float
        /// The title of the current web page.
        abstract getTitle: unit -> string
        /// the type of the webContent. Can be `backgroundPage`, `window`, `browserView`,
        /// `remote`, `webview` or `offscreen`.
        abstract getType: unit -> WebContentsGetTypeReturn
        /// The URL of the current web page.
        abstract getURL: unit -> string
        /// The user agent for this web page.
        /// 
        /// *Deprecated**
        abstract getUserAgent: unit -> string
        /// Returns the WebRTC IP Handling Policy.
        abstract getWebRTCIPHandlingPolicy: unit -> string
        /// the current zoom factor.
        /// 
        /// *Deprecated**
        abstract getZoomFactor: unit -> float
        /// the current zoom level.
        /// 
        /// *Deprecated**
        abstract getZoomLevel: unit -> float
        /// Makes the browser go back a web page.
        abstract goBack: unit -> unit
        /// Makes the browser go forward a web page.
        abstract goForward: unit -> unit
        /// Navigates browser to the specified absolute web page index.
        abstract goToIndex: index: float -> unit
        /// Navigates to the specified offset from the "current entry".
        abstract goToOffset: offset: float -> unit
        /// Increase the capturer count by one. The page is considered visible when its
        /// browser window is hidden and the capturer count is non-zero.
        /// 
        /// This also affects the Page Visibility API.
        abstract incrementCapturerCount: ?size: Size -> unit
        /// A promise that resolves with a key for the inserted CSS that can later be used
        /// to remove the CSS via `contents.removeInsertedCSS(key)`.
        /// 
        /// Injects CSS into the current web page and returns a unique key for the inserted
        /// stylesheet.
        abstract insertCSS: css: string * ?options: InsertCSSOptions -> Promise<string>
        /// Inserts `text` to the focused element.
        abstract insertText: text: string -> Promise<unit>
        /// Starts inspecting element at position (`x`, `y`).
        abstract inspectElement: x: float * y: float -> unit
        /// Opens the developer tools for the service worker context.
        abstract inspectServiceWorker: unit -> unit
        /// Opens the developer tools for the shared worker context.
        abstract inspectSharedWorker: unit -> unit
        /// Schedules a full repaint of the window this web contents is in.
        /// 
        /// If *offscreen rendering* is enabled invalidates the frame and generates a new
        /// one through the `'paint'` event.
        abstract invalidate: unit -> unit
        /// Whether this page has been muted.
        /// 
        /// *Deprecated**
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
        /// the promise will resolve when the page has finished loading (see
        /// `did-finish-load`), and rejects if the page fails to load (see `did-fail-load`).
        /// 
        /// Loads the given file in the window, `filePath` should be a path to an HTML file
        /// relative to the root of your application.  For instance an app structure like
        /// this:
        /// 
        /// Would require code like this
        abstract loadFile: filePath: string * ?options: LoadFileOptions -> Promise<unit>
        /// the promise will resolve when the page has finished loading (see
        /// `did-finish-load`), and rejects if the page fails to load (see `did-fail-load`).
        /// A noop rejection handler is already attached, which avoids unhandled rejection
        /// errors.
        /// 
        /// Loads the `url` in the window. The `url` must contain the protocol prefix, e.g.
        /// the `http://` or `file://`. If the load should bypass http cache then use the
        /// `pragma` header to achieve it.
        abstract loadURL: url: string * ?options: LoadURLOptions -> Promise<unit>
        /// Opens the devtools.
        /// 
        /// When `contents` is a `<webview>` tag, the `mode` would be `detach` by default,
        /// explicitly passing an empty `mode` can force using last used dock state.
        abstract openDevTools: ?options: OpenDevToolsOptions -> unit
        /// Executes the editing command `paste` in web page.
        abstract paste: unit -> unit
        /// Executes the editing command `pasteAndMatchStyle` in web page.
        abstract pasteAndMatchStyle: unit -> unit
        /// Prints window's web page. When `silent` is set to `true`, Electron will pick the
        /// system's default printer if `deviceName` is empty and the default settings for
        /// printing.
        /// 
        /// Use `page-break-before: always;` CSS style to force to print to a new page.
        /// 
        /// Example usage:
        abstract print: ?options: WebContentsPrintOptions * ?callback: (bool -> string -> unit) -> unit
        /// Resolves with the generated PDF data.
        /// 
        /// Prints window's web page as PDF with Chromium's preview printing custom
        /// settings.
        /// 
        /// The `landscape` will be ignored if `@page` CSS at-rule is used in the web page.
        /// 
        /// By default, an empty `options` will be regarded as:
        /// 
        /// Use `page-break-before: always;` CSS style to force to print to a new page.
        /// 
        /// An example of `webContents.printToPDF`:
        abstract printToPDF: options: PrintToPDFOptions -> Promise<Buffer>
        /// Executes the editing command `redo` in web page.
        abstract redo: unit -> unit
        /// Reloads the current web page.
        abstract reload: unit -> unit
        /// Reloads current page and ignores cache.
        abstract reloadIgnoringCache: unit -> unit
        /// Resolves if the removal was successful.
        /// 
        /// Removes the inserted CSS from the current web page. The stylesheet is identified
        /// by its key, which is returned from `contents.insertCSS(css)`.
        abstract removeInsertedCSS: key: string -> Promise<unit>
        /// Removes the specified path from DevTools workspace.
        abstract removeWorkSpace: path: string -> unit
        /// Executes the editing command `replace` in web page.
        abstract replace: text: string -> unit
        /// Executes the editing command `replaceMisspelling` in web page.
        abstract replaceMisspelling: text: string -> unit
        /// resolves if the page is saved.
        abstract savePage: fullPath: string * saveType: WebContentsSavePageSaveType -> Promise<unit>
        /// Executes the editing command `selectAll` in web page.
        abstract selectAll: unit -> unit
        /// Send an asynchronous message to renderer process via `channel`, you can also
        /// send arbitrary arguments. Arguments will be serialized in JSON internally and
        /// hence no functions or prototype chain will be included.
        /// 
        /// The renderer process can handle the message by listening to `channel` with the
        /// `ipcRenderer` module.
        /// 
        /// An example of sending messages from the main process to the renderer process:
        abstract send: channel: string * [<ParamArray>] args: ResizeArray<obj option> -> unit
        /// Sends an input `event` to the page. **Note:** The `BrowserWindow` containing the
        /// contents needs to be focused for `sendInputEvent()` to work.
        abstract sendInputEvent: inputEvent: U3<MouseInputEvent, MouseWheelInputEvent, KeyboardInputEvent> -> unit
        /// Send an asynchronous message to a specific frame in a renderer process via
        /// `channel`. Arguments will be serialized as JSON internally and as such no
        /// functions or prototype chains will be included.
        /// 
        /// The renderer process can handle the message by listening to `channel` with the
        /// `ipcRenderer` module.
        /// 
        /// If you want to get the `frameId` of a given renderer context you should use the
        /// `webFrame.routingId` value.  E.g.
        /// 
        /// You can also read `frameId` from all incoming IPC messages in the main process.
        abstract sendToFrame: frameId: float * channel: string * [<ParamArray>] args: ResizeArray<obj option> -> unit
        /// Mute the audio on the current web page.
        /// 
        /// *Deprecated**
        abstract setAudioMuted: muted: bool -> unit
        /// Controls whether or not this WebContents will throttle animations and timers
        /// when the page becomes backgrounded. This also affects the Page Visibility API.
        abstract setBackgroundThrottling: allowed: bool -> unit
        /// Uses the `devToolsWebContents` as the target `WebContents` to show devtools.
        /// 
        /// The `devToolsWebContents` must not have done any navigation, and it should not
        /// be used for other purposes after the call.
        /// 
        /// By default Electron manages the devtools by creating an internal `WebContents`
        /// with native view, which developers have very limited control of. With the
        /// `setDevToolsWebContents` method, developers can use any `WebContents` to show
        /// the devtools in it, including `BrowserWindow`, `BrowserView` and `<webview>`
        /// tag.
        /// 
        /// Note that closing the devtools does not destroy the `devToolsWebContents`, it is
        /// caller's responsibility to destroy `devToolsWebContents`.
        /// 
        /// An example of showing devtools in a `<webview>` tag:
        /// 
        /// An example of showing devtools in a `BrowserWindow`:
        abstract setDevToolsWebContents: devToolsWebContents: WebContents -> unit
        /// If *offscreen rendering* is enabled sets the frame rate to the specified number.
        /// Only values between 1 and 60 are accepted.
        /// 
        /// *Deprecated**
        abstract setFrameRate: fps: float -> unit
        /// Ignore application menu shortcuts while this web contents is focused.
        abstract setIgnoreMenuShortcuts: ignore: bool -> unit
        /// Sets the maximum and minimum layout-based (i.e. non-visual) zoom level.
        abstract setLayoutZoomLevelLimits: minimumLevel: float * maximumLevel: float -> Promise<unit>
        /// Overrides the user agent for this web page.
        /// 
        /// *Deprecated**
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
        /// 
        /// *Deprecated**
        abstract setZoomFactor: factor: float -> unit
        /// Changes the zoom level to the specified level. The original size is 0 and each
        /// increment above or below represents zooming 20% larger or smaller to default
        /// limits of 300% and 50% of original size, respectively. The formula for this is
        /// `scale := 1.2 ^ level`.
        /// 
        /// *Deprecated**
        abstract setZoomLevel: level: float -> unit
        /// Shows pop-up dictionary that searches the selected word on the page.
        abstract showDefinitionForSelection: unit -> unit
        /// Sets the `item` as dragging item for current drag-drop operation, `file` is the
        /// absolute path of the file to be dragged, and `icon` is the image showing under
        /// the cursor when dragging.
        abstract startDrag: item: Item -> unit
        /// If *offscreen rendering* is enabled and not painting, start painting.
        abstract startPainting: unit -> unit
        /// Stops any pending navigation.
        abstract stop: unit -> unit
        /// Stops any `findInPage` request for the `webContents` with the provided `action`.
        abstract stopFindInPage: action: WebContentsStopFindInPageAction -> unit
        /// If *offscreen rendering* is enabled and painting, stop painting.
        abstract stopPainting: unit -> unit
        /// Indicates whether the snapshot has been created successfully.
        /// 
        /// Takes a V8 heap snapshot and saves it to `filePath`.
        abstract takeHeapSnapshot: filePath: string -> Promise<unit>
        /// Toggles the developer tools.
        abstract toggleDevTools: unit -> unit
        /// Executes the editing command `undo` in web page.
        abstract undo: unit -> unit
        /// Executes the editing command `unselect` in web page.
        abstract unselect: unit -> unit
        abstract audioMuted: bool with get, set
        abstract debugger: Debugger
        abstract devToolsWebContents: U2<WebContents, obj>
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
        [<Emit "new $0($1...)">] abstract Create: unit -> WebContents
        /// A WebContents instance with the given ID.
        abstract fromId: id: float -> WebContents
        /// An array of all `WebContents` instances. This will contain web contents for all
        /// windows, webviews, opened devtools, and devtools extension background pages.
        abstract getAllWebContents: unit -> ResizeArray<WebContents>
        /// The web contents that is focused in this application, otherwise returns `null`.
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
        /// A promise that resolves with the result of the executed code or is rejected if
        /// the result of the code is a rejected promise.
        /// 
        /// Evaluates `code` in page.
        /// 
        /// In the browser window some HTML APIs like `requestFullScreen` can only be
        /// invoked by a gesture from the user. Setting `userGesture` to `true` will remove
        /// this limitation.
        abstract executeJavaScript: code: string * ?userGesture: bool -> Promise<obj option>
        /// A promise that resolves with the result of the executed code or is rejected if
        /// the result of the code is a rejected promise.
        /// 
        /// Works like `executeJavaScript` but evaluates `scripts` in an isolated context.
        abstract executeJavaScriptInIsolatedWorld: worldId: float * scripts: ResizeArray<WebSource> * ?userGesture: bool -> Promise<obj option>
        /// A child of `webFrame` with the supplied `name`, `null` would be returned if
        /// there's no such frame or if the frame is not in the current renderer process.
        abstract findFrameByName: name: string -> WebFrame
        /// that has the supplied `routingId`, `null` if not found.
        abstract findFrameByRoutingId: routingId: float -> WebFrame
        /// The frame element in `webFrame's` document selected by `selector`, `null` would
        /// be returned if `selector` does not select a frame or if the frame is not in the
        /// current renderer process.
        abstract getFrameForSelector: selector: string -> WebFrame
        /// * `images` MemoryUsageDetails
        /// * `scripts` MemoryUsageDetails
        /// * `cssStyleSheets` MemoryUsageDetails
        /// * `xslStyleSheets` MemoryUsageDetails
        /// * `fonts` MemoryUsageDetails
        /// * `other` MemoryUsageDetails
        /// 
        /// Returns an object describing usage information of Blink's internal memory
        /// caches.
        /// 
        /// This will generate:
        abstract getResourceUsage: unit -> ResourceUsage
        /// The current zoom factor.
        abstract getZoomFactor: unit -> float
        /// The current zoom level.
        abstract getZoomLevel: unit -> float
        /// A key for the inserted CSS that can later be used to remove the CSS via
        /// `webFrame.removeInsertedCSS(key)`.
        /// 
        /// Injects CSS into the current web page and returns a unique key for the inserted
        /// stylesheet.
        abstract insertCSS: css: string -> string
        /// Inserts `text` to the focused element.
        abstract insertText: text: string -> unit
        /// Removes the inserted CSS from the current web page. The stylesheet is identified
        /// by its key, which is returned from `webFrame.insertCSS(css)`.
        abstract removeInsertedCSS: key: string -> unit
        /// Set the security origin, content security policy and name of the isolated world.
        /// Note: If the `csp` is specified, then the `securityOrigin` also has to be
        /// specified.
        abstract setIsolatedWorldInfo: worldId: float * info: Info -> unit
        /// Sets the maximum and minimum layout-based (i.e. non-visual) zoom level.
        abstract setLayoutZoomLevelLimits: minimumLevel: float * maximumLevel: float -> unit
        /// Sets a provider for spell checking in input fields and text areas.
        /// 
        /// The `provider` must be an object that has a `spellCheck` method that accepts an
        /// array of individual words for spellchecking. The `spellCheck` function runs
        /// asynchronously and calls the `callback` function with an array of misspelt words
        /// when complete.
        /// 
        /// An example of using node-spellchecker as provider:
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
        /// A `WebFrame | null` representing the first child frame of `webFrame`, the
        /// property would be `null` if `webFrame` has no children or if first child is not
        /// in the current renderer process.
        abstract firstChild: U2<WebFrame, obj>
        /// A `WebFrame | null` representing next sibling frame, the property would be
        /// `null` if `webFrame` is the last frame in its parent or if the next sibling is
        /// not in the current renderer process.
        abstract nextSibling: U2<WebFrame, obj>
        /// A `WebFrame | null` representing the frame which opened `webFrame`, the property
        /// would be `null` if there's no opener or opener is not in the current renderer
        /// process.
        abstract opener: U2<WebFrame, obj>
        /// A `WebFrame | null` representing parent frame of `webFrame`, the property would
        /// be `null` if `webFrame` is top or parent is not in the current renderer process.
        abstract parent: U2<WebFrame, obj>
        /// An `Integer` representing the unique frame id in the current renderer process.
        /// Distinct WebFrame instances that refer to the same underlying frame will have
        /// the same `routingId`.
        abstract routingId: float
        /// A `WebFrame | null` representing top frame in frame hierarchy to which
        /// `webFrame` belongs, the property would be `null` if top frame is not in the
        /// current renderer process.
        abstract top: U2<WebFrame, obj>

    type [<AllowNullLiteral>] WebRequest =
        /// The `listener` will be called with `listener(details)` when a server initiated
        /// redirect is about to occur.
        abstract onBeforeRedirect: listener: U2<(OnBeforeRedirectListenerDetails -> unit), obj> -> unit
        /// The `listener` will be called with `listener(details)` when a server initiated
        /// redirect is about to occur.
        abstract onBeforeRedirect: filter: Filter * listener: U2<(OnBeforeRedirectListenerDetails -> unit), obj> -> unit
        /// The `listener` will be called with `listener(details, callback)` when a request
        /// is about to occur.
        /// 
        /// The `uploadData` is an array of `UploadData` objects.
        /// 
        /// The `callback` has to be called with an `response` object.
        /// 
        /// Some examples of valid `urls`:
        abstract onBeforeRequest: listener: U2<(OnBeforeRequestListenerDetails -> (Response -> unit) -> unit), obj> -> unit
        /// The `listener` will be called with `listener(details, callback)` when a request
        /// is about to occur.
        /// 
        /// The `uploadData` is an array of `UploadData` objects.
        /// 
        /// The `callback` has to be called with an `response` object.
        /// 
        /// Some examples of valid `urls`:
        abstract onBeforeRequest: filter: Filter * listener: U2<(OnBeforeRequestListenerDetails -> (Response -> unit) -> unit), obj> -> unit
        /// The `listener` will be called with `listener(details, callback)` before sending
        /// an HTTP request, once the request headers are available. This may occur after a
        /// TCP connection is made to the server, but before any http data is sent.
        /// 
        /// The `callback` has to be called with a `response` object.
        abstract onBeforeSendHeaders: filter: Filter * listener: U2<(OnBeforeSendHeadersListenerDetails -> (BeforeSendResponse -> unit) -> unit), obj> -> unit
        /// The `listener` will be called with `listener(details, callback)` before sending
        /// an HTTP request, once the request headers are available. This may occur after a
        /// TCP connection is made to the server, but before any http data is sent.
        /// 
        /// The `callback` has to be called with a `response` object.
        abstract onBeforeSendHeaders: listener: U2<(OnBeforeSendHeadersListenerDetails -> (BeforeSendResponse -> unit) -> unit), obj> -> unit
        /// The `listener` will be called with `listener(details)` when a request is
        /// completed.
        abstract onCompleted: filter: Filter * listener: U2<(OnCompletedListenerDetails -> unit), obj> -> unit
        /// The `listener` will be called with `listener(details)` when a request is
        /// completed.
        abstract onCompleted: listener: U2<(OnCompletedListenerDetails -> unit), obj> -> unit
        /// The `listener` will be called with `listener(details)` when an error occurs.
        abstract onErrorOccurred: listener: U2<(OnErrorOccurredListenerDetails -> unit), obj> -> unit
        /// The `listener` will be called with `listener(details)` when an error occurs.
        abstract onErrorOccurred: filter: Filter * listener: U2<(OnErrorOccurredListenerDetails -> unit), obj> -> unit
        /// The `listener` will be called with `listener(details, callback)` when HTTP
        /// response headers of a request have been received.
        /// 
        /// The `callback` has to be called with a `response` object.
        abstract onHeadersReceived: filter: Filter * listener: U2<(OnHeadersReceivedListenerDetails -> (HeadersReceivedResponse -> unit) -> unit), obj> -> unit
        /// The `listener` will be called with `listener(details, callback)` when HTTP
        /// response headers of a request have been received.
        /// 
        /// The `callback` has to be called with a `response` object.
        abstract onHeadersReceived: listener: U2<(OnHeadersReceivedListenerDetails -> (HeadersReceivedResponse -> unit) -> unit), obj> -> unit
        /// The `listener` will be called with `listener(details)` when first byte of the
        /// response body is received. For HTTP requests, this means that the status line
        /// and response headers are available.
        abstract onResponseStarted: listener: U2<(OnResponseStartedListenerDetails -> unit), obj> -> unit
        /// The `listener` will be called with `listener(details)` when first byte of the
        /// response body is received. For HTTP requests, this means that the status line
        /// and response headers are available.
        abstract onResponseStarted: filter: Filter * listener: U2<(OnResponseStartedListenerDetails -> unit), obj> -> unit
        /// The `listener` will be called with `listener(details)` just before a request is
        /// going to be sent to the server, modifications of previous `onBeforeSendHeaders`
        /// response are visible by the time this listener is fired.
        abstract onSendHeaders: filter: Filter * listener: U2<(OnSendHeadersListenerDetails -> unit), obj> -> unit
        /// The `listener` will be called with `listener(details)` just before a request is
        /// going to be sent to the server, modifications of previous `onBeforeSendHeaders`
        /// response are visible by the time this listener is fired.
        abstract onSendHeaders: listener: U2<(OnSendHeadersListenerDetails -> unit), obj> -> unit

    type [<AllowNullLiteral>] WebRequestStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> WebRequest

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
        /// Fired when the navigation is done, i.e. the spinner of the tab will stop
        /// spinning, and the `onload` event is dispatched.
        [<Emit "$0.addEventListener('did-finish-load',$1,$2)">] abstract ``addEventListener_did-finish-load``: listener: (Event -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('did-finish-load',$1)">] abstract ``removeEventListener_did-finish-load``: listener: (Event -> unit) -> WebviewTag
        /// This event is like `did-finish-load`, but fired when the load failed or was
        /// cancelled, e.g. `window.stop()` is invoked.
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
        /// Fired when page title is set during navigation. `explicitSet` is false when
        /// title is synthesized from file url.
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
        /// Fired when a result is available for `webview.findInPage` request.
        [<Emit "$0.addEventListener('found-in-page',$1,$2)">] abstract ``addEventListener_found-in-page``: listener: (FoundInPageEvent -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('found-in-page',$1)">] abstract ``removeEventListener_found-in-page``: listener: (FoundInPageEvent -> unit) -> WebviewTag
        /// Fired when the guest page attempts to open a new browser window.
        /// 
        /// The following example code opens the new url in system's default browser.
        [<Emit "$0.addEventListener('new-window',$1,$2)">] abstract ``addEventListener_new-window``: listener: (NewWindowEvent -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('new-window',$1)">] abstract ``removeEventListener_new-window``: listener: (NewWindowEvent -> unit) -> WebviewTag
        /// Emitted when a user or the page wants to start navigation. It can happen when
        /// the `window.location` object is changed or a user clicks a link in the page.
        /// 
        /// This event will not emit when the navigation is started programmatically with
        /// APIs like `<webview>.loadURL` and `<webview>.back`.
        /// 
        /// It is also not emitted during in-page navigation, such as clicking anchor links
        /// or updating the `window.location.hash`. Use `did-navigate-in-page` event for
        /// this purpose.
        /// 
        /// Calling `event.preventDefault()` does __NOT__ have any effect.
        [<Emit "$0.addEventListener('will-navigate',$1,$2)">] abstract ``addEventListener_will-navigate``: listener: (WillNavigateEvent -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('will-navigate',$1)">] abstract ``removeEventListener_will-navigate``: listener: (WillNavigateEvent -> unit) -> WebviewTag
        /// Emitted when a navigation is done.
        /// 
        /// This event is not emitted for in-page navigations, such as clicking anchor links
        /// or updating the `window.location.hash`. Use `did-navigate-in-page` event for
        /// this purpose.
        [<Emit "$0.addEventListener('did-navigate',$1,$2)">] abstract ``addEventListener_did-navigate``: listener: (DidNavigateEvent -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('did-navigate',$1)">] abstract ``removeEventListener_did-navigate``: listener: (DidNavigateEvent -> unit) -> WebviewTag
        /// Emitted when an in-page navigation happened.
        /// 
        /// When in-page navigation happens, the page URL changes but does not cause
        /// navigation outside of the page. Examples of this occurring are when anchor links
        /// are clicked or when the DOM `hashchange` event is triggered.
        [<Emit "$0.addEventListener('did-navigate-in-page',$1,$2)">] abstract ``addEventListener_did-navigate-in-page``: listener: (DidNavigateInPageEvent -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('did-navigate-in-page',$1)">] abstract ``removeEventListener_did-navigate-in-page``: listener: (DidNavigateInPageEvent -> unit) -> WebviewTag
        /// Fired when the guest page attempts to close itself.
        /// 
        /// The following example code navigates the `webview` to `about:blank` when the
        /// guest attempts to close itself.
        [<Emit "$0.addEventListener('close',$1,$2)">] abstract addEventListener_close: listener: (Event -> unit) * ?useCapture: bool -> WebviewTag
        [<Emit "$0.removeEventListener('close',$1)">] abstract removeEventListener_close: listener: (Event -> unit) -> WebviewTag
        /// Fired when the guest page has sent an asynchronous message to embedder page.
        /// 
        /// With `sendToHost` method and `ipc-message` event you can communicate between
        /// guest page and embedder page:
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
        abstract addEventListener: ``type``: 'K * listener: (HTMLElement -> HTMLElementEventMap -> obj option) * ?useCapture: bool -> unit
        abstract addEventListener: ``type``: string * listener: EventListenerOrEventListenerObject * ?useCapture: bool -> unit
        abstract removeEventListener: ``type``: 'K * listener: (HTMLElement -> HTMLElementEventMap -> obj option) * ?useCapture: bool -> unit
        abstract removeEventListener: ``type``: string * listener: EventListenerOrEventListenerObject * ?useCapture: bool -> unit
        /// Whether the guest page can go back.
        abstract canGoBack: unit -> bool
        /// Whether the guest page can go forward.
        abstract canGoForward: unit -> bool
        /// Whether the guest page can go to `offset`.
        abstract canGoToOffset: offset: float -> bool
        /// Resolves with a NativeImage
        /// 
        /// Captures a snapshot of the page within `rect`. Omitting `rect` will capture the
        /// whole visible page.
        abstract capturePage: ?rect: Rectangle -> Promise<Electron.NativeImage>
        /// Clears the navigation history.
        abstract clearHistory: unit -> unit
        /// Closes the DevTools window of guest page.
        abstract closeDevTools: unit -> unit
        /// Executes editing command `copy` in page.
        abstract copy: unit -> unit
        /// Executes editing command `cut` in page.
        abstract cut: unit -> unit
        /// Executes editing command `delete` in page.
        abstract delete: unit -> unit
        /// Initiates a download of the resource at `url` without navigating.
        abstract downloadURL: url: string -> unit
        /// A promise that resolves with the result of the executed code or is rejected if
        /// the result of the code is a rejected promise.
        /// 
        /// Evaluates `code` in page. If `userGesture` is set, it will create the user
        /// gesture context in the page. HTML APIs like `requestFullScreen`, which require
        /// user action, can take advantage of this option for automation.
        abstract executeJavaScript: code: string * ?userGesture: bool -> Promise<obj option>
        /// The request id used for the request.
        /// 
        /// Starts a request to find all matches for the `text` in the web page. The result
        /// of the request can be obtained by subscribing to `found-in-page` event.
        abstract findInPage: text: string * ?options: FindInPageOptions -> float
        /// The title of guest page.
        abstract getTitle: unit -> string
        /// The URL of guest page.
        abstract getURL: unit -> string
        /// The user agent for guest page.
        abstract getUserAgent: unit -> string
        /// The web contents associated with this `webview`.
        /// 
        /// It depends on the `remote` module, it is therefore not available when this
        /// module is disabled.
        abstract getWebContents: unit -> WebContents
        /// The WebContents ID of this `webview`.
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
        /// A promise that resolves with a key for the inserted CSS that can later be used
        /// to remove the CSS via `<webview>.removeInsertedCSS(key)`.
        /// 
        /// Injects CSS into the current web page and returns a unique key for the inserted
        /// stylesheet.
        abstract insertCSS: css: string -> Promise<string>
        /// Inserts `text` to the focused element.
        abstract insertText: text: string -> Promise<unit>
        /// Starts inspecting element at position (`x`, `y`) of guest page.
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
        /// The promise will resolve when the page has finished loading (see
        /// `did-finish-load`), and rejects if the page fails to load (see `did-fail-load`).
        /// 
        /// Loads the `url` in the webview, the `url` must contain the protocol prefix, e.g.
        /// the `http://` or `file://`.
        abstract loadURL: url: string * ?options: LoadURLOptions -> Promise<unit>
        /// Opens a DevTools window for guest page.
        abstract openDevTools: unit -> unit
        /// Executes editing command `paste` in page.
        abstract paste: unit -> unit
        /// Executes editing command `pasteAndMatchStyle` in page.
        abstract pasteAndMatchStyle: unit -> unit
        /// Prints `webview`'s web page. Same as `webContents.print([options])`.
        abstract print: ?options: WebviewTagPrintOptions -> Promise<unit>
        /// Resolves with the generated PDF data.
        /// 
        /// Prints `webview`'s web page as PDF, Same as `webContents.printToPDF(options)`.
        abstract printToPDF: options: PrintToPDFOptions -> Promise<Buffer>
        /// Executes editing command `redo` in page.
        abstract redo: unit -> unit
        /// Reloads the guest page.
        abstract reload: unit -> unit
        /// Reloads the guest page and ignores cache.
        abstract reloadIgnoringCache: unit -> unit
        /// Resolves if the removal was successful.
        /// 
        /// Removes the inserted CSS from the current web page. The stylesheet is identified
        /// by its key, which is returned from `<webview>.insertCSS(css)`.
        abstract removeInsertedCSS: key: string -> Promise<unit>
        /// Executes editing command `replace` in page.
        abstract replace: text: string -> unit
        /// Executes editing command `replaceMisspelling` in page.
        abstract replaceMisspelling: text: string -> unit
        /// Executes editing command `selectAll` in page.
        abstract selectAll: unit -> unit
        /// Send an asynchronous message to renderer process via `channel`, you can also
        /// send arbitrary arguments. The renderer process can handle the message by
        /// listening to the `channel` event with the `ipcRenderer` module.
        /// 
        /// See webContents.send for examples.
        abstract send: channel: string * [<ParamArray>] args: ResizeArray<obj option> -> Promise<unit>
        /// Sends an input `event` to the page.
        /// 
        /// See webContents.sendInputEvent for detailed description of `event` object.
        abstract sendInputEvent: ``event``: U3<MouseInputEvent, MouseWheelInputEvent, KeyboardInputEvent> -> Promise<unit>
        /// Set guest page muted.
        abstract setAudioMuted: muted: bool -> unit
        /// Sets the maximum and minimum layout-based (i.e. non-visual) zoom level.
        abstract setLayoutZoomLevelLimits: minimumLevel: float * maximumLevel: float -> Promise<unit>
        /// Overrides the user agent for the guest page.
        abstract setUserAgent: userAgent: string -> unit
        /// Sets the maximum and minimum pinch-to-zoom level.
        abstract setVisualZoomLevelLimits: minimumLevel: float * maximumLevel: float -> Promise<unit>
        /// Changes the zoom factor to the specified factor. Zoom factor is zoom percent
        /// divided by 100, so 300% = 3.0.
        abstract setZoomFactor: factor: float -> unit
        /// Changes the zoom level to the specified level. The original size is 0 and each
        /// increment above or below represents zooming 20% larger or smaller to default
        /// limits of 300% and 50% of original size, respectively. The formula for this is
        /// `scale := 1.2 ^ level`.
        abstract setZoomLevel: level: float -> unit
        /// Shows pop-up dictionary that searches the selected word on the page.
        abstract showDefinitionForSelection: unit -> unit
        /// Stops any pending navigation.
        abstract stop: unit -> unit
        /// Stops any `findInPage` request for the `webview` with the provided `action`.
        abstract stopFindInPage: action: WebviewTagStopFindInPageAction -> unit
        /// Executes editing command `undo` in page.
        abstract undo: unit -> unit
        /// Executes editing command `unselect` in page.
        abstract unselect: unit -> unit
        /// A `Boolean`. When this attribute is present the guest page will be allowed to
        /// open new windows. Popups are disabled by default.
        abstract allowpopups: bool with get, set
        /// A `String` which is a list of strings which specifies the blink features to be
        /// disabled separated by `,`. The full list of supported feature strings can be
        /// found in the RuntimeEnabledFeatures.json5 file.
        abstract disableblinkfeatures: string with get, set
        /// A `Boolean`. When this attribute is present the guest page will have web
        /// security disabled. Web security is enabled by default.
        abstract disablewebsecurity: bool with get, set
        /// A `String` which is a list of strings which specifies the blink features to be
        /// enabled separated by `,`. The full list of supported feature strings can be
        /// found in the RuntimeEnabledFeatures.json5 file.
        abstract enableblinkfeatures: string with get, set
        /// A `Boolean`. When this attribute is `false` the guest page in `webview` will not
        /// have access to the `remote` module. The remote module is available by default.
        abstract enableremotemodule: bool with get, set
        /// A `String` that sets the referrer URL for the guest page.
        abstract httpreferrer: string with get, set
        /// A `Boolean`. When this attribute is present the guest page in `webview` will
        /// have node integration and can use node APIs like `require` and `process` to
        /// access low level system resources. Node integration is disabled by default in
        /// the guest page.
        abstract nodeintegration: bool with get, set
        /// A `Boolean` for the experimental option for enabling NodeJS support in
        /// sub-frames such as iframes inside the `webview`. All your preloads will load for
        /// every iframe, you can use `process.isMainFrame` to determine if you are in the
        /// main frame or not. This option is disabled by default in the guest page.
        abstract nodeintegrationinsubframes: bool with get, set
        /// A `String` that sets the session used by the page. If `partition` starts with
        /// `persist:`, the page will use a persistent session available to all pages in the
        /// app with the same `partition`. if there is no `persist:` prefix, the page will
        /// use an in-memory session. By assigning the same `partition`, multiple pages can
        /// share the same session. If the `partition` is unset then default session of the
        /// app will be used.
        /// 
        /// This value can only be modified before the first navigation, since the session
        /// of an active renderer process cannot change. Subsequent attempts to modify the
        /// value will fail with a DOM exception.
        abstract partition: string with get, set
        /// A `Boolean`. When this attribute is present the guest page in `webview` will be
        /// able to use browser plugins. Plugins are disabled by default.
        abstract plugins: bool with get, set
        /// A `String` that specifies a script that will be loaded before other scripts run
        /// in the guest page. The protocol of script's URL must be either `file:` or
        /// `asar:`, because it will be loaded by `require` in guest page under the hood.
        /// 
        /// When the guest page doesn't have node integration this script will still have
        /// access to all Node APIs, but global objects injected by Node will be deleted
        /// after this script has finished executing.
        /// 
        /// **Note:** This option will appear as `preloadURL` (not `preload`) in the
        /// `webPreferences` specified to the `will-attach-webview` event.
        abstract preload: string with get, set
        /// A `String` representing the visible URL. Writing to this attribute initiates
        /// top-level navigation.
        /// 
        /// Assigning `src` its own value will reload the current page.
        /// 
        /// The `src` attribute can also accept data URLs, such as `data:text/plain,Hello,
        /// world!`.
        abstract src: string with get, set
        /// A `String` that sets the user agent for the guest page before the page is
        /// navigated to. Once the page is loaded, use the `setUserAgent` method to change
        /// the user agent.
        abstract useragent: string with get, set
        /// A `String` which is a comma separated list of strings which specifies the web
        /// preferences to be set on the webview. The full list of supported preference
        /// strings can be found in BrowserWindow.
        /// 
        /// The string follows the same format as the features string in `window.open`. A
        /// name by itself is given a `true` boolean value. A preference can be set to
        /// another value by including an `=`, followed by the value. Special values `yes`
        /// and `1` are interpreted as `true`, while `no` and `0` are interpreted as
        /// `false`.
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
        /// The app's build version number.
        abstract version: string option with get, set
        /// Credit information.
        abstract credits: string option with get, set
        /// List of app authors.
        abstract authors: ResizeArray<string> option with get, set
        /// The app's website.
        abstract website: string option with get, set
        /// Path to the app's icon. Will be shown as 64x64 pixels while retaining aspect
        /// ratio.
        abstract iconPath: string option with get, set

    type [<AllowNullLiteral>] AddRepresentationOptions =
        /// The scale factor to add the image representation for.
        abstract scaleFactor: float with get, set
        /// Defaults to 0. Required if a bitmap buffer is specified as `buffer`.
        abstract width: float option with get, set
        /// Defaults to 0. Required if a bitmap buffer is specified as `buffer`.
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
        /// Index of the icon in `appIconPath`. Ignored when `appIconPath` is not set.
        /// Default is `0`.
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
        /// If `true`, the view's width will grow and shrink together with the window.
        /// `false` by default.
        abstract width: bool option with get, set
        /// If `true`, the view's height will grow and shrink together with the window.
        /// `false` by default.
        abstract height: bool option with get, set
        /// If `true`, the view's x position and width will grow and shrink proportionally
        /// with the window. `false` by default.
        abstract horizontal: bool option with get, set
        /// If `true`, the view's y position and height will grow and shrink proportionally
        /// with the window. `false` by default.
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
        /// Window's width in pixels. Default is `800`.
        abstract width: float option with get, set
        /// Window's height in pixels. Default is `600`.
        abstract height: float option with get, set
        /// (**required** if y is used) Window's left offset from screen. Default is to
        /// center the window.
        abstract x: float option with get, set
        /// (**required** if x is used) Window's top offset from screen. Default is to
        /// center the window.
        abstract y: float option with get, set
        /// The `width` and `height` would be used as web page's size, which means the
        /// actual window's size will include window frame's size and be slightly larger.
        /// Default is `false`.
        abstract useContentSize: bool option with get, set
        /// Show window in the center of the screen.
        abstract center: bool option with get, set
        /// Window's minimum width. Default is `0`.
        abstract minWidth: float option with get, set
        /// Window's minimum height. Default is `0`.
        abstract minHeight: float option with get, set
        /// Window's maximum width. Default is no limit.
        abstract maxWidth: float option with get, set
        /// Window's maximum height. Default is no limit.
        abstract maxHeight: float option with get, set
        /// Whether window is resizable. Default is `true`.
        abstract resizable: bool option with get, set
        /// Whether window is movable. This is not implemented on Linux. Default is `true`.
        abstract movable: bool option with get, set
        /// Whether window is minimizable. This is not implemented on Linux. Default is
        /// `true`.
        abstract minimizable: bool option with get, set
        /// Whether window is maximizable. This is not implemented on Linux. Default is
        /// `true`.
        abstract maximizable: bool option with get, set
        /// Whether window is closable. This is not implemented on Linux. Default is `true`.
        abstract closable: bool option with get, set
        /// Whether the window can be focused. Default is `true`. On Windows setting
        /// `focusable: false` also implies setting `skipTaskbar: true`. On Linux setting
        /// `focusable: false` makes the window stop interacting with wm, so the window will
        /// always stay on top in all workspaces.
        abstract focusable: bool option with get, set
        /// Whether the window should always stay on top of other windows. Default is
        /// `false`.
        abstract alwaysOnTop: bool option with get, set
        /// Whether the window should show in fullscreen. When explicitly set to `false` the
        /// fullscreen button will be hidden or disabled on macOS. Default is `false`.
        abstract fullscreen: bool option with get, set
        /// Whether the window can be put into fullscreen mode. On macOS, also whether the
        /// maximize/zoom button should toggle full screen mode or maximize window. Default
        /// is `true`.
        abstract fullscreenable: bool option with get, set
        /// Use pre-Lion fullscreen on macOS. Default is `false`.
        abstract simpleFullscreen: bool option with get, set
        /// Whether to show the window in taskbar. Default is `false`.
        abstract skipTaskbar: bool option with get, set
        /// The kiosk mode. Default is `false`.
        abstract kiosk: bool option with get, set
        /// Default window title. Default is `"Electron"`. If the HTML tag `<title>` is
        /// defined in the HTML file loaded by `loadURL()`, this property will be ignored.
        abstract title: string option with get, set
        /// The window icon. On Windows it is recommended to use `ICO` icons to get best
        /// visual effects, you can also leave it undefined so the executable's icon will be
        /// used.
        abstract icon: U2<NativeImage, string> option with get, set
        /// Whether window should be shown when created. Default is `true`.
        abstract show: bool option with get, set
        /// Whether the renderer should be active when `show` is `false` and it has just
        /// been created.  In order for `document.visibilityState` to work correctly on
        /// first load with `show: false` you should set this to `false`.  Setting this to
        /// `false` will cause the `ready-to-show` event to not fire.  Default is `true`.
        abstract paintWhenInitiallyHidden: bool option with get, set
        /// Specify `false` to create a Frameless Window. Default is `true`.
        abstract frame: bool option with get, set
        /// Specify parent window. Default is `null`.
        abstract parent: BrowserWindow option with get, set
        /// Whether this is a modal window. This only works when the window is a child
        /// window. Default is `false`.
        abstract modal: bool option with get, set
        /// Whether the web view accepts a single mouse-down event that simultaneously
        /// activates the window. Default is `false`.
        abstract acceptFirstMouse: bool option with get, set
        /// Whether to hide cursor when typing. Default is `false`.
        abstract disableAutoHideCursor: bool option with get, set
        /// Auto hide the menu bar unless the `Alt` key is pressed. Default is `false`.
        abstract autoHideMenuBar: bool option with get, set
        /// Enable the window to be resized larger than screen. Only relevant for macOS, as
        /// other OSes allow larger-than-screen windows by default. Default is `false`.
        abstract enableLargerThanScreen: bool option with get, set
        /// Window's background color as a hexadecimal value, like `#66CD00` or `#FFF` or
        /// `#80FFFFFF` (alpha in #AARRGGBB format is supported if `transparent` is set to
        /// `true`). Default is `#FFF` (white).
        abstract backgroundColor: string option with get, set
        /// Whether window should have a shadow. This is only implemented on macOS. Default
        /// is `true`.
        abstract hasShadow: bool option with get, set
        /// Set the initial opacity of the window, between 0.0 (fully transparent) and 1.0
        /// (fully opaque). This is only implemented on Windows and macOS.
        abstract opacity: float option with get, set
        /// Forces using dark theme for the window, only works on some GTK+3 desktop
        /// environments. Default is `false`.
        abstract darkTheme: bool option with get, set
        /// Makes the window transparent. Default is `false`. On Windows, does not work
        /// unless the window is frameless.
        abstract transparent: bool option with get, set
        /// The type of window, default is normal window. See more about this below.
        abstract ``type``: string option with get, set
        /// The style of window title bar. Default is `default`. Possible values are:
        abstract titleBarStyle: BrowserWindowConstructorOptionsTitleBarStyle option with get, set
        /// Shows the title in the title bar in full screen mode on macOS for all
        /// `titleBarStyle` options. Default is `false`.
        abstract fullscreenWindowTitle: bool option with get, set
        /// Use `WS_THICKFRAME` style for frameless windows on Windows, which adds standard
        /// window frame. Setting it to `false` will remove window shadow and window
        /// animations. Default is `true`.
        abstract thickFrame: bool option with get, set
        /// Add a type of vibrancy effect to the window, only on macOS. Can be
        /// `appearance-based`, `light`, `dark`, `titlebar`, `selection`, `menu`, `popover`,
        /// `sidebar`, `medium-light`, `ultra-dark`, `header`, `sheet`, `window`, `hud`,
        /// `fullscreen-ui`, `tooltip`, `content`, `under-window`, or `under-page`.  Please
        /// note that using `frame: false` in combination with a vibrancy value requires
        /// that you use a non-default `titleBarStyle` as well. Also note that
        /// `appearance-based`, `light`, `dark`, `medium-light`, and `ultra-dark` have been
        /// deprecated and will be removed in an upcoming version of macOS.
        abstract vibrancy: BrowserWindowSetVibrancy option with get, set
        /// Controls the behavior on macOS when option-clicking the green stoplight button
        /// on the toolbar or by clicking the Window > Zoom menu item. If `true`, the window
        /// will grow to the preferred width of the web page when zoomed, `false` will cause
        /// it to zoom to the width of the screen. This will also affect the behavior when
        /// calling `maximize()` directly. Default is `false`.
        abstract zoomToPageWidth: bool option with get, set
        /// Tab group name, allows opening the window as a native tab on macOS 10.12+.
        /// Windows with the same tabbing identifier will be grouped together. This also
        /// adds a native new tab button to your window's tab bar and allows your `app` and
        /// window to receive the `new-window-for-tab` event.
        abstract tabbingIdentifier: string option with get, set
        /// Settings of web page's features.
        abstract webPreferences: WebPreferences option with get, set

    type [<AllowNullLiteral>] CertificateTrustDialogOptions =
        /// The certificate to trust/import.
        abstract certificate: Certificate with get, set
        /// The message to display to the user.
        abstract message: string with get, set

    type [<AllowNullLiteral>] ClearStorageDataOptions =
        /// Should follow `window.location.origin`’s representation `scheme://host:port`.
        abstract origin: string option with get, set
        /// The types of storages to clear, can contain: `appcache`, `cookies`,
        /// `filesystem`, `indexdb`, `localstorage`, `shadercache`, `websql`,
        /// `serviceworkers`, `cachestorage`.
        abstract storages: ResizeArray<string> option with get, set
        /// The types of quotas to clear, can contain: `temporary`, `persistent`,
        /// `syncable`.
        abstract quotas: ResizeArray<string> option with get, set

    type [<AllowNullLiteral>] ClientRequestConstructorOptions =
        /// The HTTP request method. Defaults to the GET method.
        abstract ``method``: string option with get, set
        /// The request URL. Must be provided in the absolute form with the protocol scheme
        /// specified as http or https.
        abstract url: string option with get, set
        /// The `Session` instance with which the request is associated.
        abstract session: Session option with get, set
        /// The name of the `partition` with which the request is associated. Defaults to
        /// the empty string. The `session` option prevails on `partition`. Thus if a
        /// `session` is explicitly specified, `partition` is ignored.
        abstract partition: string option with get, set
        /// Whether to send cookies with this request from the provided session.  This will
        /// make the `net` request's cookie behavior match a `fetch` request. Default is
        /// `false`.
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
        /// The redirect mode for this request. Should be one of `follow`, `error` or
        /// `manual`. Defaults to `follow`. When mode is `error`, any redirection will be
        /// aborted. When mode is `manual` the redirection will be cancelled unless
        /// `request.followRedirect` is invoked synchronously during the `redirect` event.
        abstract redirect: string option with get, set

    type [<AllowNullLiteral>] Config =
        /// The URL associated with the PAC file.
        abstract pacScript: string with get, set
        /// Rules indicating which proxies to use.
        abstract proxyRules: string with get, set
        /// Rules indicating which URLs should bypass the proxy settings.
        abstract proxyBypassRules: string with get, set

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
        /// Type of the node the context menu was invoked on. Can be `none`, `image`,
        /// `audio`, `video`, `canvas`, `file` or `plugin`.
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
        /// The character encoding of the frame on which the menu was invoked.
        abstract frameCharset: string with get, set
        /// If the context menu was invoked on an input field, the type of that field.
        /// Possible values are `none`, `plainText`, `password`, `other`.
        abstract inputFieldType: string with get, set
        /// Input source that invoked the context menu. Can be `none`, `mouse`, `keyboard`,
        /// `touch` or `touchMenu`.
        abstract menuSourceType: ContextMenuParamsMenuSourceType with get, set
        /// The flags for the media element the context menu was invoked on.
        abstract mediaFlags: MediaFlags with get, set
        /// These flags indicate whether the renderer believes it is able to perform the
        /// corresponding action.
        abstract editFlags: EditFlags with get, set

    type [<AllowNullLiteral>] CookiesGetFilter =
        /// Retrieves cookies which are associated with `url`. Empty implies retrieving
        /// cookies of all URLs.
        abstract url: string option with get, set
        /// Filters cookies by name.
        abstract name: string option with get, set
        /// Retrieves cookies whose domains match or are subdomains of `domains`.
        abstract domain: string option with get, set
        /// Retrieves cookies whose path matches `path`.
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
        abstract companyName: string with get, set
        /// URL that crash reports will be sent to as POST.
        abstract submitURL: string with get, set
        /// Defaults to `app.name`.
        abstract productName: string option with get, set
        /// Whether crash reports should be sent to the server. Default is `true`.
        abstract uploadToServer: bool option with get, set
        /// Default is `false`.
        abstract ignoreSystemCrashHandler: bool option with get, set
        /// An object you can define that will be sent along with the report. Only string
        /// properties are sent correctly. Nested objects are not supported. When using
        /// Windows, the property names and values must be fewer than 64 characters.
        abstract extra: Record<string, string> option with get, set
        /// Directory to store the crash reports temporarily (only used when the crash
        /// reporter is started via `process.crashReporter.start`).
        abstract crashesDirectory: string option with get, set

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
        abstract lastModified: string with get, set
        /// ETag header value.
        abstract eTag: string with get, set
        /// Time when download was started in number of seconds since UNIX epoch.
        abstract startTime: float option with get, set

    type [<AllowNullLiteral>] Data =
        abstract text: string option with get, set
        abstract html: string option with get, set
        abstract image: NativeImage option with get, set
        abstract rtf: string option with get, set
        /// The title of the URL at `text`.
        abstract bookmark: string option with get, set

    type [<AllowNullLiteral>] Details =
        /// The security orign of the `media` check.
        abstract securityOrigin: string with get, set
        /// The type of media access being requested, can be `video`, `audio` or `unknown`
        abstract mediaType: DetailsMediaType with get, set
        /// The last URL the requesting frame loaded
        abstract requestingUrl: string with get, set
        /// Whether the frame making the request is the main frame
        abstract isMainFrame: bool with get, set

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
        abstract icon: U2<NativeImage, string> option with get, set
        abstract title: string with get, set
        abstract content: string with get, set

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
        /// HTTP request headers.
        abstract headers: Record<string, string> option with get, set
        /// Either `json` or `default`, see the Squirrel.Mac README for more information.
        abstract serverType: string option with get, set

    type [<AllowNullLiteral>] FileIconOptions =
        abstract size: FileIconOptionsSize with get, set

    type [<AllowNullLiteral>] Filter =
        /// Array of URL patterns that will be used to filter out the requests that do not
        /// match the URL patterns.
        abstract urls: ResizeArray<string> with get, set

    type [<AllowNullLiteral>] FindInPageOptions =
        /// Whether to search forward or backward, defaults to `true`.
        abstract forward: bool option with get, set
        /// Whether the operation is first request or a follow up, defaults to `false`.
        abstract findNext: bool option with get, set
        /// Whether search should be case-sensitive, defaults to `false`.
        abstract matchCase: bool option with get, set
        /// Whether to look only at the start of words. defaults to `false`.
        abstract wordStart: bool option with get, set
        /// When combined with `wordStart`, accepts a match in the middle of a word if the
        /// match begins with an uppercase letter followed by a lowercase or non-letter.
        /// Accepts several other intra-word matches, defaults to `false`.
        abstract medialCapitalAsWordStart: bool option with get, set

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
        /// Should be provided when overriding `responseHeaders` to change header status
        /// otherwise original response header's status will be used.
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
        /// If true, forwards mouse move messages to Chromium, enabling mouse related events
        /// such as `mouseleave`. Only used when `ignore` is true. If `ignore` is false,
        /// forwarding is always disabled regardless of this value.
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
        /// Either `keyUp` or `keyDown`.
        abstract ``type``: string with get, set
        /// Equivalent to KeyboardEvent.key.
        abstract key: string with get, set
        /// Equivalent to KeyboardEvent.code.
        abstract code: string with get, set
        /// Equivalent to KeyboardEvent.repeat.
        abstract isAutoRepeat: bool with get, set
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
        abstract icon: NativeImage with get, set

    type [<AllowNullLiteral>] JumpListSettings =
        /// The minimum number of items that will be shown in the Jump List (for a more
        /// detailed description of this value see the MSDN docs).
        abstract minItems: float with get, set
        /// Array of `JumpListItem` objects that correspond to items that the user has
        /// explicitly removed from custom categories in the Jump List. These items must not
        /// be re-added to the Jump List in the **next** call to `app.setJumpList()`,
        /// Windows will not display any custom category that contains any of the removed
        /// items.
        abstract removedItems: ResizeArray<JumpListItem> with get, set

    type [<AllowNullLiteral>] LoadCommitEvent =
        inherit Event
        abstract url: string with get, set
        abstract isMainFrame: bool with get, set

    type [<AllowNullLiteral>] LoadFileOptions =
        /// Passed to `url.format()`.
        abstract query: Record<string, string> option with get, set
        /// Passed to `url.format()`.
        abstract search: string option with get, set
        /// Passed to `url.format()`.
        abstract hash: string option with get, set

    type [<AllowNullLiteral>] LoadURLOptions =
        /// An HTTP Referrer url.
        abstract httpReferrer: U2<string, Referrer> option with get, set
        /// A user agent originating the request.
        abstract userAgent: string option with get, set
        /// Extra headers separated by "\n"
        abstract extraHeaders: string option with get, set
        abstract postData: U3<ResizeArray<UploadRawData>, ResizeArray<UploadFile>, ResizeArray<UploadBlob>> option with get, set
        /// Base url (with trailing path separator) for files to be loaded by the data url.
        /// This is needed only if the specified `url` is a data url and needs to load other
        /// files.
        abstract baseURLForDataURL: string option with get, set

    type [<AllowNullLiteral>] LoginItemSettings =
        /// `true` if the app is set to open at login.
        abstract openAtLogin: bool with get, set
        /// `true` if the app is set to open as hidden at login. This setting is not
        /// available on MAS builds.
        abstract openAsHidden: bool with get, set
        /// `true` if the app was opened at login automatically. This setting is not
        /// available on MAS builds.
        abstract wasOpenedAtLogin: bool with get, set
        /// `true` if the app was opened as a hidden login item. This indicates that the app
        /// should not open any windows at startup. This setting is not available on MAS
        /// builds.
        abstract wasOpenedAsHidden: bool with get, set
        /// `true` if the app was opened as a login item that should restore the state from
        /// the previous session. This indicates that the app should restore the windows
        /// that were open the last time the app was closed. This setting is not available
        /// on MAS builds.
        abstract restoreState: bool with get, set

    type [<AllowNullLiteral>] LoginItemSettingsOptions =
        /// The executable path to compare against. Defaults to `process.execPath`.
        abstract path: string option with get, set
        /// The command-line arguments to compare against. Defaults to an empty array.
        abstract args: ResizeArray<string> option with get, set

    type [<AllowNullLiteral>] MenuItemConstructorOptions =
        /// Will be called with `click(menuItem, browserWindow, event)` when the menu item
        /// is clicked.
        abstract click: (MenuItem -> BrowserWindow -> KeyboardEvent -> unit) option with get, set
        /// Can be `undo`, `redo`, `cut`, `copy`, `paste`, `pasteAndMatchStyle`, `delete`,
        /// `selectAll`, `reload`, `forceReload`, `toggleDevTools`, `resetZoom`, `zoomIn`,
        /// `zoomOut`, `togglefullscreen`, `window`, `minimize`, `close`, `help`, `about`,
        /// `services`, `hide`, `hideOthers`, `unhide`, `quit`, `startSpeaking`,
        /// `stopSpeaking`, `close`, `minimize`, `zoom`, `front`, `appMenu`, `fileMenu`,
        /// `editMenu`, `viewMenu`, `recentDocuments`, `toggleTabBar`, `selectNextTab`,
        /// `selectPreviousTab`, `mergeAllWindows`, `clearRecentDocuments`,
        /// `moveTabToNewWindow` or `windowMenu` - Define the action of the menu item, when
        /// specified the `click` property will be ignored. See roles.
        abstract role: MenuItemRole option with get, set
        /// Can be `normal`, `separator`, `submenu`, `checkbox` or `radio`.
        abstract ``type``: MenuItemType option with get, set
        abstract label: string option with get, set
        abstract sublabel: string option with get, set
        /// Hover text for this menu item.
        abstract toolTip: string option with get, set
        abstract accelerator: Accelerator option with get, set
        abstract icon: U2<NativeImage, string> option with get, set
        /// If false, the menu item will be greyed out and unclickable.
        abstract enabled: bool option with get, set
        /// default is `true`, and when `false` will prevent the accelerator from triggering
        /// the item if the item is not visible`.
        abstract acceleratorWorksWhenHidden: bool option with get, set
        /// If false, the menu item will be entirely hidden.
        abstract visible: bool option with get, set
        /// Should only be specified for `checkbox` or `radio` type menu items.
        abstract ``checked``: bool option with get, set
        /// If false, the accelerator won't be registered with the system, but it will still
        /// be displayed. Defaults to true.
        abstract registerAccelerator: bool option with get, set
        /// Should be specified for `submenu` type menu items. If `submenu` is specified,
        /// the `type: 'submenu'` can be omitted. If the value is not a `Menu` then it will
        /// be automatically converted to one using `Menu.buildFromTemplate`.
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
        /// Can be `"none"`, `"info"`, `"error"`, `"question"` or `"warning"`. On Windows,
        /// `"question"` displays the same icon as `"info"`, unless you set an icon using
        /// the `"icon"` option. On macOS, both `"warning"` and `"error"` display the same
        /// warning icon.
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
        /// Initial checked state of the checkbox. `false` by default.
        abstract checkboxChecked: bool option with get, set
        abstract icon: NativeImage option with get, set
        /// The index of the button to be used to cancel the dialog, via the `Esc` key. By
        /// default this is assigned to the first button with "cancel" or "no" as the label.
        /// If no such labeled buttons exist and this option is not set, `0` will be used as
        /// the return value.
        abstract cancelId: float option with get, set
        /// On Windows Electron will try to figure out which one of the `buttons` are common
        /// buttons (like "Cancel" or "Yes"), and show the others as command links in the
        /// dialog. This can make the dialog appear in the style of modern Windows apps. If
        /// you don't like this behavior, you can set `noLink` to `true`.
        abstract noLink: bool option with get, set
        /// Normalize the keyboard access keys across platforms. Default is `false`.
        /// Enabling this assumes `&` is used in the button labels for the placement of the
        /// keyboard shortcut access key and labels will be converted so they work correctly
        /// on each platform, `&` characters are removed on macOS, converted to `_` on
        /// Linux, and left untouched on Windows. For example, a button label of `Vie&w`
        /// will be converted to `Vie_w` on Linux and `View` on macOS and can be selected
        /// via `Alt-W` on Windows and Linux.
        abstract normalizeAccessKeys: bool option with get, set

    type [<AllowNullLiteral>] MessageBoxReturnValue =
        /// The index of the clicked button.
        abstract response: float with get, set
        /// The checked state of the checkbox if `checkboxLabel` was set. Otherwise `false`.
        abstract checkboxChecked: bool with get, set

    type [<AllowNullLiteral>] MessageBoxSyncOptions =
        /// Can be `"none"`, `"info"`, `"error"`, `"question"` or `"warning"`. On Windows,
        /// `"question"` displays the same icon as `"info"`, unless you set an icon using
        /// the `"icon"` option. On macOS, both `"warning"` and `"error"` display the same
        /// warning icon.
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
        /// Initial checked state of the checkbox. `false` by default.
        abstract checkboxChecked: bool option with get, set
        abstract icon: U2<NativeImage, string> option with get, set
        /// The index of the button to be used to cancel the dialog, via the `Esc` key. By
        /// default this is assigned to the first button with "cancel" or "no" as the label.
        /// If no such labeled buttons exist and this option is not set, `0` will be used as
        /// the return value.
        abstract cancelId: float option with get, set
        /// On Windows Electron will try to figure out which one of the `buttons` are common
        /// buttons (like "Cancel" or "Yes"), and show the others as command links in the
        /// dialog. This can make the dialog appear in the style of modern Windows apps. If
        /// you don't like this behavior, you can set `noLink` to `true`.
        abstract noLink: bool option with get, set
        /// Normalize the keyboard access keys across platforms. Default is `false`.
        /// Enabling this assumes `&` is used in the button labels for the placement of the
        /// keyboard shortcut access key and labels will be converted so they work correctly
        /// on each platform, `&` characters are removed on macOS, converted to `_` on
        /// Linux, and left untouched on Windows. For example, a button label of `Vie&w`
        /// will be converted to `Vie_w` on Linux and `View` on macOS and can be selected
        /// via `Alt-W` on Windows and Linux.
        abstract normalizeAccessKeys: bool option with get, set

    type [<AllowNullLiteral>] MoveToApplicationsFolderOptions =
        /// A handler for potential conflict in move failure.
        abstract conflictHandler: (MoveToApplicationsFolderOptionsConflictHandler -> bool) option with get, set

    type [<AllowNullLiteral>] NewWindowEvent =
        inherit Event
        abstract url: string with get, set
        abstract frameName: string with get, set
        /// Can be `default`, `foreground-tab`, `background-tab`, `new-window`,
        /// `save-to-disk` and `other`.
        abstract disposition: WebContentsOn_newWindow with get, set
        /// The options which should be used for creating the new `BrowserWindow`.
        abstract options: BrowserWindowConstructorOptions with get, set

    type [<AllowNullLiteral>] NotificationConstructorOptions =
        /// A title for the notification, which will be shown at the top of the notification
        /// window when it is shown.
        abstract title: string with get, set
        /// A subtitle for the notification, which will be displayed below the title.
        abstract subtitle: string option with get, set
        /// The body text of the notification, which will be displayed below the title or
        /// subtitle.
        abstract body: string with get, set
        /// Whether or not to emit an OS notification noise when showing the notification.
        abstract silent: bool option with get, set
        /// An icon to use in the notification.
        abstract icon: U2<string, NativeImage> option with get, set
        /// Whether or not to add an inline reply option to the notification.
        abstract hasReply: bool option with get, set
        /// The placeholder to write in the inline reply input field.
        abstract replyPlaceholder: string option with get, set
        /// The name of the sound file to play when the notification is shown.
        abstract sound: string option with get, set
        /// Actions to add to the notification. Please read the available actions and
        /// limitations in the `NotificationAction` documentation.
        abstract actions: ResizeArray<NotificationAction> option with get, set
        /// A custom title for the close button of an alert. An empty string will cause the
        /// default localized text to be used.
        abstract closeButtonText: string option with get, set

    type [<AllowNullLiteral>] OnBeforeRedirectListenerDetails =
        abstract id: float with get, set
        abstract url: string with get, set
        abstract ``method``: string with get, set
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
        abstract ``method``: string with get, set
        abstract webContentsId: float option with get, set
        abstract resourceType: string with get, set
        abstract referrer: string with get, set
        abstract timestamp: float with get, set
        abstract uploadData: ResizeArray<UploadData> with get, set

    type [<AllowNullLiteral>] OnBeforeSendHeadersListenerDetails =
        abstract id: float with get, set
        abstract url: string with get, set
        abstract ``method``: string with get, set
        abstract webContentsId: float option with get, set
        abstract resourceType: string with get, set
        abstract referrer: string with get, set
        abstract timestamp: float with get, set
        abstract requestHeaders: Record<string, string> with get, set

    type [<AllowNullLiteral>] OnCompletedListenerDetails =
        abstract id: float with get, set
        abstract url: string with get, set
        abstract ``method``: string with get, set
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
        abstract ``method``: string with get, set
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
        abstract ``method``: string with get, set
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
        abstract ``method``: string with get, set
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
        abstract ``method``: string with get, set
        abstract webContentsId: float option with get, set
        abstract resourceType: string with get, set
        abstract referrer: string with get, set
        abstract timestamp: float with get, set
        abstract requestHeaders: Record<string, string> with get, set

    type [<AllowNullLiteral>] OpenDevToolsOptions =
        /// Opens the devtools with specified dock state, can be `right`, `bottom`,
        /// `undocked`, `detach`. Defaults to last used dock state. In `undocked` mode it's
        /// possible to dock back. In `detach` mode it's not.
        abstract mode: OpenDevToolsOptionsMode with get, set
        /// Whether to bring the opened devtools window to the foreground. The default is
        /// `true`.
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
        /// Message to display above input boxes.
        abstract message: string option with get, set
        /// Create security scoped bookmarks when packaged for the Mac App Store.
        abstract securityScopedBookmarks: bool option with get, set

    type [<AllowNullLiteral>] OpenDialogReturnValue =
        /// whether or not the dialog was canceled.
        abstract canceled: bool with get, set
        /// An array of file paths chosen by the user. If the dialog is cancelled this will
        /// be an empty array.
        abstract filePaths: ResizeArray<string> with get, set
        /// An array matching the `filePaths` array of base64 encoded strings which contains
        /// security scoped bookmark data. `securityScopedBookmarks` must be enabled for
        /// this to be populated. (For return values, see table here.)
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
        /// Message to display above input boxes.
        abstract message: string option with get, set
        /// Create security scoped bookmarks when packaged for the Mac App Store.
        abstract securityScopedBookmarks: bool option with get, set

    type [<AllowNullLiteral>] OpenExternalOptions =
        /// `true` to bring the opened application to the foreground. The default is `true`.
        abstract activate: bool option with get, set
        /// The working directory.
        abstract workingDirectory: string option with get, set

    type [<AllowNullLiteral>] PageFaviconUpdatedEvent =
        inherit Event
        /// Array of URLs.
        abstract favicons: ResizeArray<string> with get, set

    type [<AllowNullLiteral>] PageTitleUpdatedEvent =
        inherit Event
        abstract title: string with get, set
        abstract explicitSet: bool with get, set

    type [<AllowNullLiteral>] Parameters =
        /// Specify the screen type to emulate (default: `desktop`):
        abstract screenPosition: ParametersScreenPosition with get, set
        /// Set the emulated screen size (screenPosition == mobile).
        abstract screenSize: Size with get, set
        /// Position the view on the screen (screenPosition == mobile) (default: `{ x: 0, y:
        /// 0 }`).
        abstract viewPosition: Point with get, set
        /// Set the device scale factor (if zero defaults to original device scale factor)
        /// (default: `0`).
        abstract deviceScaleFactor: float with get, set
        /// Set the emulated view size (empty means no override)
        abstract viewSize: Size with get, set
        /// Scale of emulated view inside available space (not in fit to view mode)
        /// (default: `1`).
        abstract scale: float with get, set

    type [<AllowNullLiteral>] Payment =
        /// The identifier of the purchased product.
        abstract productIdentifier: string with get, set
        /// The quantity purchased.
        abstract quantity: float with get, set

    type [<AllowNullLiteral>] PermissionRequestHandlerHandlerDetails =
        /// The url of the `openExternal` request.
        abstract externalURL: string option with get, set
        /// The types of media access being requested, elements can be `video` or `audio`
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
        /// Default is the current mouse cursor position. Must be declared if `y` is
        /// declared.
        abstract x: float option with get, set
        /// Default is the current mouse cursor position. Must be declared if `x` is
        /// declared.
        abstract y: float option with get, set
        /// The index of the menu item to be positioned under the mouse cursor at the
        /// specified coordinates. Default is -1.
        abstract positioningItem: float option with get, set
        /// Called when menu is closed.
        abstract callback: (unit -> unit) option with get, set

    type [<AllowNullLiteral>] PreconnectOptions =
        /// URL for preconnect. Only the origin is relevant for opening the socket.
        abstract url: string with get, set
        /// number of sockets to preconnect. Must be between 1 and 6. Defaults to 1.
        abstract numSockets: float option with get, set

    type [<AllowNullLiteral>] PrintToPDFOptions =
        /// Specifies the type of margins to use. Uses 0 for default margin, 1 for no
        /// margin, and 2 for minimum margin.
        abstract marginsType: float option with get, set
        /// Specify page size of the generated PDF. Can be `A3`, `A4`, `A5`, `Legal`,
        /// `Letter`, `Tabloid` or an Object containing `height` and `width` in microns.
        abstract pageSize: U2<string, Size> option with get, set
        /// Whether to print CSS backgrounds.
        abstract printBackground: bool option with get, set
        /// Whether to print selection only.
        abstract printSelectionOnly: bool option with get, set
        /// `true` for landscape, `false` for portrait.
        abstract landscape: bool option with get, set

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

    type [<AllowNullLiteral>] ProcRequest =
        abstract hostname: string with get, set
        abstract certificate: Certificate with get, set
        /// Verification result from chromium.
        abstract verificationResult: string with get, set
        /// Error code.
        abstract errorCode: float with get, set

    type [<AllowNullLiteral>] ProgressBarOptions =
        /// Mode for the progress bar. Can be `none`, `normal`, `indeterminate`, `error` or
        /// `paused`.
        abstract mode: ProgressBarOptionsMode with get, set

    type [<AllowNullLiteral>] Provider =
        abstract spellCheck: (ResizeArray<string> -> (ResizeArray<string> -> unit) -> unit) with get, set

    type [<AllowNullLiteral>] ReadBookmark =
        abstract title: string with get, set
        abstract url: string with get, set

    type [<AllowNullLiteral>] RedirectRequest =
        abstract url: string with get, set
        abstract ``method``: string option with get, set
        abstract session: U2<Session, obj> option with get, set
        abstract uploadData: ProtocolResponseUploadData option with get, set

    type [<AllowNullLiteral>] RelaunchOptions =
        abstract args: ResizeArray<string> option with get, set
        abstract execPath: string option with get, set

    type [<AllowNullLiteral>] Request =
        abstract url: string with get, set
        abstract headers: Record<string, string> with get, set
        abstract referrer: string with get, set
        abstract ``method``: string with get, set
        abstract uploadData: ResizeArray<UploadData> with get, set

    type [<AllowNullLiteral>] ResizeOptions =
        /// Defaults to the image's width.
        abstract width: float option with get, set
        /// Defaults to the image's height.
        abstract height: float option with get, set
        /// The desired quality of the resize image. Possible values are `good`, `better` or
        /// `best`. The default is `best`. These values express a desired quality/speed
        /// tradeoff. They are translated into an algorithm-specific method that depends on
        /// the capabilities (CPU, GPU) of the underlying platform. It is possible for all
        /// three methods to be mapped to the same algorithm on a given platform.
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
        /// Message to display above text fields.
        abstract message: string option with get, set
        /// Custom label for the text displayed in front of the filename text field.
        abstract nameFieldLabel: string option with get, set
        /// Show the tags input box, defaults to `true`.
        abstract showsTagField: bool option with get, set
        /// Create a security scoped bookmark when packaged for the Mac App Store. If this
        /// option is enabled and the file doesn't already exist a blank file will be
        /// created at the chosen path.
        abstract securityScopedBookmarks: bool option with get, set

    type [<AllowNullLiteral>] SaveDialogReturnValue =
        /// whether or not the dialog was canceled.
        abstract canceled: bool with get, set
        /// If the dialog is canceled, this will be `undefined`.
        abstract filePath: string option with get, set
        /// Base64 encoded string which contains the security scoped bookmark data for the
        /// saved file. `securityScopedBookmarks` must be enabled for this to be present.
        /// (For return values, see table here.)
        abstract bookmark: string option with get, set

    type [<AllowNullLiteral>] SaveDialogSyncOptions =
        abstract title: string option with get, set
        /// Absolute directory path, absolute file path, or file name to use by default.
        abstract defaultPath: string option with get, set
        /// Custom label for the confirmation button, when left empty the default label will
        /// be used.
        abstract buttonLabel: string option with get, set
        abstract filters: ResizeArray<FileFilter> option with get, set
        /// Message to display above text fields.
        abstract message: string option with get, set
        /// Custom label for the text displayed in front of the filename text field.
        abstract nameFieldLabel: string option with get, set
        /// Show the tags input box, defaults to `true`.
        abstract showsTagField: bool option with get, set
        /// Create a security scoped bookmark when packaged for the Mac App Store. If this
        /// option is enabled and the file doesn't already exist a blank file will be
        /// created at the chosen path.
        abstract securityScopedBookmarks: bool option with get, set

    type [<AllowNullLiteral>] Settings =
        /// `true` to open the app at login, `false` to remove the app as a login item.
        /// Defaults to `false`.
        abstract openAtLogin: bool option with get, set
        /// `true` to open the app as hidden. Defaults to `false`. The user can edit this
        /// setting from the System Preferences so
        /// `app.getLoginItemSettings().wasOpenedAsHidden` should be checked when the app is
        /// opened to know the current value. This setting is not available on MAS builds.
        abstract openAsHidden: bool option with get, set
        /// The executable to launch at login. Defaults to `process.execPath`.
        abstract path: string option with get, set
        /// The command-line arguments to pass to the executable. Defaults to an empty
        /// array. Take care to wrap paths in quotes.
        abstract args: ResizeArray<string> option with get, set

    type [<AllowNullLiteral>] SourcesOptions =
        /// An array of Strings that lists the types of desktop sources to be captured,
        /// available types are `screen` and `window`.
        abstract types: ResizeArray<string> with get, set
        /// The size that the media source thumbnail should be scaled to. Default is `150` x
        /// `150`. Set width or height to 0 when you do not need the thumbnails. This will
        /// save the processing time required for capturing the content of each window and
        /// screen.
        abstract thumbnailSize: Size option with get, set
        /// Set to true to enable fetching window icons. The default value is false. When
        /// false the appIcon property of the sources return null. Same if a source has the
        /// type screen.
        abstract fetchWindowIcons: bool option with get, set

    type [<AllowNullLiteral>] StartLoggingOptions =
        /// What kinds of data should be captured. By default, only metadata about requests
        /// will be captured. Setting this to `includeSensitive` will include cookies and
        /// authentication data. Setting it to `everything` will include all bytes
        /// transferred on sockets. Can be `default`, `includeSensitive` or `everything`.
        abstract captureMode: StartLoggingOptionsCaptureMode option with get, set
        /// When the log grows beyond this size, logging will automatically stop. Defaults
        /// to unlimited.
        abstract maxFileSize: float option with get, set

    type [<AllowNullLiteral>] SystemMemoryInfo =
        /// The total amount of physical memory in Kilobytes available to the system.
        abstract total: float with get, set
        /// The total amount of memory not being used by applications or disk cache.
        abstract free: float with get, set
        /// The total amount of swap memory in Kilobytes available to the system.
        abstract swapTotal: float with get, set
        /// The free amount of swap memory in Kilobytes available to the system.
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
        /// Button background color in hex format, i.e `#ABCDEF`.
        abstract backgroundColor: string option with get, set
        /// Button icon.
        abstract icon: U2<NativeImage, string> option with get, set
        /// Can be `left`, `right` or `overlay`.
        abstract iconPosition: TouchBarButtonConstructorOptionsIconPosition option with get, set
        /// Function to call when the button is clicked.
        abstract click: (unit -> unit) option with get, set

    type [<AllowNullLiteral>] TouchBarColorPickerConstructorOptions =
        /// Array of hex color strings to appear as possible colors to select.
        abstract availableColors: ResizeArray<string> option with get, set
        /// The selected hex color in the picker, i.e `#ABCDEF`.
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
        /// Hex color of text, i.e `#ABCDEF`.
        abstract textColor: string option with get, set

    type [<AllowNullLiteral>] TouchBarPopoverConstructorOptions =
        /// Popover button text.
        abstract label: string option with get, set
        /// Popover button icon.
        abstract icon: NativeImage option with get, set
        /// Items to display in the popover.
        abstract items: TouchBar option with get, set
        /// `true` to display a close button on the left of the popover, `false` to not show
        /// it. Default is `true`.
        abstract showCloseButton: bool option with get, set

    type [<AllowNullLiteral>] TouchBarScrubberConstructorOptions =
        /// An array of items to place in this scrubber.
        abstract items: ResizeArray<ScrubberItem> with get, set
        /// Called when the user taps an item that was not the last tapped item.
        abstract select: (float -> unit) option with get, set
        /// Called when the user taps any item.
        abstract highlight: (float -> unit) option with get, set
        /// Selected item style. Defaults to `null`.
        abstract selectedStyle: string option with get, set
        /// Selected overlay item style. Defaults to `null`.
        abstract overlayStyle: string option with get, set
        /// Defaults to `false`.
        abstract showArrowButtons: bool option with get, set
        /// Defaults to `free`.
        abstract mode: string option with get, set
        /// Defaults to `true`.
        abstract continuous: bool option with get, set

    type [<AllowNullLiteral>] TouchBarSegmentedControlConstructorOptions =
        /// Style of the segments:
        abstract segmentStyle: TouchBarSegmentedControlConstructorOptionsSegmentStyle option with get, set
        /// The selection mode of the control:
        abstract mode: TouchBarSegmentedControlConstructorOptionsMode option with get, set
        /// An array of segments to place in this control.
        abstract segments: ResizeArray<SegmentedControlSegment> with get, set
        /// The index of the currently selected segment, will update automatically with user
        /// interaction. When the mode is multiple it will be the last selected item.
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
        /// Whether the upload has started. If this is false both `current` and `total` will
        /// be set to 0.
        abstract started: bool with get, set
        /// The number of bytes that have been uploaded so far
        abstract current: float with get, set
        /// The number of bytes that will be uploaded this request
        abstract total: float with get, set

    type [<AllowNullLiteral>] VisibleOnAllWorkspacesOptions =
        /// Sets whether the window should be visible above fullscreen windows
        abstract visibleOnFullScreen: bool option with get, set

    type [<AllowNullLiteral>] WebContentsPrintOptions =
        /// Don't ask user for print settings. Default is `false`.
        abstract silent: bool option with get, set
        /// Prints the background color and image of the web page. Default is `false`.
        abstract printBackground: bool option with get, set
        /// Set the printer device name to use. Must be the system-defined name and not the
        /// 'friendly' name, e.g 'Brother_QL_820NWB' and not 'Brother QL-820NWB'.
        abstract deviceName: string option with get, set
        /// Set whether the printed web page will be in color or grayscale. Default is
        /// `true`.
        abstract color: bool option with get, set
        abstract margins: Margins option with get, set
        /// Whether the web page should be printed in landscape mode. Default is `false`.
        abstract landscape: bool option with get, set
        /// The scale factor of the web page.
        abstract scaleFactor: float option with get, set
        /// The number of pages to print per page sheet.
        abstract pagesPerSheet: float option with get, set
        /// Whether the web page should be collated.
        abstract collate: bool option with get, set
        /// The number of copies of the web page to print.
        abstract copies: float option with get, set
        /// The page range to print. Should have two keys: `from` and `to`.
        abstract pageRanges: Record<string, float> option with get, set
        /// Set the duplex mode of the printed web page. Can be `simplex`, `shortEdge`, or
        /// `longEdge`.
        abstract duplexMode: WebContentsPrintOptionsDuplexMode option with get, set
        abstract dpi: Dpi option with get, set

    type [<AllowNullLiteral>] WebviewTagPrintOptions =
        /// Don't ask user for print settings. Default is `false`.
        abstract silent: bool option with get, set
        /// Also prints the background color and image of the web page. Default is `false`.
        abstract printBackground: bool option with get, set
        /// Set the printer device name to use. Default is `''`.
        abstract deviceName: string option with get, set

    type [<AllowNullLiteral>] WillNavigateEvent =
        inherit Event
        abstract url: string with get, set

    type [<AllowNullLiteral>] Dpi =
        /// The horizontal dpi.
        abstract horizontal: float option with get, set
        /// The vertical dpi.
        abstract vertical: float option with get, set

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
        /// Can be `default`, `none`, `printableArea`, or `custom`. If `custom` is chosen,
        /// you will also need to specify `top`, `bottom`, `left`, and `right`.
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
        /// Whether to enable DevTools. If it is set to `false`, can not use
        /// `BrowserWindow.webContents.openDevTools()` to open DevTools. Default is `true`.
        abstract devTools: bool option with get, set
        /// Whether node integration is enabled. Default is `false`.
        abstract nodeIntegration: bool option with get, set
        /// Whether node integration is enabled in web workers. Default is `false`. More
        /// about this can be found in Multithreading.
        abstract nodeIntegrationInWorker: bool option with get, set
        /// Experimental option for enabling Node.js support in sub-frames such as iframes
        /// and child windows. All your preloads will load for every iframe, you can use
        /// `process.isMainFrame` to determine if you are in the main frame or not.
        abstract nodeIntegrationInSubFrames: bool option with get, set
        /// Specifies a script that will be loaded before other scripts run in the page.
        /// This script will always have access to node APIs no matter whether node
        /// integration is turned on or off. The value should be the absolute file path to
        /// the script. When node integration is turned off, the preload script can
        /// reintroduce Node global symbols back to the global scope. See example here.
        abstract preload: string option with get, set
        /// If set, this will sandbox the renderer associated with the window, making it
        /// compatible with the Chromium OS-level sandbox and disabling the Node.js engine.
        /// This is not the same as the `nodeIntegration` option and the APIs available to
        /// the preload script are more limited. Read more about the option here.
        abstract sandbox: bool option with get, set
        /// Whether to enable the `remote` module. Default is `true`.
        abstract enableRemoteModule: bool option with get, set
        /// Sets the session used by the page. Instead of passing the Session object
        /// directly, you can also choose to use the `partition` option instead, which
        /// accepts a partition string. When both `session` and `partition` are provided,
        /// `session` will be preferred. Default is the default session.
        abstract session: Session option with get, set
        /// Sets the session used by the page according to the session's partition string.
        /// If `partition` starts with `persist:`, the page will use a persistent session
        /// available to all pages in the app with the same `partition`. If there is no
        /// `persist:` prefix, the page will use an in-memory session. By assigning the same
        /// `partition`, multiple pages can share the same session. Default is the default
        /// session.
        abstract partition: string option with get, set
        /// When specified, web pages with the same `affinity` will run in the same renderer
        /// process. Note that due to reusing the renderer process, certain `webPreferences`
        /// options will also be shared between the web pages even when you specified
        /// different values for them, including but not limited to `preload`, `sandbox` and
        /// `nodeIntegration`. So it is suggested to use exact same `webPreferences` for web
        /// pages with the same `affinity`. _This property is experimental_
        abstract affinity: string option with get, set
        /// The default zoom factor of the page, `3.0` represents `300%`. Default is `1.0`.
        abstract zoomFactor: float option with get, set
        /// Enables JavaScript support. Default is `true`.
        abstract javascript: bool option with get, set
        /// When `false`, it will disable the same-origin policy (usually using testing
        /// websites by people), and set `allowRunningInsecureContent` to `true` if this
        /// options has not been set by user. Default is `true`.
        abstract webSecurity: bool option with get, set
        /// Allow an https page to run JavaScript, CSS or plugins from http URLs. Default is
        /// `false`.
        abstract allowRunningInsecureContent: bool option with get, set
        /// Enables image support. Default is `true`.
        abstract images: bool option with get, set
        /// Make TextArea elements resizable. Default is `true`.
        abstract textAreasAreResizable: bool option with get, set
        /// Enables WebGL support. Default is `true`.
        abstract webgl: bool option with get, set
        /// Whether plugins should be enabled. Default is `false`.
        abstract plugins: bool option with get, set
        /// Enables Chromium's experimental features. Default is `false`.
        abstract experimentalFeatures: bool option with get, set
        /// Enables scroll bounce (rubber banding) effect on macOS. Default is `false`.
        abstract scrollBounce: bool option with get, set
        /// A list of feature strings separated by `,`, like `CSSVariables,KeyboardEventKey`
        /// to enable. The full list of supported feature strings can be found in the
        /// RuntimeEnabledFeatures.json5 file.
        abstract enableBlinkFeatures: string option with get, set
        /// A list of feature strings separated by `,`, like `CSSVariables,KeyboardEventKey`
        /// to disable. The full list of supported feature strings can be found in the
        /// RuntimeEnabledFeatures.json5 file.
        abstract disableBlinkFeatures: string option with get, set
        /// Sets the default font for the font-family.
        abstract defaultFontFamily: DefaultFontFamily option with get, set
        /// Defaults to `16`.
        abstract defaultFontSize: float option with get, set
        /// Defaults to `13`.
        abstract defaultMonospaceFontSize: float option with get, set
        /// Defaults to `0`.
        abstract minimumFontSize: float option with get, set
        /// Defaults to `ISO-8859-1`.
        abstract defaultEncoding: string option with get, set
        /// Whether to throttle animations and timers when the page becomes background. This
        /// also affects the Page Visibility API. Defaults to `true`.
        abstract backgroundThrottling: bool option with get, set
        /// Whether to enable offscreen rendering for the browser window. Defaults to
        /// `false`. See the offscreen rendering tutorial for more details.
        abstract offscreen: bool option with get, set
        /// Whether to run Electron APIs and the specified `preload` script in a separate
        /// JavaScript context. Defaults to `false`. The context that the `preload` script
        /// runs in will still have full access to the `document` and `window` globals but
        /// it will use its own set of JavaScript builtins (`Array`, `Object`, `JSON`, etc.)
        /// and will be isolated from any changes made to the global environment by the
        /// loaded page. The Electron API will only be available in the `preload` script and
        /// not the loaded page. This option should be used when loading potentially
        /// untrusted remote content to ensure the loaded content cannot tamper with the
        /// `preload` script and any Electron APIs being used. This option uses the same
        /// technique used by Chrome Content Scripts. You can access this context in the dev
        /// tools by selecting the 'Electron Isolated Context' entry in the combo box at the
        /// top of the Console tab.
        abstract contextIsolation: bool option with get, set
        /// Whether to use native `window.open()`. Defaults to `false`. Child windows will
        /// always have node integration disabled unless `nodeIntegrationInSubFrames` is
        /// true. **Note:** This option is currently experimental.
        abstract nativeWindowOpen: bool option with get, set
        /// Whether to enable the `<webview>` tag. Defaults to `false`. **Note:** The
        /// `preload` script configured for the `<webview>` will have node integration
        /// enabled when it is executed so you should ensure remote/untrusted content is not
        /// able to create a `<webview>` tag with a possibly malicious `preload` script. You
        /// can use the `will-attach-webview` event on webContents to strip away the
        /// `preload` script and to validate or alter the `<webview>`'s initial settings.
        abstract webviewTag: bool option with get, set
        /// A list of strings that will be appended to `process.argv` in the renderer
        /// process of this app.  Useful for passing small bits of data down to renderer
        /// process preload scripts.
        abstract additionalArguments: ResizeArray<string> option with get, set
        /// Whether to enable browser style consecutive dialog protection. Default is
        /// `false`.
        abstract safeDialogs: bool option with get, set
        /// The message to display when consecutive dialog protection is triggered. If not
        /// defined the default message would be used, note that currently the default
        /// message is in English and not localized.
        abstract safeDialogsMessage: string option with get, set
        /// Whether dragging and dropping a file or link onto the page causes a navigation.
        /// Default is `false`.
        abstract navigateOnDragDrop: bool option with get, set
        /// Autoplay policy to apply to content in the window, can be
        /// `no-user-gesture-required`, `user-gesture-required`,
        /// `document-user-activation-required`. Defaults to `no-user-gesture-required`.
        abstract autoplayPolicy: WebPreferencesAutoplayPolicy option with get, set
        /// Whether to prevent the window from resizing when entering HTML Fullscreen.
        /// Default is `false`.
        abstract disableHtmlFullscreenWindowResize: bool option with get, set

    type [<AllowNullLiteral>] DefaultFontFamily =
        /// Defaults to `Times New Roman`.
        abstract standard: string option with get, set
        /// Defaults to `Times New Roman`.
        abstract serif: string option with get, set
        /// Defaults to `Arial`.
        abstract sansSerif: string option with get, set
        /// Defaults to `Courier New`.
        abstract monospace: string option with get, set
        /// Defaults to `Script`.
        abstract cursive: string option with get, set
        /// Defaults to `Impact`.
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
        | Alt
        | Meta
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
        | Close
        | Minimize
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
        | Null

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

    type [<StringEnum>] [<RequireQualifiedAccess>] WebContentsOn_newWindow =
        | Default
        | [<CompiledName "foreground-tab">] ForegroundTab
        | [<CompiledName "background-tab">] BackgroundTab
        | [<CompiledName "new-window">] NewWindow
        | [<CompiledName "save-to-disk">] SaveToDisk
        | Other

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

    type [<StringEnum>] [<RequireQualifiedAccess>] DetailsMediaType =
        | Video
        | Audio
        | Unknown

    type [<StringEnum>] [<RequireQualifiedAccess>] FileIconOptionsSize =
        | Small
        | Normal
        | Large

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

    type [<StringEnum>] [<RequireQualifiedAccess>] ParametersScreenPosition =
        | Desktop
        | Mobile

    type [<StringEnum>] [<RequireQualifiedAccess>] PermissionRequestHandlerHandlerDetailsMediaTypesArray =
        | Video
        | Audio

    type [<StringEnum>] [<RequireQualifiedAccess>] ProgressBarOptionsMode =
        | None
        | Normal
        | Indeterminate
        | Error
        | Paused

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
        /// * `allocated` Integer - Size of all allocated objects in Kilobytes.
        /// * `marked` Integer - Size of all marked objects in Kilobytes.
        /// * `total` Integer - Total allocated space in Kilobytes.
        /// 
        /// Returns an object with Blink memory information. It can be useful for debugging
        /// rendering / DOM related memory issues. Note that all values are reported in
        /// Kilobytes.
        abstract getBlinkMemoryInfo: unit -> Electron.BlinkMemoryInfo
        abstract getCPUUsage: unit -> Electron.CPUUsage
        /// The number of milliseconds since epoch, or `null` if the information is
        /// unavailable
        /// 
        /// Indicates the creation time of the application. The time is represented as
        /// number of milliseconds since epoch. It returns null if it is unable to get the
        /// process creation time.
        abstract getCreationTime: unit -> U2<float, obj>
        /// * `totalHeapSize` Integer
        /// * `totalHeapSizeExecutable` Integer
        /// * `totalPhysicalSize` Integer
        /// * `totalAvailableSize` Integer
        /// * `usedHeapSize` Integer
        /// * `heapSizeLimit` Integer
        /// * `mallocedMemory` Integer
        /// * `peakMallocedMemory` Integer
        /// * `doesZapGarbage` Boolean
        /// 
        /// Returns an object with V8 heap statistics. Note that all statistics are reported
        /// in Kilobytes.
        abstract getHeapStatistics: unit -> Electron.HeapStatistics
        abstract getIOCounters: unit -> Electron.IOCounters
        /// Resolves with a ProcessMemoryInfo
        /// 
        /// Returns an object giving memory usage statistics about the current process. Note
        /// that all statistics are reported in Kilobytes. This api should be called after
        /// app ready.
        /// 
        /// Chromium does not provide `residentSet` value for macOS. This is because macOS
        /// performs in-memory compression of pages that haven't been recently used. As a
        /// result the resident set size value is not what one would expect. `private`
        /// memory is more representative of the actual pre-compression memory usage of the
        /// process on macOS.
        abstract getProcessMemoryInfo: unit -> Promise<Electron.ProcessMemoryInfo>
        /// * `total` Integer - The total amount of physical memory in Kilobytes available
        /// to the system.
        /// * `free` Integer - The total amount of memory not being used by applications or
        /// disk cache.
        /// * `swapTotal` Integer _Windows_ _Linux_ - The total amount of swap memory in
        /// Kilobytes available to the system.
        /// * `swapFree` Integer _Windows_ _Linux_ - The free amount of swap memory in
        /// Kilobytes available to the system.
        /// 
        /// Returns an object giving memory usage statistics about the entire system. Note
        /// that all statistics are reported in Kilobytes.
        abstract getSystemMemoryInfo: unit -> Electron.SystemMemoryInfo
        /// The version of the host operating system.
        /// 
        /// Example:
        /// 
        /// **Note:** It returns the actual operating system version instead of kernel
        /// version on macOS unlike `os.release()`.
        abstract getSystemVersion: unit -> string
        /// Causes the main thread of the current process hang.
        abstract hang: unit -> unit
        /// Sets the file descriptor soft limit to `maxDescriptors` or the OS hard limit,
        /// whichever is lower for the current process.
        abstract setFdLimit: maxDescriptors: float -> unit
        /// Indicates whether the snapshot has been created successfully.
        /// 
        /// Takes a V8 heap snapshot and saves it to `filePath`.
        abstract takeHeapSnapshot: filePath: string -> bool
        /// A `String` representing Chrome's version string.
        abstract chrome: string
        /// A `Boolean`. When app is started by being passed as parameter to the default
        /// app, this property is `true` in the main process, otherwise it is `undefined`.
        abstract defaultApp: bool
        /// A `String` representing Electron's version string.
        abstract electron: string
        /// A `Boolean` that controls whether or not deprecation warnings are printed to
        /// `stderr` when formerly callback-based APIs converted to Promises are invoked
        /// using callbacks. Setting this to `true` will enable deprecation warnings.
        abstract enablePromiseAPIs: bool with get, set
        /// A `Boolean`, `true` when the current renderer context is the "main" renderer
        /// frame. If you want the ID of the current frame you should use
        /// `webFrame.routingId`.
        abstract isMainFrame: bool
        /// A `Boolean`. For Mac App Store build, this property is `true`, for other builds
        /// it is `undefined`.
        abstract mas: bool
        /// A `Boolean` that controls ASAR support inside your application. Setting this to
        /// `true` will disable the support for `asar` archives in Node's built-in modules.
        abstract noAsar: bool with get, set
        /// A `Boolean` that controls whether or not deprecation warnings are printed to
        /// `stderr`. Setting this to `true` will silence deprecation warnings. This
        /// property is used instead of the `--no-deprecation` command line flag.
        abstract noDeprecation: bool with get, set
        /// A `String` representing the path to the resources directory.
        abstract resourcesPath: string
        /// A `Boolean`. When the renderer process is sandboxed, this property is `true`,
        /// otherwise it is `undefined`.
        abstract sandboxed: bool
        /// A `Boolean` that controls whether or not deprecation warnings will be thrown as
        /// exceptions. Setting this to `true` will throw errors for deprecations. This
        /// property is used instead of the `--throw-deprecation` command line flag.
        abstract throwDeprecation: bool with get, set
        /// A `Boolean` that controls whether or not deprecations printed to `stderr`
        /// include their stack trace. Setting this to `true` will print stack traces for
        /// deprecations. This property is instead of the `--trace-deprecation` command line
        /// flag.
        abstract traceDeprecation: bool with get, set
        /// A `Boolean` that controls whether or not process warnings printed to `stderr`
        /// include their stack trace. Setting this to `true` will print stack traces for
        /// process warnings (including deprecations). This property is instead of the
        /// `--trace-warnings` command line flag.
        abstract traceProcessWarnings: bool with get, set
        /// A `String` representing the current process's type, can be `"browser"` (i.e.
        /// main process), `"renderer"`, or `"worker"` (i.e. web worker).
        abstract ``type``: string
        /// A `Boolean`. If the app is running as a Windows Store app (appx), this property
        /// is `true`, for otherwise it is `undefined`.
        abstract windowsStore: bool

    type [<AllowNullLiteral>] ProcessVersions =
        abstract electron: string
        abstract chrome: string
