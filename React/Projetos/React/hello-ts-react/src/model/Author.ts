/* export interface Author{
  nome: string,
  readonly username: string,
  about: string,
  vetor: string[]
} */

export interface Author{
  name: string,
  username: string,
  about: string,
  avatar?: string;


}

/* 
const name: string = "nome";
const idade: number = 20;
const salario: number = 1.3;
const ativo: boolean = true;
const vetor: number[] = [1,2,3,4];



interface Perfil <T> {
  (key: string) : T,
  sobre: String,
}

export interface Post {
  id: number,
  author: Author,
  content: Content,
  abrir(): void
} */