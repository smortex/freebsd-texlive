# New ports collection makefile for:	texlive-context-games
# Date created:		13/03/2010 04:21:37
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	context-games
PORTVERSION=	20110721
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	The context-games package

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/fonts/afm/public/skaknew/AlphaDia.afm:${PORTSDIR}/print/texlive-skaknew \
		${LOCALBASE}/share/texmf-dist/bibtex/bst/context/cont-ab.bst:${PORTSDIR}/print/texlive-context

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
