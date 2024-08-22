import { Route, Routes } from 'react-router-dom'
import './App.css'
import Login from './Components/Login'
import Signup from './Components/Signup'
import Home from './Components/Home'

function App() {
  return (
    <Routes>
      <Route path='/' element={<Home />} />
      <Route path='login' element={<Login />} />
      <Route path='signup' element={<Signup />} />
    </Routes>
  )
}

export default App
