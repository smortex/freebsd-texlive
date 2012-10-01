# New ports collection makefile for:	texlive-mltex
# Date created:		13/03/2010 04:30:49
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	mltex
PORTVERSION=	20110531
PORTEPOCH=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	The MLTeX system.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/makeindex/latex/gglo.ist:${PORTSDIR}/print/texlive-latex \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
