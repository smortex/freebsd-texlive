# $FreeBSD$

PORTNAME=	lcdftypetools
PORTVERSION=	20120529
PORTREVISION=	1
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@FreeBSD.org
COMMENT=	A bundle of outline font manipulation tools.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/fonts/map/glyphlist/glyphlist.txt:${PORTSDIR}/print/texlive-glyphlist \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
