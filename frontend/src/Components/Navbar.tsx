import { HStack, Text, Button, ButtonGroup, Avatar } from "@chakra-ui/react"
import logo from "../assets/course-market-logo.png"

const Navbar = () => (
  <HStack justifyContent={"space-between"} className="border 1px solid black">
    <HStack spacing={0}>
      <img src={logo} alt="logo" className="box-border h-16 w-16" />
      <Text className="roboto-bold">CourseMarket</Text>
    </HStack>
    <HStack className="pr-4">
      <HStack justifyContent={"space-around"}>
        <Button colorScheme='purple' variant='ghost' width="60px" className="text-black">
          Signup
        </Button>
        <Button colorScheme='purple' variant='ghost' width="60px">
          Login
        </Button>
      </HStack>
      <Avatar name='user' size="md" className="pl-2" />
    </HStack>
  </HStack>
)

export default Navbar