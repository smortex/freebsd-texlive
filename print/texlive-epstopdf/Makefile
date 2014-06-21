# $FreeBSD$

PORTNAME=	epstopdf
PORTVERSION=	20140620
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Convert EPS to 'encapsulated' PDF using Ghostscript.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
