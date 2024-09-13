import { Route, Routes } from 'react-router-dom'
import './App.css'
import Login from './Components/Login'
import Signup from './Components/Signup'
import Home from './Components/Home'
import Navbar from './Components/Navbar'
import CourseCard from './Components/CourseCard'
import Profile from './Components/Profile'
import CreateCourse from './Components/CreateCourse'


function App() {
  return (
    <>
      <Navbar />
      <Routes>
        <Route path='/' element={<Home />} />
        <Route path='login' element={<Login />} />
        <Route path='signup' element={<Signup />} />
        <Route path='card' element={<CourseCard />} />
        <Route path="profile" element={<Profile />} />
        <Route path="addCourse" element={<CreateCourse />} />
      </Routes>
    </>
  )
}

export default App
