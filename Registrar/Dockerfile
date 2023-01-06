FROM node:18-alpine
WORKDIR /Registrar
COPY package.json yarn.lock ./
RUN yarn install --production
COPY . .
CMD ["program.cs", "Views/Home/Index.cshtml"]