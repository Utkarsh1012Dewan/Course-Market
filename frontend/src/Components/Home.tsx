import { Container, SimpleGrid } from "@chakra-ui/react"
import CourseCard from "./CourseCard"

const Home = () => {
    return (
        <Container className="mt-12" maxW="90%">
            <SimpleGrid columns={[1, 2, 3, 4]} spacing={8} minChildWidth={"250px"} >
                <CourseCard />
                <CourseCard />
                <CourseCard />
                <CourseCard />
                <CourseCard />
                <CourseCard />
                <CourseCard />
                <CourseCard />
            </SimpleGrid >
        </Container >
    )
}

export default Home