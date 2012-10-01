# New ports collection makefile for:	texlive-context-construction-plan
# Date created:		13/03/2010 04:21:31
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	context-construction-plan
PORTVERSION=	20110629
PORTEPOCH=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Construction plans in ConTeXt.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/bibtex/bst/context/cont-ab.bst:${PORTSDIR}/print/texlive-context

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
