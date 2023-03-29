import styles from "./Content.module.css"
import { Content as ContentModel } from "../model/Content";

interface ContentProps {
    contents: ContentModel[]
}

export function Content({contents} : ContentProps){
    
    console.log(contents);
    return(
        <div className={styles.content}>
            {contents.map( content => {
                if(content.type === "paragraph")
                    return <p>{content.message}</p>
                else if(content.type === "title")
                    return <h4>{content.message}</h4>
                else if(content.type === "image")
                    return <img className={styles.image} src={content.imageLink} alt={content.alternativeText} />
                else if(content.type === "link")
                    return(
                        <a
                         href={content.link}>
                            { content.displayedText ?? content.link }
                            
                            </a>
                        
                    )
            })}
        </div>

    )
}