import styles from "./Post.module.css";
//console.log(styles)
export function Post({author, message, likes, ...rest}){
    console.log(JSON.stringify(rest));
    return(
        <div className={styles.post}>
            <p>Autor: {author}</p>
            <h3>{message}</h3>           
            <button>gostei: {likes}</button>
            <button>repostar</button>
            <button>responder</button>
        </div>        
    
    
    )
}

/* function Title(){
    return(
        <strong>Lorem ipsum dolor sit, amet consectetur adipisicing elit.</strong>
    )
}

export default Post; */