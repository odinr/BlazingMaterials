import { Drawer } from "@material/mwc-drawer";

type BlazingDrawerActions = "OpenStateHandler" | "invokeDotNetCallback";

interface BlazorComponent<A> {
  invokeMethodAsync: (action: A, ...args: any) => void;
}

type BlazorDrawer = BlazorComponent<BlazingDrawerActions>;

export const connect = async (component: BlazorDrawer, el: Drawer) => {
  await import(/* webpackChunkName: "mwc-drawer" */ "@material/mwc-drawer");
  el.addEventListener("MDCDrawer:opened", () =>
    component.invokeMethodAsync("OpenStateHandler", true)
  );
  el.addEventListener("MDCDrawer:closed", () =>
    component.invokeMethodAsync("OpenStateHandler", false)
  );
};

const open = (_: BlazorDrawer, el: Drawer) => el.setAttribute("open", "");
const close = (_: BlazorDrawer, el: Drawer) => el.removeAttribute("open");

export default {
  connect,
  open,
  close
};
