import {HttpFunction} from '@google-cloud/functions-framework';
import express from 'express';

const app = express();

app.get('/hello', (req, res) => {
  return res.json({message: 'world'});
});

export const twitterCloneApi: HttpFunction = app;
