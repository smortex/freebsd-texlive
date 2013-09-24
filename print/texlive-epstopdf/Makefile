# $FreeBSD$

PORTNAME=	epstopdf
PORTVERSION=	20130517
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Convert EPS to 'encapsulated' PDF using GhostScript.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
