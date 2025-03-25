import { FC } from "react";
import { Widget } from "cs2/bindings";
import { getModule } from "cs2/modding";
import styles from "./extendedKeybinding.scss";

const InputBinding: FC<Widget<any>> = getModule("game-ui/menu/widgets/input-binding-field/input-binding-field.tsx", "BoundInputBindingField");

export const ExtendedKeybinding = (data: Widget<{ icon?: string }>) => {
  const hasIcon = !!data.props.icon;
  return (
    <div className={styles.ksHotkeyExdKeyBinding}>
      {hasIcon && <div className={styles.ksHotkeyExdKeyBindingIcon}>
        <img src={data.props.icon} />
      </div>}
      <div className={styles.ksHotkeyExdKeyBindingContents}>
        <InputBinding {...data} />
      </div>
    </div>
  );
}