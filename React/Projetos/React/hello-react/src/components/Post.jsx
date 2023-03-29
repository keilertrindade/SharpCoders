import { useState } from "react";
import styles from "./Post.module.css";
import { Content } from "./Content";

//console.log(styles)
export function Post({author, contents, time}){
    // console.log(JSON.stringify(rest));

    const [likes, giveLike] = useState(0) 

    return(
        <div className={styles.post}>
            <div className={styles.author}>
                <div>
                    <img src={author.imgUrl} />
                    <p>Autor: {author.name}</p>
                    <p>Sobre: {author.about}</p>
                </div>
                <time dateTime={time}>1 hour ago</time>
            </div>
            <Content contents={contents} />           
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