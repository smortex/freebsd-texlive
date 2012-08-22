# New ports collection makefile for:	texlive-collection-documentation-english
# Date created:		13/03/2010 04:24:56
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	collection-documentation-english
PORTVERSION=	20120821
PORTEPOCH=	1
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@FreeBSD.org
COMMENT=	English documentation

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/latex/latexfileinfo-pkgs/latexfileinfo_pkgs.RLS:${PORTSDIR}/print/texlive-latexfileinfo-pkgs \
		${LOCALBASE}/share/texmf/scripts/texlive/var/texcatalogue.keywords:${PORTSDIR}/print/texlive-texlive-docindex

NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
