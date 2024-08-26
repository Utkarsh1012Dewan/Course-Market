import { Route, Routes } from 'react-router-dom'
import './App.css'
import Login from './Components/Login'
import Signup from './Components/Signup'
import Home from './Components/Home'
import Navbar from './Components/Navbar'
import CourseCard from './Components/CourseCard'


function App() {
  return (
    <>
      <Navbar />
      <Routes>
        <Route path='/' element={<Home />} />
        <Route path='login' element={<Login />} />
        <Route path='signup' element={<Signup />} />
        <Route path='card' element={<CourseCard />} />
      </Routes>
    </>
  )
}

export default App
