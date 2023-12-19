
import React, { useEffect, useState } from 'react';
//import logo from './logo.svg';
import './App.css';
import axios from 'axios';
import { Header, List } from 'semantic-ui-react';
//import { Button, Header, List } from 'semantic-ui-react';

function App() {
  const [activities, setActivities] = useState([]);

  useEffect(() => {
    axios.get('http://localhost:5000/api/activities')
      .then(response => {
        setActivities(response.data);
      })
  }, [])

  return (
    // <div>
    //   <h1>Reactivity</h1>
    //     <ul>
    //       {activities.map((activity : any)=> (
    //         <li key={activity.Id}>
    //           {activity.title}
    //         </li>
    //       ))}
    //     </ul>

        
    // </div>

    <div>
      <Header as="h2" icon="users" content="Reactivities" />
        <List>
          {activities.map((activity : any)=> (
            <List.Item key={activity.id}>
              {activity.title}
            </List.Item>
          ))}
        </List>        
    </div>

  );
}

export default App;
