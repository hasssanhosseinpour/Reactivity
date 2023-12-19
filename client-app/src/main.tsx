import React from 'react'
import ReactDOM from 'react-dom/client'
import App from './App.tsx'
import 'semantic-ui-css/semantic.min.css'
import './index.css'

ReactDOM.createRoot(document.getElementById('root')!).render(
  <React.StrictMode>
    <App />
  </React.StrictMode>,

  /*
    You can always comment the <React.StrictMode> if you find it is not easy to work.
    //<React.StrictMode>
      <App />
    //</React.StrictMode>,
  
  */
)
