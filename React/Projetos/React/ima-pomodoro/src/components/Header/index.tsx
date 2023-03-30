import { NavLink } from "react-router-dom";
import {Alarm, HouseSimple, ChartBar} from "phosphor-react";


import styles from "./index.module.css";

export function Header(){
    return(
        <header className={styles.header}>
            <span className={styles.favicon}>
                <Alarm size={32}/>
                POMODORO
            </span>
            <nav className={styles.nav}>
                <NavLink to="/" title="Home">
                <HouseSimple size={32} />
                </NavLink>
                <NavLink to="/stats" title="Stats">
                    <ChartBar size={32} />
                </NavLink>
            </nav>
        </header>
    )
    
}