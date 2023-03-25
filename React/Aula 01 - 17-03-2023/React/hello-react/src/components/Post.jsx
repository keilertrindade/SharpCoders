import { useState } from "react";
import styles from "./Post.module.css";
//console.log(styles)
export function Post({author, message}){
    console.log(JSON.stringify(rest));

    const [likes, giveLike] = useState(0) 

    return(
        <div className={styles.post}>
            <div className={styles.author}>
                <p>Autor: {author}</p>
                <time dateTime={""}>1 hour ago</time>
            </div>
            <h3>{message}</h3>           
            <button>responder</button>
            <button onClick={() => giveLike(likes+1)}>gostei: {likes}</button>
            <button>repostar</button>
            
        </div>        
    
    
    )
}

/* function Title(){
    return(
        <strong>Lorem ipsum dolor sit, amet consectetur adipisicing elit.</strong>
    )
}

export default Post; */