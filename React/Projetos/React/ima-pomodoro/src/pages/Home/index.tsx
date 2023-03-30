import { Play } from "phosphor-react";

import styles from "./index.module.css";

export function Home(){
    return (
        <div className={styles.pomodoro}>
           <form className={styles.form}>
                <div>
                    <label>Foco: </label>
                    <input className={`${styles.input} ${styles.task}`}
                      id="task" 
                      name="task"
                      placeholder="Digite sua tarefa" type="text" />
                    <label>por </label>
                    <input className={`${styles.input} ${styles.minutesAmount}`}
                    type="number" 
                    placeholder='00'
                    step={10}
                    min={10}
                    max={60} />
                    <span>minutos.</span>
                </div>

                <div >
                    <span>0</span>
                    <span>0</span>
                    <span>:</span>
                    <span>0</span>
                    <span>0</span>
                </div>

                <div >
                    <button type="submit">
                        <Play width={24}/>
                        Começar
                    </button>
                </div>
            </form>
        </div>

        )
}