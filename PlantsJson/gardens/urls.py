from django.conf.urls import url
from gardens import views

urlpatterns = [
    url(r'^plants/$', views.plant_list),
    url(r'^plants/(?P<pk>[0-9]+)/$', views.plant_detail),
]