import { FC } from "react";
import { Widget } from "cs2/bindings";
import { getModule } from "cs2/modding";
import styles from "assets/scss/styles.scss";

const InputBinding: FC<Widget<any>> = getModule("game-ui/menu/widgets/input-binding-field/input-binding-field.tsx", "BoundInputBindingField");

export const ExtendedKeybinding = (data: Widget<{ icon?: string }>) => {
  const hasIcon = !!data.props.icon;
  return (
    <div className="ks-hotkey-exd-key-binding">
      {hasIcon && <div className="ks-hotkey-exd-key-binding-icon">
        <img src={data.props.icon} />
      </div>}
      <div className="ks-hotkey-exd-key-binding-contents">
        <InputBinding {...data} />
      </div>
    </div>
  );
}