# $FreeBSD$

PORTNAME=	checklistings
PORTVERSION=	20150906
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Pass verbatim contents through a compiler and reincorporate the resulting output

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS SRCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
