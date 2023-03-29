import React from 'react'
import ReactDOM from 'react-dom/client'
import App from './App'
import './index.css'

const name: string = "nome";
const idade: number = 20;
const salario: number = 1.3;
const ativo: boolean = true;
const vetor: number[] = [1,2,3,4];
let nullableString : string | null | undefined;


/* interface Author{
  nome: string,
  readonly username: string,
  about: string,
  vetor: string[]
}

interface Content{

}

interface Perfil <T> {
  (key: string) : T,
  sobre: String,
}

export interface Post {
  id: number,
  author: Author,
  content: Content,
  abrir(): void
}
 */

ReactDOM.createRoot(document.getElementById('root')!).render( //
  <React.StrictMode>
    <App />
  </React.StrictMode>,
)
