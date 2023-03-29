import { useState } from "react";
import { Content } from "./Content";

import { Author } from "../model/Author";

import styles from "./Post.module.css";
import { Content as ContentModel } from "../model/Content";


interface PostProps{
    author: Author,
    contents: ContentModel[],
    time: Date,
    onDelete(id:number): any
}

const naldo : Author = {
    name: "Naldo",
    username:"Naldo",
    about:"Naldo"
}

export function Post({ author, contents, time }: PostProps){
    

    const [likes, giveLike] = useState(0) 

    return(
        <div className={styles.post}>
            <div className={styles.author}>
                <div>
                    <img src={author.avatar} />
                    <p>Autor: {author.name}</p>
                    <p>Sobre: {author.about}</p>
                </div>
                <time title="27 de março de 2023 às 19:30" dateTime={time.toString()}>1 hour ago</time>
            </div>
            <Content contents={contents} />           
            <button>responder</button>
            <button onClick={() => giveLike(likes+1)}>gostei: {likes}</button>
            <button>repostar</button>
            
        </div>        
    
    
    )
}


/* 
    O que eu quero componentizar:
1- Coisas que repetem
2- Separar lógica

*/