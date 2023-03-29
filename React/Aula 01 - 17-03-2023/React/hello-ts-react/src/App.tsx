import { Magnet } from "@phosphor-icons/react";
import { Header } from "./components/Header";
import { Post } from "./components/Post";

import"./global.css";

const posts = [
{
  'id': 1,
  "imageUrl": "github.com/keilertrindade.png",
  "time": "2023-03-22 20:00",
  "author": {
    "name": "Keiler",
    "about": "Corinthiano"
},
"contents": [
  {"type": "title", "message": "Olá, cheguei"},
  {"type": "paragraph", "message": "Olá meu primeiro tweet"},
  {"type": "paragraph", "message": "Acabei de chegar por aqui"},
]
},
{
  'id': 2,
  "imageUrl": "github.com/hgrafa.png",
  "time": "2023-03-22 20:00",
  "author": {
    "name": "Hugo",
    "about": "Flamenguista"
},
"contents": [
 {"type": "paragraph", "message": "Olá meu primeiro tweet"},
 {"type": "paragraph", "message": "Acabei de chegar por aqui"},
 {"type": "image", "imageLink": "https://www.github.com/hgrafa.png", "alternativeText": "Foto de perfil"},
]
}
]

const postConvertidos = `${posts}`


export function App() {
    
  return (
  <div>
    <Header/>
    {posts.map(post => {
        
        const obj =JSON.parse(JSON.stringify(post));
        const {id, author, contents, time} = obj;
        console.log(obj);
        return (
          <Post
            key={id}
            author={author}
            contents={contents}
            time={time}
          />
        )
            
      })}
    
  </div>
);
}


