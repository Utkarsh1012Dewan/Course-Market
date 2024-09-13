import { Box, Container, HStack, Input, VStack, Image } from '@chakra-ui/react';
import { useForm } from "react-hook-form";

const CreateCourse = () => {
    const {
        register,
        handleSubmit,
        formState: { errors },
    } = useForm();

    return (
        <Container className="border-2 border-black mt-10" maxW="70%">
            <form onSubmit={handleSubmit((data) => console.log(data))}>
                <HStack>
                    <Box boxSize='sm'>
                        <Image src='https://bit.ly/dan-abramov' alt='Dan Abramov' />
                    </Box>
                    <label>
                        First Name
                    </label>
                    <Input {...register('John Doe')} className="border" size={"lg"} />
                    <label>
                        Last Name
                    </label>
                    <Input {...register('lastName', { required: true })} size={"lg"} />
                    {errors.lastName && <p>Last name is required.</p>}
                    <Input {...register('age', { pattern: /\d+/ })} />
                    {errors.age && <p>Please enter number for age.</p>}
                    <Input type="submit" />
                </HStack>



            </form>

        </Container >
    );
}

export default CreateCourse