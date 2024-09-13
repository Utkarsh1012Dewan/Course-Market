import axios from "axios";
import { useState } from "react";

const courses = () => {
  const [error, setError] = useState<Error | null>(null);
  const [loading, setLoading] = useState<Boolean>(false);
  const [data, setData] = useState([]);
};
