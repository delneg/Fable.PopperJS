// ts2fable 0.7.1
module rec ReactPopper
open System
open Fable.Core
open Fable.Core.JS
open Browser.Types
open PopperJsCore.Enums
open PopperJsCore.Types
open Fable.React
type ReadonlyArray<'T> = System.Collections.Generic.IReadOnlyList<'T>


type [<AllowNullLiteral>] IExports =
    abstract Manager: ManagerStatic
    abstract Reference: ReferenceStatic
    abstract Popper: PopperStatic
    abstract usePopper: ?referenceElement: U2<Element, VirtualElement> * ?popperElement: HTMLElement * ?options: obj -> UsePopperReturn

type [<AllowNullLiteral>] UsePopperReturn =
    abstract styles: UsePopperReturnStyles with get, set
    abstract attributes: UsePopperReturnAttributes with get, set
    abstract state: State option with get, set
    abstract update: Instance option with get, set
    abstract forceUpdate: Instance option with get, set

type UnionWhere<'U, 'M> =
    obj

type [<AllowNullLiteral>] ManagerProps =
    abstract children: ReactElement with get, set

type [<AllowNullLiteral>] Manager =
    inherit React.Component<ManagerProps, ManagerReactComponent>

type [<AllowNullLiteral>] ManagerStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Manager

type [<AllowNullLiteral>] RefHandler =
    [<Emit "$0($1...)">] abstract Invoke: ref: HTMLElement option -> unit

type [<AllowNullLiteral>] ReferenceChildrenProps =
    abstract ref: React.Ref<obj option> with get, set

type [<AllowNullLiteral>] ReferenceProps =
    abstract children: (ReferenceChildrenProps -> React.ReactNode) with get, set
    abstract innerRef: React.Ref<obj option> option with get, set

type [<AllowNullLiteral>] Reference =
    inherit React.Component<ReferenceProps, ManagerReactComponent>

type [<AllowNullLiteral>] ReferenceStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Reference

type [<AllowNullLiteral>] PopperArrowProps =
    abstract ref: React.Ref<obj option> with get, set
    abstract style: React.CSSProperties with get, set

type [<AllowNullLiteral>] PopperChildrenProps =
    abstract ref: React.Ref<obj option> with get, set
    abstract style: React.CSSProperties with get, set
    abstract placement: Placement with get, set
    abstract isReferenceHidden: bool option with get, set
    abstract hasPopperEscaped: bool option with get, set
    abstract update: (unit -> Promise<obj option>) with get, set
    abstract forceUpdate: (unit -> obj) with get, set
    abstract arrowProps: PopperArrowProps with get, set

type StrictModifierNames =
    NonNullable<StrictModifiers>

type StrictModifier =
    StrictModifier<obj>

type StrictModifier<'Name> =
    UnionWhere<StrictModifiers, StrictModifierUnionWhere<'Name>>

type Modifier<'Options> =
    Modifier<obj, 'Options>

type Modifier<'Name, 'Options> =
    obj

type [<AllowNullLiteral>] PopperProps<'Modifiers> =
    abstract children: (PopperChildrenProps -> React.ReactNode) with get, set
    abstract innerRef: React.Ref<obj option> option with get, set
    abstract modifiers: ReadonlyArray<Modifier<'Modifiers>> option with get, set
    abstract placement: Placement option with get, set
    abstract strategy: PositioningStrategy option with get, set
    abstract referenceElement: U2<HTMLElement, VirtualElement> option with get, set
    abstract onFirstUpdate: (obj -> unit) option with get, set

type [<AllowNullLiteral>] Popper<'Modifiers> =
    inherit React.Component<PopperProps<'Modifiers>, ManagerReactComponent>

type [<AllowNullLiteral>] PopperStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Popper<'Modifiers>

type [<AllowNullLiteral>] UsePopperReturnStyles =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> React.CSSProperties with get, set

type [<AllowNullLiteral>] UsePopperReturnAttributesItem =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> string with get, set

type [<AllowNullLiteral>] UsePopperReturnAttributes =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> UsePopperReturnAttributesItem option with get, set

type [<AllowNullLiteral>] ManagerReactComponent =
    interface end

type [<AllowNullLiteral>] StrictModifierUnionWhere<'Name> =
    abstract name: 'Name option with get, set
