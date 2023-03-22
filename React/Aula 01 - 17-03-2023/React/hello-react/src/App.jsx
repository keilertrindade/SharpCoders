import { Header } from "./components/Header";
import { Post } from "./components/Post";

import"./global.css";

export function App() {
    
  return (<div>
    <Header></Header>
    <Post 
      author="Felipe"
      message="Cacique"
      likes="65"/>

    <Post 
      author="Felipe"
      message="Cacique"
      likes="65"/>

    <Post 
      author="Felipe"
      message="Cacique"
      likes="65"/>


    <Post 
      author="Felipe"
      message="Cacique"
      likes="65"/>

    <Post 
      author="Felipe"
      message="Cacique"
      likes="65"/>

  </div>
);
}


