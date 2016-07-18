# $FreeBSD$

PORTNAME=	texosquery
PORTVERSION=	20160715
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Cross-platform Java application to query OS information

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS SRCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
