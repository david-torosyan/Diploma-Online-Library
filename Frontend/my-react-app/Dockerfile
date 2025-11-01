# Stage 1: Build React app
FROM node:20 AS build
WORKDIR /app

# Clear all potential credentials and config
RUN rm -f /root/.npmrc /app/.npmrc
RUN npm config set registry https://registry.npmjs.org/
RUN npm config delete //registry.npmjs.org/:_authToken || true
RUN npm config delete _auth || true
RUN npm config delete username || true
RUN npm config delete password || true
RUN npm config delete email || true
RUN npm config delete always-auth || true

# Ensure environment does not force auth
ENV NPM_CONFIG_ALWAYS_AUTH=false
ENV NPM_TOKEN=""
ENV NODE_AUTH_TOKEN=""

# Install dependencies
COPY package*.json ./
RUN npm install --legacy-peer-deps

# Copy rest of the app and build
COPY . .
RUN npm run build

# Stage 2: Serve with nginx
FROM nginx:1.27-alpine
COPY --from=build /app/dist /usr/share/nginx/html
EXPOSE 80
CMD ["nginx", "-g", "daemon off;"]
