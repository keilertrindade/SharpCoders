import React, { useState } from "react";
import { v4 as uuidv4} from "uuid";

import { BrowserRouter as Router, Route/*, Routes*/} from "react-router-dom";

import "./App.css";
import Tasks from "./components/Tasks";
import AddTask from "./components/AddTask";
import Header from './components/Header';
import TaskDetails from './components/TaskDetails'


const App = () => {
  // let message = "Hello World!"
  const [tasks, setTasks] = useState(
    [
      {
        id: '1',
        title: 'Estudar Programação',
        completed: false,
      },
      {
        id: '2',
        title: "Ler livros",
        completed: true,
      },
      
    ]
  );

  const handleTaskClick = (taskId) => {
    const newTasks = tasks.map(task => {
      if(task.id === taskId) return {... task, completed: !task.completed};
      return task;
    })

    setTasks(newTasks);
  };

  const handleTaskAddition = (taskTitle) =>{
    const newTasks = [...tasks,{
      title: taskTitle,
      id: uuidv4(),
      completed: false,
    },
    ];

    setTasks(newTasks);
  }

  const handleTaskDeletion = (taskId) => {
    const newTasks = tasks.filter(task => task.id !== taskId);
    setTasks(newTasks);
  }

  return(

       <Router>
        <div className="container">
        <Header />
        {/* <Routes> */}
          <Route 
              path="/"
              exact
              render={() => (
            <>
              <AddTask handleTaskAddition={handleTaskAddition}/>
              <Tasks
                tasks={tasks}
                handleTaskClick={handleTaskClick}
                handleTaskDeletion={handleTaskDeletion}
              />
            </>
          )}
        />
        {/* </Routes> */}
        <Route 
          path="/:taskTitle"
          exact
          component={TaskDetails}
        />
        </div>      
       </Router>
  
  )
}

export default App;
