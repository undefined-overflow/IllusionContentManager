import cors from "cors";
import express from "express";

const app = express();
app.use(cors());
app.use(express.static('../FakeApi/wwwroot'));

const port = 3001;
app.listen(port, function () {
  console.log(`App is listening on port ${port}!`);
});
